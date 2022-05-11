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
    public partial class CalendarForm : Form
    {
        DateTime showDateFrom, showDateTo;
        danilov_stadiumEntities db;
        PictureBox pb_active;
        int activeCol, activeRow;
        public CalendarForm()
        {
            InitializeComponent();
            showDateFrom = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
            showDateTo = DateTime.Now.AddDays(7 - (int)DateTime.Now.DayOfWeek);
            activeCol = 0;
            activeRow = 0;
        }

        private void Dtp_selectWeek_ValueChanged(object sender, EventArgs e)
        {
            showDateFrom = dtp_selectWeek.Value.Date.AddDays(-(int)dtp_selectWeek.Value.DayOfWeek+1);
            showDateTo = dtp_selectWeek.Value.Date.AddDays(7 - (int)dtp_selectWeek.Value.DayOfWeek);
            FillCalendar();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            db = new danilov_stadiumEntities();
            pb_active = null;
            FillCalendar();
        }

        private void CalendarForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void TableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e) //редактировать
        {
            EventEditForm2 ef = new EventEditForm2(db);
            ef.db = db;
            ef.ev_glob = db.events.Where(ev => ev.event_id == (decimal)pb_active.Tag).FirstOrDefault();
            ef.ShowDialog();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e) //удалить
        {
            events ev_toDelete = db.events.Where(ev => ev.event_id == (decimal)pb_active.Tag).FirstOrDefault();
            if (MessageBox.Show(string.Format("Подтвердите удаление события {0} с началом {1}", ev_toDelete.event_types.event_type_name, ev_toDelete.start_dt.ToShortDateString()), "Выполняется удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<staff_sets> ss_toDelete = db.staff_sets.Where(s => s.event_id == ev_toDelete.event_id).ToList();
                db.staff_sets.RemoveRange(ss_toDelete);
                db.events.Remove(ev_toDelete);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e) //добавить событие
        {
            EventEditForm2 ef = new EventEditForm2(db);
            ef.db = db;
            ef.ev_glob = null;
            ef.DesiredDay = new DateTime(showDateFrom.Year, showDateFrom.Month, showDateFrom.Day + activeCol, activeRow - 1, 0, 0);
            if (ef.ShowDialog() == DialogResult.OK)
            {
                FillCalendar();
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pb_active = (PictureBox)sender;
            }
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pb_active = (PictureBox)sender;
        }

        private void УказатьРезультатToolStripMenuItem_Click(object sender, EventArgs e) //результат
        {
            EventResultForm erf = new EventResultForm(db, db.events.Where(en => en.event_id == (decimal)pb_active.Tag).FirstOrDefault());
            if(erf.ShowDialog() == DialogResult.OK)
            {
                FillCalendar();
            }
        }

        private void TableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            float Width0 = tableLayoutPanel1.ColumnStyles[0].Width;
            float WidthN = (tableLayoutPanel1.Width - Width0) / (tableLayoutPanel1.ColumnCount - 1);
            float HightRow = (tableLayoutPanel1.Height) / (tableLayoutPanel1.RowCount);
            
            activeCol = (int)(e.X - Width0) / (int)WidthN;
            activeRow = (int)(e.Y) / (int)HightRow;
        }

        private void FillCalendar()
        {
            //  tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableLayoutPanel1.SuspendLayout();
            dtp_selectWeek.Value = showDateFrom;
            dateTimePicker1.Value = showDateTo;
            lbl_day1.Text = showDateFrom.Date.ToShortDateString();
            lbl_day2.Text = showDateFrom.Date.AddDays(1).ToShortDateString();
            lbl_day3.Text = showDateFrom.Date.AddDays(2).ToShortDateString();
            lbl_day4.Text = showDateFrom.Date.AddDays(3).ToShortDateString();
            lbl_day5.Text = showDateFrom.Date.AddDays(4).ToShortDateString();
            lbl_day6.Text = showDateFrom.Date.AddDays(5).ToShortDateString();
            lbl_day7.Text = showDateFrom.Date.AddDays(6).ToShortDateString();
            for (int c=1;c<tableLayoutPanel1.ColumnCount;c++)
            {
                for (int r = 1; r < tableLayoutPanel1.RowCount; r++)
                {
                    Control ctrl = tableLayoutPanel1.GetControlFromPosition(c, r);
                    if (ctrl is PictureBox)
                    {
                        tableLayoutPanel1.Controls.Remove(ctrl);
                    }
                }
            }
            List<events> evs = db.events.Where(e => (e.start_dt >= showDateFrom && e.start_dt <= showDateTo) || (e.end_dt >= showDateFrom && e.end_dt <= showDateTo)).ToList();
            List<events> movedEvs = new List<events>();
            foreach (events tmpev in evs)
            {
                if (db.event_statuses.Where(es=>es.event_id == tmpev.event_id && (es.statuses.status_name.ToUpper() == "ПЕРЕНЕСЕНО" || es.statuses.status_name.ToUpper() == "ОТМЕНЕНО")).Any())
                {
                    movedEvs.Add(tmpev);
                }
            }
            foreach (events ev in movedEvs)
            {
                evs.Remove(ev);
            }
            foreach (events ev in evs)
            {
                PictureBox calEvent = new PictureBox();
                calEvent.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
                if (ev.event_types.event_type_name.ToUpper() == "ТРЕНИРОВКА")
                {
                    calEvent.BackColor = System.Drawing.Color.LawnGreen;
                    calEvent.Image = Danilov_stadium.Properties.Resources.training;
                    calEvent.SizeMode = PictureBoxSizeMode.Zoom;
                    calEvent.Tag = ev.event_id;
                    calEvent.ContextMenuStrip = contextMenuStrip2;

                    int column = (int)ev.start_dt.DayOfWeek;
                    int row = ev.start_dt.Hour + 1;
                    double duration = ev.end_dt.Hour - ev.start_dt.Hour;
                    double height = Math.Floor((double)tableLayoutPanel1.RowStyles[row].Height);
                    calEvent.Size = new System.Drawing.Size(120, 25 * (int)duration);
                    tableLayoutPanel1.Controls.Add(calEvent, column, row);
                    tableLayoutPanel1.SetRowSpan(calEvent, (int)duration);
                }
                else if (ev.event_types.event_type_name.ToUpper() == "МАТЧ")
                {
                    calEvent.BackColor = System.Drawing.Color.Crimson;
                    calEvent.Image = Danilov_stadium.Properties.Resources.cup;
                    calEvent.SizeMode = PictureBoxSizeMode.Zoom;

                    int column = (int)ev.start_dt.DayOfWeek;
                    int row = ev.start_dt.Hour + 1;
                    double duration = ev.end_dt.Hour - ev.start_dt.Hour;
                    double height = Math.Floor((double)tableLayoutPanel1.RowStyles[row].Height);
                    calEvent.Size = new System.Drawing.Size(120, 25 * (int)duration);
                    calEvent.ContextMenuStrip = contextMenuStrip2;
                    calEvent.Tag = ev.event_id;
                    tableLayoutPanel1.Controls.Add(calEvent, column, row);
                    tableLayoutPanel1.SetRowSpan(calEvent, (int)duration);
                }
            }
            //tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ResumeLayout();
        }
    }
}
