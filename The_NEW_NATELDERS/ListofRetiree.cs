using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_NEW_NATELDERS
{
    public partial class ListofRetiree : Form
    {
        public DataTable dt = new DataTable();
        public ListofRetiree()
        {
            InitializeComponent();
        }

        private void ListofRetiree_Load(object sender, EventArgs e)
        {
           // ListofRetiree.DataSource = dt;

            if (ListofRetireGrid.CurrentRow.Index != -1)
            {
                this.Hide();
                Promote ss = new Promote();
                ss.Surname = ListofRetireGrid.CurrentRow.Cells[0].Value.ToString();
                ss.OtherNames = ListofRetireGrid.CurrentRow.Cells[1].Value.ToString();
                ss.RCCNO = ListofRetireGrid.CurrentRow.Cells[2].Value.ToString();
                ss.YearLastPromoted = ListofRetireGrid.CurrentRow.Cells[3].Value.ToString();
                ss.Designation = ListofRetireGrid.CurrentRow.Cells[4].Value.ToString();
                ss.DateofBirth = ListofRetireGrid.CurrentRow.Cells[5].Value.ToString();
                ss.ShowDialog();
            }
        }
    }
}
