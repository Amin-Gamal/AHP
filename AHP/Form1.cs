using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AHP
{
    public partial class Form1 : Form
    {
        AhpOperations ahp = new AhpOperations();
        public List<string> criterias = new List<string>();
        TreeNode root = new TreeNode("Goal");

        Matrix<double> criteria_matrix;
        Matrix<double> normalized_matrix;
        Vector<double> criteria_weight;
        List<double> column_total = new List<double>();
        List<string> alternatives = new List<string>();
        Matrix<double> alternativesMatrix;
        List<double> AltColumnTotal = new List<double>();

        List<List<double>> alt_periority = new List<List<double>>();
        //List<double> altWeightList;
        Matrix<double> periorityMatrix;
        Vector<double> finalRatingVector;

        Dictionary<string, Parameter> parameterObject = new Dictionary<string, Parameter>();
        List<Parameter> parameterList = new List<Parameter>();
        Queue<Parameter> parentsList;
       
        List<Parameter> childrenList;
        Dictionary<Dictionary<string, int>, List<string>> AhpParameter = new Dictionary<Dictionary<string, int>, List<string>>();
        List<Parameter> coveringCriterias = new List<Parameter>();
        List<string> parents;
        Dictionary<string, Alternative> alternativeObject = new Dictionary<string, Alternative>();
        List<Alternative> listOfAlternatives = new List<Alternative>();
        List<string> alternativeList = new List<string>();
        int comparisonCounter = 0;


        List<string> parametersToCompare;
        int current_level = 1;
        int nextCounter = 0;

        List<List<double>> finalRatingList = new List<List<double>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AltPeriority_dgv.Hide();
            //AltCheckConsistency_button.Hide();
            label2.Hide();
            Criterias_comboBox.Hide();

            NormalizedMatrix_dgv.Hide();
            CriteriaWeight_dgv.Hide();
            label1.Hide();
            CriteriaWeight_label.Hide();
            CheckConsistency_button.Hide();
            treeView1.Nodes.Add(root);
            
            Criterias_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            NormalizedMatrix_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            Alternatives_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AlterNormalizedMatrix_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AlternativesWeight_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //AltPeriority_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void CriteriasAdd_button_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Criterias_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
                

        private void Update_button_Click(object sender, EventArgs e)
        {
           
        }

        private void CheckConsistency_button_Click(object sender, EventArgs e)
        {
           
        }

        private void CriteriasAdd_button_Click_1(object sender, EventArgs e)
        {
            criterias.Add(Criteria_textBox.Text);
            string parameter_input = Criteria_textBox.Text;
            
            //Dictionary<Dictionary<Parameter, level>, parent>
            if (treeView1.SelectedNode == null)
            {
                treeView1.Nodes[0].Nodes.Add(parameter_input);

                AhpParameter.Add(new Dictionary<string, int> { { parameter_input, Math.Abs(MyTreeView.level(treeView1.SelectedNode)) } }, parents);
                
                parameterObject[parameter_input] = new Parameter {name = parameter_input, level = Math.Abs(MyTreeView.level(treeView1.SelectedNode)), parents = parentsList };
                parameterList.Add(parameterObject[parameter_input]);
            }
            else
            {
                treeView1.SelectedNode.Nodes.Add(parameter_input);
                string parent_name = treeView1.SelectedNode.Text;
                treeView1.SelectedNode = SearchTreeView(Criteria_textBox.Text, treeView1.Nodes);
                parentsList = new Queue<Parameter>();
                while (MyTreeView.level(treeView1.SelectedNode) > 1)
                {
                    string tmp = treeView1.SelectedNode.Parent.Text;
                    parentsList.Enqueue(parameterObject[tmp]);
                    treeView1.SelectedNode = SearchTreeView(tmp, treeView1.Nodes);
                }

                if (parameterObject[parent_name].children == null)
                {
                    childrenList = new List<Parameter>();
                }

                TreeNode selectCurrentNode = SearchTreeView(parameter_input, treeView1.Nodes);
                parameterObject[parameter_input] = new Parameter { name = parameter_input, level = Math.Abs(MyTreeView.level(selectCurrentNode)), parents = parentsList };
                childrenList.Add(parameterObject[parameter_input]);
                parameterObject[parent_name].children = childrenList;
                parameterList.Add(parameterObject[parameter_input]);
            }
            
            treeView1.ExpandAll();
            Criterias_comboBox.Items.Add(Criteria_textBox.Text);
            Criteria_textBox.Clear();
        }

        private void AlternativesAdd_button_Click(object sender, EventArgs e)
        {

        }

        private void CriteriaCPC_button_Click(object sender, EventArgs e)
        {

            parametersToCompare = new List<string>();
            var query = (from p in parameterList
                                   where p.level == 1
                                   select p.name);
            foreach (var item in query)
            {
                parametersToCompare.Add(item);
            }


            criteria_matrix = Matrix<double>.Build.Dense(parametersToCompare.Count, parametersToCompare.Count, 1);

            DataTable data = ahp.GetTable(parametersToCompare, criteria_matrix);
            ahp.DisplayTable(data, Criterias_dgv, parametersToCompare);

            for (int i = 0; i < Criterias_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < Criterias_dgv.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        Criterias_dgv.Rows[i].Cells[j].ReadOnly = true;
                        Criterias_dgv.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void Update_button_Click_1(object sender, EventArgs e)
        {
            int max_level = parameterList.Max(m => m.level);
            
            parametersToCompare = new List<string>();
            repeat:
            var query = (from p in parameterList
                         where p.level == current_level
                         select p).ToList();
            if (max_level == 1)
            {
                coveringCriterias = GetLeafNodes(parameterList);
                Update_button.Enabled = false;
                tabControl1.SelectTab(1);
                return;
            }
            while (query.Count > nextCounter)
            {
                
                if (query[nextCounter].hasChild)
                {
                    foreach (var item in query[nextCounter].children)
                    {
                        parametersToCompare.Add(item.name);
                    }
                    break;
                }
                else
                {
                    nextCounter++;
                }
            }

            nextCounter++;

            if (parametersToCompare.Count == 0)
            {
                current_level++;
                nextCounter = 0;
                if (current_level == max_level)
                {
                    coveringCriterias = GetLeafNodes(parameterList);
                    Update_button.Enabled = false;
                    tabControl1.SelectTab(1);
                    return;

                }
                else
                {
                    goto repeat;
                }
               
            }
            criteria_matrix = Matrix<double>.Build.Dense(parametersToCompare.Count, parametersToCompare.Count, 1);
            DataTable data = ahp.GetTable(parametersToCompare, criteria_matrix);
            ahp.DisplayTable(data, Criterias_dgv, parametersToCompare);

            for (int i = 0; i < Criterias_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < Criterias_dgv.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        Criterias_dgv.Rows[i].Cells[j].ReadOnly = true;
                        Criterias_dgv.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }

            Criterias_comboBox.Hide();
            label2.Hide();
        }

        private void CheckConsistency_button_Click_1(object sender, EventArgs e)
        {
            criteria_matrix = Matrix<double>.Build.Dense(criterias.Count, criterias.Count, 1);
            Matrix<double> normalized_matrix = ahp.NormalizeMatrix(Criterias_dgv, column_total);
            Vector<double> criteria_weight = ahp.GetCriteriaWeight(normalized_matrix, NormalizedMatrix_dgv);

            double largest_eigen_value = ahp.GetLargestEigenValue(Criterias_dgv, criteria_weight);
            bool is_consistent = ahp.CheckConsistencyRatio(largest_eigen_value, criteria_matrix);

            if (is_consistent)
            {
                MessageBox.Show("The matrix is consistent");
            }
            else
            {
                MessageBox.Show("Warning: The matrix is inconsistent");
            }
        }

        private void AddAlternative_button_Click(object sender, EventArgs e)
        {
            alternativeList.Add(Alternatives_textBox.Text);
            Alternatives_listBox.Items.Add(Alternatives_textBox.Text);

            alternatives.Add(Alternatives_textBox.Text);
            alternativeObject[Alternatives_textBox.Text] = new Alternative { name = Alternatives_textBox.Text };
            listOfAlternatives.Add(alternativeObject[Alternatives_textBox.Text]);

            Alternatives_textBox.Clear();
        }

        private void AlternativesCPC_button_Click(object sender, EventArgs e)
        {
            alt_table_label.Text = "Compare alternatives with respect to " + coveringCriterias[comparisonCounter].name;
            alternativesMatrix = Matrix<double>.Build.Dense(alternativeList.Count, alternativeList.Count, 1);
            DataTable data = ahp.GetTable(alternativeList, alternativesMatrix);
            ahp.DisplayTable(data, Alternatives_dgv, alternativeList);


            for (int i = 0; i < Alternatives_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < Alternatives_dgv.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        Alternatives_dgv.Rows[i].Cells[j].ReadOnly = true;
                        Alternatives_dgv.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comparisonCounter++;
            if (comparisonCounter == coveringCriterias.Count)
            {
                button1.Enabled = false;
                tabControl1.SelectTab(1);
                return;
            }

            alt_table_label.Text = "Compare alternatives with respect to " + coveringCriterias[comparisonCounter].name;
            alternativesMatrix = Matrix<double>.Build.Dense(alternativeList.Count, alternativeList.Count, 1);
            DataTable data = ahp.GetTable(alternativeList, alternativesMatrix);
            ahp.DisplayTable(data, Alternatives_dgv, alternativeList);

            for (int i = 0; i < Alternatives_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < Alternatives_dgv.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        Alternatives_dgv.Rows[i].Cells[j].ReadOnly = true;
                        Alternatives_dgv.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                }
            }
            



        }

        private void AltCheckConsistency_button_Click(object sender, EventArgs e)
        {
            alternativesMatrix = Matrix<double>.Build.Dense(alternativeList.Count, alternativeList.Count, 1);
            Matrix<double> normalized_matrix = ahp.NormalizeMatrix(Alternatives_dgv, AltColumnTotal);
            Vector<double> criteria_weight = ahp.GetCriteriaWeight(normalized_matrix, AlterNormalizedMatrix_dgv);

            double largest_eigen_value = ahp.GetLargestEigenValue(Alternatives_dgv, criteria_weight);
            bool is_consistent = ahp.CheckConsistencyRatio(largest_eigen_value, alternativesMatrix);

            
            if (is_consistent)
            {
                MessageBox.Show("The matrix is consistent");
            }
            else
            {
                MessageBox.Show("Warning: The matrix is inconsistent");
            }
        }

        
        private void Criterias_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        
        private void ShowPeriorityMatrix_button_Click(object sender, EventArgs e)
        {



            periorityMatrix = GetFinalRatineMatrix();
            

            //periorityMatrix = ahp.GetPeriorityMatrix(alt_periority);
            DataTable periorityTable = ahp.GetTable(alternatives, periorityMatrix);
            ahp.DisplayTable(periorityTable, AltPeriority_dgv, alternatives);
            for (int i = 0; i < coveringCriterias.Count; i++)
            {
                AltPeriority_dgv.Rows[i].HeaderCell.Value = criterias[i];
            }

        }

        
        private void FinalTab_button_Click(object sender, EventArgs e)
        {
            criteria_weight = GetCoveringCriteriaWeight(coveringCriterias);
            finalRatingVector = ahp.GetFinalRatingVector(periorityMatrix, criteria_weight);
            List<double> finalRatingList = finalRatingVector.ToList();
            double bestAltValue = finalRatingList.Max();
            int bestAltIndex = finalRatingList.FindIndex(a => a == bestAltValue);
            string bestAltName = alternativeList[bestAltIndex];
            //alternativeList.Sort();
            //finalRatingList.Sort();
            for (int i = 0; i < finalRatingList.Count; i++)
            {
                FRM_listBox.Items.Add(alternativeList[i] + " >> " + (Math.Round (finalRatingList[i],2)).ToString());
            }

            FRM_label.Text = "Best Alternative is: " + bestAltName + ": " + Math.Round(bestAltValue, 2);
            tabControl1.SelectedTab = tabPage3;
        }

        
        private void Compare_btn_Click(object sender, EventArgs e)
        {
            
        }

        private TreeNode SearchTreeView(string p_sSearchTerm, TreeNodeCollection p_Nodes)
        {
            foreach (TreeNode node in p_Nodes)
            {
                if (node.Text == p_sSearchTerm)
                {
                    return node;
                }

                if (node.Nodes.Count > 0)
                {
                    var result = SearchTreeView(p_sSearchTerm, node.Nodes);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }

            return null;
        }

        private void Criterias_dgv_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Criterias_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!ahp.VerifyPairwiseComparisonRanking(Convert.ToDouble(Criterias_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)))
            {
                Criterias_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                MessageBox.Show("Ranking value can't be less than 1 or greater than 9");
                Criterias_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                Criterias_dgv.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = 1;
            }
            else
            {
                Criterias_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                ahp.PairwiseComparing(Criterias_dgv);
                column_total = ahp.SumUpColumns(Criterias_dgv);

                //Get Normalized Table
                normalized_matrix = ahp.NormalizeMatrix(Criterias_dgv, column_total);
                DataTable NormalizedTable = ahp.GetTable(parametersToCompare, normalized_matrix);
                NormalizedMatrix_dgv.Show();
                label1.Show();
                ahp.DisplayTable(NormalizedTable, NormalizedMatrix_dgv, parametersToCompare);
                NormalizedMatrix_dgv.Show();

                //Get Criteria Weight Table
                criteria_weight = ahp.GetCriteriaWeight(normalized_matrix, NormalizedMatrix_dgv);
                ahp.VectorToTable(criteria_weight, normalized_matrix, NormalizedMatrix_dgv, CriteriaWeight_dgv);
                CriteriaWeight_label.Show();
                CheckConsistency_button.Show();
            }
            AssignLocalWeightToParameters(CriteriaWeight_dgv, parametersToCompare);
            AssignGlobalWeightToParameter(parameterList);


        }

        private void AssignGlobalWeightToParameter(List<Parameter> plist)
        {
            double temp = 0;
            foreach (var item in plist)
            {
                if (item.hasParent)
                {
                    temp = item.parents.Peek().globalWeight;
                    item.globalWeight = temp * item.localWeight;
                }
            }
            
        }
        private void AssignLocalWeightToParameters(DataGridView dgv, List<string> pl)
        {
            for (int i = 0; i < pl.Count; i++)
            {
                if (!parameterObject[pl[i]].hasParent)
                {
                    parameterObject[pl[i]].globalWeight = Convert.ToDouble(dgv.Rows[i].Cells[0].Value);
                }
                else
                {
                    parameterObject[pl[i]].localWeight = Convert.ToDouble(dgv.Rows[i].Cells[0].Value);
                }
                
            }

        }

        public List<Parameter> GetLeafNodes(List<Parameter> plist)
        {
            List<Parameter> leafList = new List<Parameter>();
            int node_level = 1;
            int max_level = plist.Max(m => m.level);
            for (int i = node_level; i <= max_level; i++)
            {
                var query = (from p in plist
                             where p.level == node_level
                             select p).ToList();
                foreach (var item in query)
                {
                    if (!item.hasChild)
                    {
                        leafList.Add(item);
                    }

                }
                node_level++;
            }
            return leafList;
        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
            foreach (var item in alternativeObject)
            {
                for (int i = 0; i < coveringCriterias.Count; i++)
                {
                    MessageBox.Show(item.Value.name + ": " + item.Value.Get(coveringCriterias[i]));
                }
                
            }
        }

        private void Alternatives_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (!ahp.VerifyPairwiseComparisonRanking(Convert.ToDouble(Alternatives_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)))
            {
                Alternatives_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                MessageBox.Show("Ranking value can't be less than 1 or greater than 9");
                Alternatives_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                Alternatives_dgv.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = 1;
            }
            else
            {
                Alternatives_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                ahp.PairwiseComparing(Alternatives_dgv);
                AltColumnTotal = ahp.SumUpColumns(Alternatives_dgv);

                //Get Normalized Table
                normalized_matrix = ahp.NormalizeMatrix(Alternatives_dgv, AltColumnTotal);
                DataTable NormalizedTable = ahp.GetTable(alternativeList, normalized_matrix);
                AlterNormalizedMatrix_dgv.Show();
                AltNorm_label.Show();
                ahp.DisplayTable(NormalizedTable, AlterNormalizedMatrix_dgv, alternativeList);
                AlterNormalizedMatrix_dgv.Show();

                //Get Criteria Weight Table
                criteria_weight = ahp.GetCriteriaWeight(normalized_matrix, AlterNormalizedMatrix_dgv);
                ahp.VectorToTable(/*criteria_weight*/GetCoveringCriteriaWeight(parameterList), normalized_matrix, AlterNormalizedMatrix_dgv, AlternativesWeight_dgv);
                AltWeight_label.Show();
                
            }


            AssignAlternativesPriorities(coveringCriterias, comparisonCounter, listOfAlternatives, AlternativesWeight_dgv);

        }


        public void AssignAlternativesPriorities(List<Parameter> parameter_list,int parameterIndex, List<Alternative>alternative_list, DataGridView dgv)
        {

            for (int i = 0; i < alternative_list.Count; i++)
            {
                alternative_list[i].Set(parameter_list[parameterIndex], Convert.ToDouble(dgv.Rows[i].Cells[0].Value));

            }
        }


        public Matrix<double> GetFinalRatineMatrix()
        {
            Matrix<double> periorityMatrix = Matrix<Double>.Build.Dense(coveringCriterias.Count, listOfAlternatives.Count);

            for (int i = 0; i < listOfAlternatives.Count; i++)
            {
                for (int j = 0; j < coveringCriterias.Count; j++)
                {
                    periorityMatrix[j, i] = listOfAlternatives[i].Get(coveringCriterias[j]);
                }
            }
            //for (int i = 0; i < alt_periority.Count; i++)
            //{
            //    for (int j = 0; j < alt_periority[i].Count; j++)
            //    {
            //        periorityMatrix[j, i] = alt_periority[j][i];
            //    }
            //}
            return periorityMatrix.Transpose();
           //return periorityMatrix;
        }


        public Vector<double> GetCoveringCriteriaWeight(List<Parameter> covering_criteria)
        {
            Vector<double> cw = Vector<double>.Build.Dense(covering_criteria.Count);
            for (int i = 0; i < covering_criteria.Count; i++)
            {
                cw[i] = covering_criteria[i].globalWeight;
            }
            return cw;
        }

        private void Test_btn_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
