namespace skyetechRSMS
{
    partial class formemergency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formemergency));
            this.lbl_dateofincident = new System.Windows.Forms.Label();
            this.calendar_dateofincident = new System.Windows.Forms.DateTimePicker();
            this.lbl_timeofincident = new System.Windows.Forms.Label();
            this.input_timeofincident = new System.Windows.Forms.TextBox();
            this.lbl_natureofincident = new System.Windows.Forms.Label();
            this.drop_natureofincident = new System.Windows.Forms.ComboBox();
            this.drop_placeofincident = new System.Windows.Forms.ComboBox();
            this.lbl_placeofincident = new System.Windows.Forms.Label();
            this.input_numberofvictims = new System.Windows.Forms.TextBox();
            this.lbl_numberofvictims = new System.Windows.Forms.Label();
            this.lbl_isitacollision = new System.Windows.Forms.Label();
            this.lbl_collisionsubtitle = new System.Windows.Forms.Label();
            this.radio_va_yes = new System.Windows.Forms.RadioButton();
            this.radio_va_no = new System.Windows.Forms.RadioButton();
            this.grp_vehicularaccident = new System.Windows.Forms.GroupBox();
            this.checkbox_unknown = new System.Windows.Forms.CheckBox();
            this.checkbox_bicycle = new System.Windows.Forms.CheckBox();
            this.checkbox_tricycle = new System.Windows.Forms.CheckBox();
            this.checkbox_motorcycle = new System.Windows.Forms.CheckBox();
            this.checkbox_bus = new System.Windows.Forms.CheckBox();
            this.checkbox_van = new System.Windows.Forms.CheckBox();
            this.checkbox_car = new System.Windows.Forms.CheckBox();
            this.lbl_vehiclesinvolved = new System.Windows.Forms.Label();
            this.grp_incidentinformation = new System.Windows.Forms.GroupBox();
            this.lbl_endorsed = new System.Windows.Forms.Label();
            this.drop_hospital = new System.Windows.Forms.ComboBox();
            this.grp_dispatchandgroups = new System.Windows.Forms.GroupBox();
            this.checkbox_ptv = new System.Windows.Forms.CheckBox();
            this.checkbox_vmo = new System.Windows.Forms.CheckBox();
            this.checkbox_bdrrmc = new System.Windows.Forms.CheckBox();
            this.checkbox_pnp = new System.Windows.Forms.CheckBox();
            this.checkbox_bfp = new System.Windows.Forms.CheckBox();
            this.checkbox_mdrrmovolunteer = new System.Windows.Forms.CheckBox();
            this.checkbox_mdrrmo = new System.Windows.Forms.CheckBox();
            this.lbl_respondedby = new System.Windows.Forms.Label();
            this.grp_otherdetails = new System.Windows.Forms.GroupBox();
            this.lbl_detailsubtitle = new System.Windows.Forms.Label();
            this.lbl_charcount = new System.Windows.Forms.Label();
            this.input_otherdetail = new System.Windows.Forms.RichTextBox();
            this.grp_remarks = new System.Windows.Forms.GroupBox();
            this.lbl_charcount_remarks = new System.Windows.Forms.Label();
            this.lbl_remarksubtitle = new System.Windows.Forms.Label();
            this.input_remarks = new System.Windows.Forms.RichTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_red1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_vehicularaccident.SuspendLayout();
            this.grp_incidentinformation.SuspendLayout();
            this.grp_dispatchandgroups.SuspendLayout();
            this.grp_otherdetails.SuspendLayout();
            this.grp_remarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dateofincident
            // 
            this.lbl_dateofincident.AutoSize = true;
            this.lbl_dateofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateofincident.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_dateofincident.Location = new System.Drawing.Point(28, 47);
            this.lbl_dateofincident.Name = "lbl_dateofincident";
            this.lbl_dateofincident.Size = new System.Drawing.Size(137, 21);
            this.lbl_dateofincident.TabIndex = 0;
            this.lbl_dateofincident.Text = "Date of Incident:";
            // 
            // calendar_dateofincident
            // 
            this.calendar_dateofincident.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_dateofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_dateofincident.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendar_dateofincident.Location = new System.Drawing.Point(32, 71);
            this.calendar_dateofincident.Name = "calendar_dateofincident";
            this.calendar_dateofincident.Size = new System.Drawing.Size(169, 29);
            this.calendar_dateofincident.TabIndex = 1;
            // 
            // lbl_timeofincident
            // 
            this.lbl_timeofincident.AutoSize = true;
            this.lbl_timeofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeofincident.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_timeofincident.Location = new System.Drawing.Point(28, 103);
            this.lbl_timeofincident.Name = "lbl_timeofincident";
            this.lbl_timeofincident.Size = new System.Drawing.Size(139, 21);
            this.lbl_timeofincident.TabIndex = 2;
            this.lbl_timeofincident.Text = "Time of Incident:";
            // 
            // input_timeofincident
            // 
            this.input_timeofincident.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_timeofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_timeofincident.Location = new System.Drawing.Point(32, 127);
            this.input_timeofincident.Name = "input_timeofincident";
            this.input_timeofincident.Size = new System.Drawing.Size(310, 22);
            this.input_timeofincident.TabIndex = 4;
            this.input_timeofincident.Enter += new System.EventHandler(this.input_timeofincident_Enter);
            this.input_timeofincident.Leave += new System.EventHandler(this.input_timeofincident_Leave);
            // 
            // lbl_natureofincident
            // 
            this.lbl_natureofincident.AutoSize = true;
            this.lbl_natureofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_natureofincident.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_natureofincident.Location = new System.Drawing.Point(28, 152);
            this.lbl_natureofincident.Name = "lbl_natureofincident";
            this.lbl_natureofincident.Size = new System.Drawing.Size(154, 21);
            this.lbl_natureofincident.TabIndex = 5;
            this.lbl_natureofincident.Text = "Nature of Incident:";
            // 
            // drop_natureofincident
            // 
            this.drop_natureofincident.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drop_natureofincident.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drop_natureofincident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_natureofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_natureofincident.FormattingEnabled = true;
            this.drop_natureofincident.Items.AddRange(new object[] {
            "Road Crash",
            "Earthquake",
            "Fire",
            "Hacking",
            "Stabbing",
            "Industrial",
            "Water Transportation",
            "Weather Related Injuries",
            "Drowning",
            "Others"});
            this.drop_natureofincident.Location = new System.Drawing.Point(32, 176);
            this.drop_natureofincident.Name = "drop_natureofincident";
            this.drop_natureofincident.Size = new System.Drawing.Size(310, 29);
            this.drop_natureofincident.TabIndex = 6;
            // 
            // drop_placeofincident
            // 
            this.drop_placeofincident.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drop_placeofincident.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drop_placeofincident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_placeofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_placeofincident.FormattingEnabled = true;
            this.drop_placeofincident.Items.AddRange(new object[] {
            "Angeles",
            "Balubad",
            "Balugohin",
            "Buhangin",
            "Caridad Ibaba",
            "Caridad Ilaya",
            "Habingan",
            "Inaclagan",
            "Inalig",
            "Kilait",
            "Kulawit",
            "Lakip",
            "Lubi",
            "Lumutan",
            "Magsaysay",
            "Malinao Ibaba",
            "Malinao Ilaya",
            "Malusak",
            "Manggalayan Bundok",
            "Manggalayan Labak",
            "Matanag",
            "Montes Balaon",
            "Montes Kallagan",
            "Ponon",
            "Rizal",
            "San Andres Bundok",
            "San Andres Labak",
            "San Isidro",
            "San Jose Balatok",
            "San Rafael",
            "Sta. Catalina",
            "Sapaan",
            "Sokol",
            "Tagbakin",
            "Talaba",
            "Tinandog",
            "Zone I Poblacion",
            "Zone II Poblacion",
            "Zone III Poblacion",
            "Zone IV Poblacion",
            "Villa Ibaba",
            "Villa Ilaya"});
            this.drop_placeofincident.Location = new System.Drawing.Point(32, 232);
            this.drop_placeofincident.Name = "drop_placeofincident";
            this.drop_placeofincident.Size = new System.Drawing.Size(310, 29);
            this.drop_placeofincident.TabIndex = 8;
            // 
            // lbl_placeofincident
            // 
            this.lbl_placeofincident.AutoSize = true;
            this.lbl_placeofincident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeofincident.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_placeofincident.Location = new System.Drawing.Point(28, 208);
            this.lbl_placeofincident.Name = "lbl_placeofincident";
            this.lbl_placeofincident.Size = new System.Drawing.Size(142, 21);
            this.lbl_placeofincident.TabIndex = 7;
            this.lbl_placeofincident.Text = "Place of Incident:";
            // 
            // input_numberofvictims
            // 
            this.input_numberofvictims.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_numberofvictims.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_numberofvictims.Location = new System.Drawing.Point(32, 288);
            this.input_numberofvictims.Name = "input_numberofvictims";
            this.input_numberofvictims.Size = new System.Drawing.Size(310, 22);
            this.input_numberofvictims.TabIndex = 10;
            // 
            // lbl_numberofvictims
            // 
            this.lbl_numberofvictims.AutoSize = true;
            this.lbl_numberofvictims.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberofvictims.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_numberofvictims.Location = new System.Drawing.Point(28, 264);
            this.lbl_numberofvictims.Name = "lbl_numberofvictims";
            this.lbl_numberofvictims.Size = new System.Drawing.Size(158, 21);
            this.lbl_numberofvictims.TabIndex = 9;
            this.lbl_numberofvictims.Text = "Number of Victims:";
            // 
            // lbl_isitacollision
            // 
            this.lbl_isitacollision.AutoSize = true;
            this.lbl_isitacollision.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isitacollision.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_isitacollision.Location = new System.Drawing.Point(27, 386);
            this.lbl_isitacollision.Name = "lbl_isitacollision";
            this.lbl_isitacollision.Size = new System.Drawing.Size(166, 30);
            this.lbl_isitacollision.TabIndex = 11;
            this.lbl_isitacollision.Text = "Is it a Collision?";
            // 
            // lbl_collisionsubtitle
            // 
            this.lbl_collisionsubtitle.AutoSize = true;
            this.lbl_collisionsubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_collisionsubtitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_collisionsubtitle.Location = new System.Drawing.Point(29, 417);
            this.lbl_collisionsubtitle.Name = "lbl_collisionsubtitle";
            this.lbl_collisionsubtitle.Size = new System.Drawing.Size(152, 13);
            this.lbl_collisionsubtitle.TabIndex = 12;
            this.lbl_collisionsubtitle.Text = "(For Vehicular Accident only)";
            // 
            // radio_va_yes
            // 
            this.radio_va_yes.AutoSize = true;
            this.radio_va_yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_va_yes.ForeColor = System.Drawing.SystemColors.Control;
            this.radio_va_yes.Location = new System.Drawing.Point(32, 433);
            this.radio_va_yes.Name = "radio_va_yes";
            this.radio_va_yes.Size = new System.Drawing.Size(51, 25);
            this.radio_va_yes.TabIndex = 13;
            this.radio_va_yes.TabStop = true;
            this.radio_va_yes.Text = "Yes";
            this.radio_va_yes.UseVisualStyleBackColor = true;
            this.radio_va_yes.CheckedChanged += new System.EventHandler(this.radio_va_yes_CheckedChanged);
            // 
            // radio_va_no
            // 
            this.radio_va_no.AutoSize = true;
            this.radio_va_no.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_va_no.ForeColor = System.Drawing.SystemColors.Control;
            this.radio_va_no.Location = new System.Drawing.Point(32, 464);
            this.radio_va_no.Name = "radio_va_no";
            this.radio_va_no.Size = new System.Drawing.Size(49, 25);
            this.radio_va_no.TabIndex = 14;
            this.radio_va_no.TabStop = true;
            this.radio_va_no.Text = "No";
            this.radio_va_no.UseVisualStyleBackColor = true;
            this.radio_va_no.CheckedChanged += new System.EventHandler(this.radio_va_no_CheckedChanged);
            // 
            // grp_vehicularaccident
            // 
            this.grp_vehicularaccident.Controls.Add(this.label7);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_unknown);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_bicycle);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_tricycle);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_motorcycle);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_bus);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_van);
            this.grp_vehicularaccident.Controls.Add(this.checkbox_car);
            this.grp_vehicularaccident.Controls.Add(this.lbl_vehiclesinvolved);
            this.grp_vehicularaccident.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_vehicularaccident.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_vehicularaccident.Location = new System.Drawing.Point(65, 578);
            this.grp_vehicularaccident.Name = "grp_vehicularaccident";
            this.grp_vehicularaccident.Size = new System.Drawing.Size(487, 324);
            this.grp_vehicularaccident.TabIndex = 15;
            this.grp_vehicularaccident.TabStop = false;
            this.grp_vehicularaccident.Text = "Vehicular Accident";
            this.grp_vehicularaccident.Visible = false;
            // 
            // checkbox_unknown
            // 
            this.checkbox_unknown.AutoSize = true;
            this.checkbox_unknown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_unknown.Location = new System.Drawing.Point(76, 262);
            this.checkbox_unknown.Name = "checkbox_unknown";
            this.checkbox_unknown.Size = new System.Drawing.Size(96, 25);
            this.checkbox_unknown.TabIndex = 23;
            this.checkbox_unknown.Text = "Unknown";
            this.checkbox_unknown.UseVisualStyleBackColor = true;
            // 
            // checkbox_bicycle
            // 
            this.checkbox_bicycle.AutoSize = true;
            this.checkbox_bicycle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_bicycle.Location = new System.Drawing.Point(76, 231);
            this.checkbox_bicycle.Name = "checkbox_bicycle";
            this.checkbox_bicycle.Size = new System.Drawing.Size(111, 25);
            this.checkbox_bicycle.TabIndex = 22;
            this.checkbox_bicycle.Text = "Bicycle/Bike";
            this.checkbox_bicycle.UseVisualStyleBackColor = true;
            // 
            // checkbox_tricycle
            // 
            this.checkbox_tricycle.AutoSize = true;
            this.checkbox_tricycle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_tricycle.Location = new System.Drawing.Point(76, 200);
            this.checkbox_tricycle.Name = "checkbox_tricycle";
            this.checkbox_tricycle.Size = new System.Drawing.Size(80, 25);
            this.checkbox_tricycle.TabIndex = 21;
            this.checkbox_tricycle.Text = "Tricycle";
            this.checkbox_tricycle.UseVisualStyleBackColor = true;
            // 
            // checkbox_motorcycle
            // 
            this.checkbox_motorcycle.AutoSize = true;
            this.checkbox_motorcycle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_motorcycle.Location = new System.Drawing.Point(76, 169);
            this.checkbox_motorcycle.Name = "checkbox_motorcycle";
            this.checkbox_motorcycle.Size = new System.Drawing.Size(106, 25);
            this.checkbox_motorcycle.TabIndex = 20;
            this.checkbox_motorcycle.Text = "Motorcycle";
            this.checkbox_motorcycle.UseVisualStyleBackColor = true;
            // 
            // checkbox_bus
            // 
            this.checkbox_bus.AutoSize = true;
            this.checkbox_bus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_bus.Location = new System.Drawing.Point(76, 138);
            this.checkbox_bus.Name = "checkbox_bus";
            this.checkbox_bus.Size = new System.Drawing.Size(54, 25);
            this.checkbox_bus.TabIndex = 19;
            this.checkbox_bus.Text = "Bus";
            this.checkbox_bus.UseVisualStyleBackColor = true;
            // 
            // checkbox_van
            // 
            this.checkbox_van.AutoSize = true;
            this.checkbox_van.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_van.Location = new System.Drawing.Point(76, 107);
            this.checkbox_van.Name = "checkbox_van";
            this.checkbox_van.Size = new System.Drawing.Size(55, 25);
            this.checkbox_van.TabIndex = 18;
            this.checkbox_van.Text = "Van";
            this.checkbox_van.UseVisualStyleBackColor = true;
            // 
            // checkbox_car
            // 
            this.checkbox_car.AutoSize = true;
            this.checkbox_car.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_car.Location = new System.Drawing.Point(76, 76);
            this.checkbox_car.Name = "checkbox_car";
            this.checkbox_car.Size = new System.Drawing.Size(89, 25);
            this.checkbox_car.TabIndex = 17;
            this.checkbox_car.Text = "Car/SUV";
            this.checkbox_car.UseVisualStyleBackColor = true;
            // 
            // lbl_vehiclesinvolved
            // 
            this.lbl_vehiclesinvolved.AutoSize = true;
            this.lbl_vehiclesinvolved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiclesinvolved.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_vehiclesinvolved.Location = new System.Drawing.Point(37, 47);
            this.lbl_vehiclesinvolved.Name = "lbl_vehiclesinvolved";
            this.lbl_vehiclesinvolved.Size = new System.Drawing.Size(141, 21);
            this.lbl_vehiclesinvolved.TabIndex = 10;
            this.lbl_vehiclesinvolved.Text = "Vehicle Involved:";
            // 
            // grp_incidentinformation
            // 
            this.grp_incidentinformation.Controls.Add(this.label6);
            this.grp_incidentinformation.Controls.Add(this.label5);
            this.grp_incidentinformation.Controls.Add(this.label4);
            this.grp_incidentinformation.Controls.Add(this.label3);
            this.grp_incidentinformation.Controls.Add(this.label2);
            this.grp_incidentinformation.Controls.Add(this.label1);
            this.grp_incidentinformation.Controls.Add(this.lbl_red1);
            this.grp_incidentinformation.Controls.Add(this.lbl_endorsed);
            this.grp_incidentinformation.Controls.Add(this.drop_hospital);
            this.grp_incidentinformation.Controls.Add(this.lbl_dateofincident);
            this.grp_incidentinformation.Controls.Add(this.calendar_dateofincident);
            this.grp_incidentinformation.Controls.Add(this.radio_va_no);
            this.grp_incidentinformation.Controls.Add(this.lbl_timeofincident);
            this.grp_incidentinformation.Controls.Add(this.radio_va_yes);
            this.grp_incidentinformation.Controls.Add(this.input_timeofincident);
            this.grp_incidentinformation.Controls.Add(this.lbl_collisionsubtitle);
            this.grp_incidentinformation.Controls.Add(this.lbl_natureofincident);
            this.grp_incidentinformation.Controls.Add(this.lbl_isitacollision);
            this.grp_incidentinformation.Controls.Add(this.drop_natureofincident);
            this.grp_incidentinformation.Controls.Add(this.input_numberofvictims);
            this.grp_incidentinformation.Controls.Add(this.lbl_placeofincident);
            this.grp_incidentinformation.Controls.Add(this.lbl_numberofvictims);
            this.grp_incidentinformation.Controls.Add(this.drop_placeofincident);
            this.grp_incidentinformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_incidentinformation.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_incidentinformation.Location = new System.Drawing.Point(65, 57);
            this.grp_incidentinformation.Name = "grp_incidentinformation";
            this.grp_incidentinformation.Size = new System.Drawing.Size(487, 515);
            this.grp_incidentinformation.TabIndex = 16;
            this.grp_incidentinformation.TabStop = false;
            this.grp_incidentinformation.Text = "Incident Information";
            // 
            // lbl_endorsed
            // 
            this.lbl_endorsed.AutoSize = true;
            this.lbl_endorsed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endorsed.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_endorsed.Location = new System.Drawing.Point(28, 313);
            this.lbl_endorsed.Name = "lbl_endorsed";
            this.lbl_endorsed.Size = new System.Drawing.Size(223, 21);
            this.lbl_endorsed.TabIndex = 15;
            this.lbl_endorsed.Text = "Endorsed to which Hospital:";
            // 
            // drop_hospital
            // 
            this.drop_hospital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drop_hospital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drop_hospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_hospital.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_hospital.FormattingEnabled = true;
            this.drop_hospital.Items.AddRange(new object[] {
            "DMMDH",
            "NSDA Hospital"});
            this.drop_hospital.Location = new System.Drawing.Point(32, 337);
            this.drop_hospital.Name = "drop_hospital";
            this.drop_hospital.Size = new System.Drawing.Size(310, 29);
            this.drop_hospital.TabIndex = 16;
            // 
            // grp_dispatchandgroups
            // 
            this.grp_dispatchandgroups.Controls.Add(this.label8);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_ptv);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_vmo);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_bdrrmc);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_pnp);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_bfp);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_mdrrmovolunteer);
            this.grp_dispatchandgroups.Controls.Add(this.checkbox_mdrrmo);
            this.grp_dispatchandgroups.Controls.Add(this.lbl_respondedby);
            this.grp_dispatchandgroups.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dispatchandgroups.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_dispatchandgroups.Location = new System.Drawing.Point(585, 57);
            this.grp_dispatchandgroups.Name = "grp_dispatchandgroups";
            this.grp_dispatchandgroups.Size = new System.Drawing.Size(487, 324);
            this.grp_dispatchandgroups.TabIndex = 17;
            this.grp_dispatchandgroups.TabStop = false;
            this.grp_dispatchandgroups.Text = "Dispatch and Groups";
            // 
            // checkbox_ptv
            // 
            this.checkbox_ptv.AutoSize = true;
            this.checkbox_ptv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_ptv.Location = new System.Drawing.Point(76, 262);
            this.checkbox_ptv.Name = "checkbox_ptv";
            this.checkbox_ptv.Size = new System.Drawing.Size(91, 25);
            this.checkbox_ptv.TabIndex = 23;
            this.checkbox_ptv.Text = "LGU/PTV";
            this.checkbox_ptv.UseVisualStyleBackColor = true;
            // 
            // checkbox_vmo
            // 
            this.checkbox_vmo.AutoSize = true;
            this.checkbox_vmo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_vmo.Location = new System.Drawing.Point(76, 231);
            this.checkbox_vmo.Name = "checkbox_vmo";
            this.checkbox_vmo.Size = new System.Drawing.Size(317, 25);
            this.checkbox_vmo.TabIndex = 22;
            this.checkbox_vmo.Text = "Volunteer Mobilizing Organization - VMO";
            this.checkbox_vmo.UseVisualStyleBackColor = true;
            // 
            // checkbox_bdrrmc
            // 
            this.checkbox_bdrrmc.AutoSize = true;
            this.checkbox_bdrrmc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_bdrrmc.Location = new System.Drawing.Point(76, 200);
            this.checkbox_bdrrmc.Name = "checkbox_bdrrmc";
            this.checkbox_bdrrmc.Size = new System.Drawing.Size(93, 25);
            this.checkbox_bdrrmc.TabIndex = 21;
            this.checkbox_bdrrmc.Text = "BDRRMC";
            this.checkbox_bdrrmc.UseVisualStyleBackColor = true;
            // 
            // checkbox_pnp
            // 
            this.checkbox_pnp.AutoSize = true;
            this.checkbox_pnp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_pnp.Location = new System.Drawing.Point(76, 169);
            this.checkbox_pnp.Name = "checkbox_pnp";
            this.checkbox_pnp.Size = new System.Drawing.Size(249, 25);
            this.checkbox_pnp.TabIndex = 20;
            this.checkbox_pnp.Text = "Philippine National Police - PNP";
            this.checkbox_pnp.UseVisualStyleBackColor = true;
            // 
            // checkbox_bfp
            // 
            this.checkbox_bfp.AutoSize = true;
            this.checkbox_bfp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_bfp.Location = new System.Drawing.Point(76, 138);
            this.checkbox_bfp.Name = "checkbox_bfp";
            this.checkbox_bfp.Size = new System.Drawing.Size(241, 25);
            this.checkbox_bfp.TabIndex = 19;
            this.checkbox_bfp.Text = "Bureau of Fire Protection - BFP";
            this.checkbox_bfp.UseVisualStyleBackColor = true;
            // 
            // checkbox_mdrrmovolunteer
            // 
            this.checkbox_mdrrmovolunteer.AutoSize = true;
            this.checkbox_mdrrmovolunteer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_mdrrmovolunteer.Location = new System.Drawing.Point(76, 107);
            this.checkbox_mdrrmovolunteer.Name = "checkbox_mdrrmovolunteer";
            this.checkbox_mdrrmovolunteer.Size = new System.Drawing.Size(178, 25);
            this.checkbox_mdrrmovolunteer.TabIndex = 18;
            this.checkbox_mdrrmovolunteer.Text = "MDRRMO Volunteers";
            this.checkbox_mdrrmovolunteer.UseVisualStyleBackColor = true;
            // 
            // checkbox_mdrrmo
            // 
            this.checkbox_mdrrmo.AutoSize = true;
            this.checkbox_mdrrmo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_mdrrmo.Location = new System.Drawing.Point(76, 76);
            this.checkbox_mdrrmo.Name = "checkbox_mdrrmo";
            this.checkbox_mdrrmo.Size = new System.Drawing.Size(100, 25);
            this.checkbox_mdrrmo.TabIndex = 17;
            this.checkbox_mdrrmo.Text = "MDRRMO";
            this.checkbox_mdrrmo.UseVisualStyleBackColor = true;
            // 
            // lbl_respondedby
            // 
            this.lbl_respondedby.AutoSize = true;
            this.lbl_respondedby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_respondedby.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_respondedby.Location = new System.Drawing.Point(37, 47);
            this.lbl_respondedby.Name = "lbl_respondedby";
            this.lbl_respondedby.Size = new System.Drawing.Size(122, 21);
            this.lbl_respondedby.TabIndex = 10;
            this.lbl_respondedby.Text = "Responded by:";
            // 
            // grp_otherdetails
            // 
            this.grp_otherdetails.Controls.Add(this.label9);
            this.grp_otherdetails.Controls.Add(this.lbl_detailsubtitle);
            this.grp_otherdetails.Controls.Add(this.lbl_charcount);
            this.grp_otherdetails.Controls.Add(this.input_otherdetail);
            this.grp_otherdetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_otherdetails.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_otherdetails.Location = new System.Drawing.Point(585, 404);
            this.grp_otherdetails.Name = "grp_otherdetails";
            this.grp_otherdetails.Size = new System.Drawing.Size(1006, 498);
            this.grp_otherdetails.TabIndex = 18;
            this.grp_otherdetails.TabStop = false;
            this.grp_otherdetails.Text = "Other Details";
            // 
            // lbl_detailsubtitle
            // 
            this.lbl_detailsubtitle.AutoSize = true;
            this.lbl_detailsubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detailsubtitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_detailsubtitle.Location = new System.Drawing.Point(38, 70);
            this.lbl_detailsubtitle.Name = "lbl_detailsubtitle";
            this.lbl_detailsubtitle.Size = new System.Drawing.Size(325, 13);
            this.lbl_detailsubtitle.TabIndex = 14;
            this.lbl_detailsubtitle.Text = "(Eg: Plate number, Vehicle descriptions, Victim names and etc.)";
            // 
            // lbl_charcount
            // 
            this.lbl_charcount.AutoSize = true;
            this.lbl_charcount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_charcount.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_charcount.Location = new System.Drawing.Point(801, 442);
            this.lbl_charcount.Name = "lbl_charcount";
            this.lbl_charcount.Size = new System.Drawing.Size(149, 13);
            this.lbl_charcount.TabIndex = 13;
            this.lbl_charcount.Text = "Characters Remaining: 5000";
            // 
            // input_otherdetail
            // 
            this.input_otherdetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_otherdetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_otherdetail.Location = new System.Drawing.Point(41, 89);
            this.input_otherdetail.MaxLength = 5000;
            this.input_otherdetail.Name = "input_otherdetail";
            this.input_otherdetail.Size = new System.Drawing.Size(934, 331);
            this.input_otherdetail.TabIndex = 0;
            this.input_otherdetail.Text = "";
            this.input_otherdetail.TextChanged += new System.EventHandler(this.input_otherdetail_TextChanged);
            // 
            // grp_remarks
            // 
            this.grp_remarks.Controls.Add(this.lbl_charcount_remarks);
            this.grp_remarks.Controls.Add(this.lbl_remarksubtitle);
            this.grp_remarks.Controls.Add(this.input_remarks);
            this.grp_remarks.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_remarks.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_remarks.Location = new System.Drawing.Point(1104, 57);
            this.grp_remarks.Name = "grp_remarks";
            this.grp_remarks.Size = new System.Drawing.Size(487, 324);
            this.grp_remarks.TabIndex = 24;
            this.grp_remarks.TabStop = false;
            this.grp_remarks.Text = "Remarks";
            // 
            // lbl_charcount_remarks
            // 
            this.lbl_charcount_remarks.AutoSize = true;
            this.lbl_charcount_remarks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_charcount_remarks.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_charcount_remarks.Location = new System.Drawing.Point(307, 288);
            this.lbl_charcount_remarks.Name = "lbl_charcount_remarks";
            this.lbl_charcount_remarks.Size = new System.Drawing.Size(149, 13);
            this.lbl_charcount_remarks.TabIndex = 16;
            this.lbl_charcount_remarks.Text = "Characters Remaining: 1000";
            // 
            // lbl_remarksubtitle
            // 
            this.lbl_remarksubtitle.AutoSize = true;
            this.lbl_remarksubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarksubtitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_remarksubtitle.Location = new System.Drawing.Point(34, 53);
            this.lbl_remarksubtitle.Name = "lbl_remarksubtitle";
            this.lbl_remarksubtitle.Size = new System.Drawing.Size(181, 13);
            this.lbl_remarksubtitle.TabIndex = 15;
            this.lbl_remarksubtitle.Text = "(Additional information for notes)";
            // 
            // input_remarks
            // 
            this.input_remarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_remarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_remarks.Location = new System.Drawing.Point(37, 71);
            this.input_remarks.MaxLength = 1000;
            this.input_remarks.Name = "input_remarks";
            this.input_remarks.Size = new System.Drawing.Size(419, 190);
            this.input_remarks.TabIndex = 1;
            this.input_remarks.Text = "";
            this.input_remarks.TextChanged += new System.EventHandler(this.input_remarks_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Image = ((System.Drawing.Image)(resources.GetObject("btn_submit.Image")));
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Location = new System.Drawing.Point(1338, 920);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_submit.Size = new System.Drawing.Size(253, 60);
            this.btn_submit.TabIndex = 25;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_red1
            // 
            this.lbl_red1.AutoSize = true;
            this.lbl_red1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red1.ForeColor = System.Drawing.Color.Red;
            this.lbl_red1.Location = new System.Drawing.Point(171, 44);
            this.lbl_red1.Name = "lbl_red1";
            this.lbl_red1.Size = new System.Drawing.Size(20, 25);
            this.lbl_red1.TabIndex = 17;
            this.lbl_red1.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(173, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(181, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(176, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(192, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(257, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(192, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(184, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(165, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(369, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // formemergency
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1657, 1026);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.grp_remarks);
            this.Controls.Add(this.grp_otherdetails);
            this.Controls.Add(this.grp_dispatchandgroups);
            this.Controls.Add(this.grp_incidentinformation);
            this.Controls.Add(this.grp_vehicularaccident);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formemergency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formemergency";
            this.Load += new System.EventHandler(this.formemergency_Load);
            this.grp_vehicularaccident.ResumeLayout(false);
            this.grp_vehicularaccident.PerformLayout();
            this.grp_incidentinformation.ResumeLayout(false);
            this.grp_incidentinformation.PerformLayout();
            this.grp_dispatchandgroups.ResumeLayout(false);
            this.grp_dispatchandgroups.PerformLayout();
            this.grp_otherdetails.ResumeLayout(false);
            this.grp_otherdetails.PerformLayout();
            this.grp_remarks.ResumeLayout(false);
            this.grp_remarks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_dateofincident;
        private System.Windows.Forms.DateTimePicker calendar_dateofincident;
        private System.Windows.Forms.Label lbl_timeofincident;
        private System.Windows.Forms.TextBox input_timeofincident;
        private System.Windows.Forms.Label lbl_natureofincident;
        private System.Windows.Forms.ComboBox drop_natureofincident;
        private System.Windows.Forms.ComboBox drop_placeofincident;
        private System.Windows.Forms.Label lbl_placeofincident;
        private System.Windows.Forms.TextBox input_numberofvictims;
        private System.Windows.Forms.Label lbl_numberofvictims;
        private System.Windows.Forms.Label lbl_isitacollision;
        private System.Windows.Forms.Label lbl_collisionsubtitle;
        private System.Windows.Forms.RadioButton radio_va_yes;
        private System.Windows.Forms.RadioButton radio_va_no;
        private System.Windows.Forms.GroupBox grp_vehicularaccident;
        private System.Windows.Forms.Label lbl_vehiclesinvolved;
        private System.Windows.Forms.GroupBox grp_incidentinformation;
        private System.Windows.Forms.CheckBox checkbox_unknown;
        private System.Windows.Forms.CheckBox checkbox_bicycle;
        private System.Windows.Forms.CheckBox checkbox_tricycle;
        private System.Windows.Forms.CheckBox checkbox_motorcycle;
        private System.Windows.Forms.CheckBox checkbox_bus;
        private System.Windows.Forms.CheckBox checkbox_van;
        private System.Windows.Forms.CheckBox checkbox_car;
        private System.Windows.Forms.GroupBox grp_dispatchandgroups;
        private System.Windows.Forms.CheckBox checkbox_ptv;
        private System.Windows.Forms.CheckBox checkbox_vmo;
        private System.Windows.Forms.CheckBox checkbox_bdrrmc;
        private System.Windows.Forms.CheckBox checkbox_pnp;
        private System.Windows.Forms.CheckBox checkbox_bfp;
        private System.Windows.Forms.CheckBox checkbox_mdrrmovolunteer;
        private System.Windows.Forms.CheckBox checkbox_mdrrmo;
        private System.Windows.Forms.Label lbl_respondedby;
        private System.Windows.Forms.GroupBox grp_otherdetails;
        private System.Windows.Forms.RichTextBox input_otherdetail;
        private System.Windows.Forms.GroupBox grp_remarks;
        private System.Windows.Forms.Label lbl_charcount;
        private System.Windows.Forms.RichTextBox input_remarks;
        private System.Windows.Forms.Label lbl_detailsubtitle;
        private System.Windows.Forms.Label lbl_remarksubtitle;
        private System.Windows.Forms.Label lbl_charcount_remarks;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_endorsed;
        private System.Windows.Forms.ComboBox drop_hospital;
        private System.Windows.Forms.Label lbl_red1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}