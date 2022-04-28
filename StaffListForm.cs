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
                rw.Cells["role"].Value = db.roles.Where(rl => rl.role_id == roleID).FirstOrDefault().role_name;
            }
        }
    }
}
