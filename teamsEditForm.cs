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
    public partial class teamsEditForm : Form
    {
        teams t;
        bool isEdit;
        danilov_stadiumEntities db;
        public teamsEditForm(danilov_stadiumEntities db_i)
        {
            InitializeComponent();
            isEdit = false;
            t = null;
            db = db_i;
        }

        public teamsEditForm(danilov_stadiumEntities db_i, teams t_i)
        {
            InitializeComponent();
            isEdit = true;
            t = t_i;
            db = db_i;
        }
        private void TeamsEditForm_Load(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                teamsBindingSource.AddNew();
            }
            else
            {
                teamsBindingSource.Add(t);
                ImageConverter conv = new ImageConverter();
                if (t.emblem != null)
                {
                    pb_emblem.Image = (Image)conv.ConvertFrom(t.emblem);
                }
            }
        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            ImageConverter conv = new ImageConverter();
            // создаем массив байтов, из свойства Image ЭУ PictureBox
            byte[] bImg = (byte[])conv.ConvertTo(pb_emblem.Image, typeof(byte[]));

            if (!isEdit)
            {
                t = (teams)teamsBindingSource.List[0];
                if (pb_emblem.Image != null)
                {
                    t.emblem = bImg;
                }
                db.teams.Add(t);
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

        private void Bt__selectImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pb_emblem.Image = img;
                ImageConverter conv = new ImageConverter();
                // создаем массив байтов, из свойства Image ЭУ PictureBox
                byte[] bImg = (byte[])conv.ConvertTo(img, typeof(byte[]));
                t.emblem = bImg;
            }
        }
    }
}
