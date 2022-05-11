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
    public partial class EventEditForm2 : Form
    {
        List<teams> allteams, allteams2;
        List<staff> alltrainers, allplayers, referee, fieldReferee, managers, team1players, team2players, team1trainers, team2trainers;
        List<event_types> eventTypes;
        ComboBox cb_team1, cb_trainer1, cb_team2, cb_trainer2, cb_responsible;
        CheckedListBox clb_players1, clb_players2, clb_judgesMain, clb_judgesField;
        Button bt_editStaff, bt_editTeams; 
        public danilov_stadiumEntities db;
        public events ev_glob;
        public DateTime DesiredDay;
        bool isEdit;

        private void Event_type_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switchControlsByEventType(int.Parse(event_type_nameComboBox.SelectedValue.ToString()));
        }

        DateTimePicker dtp_eventStartDate, dtp_eventStartTime, dtp_eventEndDate, dtp_eventEndTime;

        private void bt_editStaff_click(object sender, EventArgs e)
        {
            StaffListForm slf = new StaffListForm();
            if (slf.ShowDialog() == DialogResult.OK)
            {
                InitalizeManual();
            }
        }

        private void bt_editTeams_click(object sender, EventArgs e)
        {
            TeamsList tl = new TeamsList();
            if (tl.ShowDialog() == DialogResult.OK)
            {
                InitalizeManual();
            }
        }

        private void DateOrTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_eventEndDate.Value < dtp_eventStartDate.Value)
            {
                dtp_eventEndDate.Value = dtp_eventStartDate.Value;
            }
            if (dtp_eventStartDate.Value == dtp_eventEndDate.Value && dtp_eventEndTime.Value<dtp_eventStartTime.Value)
            {
                dtp_eventEndTime.Value = dtp_eventStartTime.Value.AddHours(1);
            }
            dtp_eventEndTime.Value.AddSeconds(-dtp_eventEndTime.Value.Second);
            dtp_eventStartTime.Value.AddSeconds(-dtp_eventStartTime.Value.Second);

        }

        public EventEditForm2(danilov_stadiumEntities db_input)
        {
            db = db_input;
            InitializeComponent();
            InitalizeManual();

        }

        public void InitalizeManual()
        {
            allteams = db.teams.OrderBy(t => t.team_name).ToList();
            allteams2 = db.teams.OrderBy(t => t.team_name).ToList();
            alltrainers = db.staff.Where(s => s.roles.role_name.ToUpper() == "ТРЕНЕР").OrderBy(s => s.last_name).ToList();
            allplayers = db.staff.Where(s => s.roles.role_name.ToUpper() == "ИГРОК").OrderBy(s => s.last_name).ToList();
            fieldReferee = db.staff.Where(s => s.roles.role_name.ToUpper() == "СУДЬЯ" && !s.is_head).OrderBy(s => s.last_name).ToList();
            referee = db.staff.Where(s => s.roles.role_name.ToUpper() == "СУДЬЯ" && s.is_head).OrderBy(s => s.last_name).ToList();
            managers = db.staff.Where(s => s.roles.role_name.ToUpper() == "МЕНЕДЖЕР").OrderBy(s => s.last_name).ToList();

            cb_team1 = new ComboBox();
            cb_team1.Size = new Size(151, 21);

            cb_team1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_team1.Anchor = AnchorStyles.Bottom;
            cb_team1.SelectedIndexChanged += Team1SelectedChanged;

            cb_team2 = new ComboBox();
            cb_team2.Size = new Size(151, 21);
            cb_team2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_team2.Anchor = AnchorStyles.Bottom;
            cb_team2.SelectedIndexChanged += Team2SelectedChanged;

            cb_trainer1 = new ComboBox();
            cb_trainer1.Size = new Size(151, 21);
            cb_trainer1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_trainer1.Anchor = AnchorStyles.Bottom;
            cb_trainer2 = new ComboBox();
            cb_trainer2.Size = new Size(151, 21);
            cb_trainer2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_trainer2.Anchor = AnchorStyles.Bottom;

            clb_players1 = new CheckedListBox();
            clb_players1.Size = new Size(151, 274);
            clb_players1.Anchor = AnchorStyles.Bottom;
            clb_players1.CheckOnClick = true;

            clb_players2 = new CheckedListBox();
            clb_players2.Size = new Size(151, 274);
            clb_players2.Anchor = AnchorStyles.Bottom;
            clb_players2.CheckOnClick = true;

            clb_judgesMain = new CheckedListBox();
            clb_judgesMain.Size = new Size(156, 64);
            clb_judgesMain.CheckOnClick = true;

            clb_judgesField = new CheckedListBox();
            clb_judgesField.Size = new Size(156, 139);
            clb_judgesField.CheckOnClick = true;

            cb_responsible = new ComboBox();
            cb_responsible.Size = new Size(200, 21);
            cb_responsible.Anchor = AnchorStyles.Bottom;
            cb_responsible.DropDownStyle = ComboBoxStyle.DropDownList;

            bt_editStaff = new Button();
            bt_editStaff.Name = "bt_editStaff";
            bt_editStaff.Size = new System.Drawing.Size(156, 21);
            bt_editStaff.Text = "Отредактировать персонал";
            bt_editStaff.UseVisualStyleBackColor = true;
            bt_editStaff.Anchor = AnchorStyles.Bottom;
            bt_editStaff.Click += new System.EventHandler(bt_editStaff_click);

            bt_editTeams = new Button();
            bt_editTeams.Name = "bt_editTeams";
            bt_editTeams.Size = new System.Drawing.Size(156, 21);
            bt_editTeams.Text = "Отредактировать команды";
            bt_editTeams.UseVisualStyleBackColor = true;
            bt_editTeams.Anchor = AnchorStyles.Bottom;
            bt_editTeams.Click += new System.EventHandler(bt_editTeams_click);

            dtp_eventStartDate = new DateTimePicker();
            dtp_eventStartDate.Size = new Size(200, 20);
            dtp_eventStartDate.Format = DateTimePickerFormat.Short;
            dtp_eventStartDate.Anchor = AnchorStyles.Bottom;
            dtp_eventStartDate.ValueChanged += new System.EventHandler(DateOrTimeFrom_ValueChanged);
            dtp_eventStartTime = new DateTimePicker();
            dtp_eventStartTime.Size = new Size(200, 20);
            dtp_eventStartTime.Format = DateTimePickerFormat.Time;
            dtp_eventStartTime.Anchor = AnchorStyles.Bottom;
            dtp_eventStartTime.ValueChanged += new System.EventHandler(DateOrTimeFrom_ValueChanged);

            dtp_eventEndDate = new DateTimePicker();
            dtp_eventEndDate.Size = new Size(200, 20);
            dtp_eventEndDate.Format = DateTimePickerFormat.Short;
            dtp_eventEndDate.Anchor = AnchorStyles.Bottom;
            dtp_eventEndDate.ValueChanged += new System.EventHandler(DateOrTimeFrom_ValueChanged);
            dtp_eventEndTime = new DateTimePicker();
            dtp_eventEndTime.Size = new Size(200, 20);
            dtp_eventEndTime.Format = DateTimePickerFormat.Time;
            dtp_eventEndTime.Anchor = AnchorStyles.Bottom;
            dtp_eventEndTime.ValueChanged += new System.EventHandler(DateOrTimeFrom_ValueChanged);
        }

        private void switchControlsByEventType(int eventTypeId)
        {
            if (eventTypeId == -1)
                return;
            string eventName = db.event_types.Find(eventTypeId).event_type_name;
            switch (eventName.ToUpper())
            {
                case "МАТЧ":
                    {
                        tableLayoutPanel1.Controls.Clear();
                        foreach(ColumnStyle style in tableLayoutPanel1.ColumnStyles)
                        {
                            style.SizeType = SizeType.Percent;
                            style.Width = 25;
                        }
                        Label lbl1 = new Label();
                        lbl1.Text = "Выберите команду:";
                        lbl1.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl1.Size = new Size(200, 15);
                        tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

                        Label lbl2 = new Label();
                        lbl2.Text = "Выберите команду:";
                        lbl2.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl2.Size = new Size(200, 15);
                        lbl2.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl2, 1, 0);
                        lbl2.Anchor = (AnchorStyles.Bottom);


                        Label lbl3 = new Label();
                        lbl3.Text = "Тренер";
                        lbl3.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl3.Size = new Size(200, 15);
                        lbl3.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl3, 0, 2);
                        lbl3.Anchor = (AnchorStyles.Bottom);
                        

                        Label lbl4 = new Label();
                        lbl4.Text = "Тренер";
                        lbl4.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl4.Size = new Size(200, 15);
                        lbl4.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl4, 1, 2);
                        lbl4.Anchor = AnchorStyles.Bottom;
                        

                        Label lbl5 = new Label();
                        lbl5.Text = "Основной судья";
                        lbl5.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl5.Size = new Size(200, 15);
                        lbl5.Anchor = AnchorStyles.Bottom;
                        lbl5.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl5,2,0);
                        tableLayoutPanel1.Invalidate(true);

                        Label lbl6 = new Label();
                        lbl6.Text = "Судьи на поле";
                        lbl6.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl6.Size = new Size(200, 15);
                        lbl6.TextAlign = ContentAlignment.MiddleCenter;
                        lbl6.Anchor = AnchorStyles.Bottom;
                        tableLayoutPanel1.Controls.Add(lbl6, 2, 4);

                        Label lbl7 = new Label();
                        lbl7.Text = "Ответственный менеджер";
                        lbl7.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl7.Size = new Size(200, 15);
                        lbl7.TextAlign = ContentAlignment.MiddleCenter;
                        lbl7.Anchor = AnchorStyles.Bottom;
                        tableLayoutPanel1.Controls.Add(lbl7, 3, 0);

                        Label lbl8 = new Label();
                        lbl8.Text = "Дата и время начала";
                        lbl8.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl8.Size = new Size(200, 15);
                        lbl8.Anchor = AnchorStyles.Bottom;
                        lbl8.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl8, 3, 2);

                        Label lbl9 = new Label();
                        lbl9.Text = "Дата и время окончания";
                        lbl9.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl9.Size = new Size(200, 15);
                        lbl9.Anchor = AnchorStyles.Bottom;
                        lbl9.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl9, 3, 5);

                        cb_team1.DataSource = allteams;
                        cb_team1.DisplayMember = "team_name";
                        cb_team1.ValueMember = "team_id";

                        cb_team2.DataSource = allteams2;
                        cb_team2.DisplayMember = "team_name";
                        cb_team2.ValueMember = "team_id";

                        tableLayoutPanel1.Controls.Add(cb_team1, 0, 1);
                        tableLayoutPanel1.Controls.Add(cb_team2, 1, 1);
                        tableLayoutPanel1.Controls.Add(cb_trainer1, 0, 3);
                        tableLayoutPanel1.Controls.Add(cb_trainer2, 1, 3);
                        tableLayoutPanel1.Controls.Add(clb_players1, 0, 5);
                        tableLayoutPanel1.SetRowSpan(clb_players1, 10);
                        tableLayoutPanel1.Controls.Add(clb_players2, 1, 5);
                        tableLayoutPanel1.SetRowSpan(clb_players2, 10);
                        tableLayoutPanel1.Controls.Add(clb_judgesMain, 2, 1);
                        tableLayoutPanel1.SetRowSpan(clb_judgesMain, 3);
                        tableLayoutPanel1.Controls.Add(clb_judgesField, 2, 5);
                        tableLayoutPanel1.SetRowSpan(clb_judgesField, 4);
                        tableLayoutPanel1.Controls.Add(bt_editStaff, 2, 10);
                        tableLayoutPanel1.Controls.Add(bt_editTeams, 2, 11);
                        tableLayoutPanel1.Controls.Add(cb_responsible, 3, 1);
                        tableLayoutPanel1.Controls.Add(dtp_eventStartDate, 3, 3);
                        tableLayoutPanel1.Controls.Add(dtp_eventStartTime, 3, 4);
                        tableLayoutPanel1.Controls.Add(dtp_eventEndDate, 3, 6);
                        tableLayoutPanel1.Controls.Add(dtp_eventEndTime, 3, 7);

                        Team1SelectedChanged(cb_team1, new EventArgs());
                        Team2SelectedChanged(cb_team2, new EventArgs());
                        FillClb(clb_judgesMain, referee);
                        FillClb(clb_judgesField, fieldReferee);
                        FillCbByFIO(cb_responsible, managers);
                        break;
                    }
                case "ТРЕНИРОВКА":
                    {
                        tableLayoutPanel1.Controls.Clear();
                        tableLayoutPanel1.ColumnStyles[1].Width = 1;
                        tableLayoutPanel1.ColumnStyles[2].Width = 1;

                        Label lbl1 = new Label();
                        lbl1.Text = "Выберите команду:";
                        lbl1.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl1.Size = new Size(200, 15);
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
                        lbl1.Anchor = (AnchorStyles.Bottom);

                        Label lbl3 = new Label();
                        lbl3.Text = "Тренер";
                        lbl3.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl3.Size = new Size(200, 15);
                        lbl3.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl3, 0, 2);
                        lbl3.Anchor = (AnchorStyles.Bottom);

                        tableLayoutPanel1.Controls.Add(clb_players1, 0, 5);
                        tableLayoutPanel1.SetRowSpan(clb_players1, 10);
                        tableLayoutPanel1.Controls.Add(cb_responsible, 3, 1);

                        Label lbl7 = new Label();
                        lbl7.Text = "Ответственный менеджер";
                        lbl7.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl7.Size = new Size(200, 15);
                        lbl7.Anchor = AnchorStyles.Bottom;
                        lbl7.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl7, 3, 0);

                        Label lbl8 = new Label();
                        lbl8.Text = "Дата и время начала";
                        lbl8.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl8.Size = new Size(200, 15);
                        lbl8.Anchor = AnchorStyles.Bottom;
                        lbl8.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl8, 3, 2);

                        Label lbl9 = new Label();
                        lbl9.Text = "Дата и время окончания";
                        lbl9.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        lbl9.Size = new Size(200, 15);
                        lbl9.Anchor = AnchorStyles.Bottom;
                        lbl9.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(lbl9, 3, 5);

                        cb_team1.DataSource = allteams;
                        cb_team1.DisplayMember = "team_name";
                        cb_team1.ValueMember = "team_id";

                        FillCbByFIO(cb_responsible, managers);

                        tableLayoutPanel1.Controls.Add(cb_team1, 0, 1);
                        tableLayoutPanel1.Controls.Add(cb_trainer1, 0, 3);
                        tableLayoutPanel1.Controls.Add(clb_players1, 0, 5);
                        tableLayoutPanel1.SetRowSpan(clb_players1, 10);
                        tableLayoutPanel1.Controls.Add(cb_responsible, 3, 1);
                        tableLayoutPanel1.Controls.Add(dtp_eventStartDate, 3, 3);
                        tableLayoutPanel1.Controls.Add(dtp_eventStartTime, 3, 4);
                        tableLayoutPanel1.Controls.Add(dtp_eventEndDate, 3, 6);
                        tableLayoutPanel1.Controls.Add(dtp_eventEndTime, 3, 7);
                        tableLayoutPanel1.Controls.Add(bt_editStaff, 3, 8);
                        tableLayoutPanel1.Controls.Add(bt_editTeams, 3, 9);
                        Team1SelectedChanged(cb_team1, new EventArgs());
                        break;
                    }
            }
            Button button1 = new Button();
            button1.Size = new Size(101, 34);
            button1.Text = "Сохранить";
            button1.Click += Button1_Click;
            tableLayoutPanel1.Controls.Add(button1, 3, 13);
            tableLayoutPanel1.SetRowSpan(button1, 2);
            button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveEventAndStaffSet();
        }

        private void SaveEventAndStaffSet()
        {
            
            decimal eventTypeId = (decimal)event_type_nameComboBox.SelectedValue;
            if (eventTypeId == -1)
                return;
            string eventName = db.event_types.Find(eventTypeId).event_type_name;
            decimal eventID;
            if (!isEdit)
            {
                eventID = (decimal)(db.GetNextSequenceValue().Single());

            }
            else
            {
                eventID = ev_glob.event_id;
            }

            switch (eventName.ToUpper())
            {
                case "МАТЧ":
                    {
                        //необходимо создать событие и одновременно загрузить данные о наборе людей на событие
                        events ev;
                        if (!isEdit)
                        {
                            ev = new events();
                        }
                        else
                        {
                            ev = ev_glob;
                        }
                        ev.event_type_id = decimal.Parse(event_type_nameComboBox.SelectedValue.ToString());
                        ev.start_dt = dtp_eventStartDate.Value.Date + dtp_eventStartTime.Value.TimeOfDay;
                        ev.end_dt = dtp_eventEndDate.Value.Date + dtp_eventEndTime.Value.TimeOfDay;
                        ev.event_id = eventID;
                        if (!isEdit)
                            db.events.Add(ev);

                        staff_sets ss;
                        foreach (decimal player in GetMarked(clb_players1, team1players))
                        {
                            ss = new staff_sets();
                            ss.created_at = DateTime.Now;
                            ss.event_id = eventID;
                            ss.staff_id = player;
                            db.staff_sets.Add(ss);
                        }
                        foreach (decimal player in GetMarked(clb_players2, team2players))
                        {
                            ss = new staff_sets();
                            ss.created_at = DateTime.Now;
                            ss.event_id = eventID;
                            ss.staff_id = player;
                            db.staff_sets.Add(ss);
                        }
                        foreach (decimal judge in GetMarked(clb_judgesMain, referee))
                        {
                            ss = new staff_sets();
                            ss.created_at = DateTime.Now;
                            ss.event_id = eventID;
                            ss.staff_id = judge;
                            db.staff_sets.Add(ss);
                        }
                        foreach (decimal judge in GetMarked(clb_judgesField, fieldReferee))
                        {
                            ss = new staff_sets();
                            ss.created_at = DateTime.Now;
                            ss.event_id = eventID;
                            ss.staff_id = judge;
                            db.staff_sets.Add(ss);
                        }

                        ss = new staff_sets();
                        ss.staff_id = decimal.Parse(cb_responsible.SelectedValue.ToString());
                        ss.event_id = eventID;
                        ss.created_at = DateTime.Now;
                        db.staff_sets.Add(ss);

                        break;    
                    }

                case "ТРЕНИРОВКА":
                    {
                        events ev;
                        if (!isEdit)
                        {
                            ev = new events();
                        }
                        else
                        {
                            ev = ev_glob;
                        }
                        ev.event_type_id = decimal.Parse(event_type_nameComboBox.SelectedValue.ToString());
                        ev.start_dt = dtp_eventStartDate.Value.Date + dtp_eventStartTime.Value.TimeOfDay;
                        ev.end_dt = dtp_eventEndDate.Value.Date + dtp_eventEndTime.Value.TimeOfDay;
                        ev.event_id = eventID;
                        if (!isEdit)
                            db.events.Add(ev);
                        staff_sets ss;
                        foreach (decimal player in GetMarked(clb_players1, team1players))
                        {
                            ss = new staff_sets();
                            ss.created_at = DateTime.Now;
                            ss.event_id = eventID;
                            ss.staff_id = player;
                            db.staff_sets.Add(ss);
                        }
                        ss = new staff_sets();
                        ss.staff_id = decimal.Parse(cb_responsible.SelectedValue.ToString());
                        ss.event_id = eventID;
                        ss.created_at = DateTime.Now;
                        db.staff_sets.Add(ss);

                        break;
                    }
            }
            try
            {
                CleanUpStaffSetsForEvent(eventID);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CleanUpStaffSetsForEvent (decimal eventID)
        {
            List<staff_sets> ss_to_del = db.staff_sets.Where(s => s.event_id == eventID).ToList();
            foreach (staff_sets st in ss_to_del)
            {
                db.staff_sets.Remove(st);
            }
        }

        private void FillCbByFIO (ComboBox cb, List<staff> source)
        {
            cb.DataSource = null;
            var datatetmpData = source.Select(t => new { FIO = string.Concat(t.last_name, " ", t.first_name), t.staff_id, t.team_id }).ToList();
            cb.DataSource = datatetmpData;
            cb.ValueMember = "staff_id";
            cb.DisplayMember = "FIO";
        }

        private void FillClb(CheckedListBox clb, List<staff> source)
        {
            clb.Items.Clear();
            var Persons = source.Select(p => new { FIO = string.Concat(p.last_name, " ", p.first_name), p.staff_id, p.team_id }).ToList();
            foreach (var person in Persons)
            {
                clb.Items.Add(person.FIO);
            }
        }

        private void Event_typesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventEditForm2_Load(object sender, EventArgs e)
        {
            if (ev_glob == null)
            {
                isEdit = false;
            }
            else
            {
                isEdit = true;
            }
            teamsBindingSource.DataSource = allteams;
            teamsBindingSource2.DataSource = allteams;
            eventTypes = db.event_types.OrderBy(t=>t.event_type_name).ToList();
            eventTypes.Insert(0, new event_types() { event_type_id = -1, event_type_name = "Выберите событие" });
            event_type_nameComboBox.DataSource = eventTypes;
            if (isEdit)
            {
                LoadEventData();
                event_type_nameComboBox.Enabled = false;
                cb_team1.Enabled = false;
                cb_team2.Enabled = false;
            }
            else
            {
                if (DesiredDay != null)
                {
                    dtp_eventStartDate.Value = DesiredDay;
                    dtp_eventEndDate.Value = DesiredDay;
                    dtp_eventStartTime.Value = DesiredDay;
                }
            }
        }

        private void LoadEventData()
        {
            event_type_nameComboBox.SelectedValue = ev_glob.event_types.event_type_id;
            List<staff_sets> competitors = db.staff_sets.Where(e => e.event_id == ev_glob.event_id && e.staff.team_id != null).ToList();
            var result = competitors.GroupBy(test => test.staff.team_id)
                   .Select(grp => grp.First())
                   .ToList().Select(s=>s.staff.team_id).ToList();
            if (ev_glob.event_types.event_type_name.ToUpper() == "МАТЧ" && result.Count == 2)
            {
                cb_team1.SelectedValue = result[0];
                cb_team2.SelectedValue = result[1];
                MarkFromDB(clb_players1, team1players, ev_glob.event_id, db.staff.Where(s => s.roles.role_name.ToUpper() == "ИГРОК").Select(s => s.role_id).FirstOrDefault());
                MarkFromDB(clb_players2, team2players, ev_glob.event_id, db.staff.Where(s => s.roles.role_name.ToUpper() == "ИГРОК").Select(s => s.role_id).FirstOrDefault());
                MarkFromDB(clb_judgesMain, referee, ev_glob.event_id, db.staff.Where(s => s.roles.role_name.ToUpper() == "СУДЬЯ").Select(s => s.role_id).FirstOrDefault());
                MarkFromDB(clb_judgesField, fieldReferee, ev_glob.event_id, db.staff.Where(s => s.roles.role_name.ToUpper() == "СУДЬЯ").Select(s => s.role_id).FirstOrDefault());
                cb_responsible.SelectedValue = ev_glob.staff_sets.Where(e => e.event_id == ev_glob.event_id && e.staff.roles.role_name.ToUpper().Trim() == "МЕНЕДЖЕР").Select(s => s.staff_id).FirstOrDefault();
                dtp_eventStartDate.Value = ev_glob.start_dt.Date;
                dtp_eventStartTime.Value = ev_glob.start_dt;
                dtp_eventEndDate.Value = ev_glob.end_dt;
                dtp_eventEndTime.Value = ev_glob.end_dt;

            }
            else
            {
                cb_team1.SelectedValue = result[0];
            }
            
        }

        private void Team1SelectedChanged(object sender, EventArgs e)
        {
            if (cb_team1.SelectedValue != null)
            {
                cb_trainer1.DataSource = null;                
                team1trainers = alltrainers.Where(t => t.team_id == (decimal)cb_team1.SelectedValue).ToList();
                FillCbByFIO(cb_trainer1, team1trainers);
                team1players = allplayers.Where(p => p.team_id == (decimal)cb_team1.SelectedValue).ToList();
                FillClb(clb_players1, team1players);
            }
        }
        private void Team2SelectedChanged(object sender, EventArgs e)
        {

            if (cb_team2.SelectedValue != null)
            {
                cb_trainer2.DataSource = null;
                clb_players2.Items.Clear();
                team2trainers = alltrainers.Where(t => t.team_id == (decimal)cb_team2.SelectedValue).ToList();
                FillCbByFIO(cb_trainer2, team2trainers);
                team2players = allplayers.Where(p => p.team_id == (decimal)cb_team2.SelectedValue).ToList();
                FillClb(clb_players2, team2players);
            }
        }

        private List<decimal> GetMarked(CheckedListBox clb, List<staff> source)
        {
            List<decimal> selectedPcs = new List<decimal>();
            foreach (int selIndex in clb.CheckedIndices)
            {
                selectedPcs.Add(source[selIndex].staff_id);
            }
            return selectedPcs;
        }
        private void MarkFromDB(CheckedListBox clb, List<staff> source, decimal eventID, decimal staffRoleID)
        {
            List<staff_sets> set = db.staff_sets.Where(ss => ss.event_id == eventID && ss.staff.role_id == staffRoleID).ToList();
            for (int i=0;i<clb.Items.Count;i++)
            {
                if (set.Where(s=>s.staff_id == source[i].staff_id).Any())
                {
                    clb.SetItemChecked(i, true);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GetMarked(clb_players1, team1players);
        }
    }
}
