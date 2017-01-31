using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ProjectList : System.Web.UI.Page
    {
        protected void searchBtnClick(object sender,EventArgs e)
        {
            ArrayList projectList = DAL.ProjectDAL.GetProjectList(txtProjectName.Text);
            foreach (Common.Project sample in projectList)
            {
                
                TableRow tableRow = new TableRow();
                tableRow.Cells.Add(new TableCell() { Text = sample.ID1.ToString() });
                tableRow.Cells.Add(new TableCell() { Text = sample.Name1});
                tableRow.Cells.Add(new TableCell() { Text = sample.Assignment_date1.ToString() });
                tableRow.Cells.Add(new TableCell() { Text = sample.Client.Name1 });
                tableRow.Cells.Add(new TableCell() { Text = sample.Supervisor.Staff.LName1 });
                tableProject.Rows.Add(tableRow);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}