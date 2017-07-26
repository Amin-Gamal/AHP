using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP
{
    public class AhpOperations
    {
        public DataTable GetTable(List<string> tData, Matrix<double> m)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < tData.Count; i++)
            {
                table.Columns.Add();
            }
            for (int i = 0; i < tData.Count; i++)
            {

                DataRow row = table.NewRow();

                for (int j = 0; j < tData.Count; j++)
                {

                    row[j] = m[i, j];
                }
                table.Rows.Add(row);
            }


            return table;
        }

        
        public void DisplayTable(DataTable data, DataGridView datagridview, List<string> criterias)
        {
            Matrix<double> m = Matrix<double>.Build.Dense(criterias.Count, criterias.Count, 1);
            //data = GetTable(criterias, m);
            datagridview.DataSource = data;

            for (int i = 0; i < criterias.Count; i++)
            {
                datagridview.Rows[i].HeaderCell.Value = criterias[i];
                datagridview.Columns[i].HeaderCell.Value = criterias[i];
            }
        }

        //Pairwise Comparison
        public void PairwiseComparing(DataGridView dgv)
        {
            double result = 0;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    //double temp = Convert.ToDouble(dgv.Rows[i].Cells[j].Value);
                    //if (double.TryParse((dgv.Rows[i].Cells[j].Value).ToString(), out temp) && !VerifyPairwiseComparisonRanking(temp) && (Convert.ToDouble(dgv.Rows[j].Cells[i].Value)) != Math.Round(1 / temp, 2))
                    //{
                    //    MessageBox.Show("Error: " + (dgv.Rows[i].Cells[j].Value).ToString());
                    //}
                    if (Convert.ToDouble(dgv.Rows[i].Cells[j].Value) != 1)
                    {
                        result = 1 / (Convert.ToDouble(dgv.Rows[i].Cells[j].Value));
                        // dgv.Rows[j].Cells[i].Value = Math.Round(1 / (Convert.ToDouble(dgv.Rows[i].Cells[j].Value)), 2);

                        if (result < 1)
                        {
                            dgv.Rows[j].Cells[i].Value = Math.Round(result, 2);
                        }
                        else
                        {
                            dgv.Rows[j].Cells[i].Value = (int)result;
                        }
                    }
                }
            }


        }

        //Sum up columns
        public List<double> SumUpColumns(DataGridView dgv)
        {
            List<double> column_total = new List<double>();
            double sum = 0;
            int counter = 0;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    sum += Convert.ToDouble(dgv.Rows[j].Cells[i].Value);

                }
                dgv.Rows[dgv.Rows.Count - 1].Cells[i].Value = sum;
                column_total.Add(sum);
                counter++;
                sum = 0;
                //dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[i].Value
            }
            dgv.Rows[dgv.Rows.Count - 1].HeaderCell.Value = "Total";
            return column_total;
        }

        //Divide each element in every column by the sum of that column
        public Matrix<double> NormalizeMatrix(DataGridView datagridveiw, List<double> column_total)
        {
            Matrix<double> normalized_matrix = Matrix<double>.Build.Dense(datagridveiw.ColumnCount, datagridveiw.RowCount - 1);
            for (int i = 0; i < datagridveiw.Columns.Count; i++)
            {
                for (int j = 0; j < datagridveiw.Rows.Count - 1; j++)
                {
                    normalized_matrix[j, i] = Math.Round((Convert.ToDouble(datagridveiw.Rows[j].Cells[i].Value)) / column_total[i], 2);
                }
            }

            return normalized_matrix;
        }

        //Average each row in the normalized matrix
        public Vector<double>/*List<double>*/ GetCriteriaWeight(Matrix<double> normalized_matrix, DataGridView dataGV)
        {
            //List<double> criteria_weight = new List<double>();
            List<string> criterias = new List<string>();
            Vector<double> cw = Vector<double>.Build.Dense(dataGV.Rows.Count - 1);

            DataTable data = GetTable(criterias, normalized_matrix);

            int row_counter = dataGV.Columns.Count;
            double sum1 = 0;

            for (int i = 0; i < dataGV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGV.Columns.Count; j++)
                {
                    sum1 += (Convert.ToDouble(dataGV.Rows[i].Cells[j].Value));

                }
                cw[i] = Math.Round(sum1 / row_counter, 2);
                //criteria_weight.Add(sum1 / row_counter);
                sum1 = 0;
            }



            return cw; // criteria_weight;

        }

        //Assign vector elements to a DataGridView
        public void VectorToTable(Vector<double> criteria_weight, Matrix<double> normalized_matrix, DataGridView norm_dgv, DataGridView dgv)
        {
            criteria_weight = GetCriteriaWeight(normalized_matrix, norm_dgv);
            DataTable table = new DataTable();
            table.Columns.Add("Criteria Weight", typeof(double));
            int counter = 0;
            for (int i = 0; i < criteria_weight.Count; i++)
            {
                DataRow row = table.NewRow();

                for (int j = 0; j < table.Columns.Count; j++)
                {
                    row[j] = criteria_weight[counter];
                }
                table.Rows.Add(row);
                counter++;
            }

            dgv.DataSource = table;
            dgv.Show();
        }

        public double GetLargestEigenValue(DataGridView dgv, Vector<double> criteria_weight)
        {
            double largest_Eigen_value = 0;
            for (int i = 0; i < criteria_weight.Count; i++)
            {
                largest_Eigen_value += criteria_weight[i] * Convert.ToDouble(dgv.Rows[dgv.Rows.Count - 1].Cells[i].Value);
            }
            return largest_Eigen_value;
        }

        public double GetRandomConsistencyIndex(Matrix<double> m)
        {
            int n = m.ColumnCount;
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 0;
            }
            else if (n == 3)
            {
                return 0.58;
            }
            else if (n == 4)
            {
                return 0.9;
            }
            else if (n == 5)
            {
                return 1.12;
            }
            else if (n == 6)
            {
                return 1.24;
            }
            else if (n == 7)
            {
                return 1.32;
            }
            else if (n == 8)
            {
                return 1.41;
            }
            else if (n == 9)
            {
                return 1.45;
            }
            else if (n == 10)
            {
                return 1.49;
            }
            else
            {
                return -1;
            }
        }

        public bool CheckConsistencyRatio(double largest_eigen_value, Matrix<double> m)
        {
            double consistency_index = (largest_eigen_value - m.ColumnCount) / (m.ColumnCount - 1);
            //MessageBox.Show(consistency_index.ToString());
            double ri = GetRandomConsistencyIndex(m);
            double cr = consistency_index / ri;
            if (cr < 0.1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /*
        public Matrix<double> GetPeriorityMatrix(List<string> criterias, Vector<double> alt, int row_index)
        {
            Matrix<double> alt_priority_matrix = Matrix<double>.Build.Dense(criterias.Count, alt.Count, 1);
            for (int i = 0; i < alt.Count; i++)
            {
                alt_priority_matrix[row_index, i] = Convert.ToDouble(alt[i]);

            }
            return alt_priority_matrix;
        }
        */
        public List<double> StoreAlternativesPeriorities(Vector<double> altWeight)
        {
            List<double> alt_periority = new List<double>();
            for (int i = 0; i < altWeight.Count; i++)
            {
                alt_periority.Add(altWeight[i]);
            }
            return alt_periority;
        }


        //public Matrix<double> ConvertDictionaryToMatrix(Dictionary<Parameter, double> dictionary)
        //{
        //    Matrix<double> periorityMatrix = Matrix<Double>.Build.Dense(dictionary.Count, alt_periority[0].Count);
        //}

        public Matrix<double> GetPeriorityMatrix(List<List<double>> alt_periority)
        {
            Matrix<double> periorityMatrix = Matrix<Double>.Build.Dense(alt_periority.Count, alt_periority[0].Count);
            for (int i = 0; i < alt_periority.Count; i++)
            {
                for (int j = 0; j < alt_periority[i].Count; j++)
                {
                    periorityMatrix[j, i] = alt_periority[j][i];
                }
            }
            periorityMatrix.Transpose();
            return periorityMatrix;
        }

        public Vector<double> GetFinalRatingVector(Matrix<double> periorityMatrix, Vector<double> criteriaWeight)
        {
            //periorityMatrix = periorityMatrix.Transpose();
            Vector<double> FinalRatingVector = periorityMatrix.Multiply(criteriaWeight);
            return FinalRatingVector;
        }


        public bool VerifyPairwiseComparisonRanking(double value)
        {
            if (value < 1 || value > 9)
            {
                return false;
            }

            return true;
        }
    }
}

