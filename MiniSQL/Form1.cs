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
        MiniSQL db = new MiniSQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            db.SQL(textInput.Text);
            textOutput.Text = db.log;
        }
    }
}
