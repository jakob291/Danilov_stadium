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
        public staffEditForm(danilov_stadiumEntities db_i) //конструктор для создания новых сотрудников
        {
            InitializeComponent();
            isEdit = false;
            db = db_i;
            st = null;
        }

        public staffEditForm(danilov_stadiumEntities db_i, staff st_i) //конструктор для редактирования
        {
            InitializeComponent();
            isEdit = true;
            db = db_i;
            st = st_i;
        }

        private void StaffEditForm_Load(object sender, EventArgs e)
        {
            List<teams> allTeams = db.teams.OrderBy(t => t.team_name).ToList();
            allTeams.Insert(0, new teams() { team_name = "==НЕТ==" , team_id=-1}); //добавим первый пункт для возможности убрать ринадлежность к команде
            role_nameComboBox.DataSource = db.roles.OrderBy(r=>r.role_name).ToList();
            team_nameComboBox.DataSource = allTeams;
            
            if (isEdit)
            {
                this.Text = "Изменение сотрудника";
                staffBindingSource.Add(st);
                role_nameComboBox.SelectedValue = st.roles.role_id;
                if (st.teams != null)
                {
                    team_nameComboBox.SelectedValue = st.teams.team_id;
                }
                
                for (int i=0; i<role_nameComboBox.Items.Count;i++)
                {
                    if ((roles)role_nameComboBox.Items[i] == st.roles)
                    {
                        role_nameComboBox.SelectedIndex = i;                        
                    }
                }
            }
            else
            {
                this.Text = "Создание сотрудника";
                staffBindingSource.AddNew();
            }
        }

        private void Role_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (st != null)
            {
                st.role_id = (decimal)role_nameComboBox.SelectedValue;
            }
        }



        private void Bt_save_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                st = (staff)(staffBindingSource.List[staffBindingSource.List.Count-1]);
                Team_nameComboBox_SelectedIndexChanged(sender, e);
                Role_nameComboBox_SelectedIndexChanged(sender, e);
                db.staff.Add(st);
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

        private void Team_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (st != null)
            {
                if ((decimal)team_nameComboBox.SelectedValue != -1)
                {
                    st.team_id = (decimal)team_nameComboBox.SelectedValue;
                }
                else
                {
                    st.team_id = null;
                }
            }
        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.OK;
        }
    }
}
