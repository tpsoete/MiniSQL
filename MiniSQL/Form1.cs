using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSQL
{
    public partial class Form1 : Form
    {
        MiniSQL db = new MiniSQL(Application.StartupPath);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            //db.SQL(textInput.Text);
            db.Test(textInput.Text);
            textOutput.AppendText(textInput.Text + Environment.NewLine + db.log);
            textInput.Text = "";
            textInput.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {
            textOutput.Select(textOutput.TextLength, 0);
            textOutput.ScrollToCaret();  
        }
    }
}
