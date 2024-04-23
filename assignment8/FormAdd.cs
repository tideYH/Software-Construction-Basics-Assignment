using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DetailsAdd_Click(object sender, EventArgs e)
        {
            FormDetailsAdd formDetailsAdd = new FormDetailsAdd();
            formDetailsAdd.ShowDialog();
        }


    }
}
