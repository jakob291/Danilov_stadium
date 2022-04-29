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
    public partial class staffEditForm : Form
    {
        public danilov_stadiumEntities db;
        public staff st;
        private bool isEdit;
        public staffEditForm(danilov_stadiumEntities db) //конструктор для создания новых сотрудников
        {
            InitializeComponent();
            isEdit = false;
            this.db = db;
            st = null;
        }

        public staffEditForm(danilov_stadiumEntities db, staff st) //конструктор для редактирования
        {
            InitializeComponent();
            isEdit = true;
            this.db = db;
            this.st = st;
        }

        private void StaffEditForm_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "Изменение сотрудника";
                staffBindingSource.Add(st);
                teamsBindingSource.DataSource = db.teams.OrderBy(tm => tm.team_name).ToList();
                rolesBindingSource.DataSource = db.roles.OrderBy(r => r.role_name).ToList();
                role_nameComboBox.SelectedItem = st.role_id;
                team_nameComboBox.SelectedItem = st.team_id;
            }
            else
            {
                this.Text = "Создание сотрудника";
                staffBindingSource.AddNew();
                teamsBindingSource.DataSource = db.teams.OrderBy(tm => tm.team_name).ToList();
                rolesBindingSource.DataSource = db.roles.OrderBy(r=>r.role_name).ToList();
            }
        }

        private void Role_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                st = (staff)(staffBindingSource.List[0]);
            }

            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
