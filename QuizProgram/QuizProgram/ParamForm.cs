using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProgram
{
    public partial class ParamForm : Form
    {
        public ParamForm(string[] paramArr)
        {
            InitializeComponent();
            listBox.Items.AddRange(paramArr);
        }
    }
}
