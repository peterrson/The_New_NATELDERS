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
    public partial class Dashboard : Form
    {

        DataTable employeeListDT = new DataTable();
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PETERRSON\Documents\Visual Studio 2010\Projects\ElderNatSecCgo\DB\database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("select Surname, OtherNames, RCCNO, YearLastPromoted, Designation  from personal WHERE YearLastPromoted IS NOT NULL AND YearLastPromoted != ''", SqlCon);
            DataTable dt = new DataTable();
            
            

            sda.Fill(dt);


            employeeListDT.Columns.Add("Surname");
            employeeListDT.Columns.Add("OtherNames");
            employeeListDT.Columns.Add("RCCNO");
            employeeListDT.Columns.Add("YearLastPromoted");
            employeeListDT.Columns.Add("Designation");


            int PromotionCount = 0;
            int CurrentYear =  DateTime.Now.Year;
            for (int i = 0; i <= dt.Rows.Count - 1; i++ )
            {
                int YearLastPromoted = Convert.ToInt32(dt.Rows[i]["YearLastPromoted"]);
                int YearDueForPromotion = YearLastPromoted + 5;

                if (CurrentYear == YearDueForPromotion)
                {
                    PromotionCount += 1;
                    DataRow row = employeeListDT.NewRow();

                    row["Surname"] = dt.Rows[i]["Surname"];
                    row["OtherNames"] = dt.Rows[i]["OtherNames"];
                    row["RCCNO"] = dt.Rows[i]["RCCNO"];
                    row["YearLastPromoted"] = dt.Rows[i]["YearLastPromoted"];
                    row["Designation"] = dt.Rows[i]["Designation"];
                                  
                    employeeListDT.Rows.Add(row);
                }
            }

          btnPromotionDue.Text = "Employee Due Promotion" +" (" + PromotionCount.ToString() + ")";
        }

        private void btnPromotionDue_Click(object sender, EventArgs e)
        {
            EmployeeDuePromotionList list = new EmployeeDuePromotionList();
            list.dt = employeeListDT;
            list.ShowDialog();

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 n = new Form4();
            n.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 n = new Form3();
            n.ShowDialog();
        }
    }
}
