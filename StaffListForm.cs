using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danilov_stadium
{
    public partial class StaffListForm : Form
    {
        danilov_stadiumEntities db;
        public StaffListForm()
        {
            InitializeComponent();
            db = new danilov_stadiumEntities();
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            DGV_Staff.DataSource = db.staff.ToList();
            foreach (DataGridViewRow rw in DGV_Staff.Rows)
            {
                decimal roleID = (decimal)(rw.Cells["role_id"].Value);
                decimal teamID = rw.Cells["team_id"].Value != null ? (decimal)(rw.Cells["team_id"].Value) : -1;
                rw.Cells["role"].Value = db.roles.Where(rl => rl.role_id == roleID).FirstOrDefault().role_name;
                rw.Cells["team"].Value = teamID != -1 ? db.teams.Where(tm => tm.team_id == teamID).FirstOrDefault().team_name : "";
            }
        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {
            staff st = (staff)staffBindingSource.Current;
            staffEditForm sef = new staffEditForm(db, st);
            if (sef.ShowDialog() == DialogResult.OK)
            {
                DGV_Staff.DataSource = null;
                DGV_Staff.DataSource = db.staff.ToList();
            }
        }

        private void Bt_add_Click(object sender, EventArgs e)
        {
            staffEditForm sef = new staffEditForm(db);
            if (sef.ShowDialog() == DialogResult.OK)
            {
                DGV_Staff.DataSource = null;
                DGV_Staff.DataSource = db.staff.ToList();
            }
        }

        private void DGV_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
