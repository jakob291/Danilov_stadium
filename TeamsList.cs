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
    public partial class TeamsList : Form
    {
        danilov_stadiumEntities db;
        public TeamsList()
        {
            InitializeComponent();
        }

        private void TeamsList_Load(object sender, EventArgs e)
        {
            db = new danilov_stadiumEntities();
            RefreshView();
        }

        private void Bt_add_Click(object sender, EventArgs e)
        {
            teamsEditForm tef = new teamsEditForm(db);
            if (tef.ShowDialog() == DialogResult.OK)
            {
                RefreshView();
            }
        }

        private void RefreshView()
        {
            teamsBindingSource.Clear();
            teamsBindingSource.DataSource = db.teams.OrderBy(t => t.team_name).ToList();
        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {
            teams t = (teams)teamsBindingSource.Current;
            teamsEditForm tef = new teamsEditForm(db, t);
            if (tef.ShowDialog() == DialogResult.OK)
            {
                RefreshView();
            }
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
            teams t = (teams)teamsBindingSource.Current;
            if (MessageBox.Show("Удалить команду:  "+t.team_name, "Выполняется удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.teams.Remove(t);
                try
                {
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.InnerException.Message);
                }
            }
        }
    }
}
