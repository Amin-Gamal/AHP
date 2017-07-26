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

namespace AHP
{
    public partial class Alternatives : Form
    {
       
        List<string> alternatives = new List<string>();
        //Matrix<double> alternativesMatrix;
        List<double> AltColumnTotal = new List<double>();
       
        public Alternatives()
        {
            InitializeComponent();
        }

        private void Alternatives_Load(object sender, EventArgs e)
        {
            Alternatives_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AlterNormalizedMatrix_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AlternativesWeight_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddAlternative_button_Click(object sender, EventArgs e)
        {
            //alternatives.Add(Alternatives_textBox.Text);
            //Alternatives_listBox.Items.Add(Alternatives_textBox.Text);
            //Alternatives_textBox.Clear();
;        }

        private void AlternativesCPC_button_Click(object sender, EventArgs e)
        {
            //alternativesMatrix = Matrix<double>.Build.Dense(alternatives.Count, alternatives.Count, 1);
            //DataTable data = ahp.GetTable(alternatives, alternativesMatrix);
            //ahp.DisplayTable(data, Alternatives_dgv, alternatives);
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            //ahp.PairwiseComparing(Alternatives_dgv);
            //AltColumnTotal = ahp.SumUpColumns(Alternatives_dgv);
            //Alternatives_dgv.Update();


            //Matrix<double> normalized_matrix = ahp.NormalizeMatrix(Alternatives_dgv, AltColumnTotal);
            //DataTable NormalizedTable = ahp.GetTable(alternatives, normalized_matrix);
            //AlterNormalizedMatrix_dgv.Show();
            //AltNorm_label.Show();
            //ahp.DisplayTable(NormalizedTable, AlterNormalizedMatrix_dgv, alternatives);
            //AlterNormalizedMatrix_dgv.Show();

            //Vector<double> alt_weight = ahp.GetCriteriaWeight(normalized_matrix, AlterNormalizedMatrix_dgv);
            //ahp.VectorToTable(alt_weight, normalized_matrix, AlterNormalizedMatrix_dgv, AlternativesWeight_dgv);
            //AltWeight_label.Show();
            //AltCheckConsistency_button.Show();
            //MessageBox.Show(f1.criterias.Count.ToString());
            //foreach (var c in f1.criterias)
            //{
            //    Criterias_comboBox.Items.Add(c);
            //}
            
        }

        private void AltCheckConsistency_button_Click(object sender, EventArgs e)
        {
            //alternativesMatrix = Matrix<double>.Build.Dense(alternatives.Count, alternatives.Count, 1);
            //Matrix<double> normalized_matrix = ahp.NormalizeMatrix(Alternatives_dgv, AltColumnTotal);
            //Vector<double> criteria_weight = ahp.GetCriteriaWeight(normalized_matrix, AlterNormalizedMatrix_dgv);

            //double largest_eigen_value = ahp.GetLargestEigenValue(Alternatives_dgv, criteria_weight);
            //bool is_consistent = ahp.CheckConsistencyRatio(largest_eigen_value, alternativesMatrix);

            ////MessageBox.Show(largest_eigen_value.ToString());
            //if (is_consistent)
            //{
            //    MessageBox.Show("The matrix is consistent");
            //}
            //else
            //{
            //    MessageBox.Show("Warning: The matrix is inconsistent");
            //}
        }
    }
}
