namespace CourseWork
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.agePicker = new System.Windows.Forms.DateTimePicker();
            this.DOBLbl = new System.Windows.Forms.Label();
            this.ContactNoTb = new System.Windows.Forms.TextBox();
            this.ContactNoLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.tabletitle = new System.Windows.Forms.Label();
            this.sortingCB = new System.Windows.Forms.ComboBox();
            this.ProgramCb = new System.Windows.Forms.ComboBox();
            this.EnrolledLbl = new System.Windows.Forms.Label();
            this.RegistrationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.RegistrationLbl = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.ProgramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.titleLbl = new System.Windows.Forms.Label();
            this.WeeklyReportGrid = new System.Windows.Forms.DataGridView();
            this.WeeklyReportLbl = new System.Windows.Forms.Label();
            this.WeeklyRptPicker = new System.Windows.Forms.DateTimePicker();
            this.WeeklyDateLbl = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(13, 46);
            this.FirstNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLbl.TabIndex = 1;
            this.FirstNameLbl.Text = "First Name";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(342, 46);
            this.LastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(82, 20);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "LastName";
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(432, 43);
            this.LastNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(224, 26);
            this.LastNameTb.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(664, 43);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 60);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(107, 79);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(206, 26);
            this.AddressTb.TabIndex = 3;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(13, 86);
            this.AddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(68, 20);
            this.AddressLbl.TabIndex = 7;
            this.AddressLbl.Text = "Address";
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(432, 80);
            this.EmailTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(224, 26);
            this.EmailTb.TabIndex = 4;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(342, 86);
            this.EmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(48, 20);
            this.EmailLbl.TabIndex = 9;
            this.EmailLbl.Text = "Email";
            // 
            // agePicker
            // 
            this.agePicker.Location = new System.Drawing.Point(120, 151);
            this.agePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agePicker.Name = "agePicker";
            this.agePicker.Size = new System.Drawing.Size(193, 26);
            this.agePicker.TabIndex = 7;
            // 
            // DOBLbl
            // 
            this.DOBLbl.AutoSize = true;
            this.DOBLbl.Location = new System.Drawing.Point(13, 156);
            this.DOBLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DOBLbl.Name = "DOBLbl";
            this.DOBLbl.Size = new System.Drawing.Size(99, 20);
            this.DOBLbl.TabIndex = 11;
            this.DOBLbl.Text = "Date of Birth";
            // 
            // ContactNoTb
            // 
            this.ContactNoTb.Location = new System.Drawing.Point(107, 115);
            this.ContactNoTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContactNoTb.Name = "ContactNoTb";
            this.ContactNoTb.Size = new System.Drawing.Size(206, 26);
            this.ContactNoTb.TabIndex = 5;
            // 
            // ContactNoLbl
            // 
            this.ContactNoLbl.AutoSize = true;
            this.ContactNoLbl.Location = new System.Drawing.Point(10, 121);
            this.ContactNoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNoLbl.Name = "ContactNoLbl";
            this.ContactNoLbl.Size = new System.Drawing.Size(89, 20);
            this.ContactNoLbl.TabIndex = 13;
            this.ContactNoLbl.Text = "Contact No";
            this.ContactNoLbl.Click += new System.EventHandler(this.lblContactNo_Click);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(342, 124);
            this.GenderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(63, 20);
            this.GenderLbl.TabIndex = 14;
            this.GenderLbl.Text = "Gender";
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelStudent.Controls.Add(this.tabletitle);
            this.panelStudent.Controls.Add(this.sortingCB);
            this.panelStudent.Controls.Add(this.ProgramCb);
            this.panelStudent.Controls.Add(this.EnrolledLbl);
            this.panelStudent.Controls.Add(this.RegistrationDatePicker);
            this.panelStudent.Controls.Add(this.btnUpdate);
            this.panelStudent.Controls.Add(this.RegistrationLbl);
            this.panelStudent.Controls.Add(this.btnCancel);
            this.panelStudent.Controls.Add(this.agePicker);
            this.panelStudent.Controls.Add(this.DOBLbl);
            this.panelStudent.Controls.Add(this.GenderLbl);
            this.panelStudent.Controls.Add(this.IdTb);
            this.panelStudent.Controls.Add(this.ContactNoTb);
            this.panelStudent.Controls.Add(this.ContactNoLbl);
            this.panelStudent.Controls.Add(this.dataGridStudents);
            this.panelStudent.Controls.Add(this.GenderCb);
            this.panelStudent.Controls.Add(this.btnSubmit);
            this.panelStudent.Controls.Add(this.EmailTb);
            this.panelStudent.Controls.Add(this.EmailLbl);
            this.panelStudent.Controls.Add(this.FirstNameLbl);
            this.panelStudent.Controls.Add(this.FirstNameTb);
            this.panelStudent.Controls.Add(this.LastNameTb);
            this.panelStudent.Controls.Add(this.AddressTb);
            this.panelStudent.Controls.Add(this.LastNameLbl);
            this.panelStudent.Controls.Add(this.AddressLbl);
            this.panelStudent.Location = new System.Drawing.Point(13, 63);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(770, 627);
            this.panelStudent.TabIndex = 15;
            // 
            // tabletitle
            // 
            this.tabletitle.AutoSize = true;
            this.tabletitle.Location = new System.Drawing.Point(13, 232);
            this.tabletitle.Name = "tabletitle";
            this.tabletitle.Size = new System.Drawing.Size(148, 20);
            this.tabletitle.TabIndex = 19;
            this.tabletitle.Text = "Student Data Table";
            // 
            // sortingCB
            // 
            this.sortingCB.FormattingEnabled = true;
            this.sortingCB.Items.AddRange(new object[] {
            "Name (Ascending)",
            "Name (Descending)",
            "Registered Date (Ascending)",
            "Registered Date (Descending)"});
            this.sortingCB.Location = new System.Drawing.Point(466, 584);
            this.sortingCB.Name = "sortingCB";
            this.sortingCB.Size = new System.Drawing.Size(291, 28);
            this.sortingCB.TabIndex = 14;
            this.sortingCB.Text = "Sort Here";
            this.sortingCB.SelectedIndexChanged += new System.EventHandler(this.sortingCB_SelectedIndexChanged);
            // 
            // ProgramCb
            // 
            this.ProgramCb.FormattingEnabled = true;
            this.ProgramCb.Items.AddRange(new object[] {
            "Computing",
            "Networking",
            "Multimedia"});
            this.ProgramCb.Location = new System.Drawing.Point(479, 188);
            this.ProgramCb.Name = "ProgramCb";
            this.ProgramCb.Size = new System.Drawing.Size(177, 28);
            this.ProgramCb.TabIndex = 9;
            // 
            // EnrolledLbl
            // 
            this.EnrolledLbl.AutoSize = true;
            this.EnrolledLbl.Location = new System.Drawing.Point(342, 191);
            this.EnrolledLbl.Name = "EnrolledLbl";
            this.EnrolledLbl.Size = new System.Drawing.Size(131, 20);
            this.EnrolledLbl.TabIndex = 17;
            this.EnrolledLbl.Text = "Program Enrolled";
            // 
            // RegistrationDatePicker
            // 
            this.RegistrationDatePicker.Location = new System.Drawing.Point(477, 154);
            this.RegistrationDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegistrationDatePicker.Name = "RegistrationDatePicker";
            this.RegistrationDatePicker.Size = new System.Drawing.Size(179, 26);
            this.RegistrationDatePicker.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(664, 158);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 58);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // RegistrationLbl
            // 
            this.RegistrationLbl.AutoSize = true;
            this.RegistrationLbl.Location = new System.Drawing.Point(342, 157);
            this.RegistrationLbl.Name = "RegistrationLbl";
            this.RegistrationLbl.Size = new System.Drawing.Size(134, 20);
            this.RegistrationLbl.TabIndex = 15;
            this.RegistrationLbl.Text = "Registration Date";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(664, 102);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 57);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(4, 5);
            this.IdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(148, 26);
            this.IdTb.TabIndex = 8;
            this.IdTb.Visible = false;
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridStudents.Location = new System.Drawing.Point(4, 257);
            this.dataGridStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersWidth = 62;
            this.dataGridStudents.Size = new System.Drawing.Size(753, 321);
            this.dataGridStudents.TabIndex = 13;
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellContentClick);
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.GenderCb.Location = new System.Drawing.Point(432, 116);
            this.GenderCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(140, 28);
            this.GenderCb.TabIndex = 6;
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(107, 43);
            this.FirstNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(206, 26);
            this.FirstNameTb.TabIndex = 1;
            // 
            // ProgramChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ProgramChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ProgramChart.Legends.Add(legend3);
            this.ProgramChart.Location = new System.Drawing.Point(836, 14);
            this.ProgramChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgramChart.Name = "ProgramChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ProgramChart.Series.Add(series3);
            this.ProgramChart.Size = new System.Drawing.Size(338, 344);
            this.ProgramChart.TabIndex = 16;
            this.ProgramChart.Text = "chart1";
            this.ProgramChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(169, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(410, 49);
            this.titleLbl.TabIndex = 17;
            this.titleLbl.Text = "Student Registration";
            // 
            // WeeklyReportGrid
            // 
            this.WeeklyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeeklyReportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Program,
            this.Number});
            this.WeeklyReportGrid.Location = new System.Drawing.Point(794, 439);
            this.WeeklyReportGrid.Name = "WeeklyReportGrid";
            this.WeeklyReportGrid.RowHeadersWidth = 62;
            this.WeeklyReportGrid.RowTemplate.Height = 28;
            this.WeeklyReportGrid.Size = new System.Drawing.Size(366, 236);
            this.WeeklyReportGrid.TabIndex = 18;
            // 
            // WeeklyReportLbl
            // 
            this.WeeklyReportLbl.AutoSize = true;
            this.WeeklyReportLbl.Location = new System.Drawing.Point(790, 376);
            this.WeeklyReportLbl.Name = "WeeklyReportLbl";
            this.WeeklyReportLbl.Size = new System.Drawing.Size(182, 20);
            this.WeeklyReportLbl.TabIndex = 19;
            this.WeeklyReportLbl.Text = "Students Weekly Report";
            // 
            // WeeklyRptPicker
            // 
            this.WeeklyRptPicker.Location = new System.Drawing.Point(893, 407);
            this.WeeklyRptPicker.Name = "WeeklyRptPicker";
            this.WeeklyRptPicker.Size = new System.Drawing.Size(212, 26);
            this.WeeklyRptPicker.TabIndex = 20;
            this.WeeklyRptPicker.ValueChanged += new System.EventHandler(this.WeeklyRptPicker_ValueChanged);
            // 
            // WeeklyDateLbl
            // 
            this.WeeklyDateLbl.AutoSize = true;
            this.WeeklyDateLbl.Location = new System.Drawing.Point(790, 412);
            this.WeeklyDateLbl.Name = "WeeklyDateLbl";
            this.WeeklyDateLbl.Size = new System.Drawing.Size(97, 20);
            this.WeeklyDateLbl.TabIndex = 21;
            this.WeeklyDateLbl.Text = "Select Date:";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 90;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 90;
            // 
            // Program
            // 
            this.Program.HeaderText = "Programs";
            this.Program.MinimumWidth = 8;
            this.Program.Name = "Program";
            this.Program.Width = 150;
            // 
            // Number
            // 
            this.Number.HeaderText = "Total";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 150;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1187, 692);
            this.Controls.Add(this.WeeklyDateLbl);
            this.Controls.Add(this.WeeklyRptPicker);
            this.Controls.Add(this.WeeklyReportLbl);
            this.Controls.Add(this.WeeklyReportGrid);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.ProgramChart);
            this.Controls.Add(this.panelStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.DateTimePicker agePicker;
        private System.Windows.Forms.Label DOBLbl;
        private System.Windows.Forms.TextBox ContactNoTb;
        private System.Windows.Forms.Label ContactNoLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgramChart;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.DateTimePicker RegistrationDatePicker;
        private System.Windows.Forms.Label RegistrationLbl;
        private System.Windows.Forms.ComboBox ProgramCb;
        private System.Windows.Forms.Label EnrolledLbl;
        private System.Windows.Forms.ComboBox sortingCB;
        private System.Windows.Forms.DataGridView WeeklyReportGrid;
        private System.Windows.Forms.Label WeeklyReportLbl;
        private System.Windows.Forms.Label tabletitle;
        private System.Windows.Forms.DateTimePicker WeeklyRptPicker;
        private System.Windows.Forms.Label WeeklyDateLbl;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}

