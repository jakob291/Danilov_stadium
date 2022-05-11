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
    public partial class roles_evtypes_edit : Form
    {
        danilov_stadiumEntities db;
        public roles_evtypes_edit()
        {
            InitializeComponent();
        }

        private void Roles_evtypes_edit_Load(object sender, EventArgs e)
        {
            db = new danilov_stadiumEntities();
            rolesBindingSource.DataSource = db.roles.OrderBy(r => r.role_name).ToList();
            eventtypesBindingSource.DataSource = db.event_types.OrderBy(etp => etp.event_type_name).ToList();
        }

        private void Bt_add_Click(object sender, EventArgs e)
        {
            roles nr = new roles() { role_name = tb_new_role.Text };
            db.roles.Add(nr);
            SaveChangesWithTry();
            rolesBindingSource.Clear();
            rolesBindingSource.DataSource = db.roles.OrderBy(r => r.role_name).ToList();
        }

        private void SaveChangesWithTry()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Roles_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RolesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
            roles role_to_delete = (roles)rolesBindingSource.Current;
            if (MessageBox.Show("Действительно удалить роль " + role_to_delete.role_name, "Выполняется удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.roles.Remove(role_to_delete);
            }
            SaveChangesWithTry();
            rolesBindingSource.Clear();
            rolesBindingSource.DataSource = db.roles.OrderBy(r => r.role_name).ToList();

        }

        private void Bt_add_eventtype_Click(object sender, EventArgs e)
        {
            event_types et = new event_types() { event_type_name = tb_new_eventtype.Text };
            db.event_types.Add(et);
            SaveChangesWithTry();
            eventtypesBindingSource.Clear();
            eventtypesBindingSource.DataSource = db.event_types.OrderBy(etp => etp.event_type_name).ToList();
        }

        private void Bt_delete_eventtype_Click(object sender, EventArgs e)
        {
            event_types typetodelete = (event_types)eventtypesBindingSource.Current;
            if (MessageBox.Show("Действительно удалить тип события " + typetodelete.event_type_name, "Выполняется удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.event_types.Remove(typetodelete);
            }
            SaveChangesWithTry();
            eventtypesBindingSource.Clear();
            eventtypesBindingSource.DataSource = db.event_types.OrderBy(etp => etp.event_type_name).ToList();
        }
    }
}
