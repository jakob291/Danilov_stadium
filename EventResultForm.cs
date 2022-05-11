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
    public partial class EventResultForm : Form
    {
        danilov_stadiumEntities db;
        events ev;
        string statusToPost;
        List<teams> tms;
        public EventResultForm(danilov_stadiumEntities db_i, events ev__i)
        {
            InitializeComponent();
            db = db_i;
            ev = ev__i;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_details.Text = "Выберите дату переноса: ";
            cb_winner.Visible = false;
            dt_transfer_to.Visible = true;
            statusToPost = ((RadioButton)sender).Text;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (ev.event_types.event_type_name.ToUpper() == "МАТЧ")
            {
                List<staff_sets> competitors = db.staff_sets.Where(evn => evn.event_id == ev.event_id && evn.staff.team_id != null).ToList();
                var result = competitors.GroupBy(test => test.staff.team_id)
                       .Select(grp => grp.First())
                       .ToList().Select(s => s.staff.team_id).ToList();
                tms = db.teams.Where(t => result.Contains(t.team_id)).ToList();
                lbl_details.Text = "Выберите победителя: ";
                cb_winner.Visible = true;
                cb_winner.DataSource = tms;
                cb_winner.ValueMember = "team_id";
                cb_winner.DisplayMember = "team_name";
            }
            
            dt_transfer_to.Visible = false;
            statusToPost = ((RadioButton)sender).Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (statusToPost.ToUpper())
            {
                case "ПЕРЕНЕСЕНО":
                    {
                        events newEvent = new events();
                        newEvent.event_id = (decimal)db.GetNextSequenceValue().Single();
                        newEvent.original_event_id = ev.event_id;
                        newEvent.start_dt = dt_transfer_to.Value.Date + ev.start_dt.TimeOfDay;
                        newEvent.end_dt = dt_transfer_to.Value.Date + ev.end_dt.TimeOfDay;
                        newEvent.event_type_id = ev.event_type_id;
                        event_statuses new_st = new event_statuses();
                        new_st.event_id = ev.event_id;
                        new_st.status_id = db.statuses.Where(s => s.status_name == statusToPost)
                                .Select(s => s.status_id).FirstOrDefault();
                        db.event_statuses.Add(new_st);
                        List<staff_sets> ss = db.staff_sets.Where(s => s.event_id == ev.event_id).ToList();
                        foreach (staff_sets set in ss)
                        {
                            set.event_id = newEvent.event_id;
                        }
                        db.events.Add(newEvent);
                        break;
                    }
                case "ПРОВЕДЕНО":
                    {
                        if (ev.event_types.event_type_name.ToUpper() == "МАТЧ")
                        {
                            event_statuses st = new event_statuses();
                            st.participant1 = tms[0].team_id;
                            st.participant2 = tms[1].team_id;
                            st.winner = (decimal)cb_winner.SelectedValue;
                            st.status_id = db.statuses.Where(s => s.status_name == statusToPost)
                                .Select(s => s.status_id).FirstOrDefault();
                            st.event_id = ev.event_id;
                            db.event_statuses.Add(st);
                        }
                        else if (ev.event_types.event_type_name.ToUpper() == "ТРЕНИРОВКА")
                        {
                            event_statuses st = new event_statuses();
                            st.participant1 = tms[0].team_id;
                            st.status_id = db.statuses.Where(s => s.status_name == statusToPost)
                                .Select(s => s.status_id).FirstOrDefault();
                            st.event_id = ev.event_id;
                            db.event_statuses.Add(st);
                        }
                        break;
                    }
                case "ОТМЕНЕНО":
                    {
                        event_statuses st = new event_statuses();
                        st.event_id = ev.event_id;
                        st.status_id = db.statuses.Where(s => s.status_name == statusToPost)
                                .Select(s => s.status_id).FirstOrDefault();
                        db.event_statuses.Add(st);
                        break;
                    }
            }
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

        private void EventResultForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            statusToPost = ((RadioButton)sender).Text;
        }
    }
}
