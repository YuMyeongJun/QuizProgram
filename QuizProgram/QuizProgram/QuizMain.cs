using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizClassLibrary;

namespace QuizProgram
{
    public partial class QuizMain : Form
    {
        public QuizMain()
        {
            InitializeComponent();
            InitUI();
            InitEvent();
            DataGridViewSetup();
        }

        private void InitUI()
        {
            attackCombo.Items.Clear();
            attackCombo.Items.Add("70");
            attackCombo.Items.Add("80");
            attackCombo.Items.Add("90");
            attackCombo.Items.Add("100");

            defenceCombo.Items.Clear();
            defenceCombo.Items.Add("70");
            defenceCombo.Items.Add("80");
            defenceCombo.Items.Add("90");
            defenceCombo.Items.Add("100");

            passCombo.Items.Clear();
            passCombo.Items.Add("70");
            passCombo.Items.Add("80");
            passCombo.Items.Add("90");
            passCombo.Items.Add("100");

            shootCombo.Items.Clear();
            shootCombo.Items.Add("70");
            shootCombo.Items.Add("80");
            shootCombo.Items.Add("90");
            shootCombo.Items.Add("100");
        }

        private void InitEvent()
        {
            favoriteFoodBtn.Click += favoriteFood_Click;
            calculationBtn.Click += calculation_Click;
            dataAddBtn.Click += dataAdd_Click;
        }

        private void DataGridViewSetup()
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "이름";
            dataGridView.Columns[1].Name = "공격";
            dataGridView.Columns[2].Name = "수비";
            dataGridView.Columns[3].Name = "패스";
            dataGridView.Columns[4].Name = "슛";
        }

        private void favoriteFood_Click(object sender, EventArgs e)
        {
            string param = txtOne.Text;
            param = param.Replace(" ", "");
            //사과, 배, 딸기
            string[] paramArr = param.Split(',');

            ParamForm paramForm = new ParamForm(paramArr);
            paramForm.Show();
        }

        private void calculation_Click(object sender, EventArgs e)
        {

            StringCompute stringCompute = new StringCompute();
            string exp = txtCalculation.Text;
            try
            {
                string result = stringCompute.Compute(exp);
                txtResult.Text = result;
            }
            catch(Exception ex)
            {
                txtResult.Text = "오류발생";
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void dataAdd_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(txtName.Text, attackCombo.Text, defenceCombo.Text, passCombo.Text, shootCombo.Text);
        }

        private void chart_Click(object sender, EventArgs e)
        {
            string[] chartArr;

            Console.WriteLine(dataGridView);
/*
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                Console.WriteLine(dataGridView.DataSource.Rows[i]);
                chartArr = dataGridView.Rows[i];
            }*/

            chartArr = new string[] { txtName.Text, attackCombo.Text, defenceCombo.Text, passCombo.Text, shootCombo.Text };

            /*ChartForm chartForm = new ChartForm(chartArr);
            chartForm.Show();*/
        }
    }
}
