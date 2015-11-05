namespace To_Do_App
{
    partial class Add_Event
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
            this.txt_Event = new System.Windows.Forms.TextBox();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.dtp_Day = new System.Windows.Forms.DateTimePicker();
            this.pnl_Completion = new System.Windows.Forms.Panel();
            this.dtp_Complete_Date = new System.Windows.Forms.DateTimePicker();
            this.rad_done = new System.Windows.Forms.RadioButton();
            this.rad_3_4ths = new System.Windows.Forms.RadioButton();
            this.rad_half = new System.Windows.Forms.RadioButton();
            this.rad_4th = new System.Windows.Forms.RadioButton();
            this.rad_zero = new System.Windows.Forms.RadioButton();
            this.txt_Completion = new System.Windows.Forms.TextBox();
            this.pnl_Deadline = new System.Windows.Forms.Panel();
            this.chk_Deadline = new System.Windows.Forms.CheckBox();
            this.txt_Deadline = new System.Windows.Forms.TextBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.pnl_Description = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.pnl_Projects = new System.Windows.Forms.Panel();
            this.chk_Project = new System.Windows.Forms.CheckBox();
            this.txt_Project = new System.Windows.Forms.TextBox();
            this.lsv_Projects = new System.Windows.Forms.ListView();
            this.clh_Projects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_Completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Save_Event = new System.Windows.Forms.Button();
            this.btn_Del_Event = new System.Windows.Forms.Button();
            this.btn_Del_Project = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_Title.SuspendLayout();
            this.pnl_Completion.SuspendLayout();
            this.pnl_Deadline.SuspendLayout();
            this.pnl_Description.SuspendLayout();
            this.pnl_Projects.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Event
            // 
            this.txt_Event.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Event.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Event.Enabled = false;
            this.txt_Event.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Event.Location = new System.Drawing.Point(75, 5);
            this.txt_Event.Name = "txt_Event";
            this.txt_Event.Size = new System.Drawing.Size(250, 39);
            this.txt_Event.TabIndex = 0;
            this.txt_Event.Text = "Event";
            this.txt_Event.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Title.Controls.Add(this.txt_Title);
            this.pnl_Title.Controls.Add(this.txt_Event);
            this.pnl_Title.Location = new System.Drawing.Point(15, 45);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(400, 100);
            this.pnl_Title.TabIndex = 2;
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(50, 50);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(300, 33);
            this.txt_Title.TabIndex = 1;
            this.txt_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_Day
            // 
            this.dtp_Day.Enabled = false;
            this.dtp_Day.Location = new System.Drawing.Point(24, 62);
            this.dtp_Day.Name = "dtp_Day";
            this.dtp_Day.Size = new System.Drawing.Size(227, 20);
            this.dtp_Day.TabIndex = 10;
            this.dtp_Day.ValueChanged += new System.EventHandler(this.dtp_Day_ValueChanged);
            // 
            // pnl_Completion
            // 
            this.pnl_Completion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Completion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Completion.Controls.Add(this.dtp_Complete_Date);
            this.pnl_Completion.Controls.Add(this.rad_done);
            this.pnl_Completion.Controls.Add(this.rad_3_4ths);
            this.pnl_Completion.Controls.Add(this.rad_half);
            this.pnl_Completion.Controls.Add(this.rad_4th);
            this.pnl_Completion.Controls.Add(this.rad_zero);
            this.pnl_Completion.Controls.Add(this.txt_Completion);
            this.pnl_Completion.Location = new System.Drawing.Point(470, 45);
            this.pnl_Completion.Name = "pnl_Completion";
            this.pnl_Completion.Size = new System.Drawing.Size(400, 100);
            this.pnl_Completion.TabIndex = 3;
            // 
            // dtp_Complete_Date
            // 
            this.dtp_Complete_Date.Enabled = false;
            this.dtp_Complete_Date.Location = new System.Drawing.Point(155, 60);
            this.dtp_Complete_Date.Name = "dtp_Complete_Date";
            this.dtp_Complete_Date.Size = new System.Drawing.Size(227, 20);
            this.dtp_Complete_Date.TabIndex = 11;
            // 
            // rad_done
            // 
            this.rad_done.AutoSize = true;
            this.rad_done.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rad_done.Location = new System.Drawing.Point(352, 20);
            this.rad_done.Name = "rad_done";
            this.rad_done.Size = new System.Drawing.Size(37, 30);
            this.rad_done.TabIndex = 5;
            this.rad_done.TabStop = true;
            this.rad_done.Text = "100%";
            this.rad_done.UseVisualStyleBackColor = true;
            this.rad_done.CheckedChanged += new System.EventHandler(this.rad_done_CheckedChanged);
            // 
            // rad_3_4ths
            // 
            this.rad_3_4ths.AutoSize = true;
            this.rad_3_4ths.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rad_3_4ths.Location = new System.Drawing.Point(314, 20);
            this.rad_3_4ths.Name = "rad_3_4ths";
            this.rad_3_4ths.Size = new System.Drawing.Size(31, 30);
            this.rad_3_4ths.TabIndex = 4;
            this.rad_3_4ths.TabStop = true;
            this.rad_3_4ths.Text = "75%";
            this.rad_3_4ths.UseVisualStyleBackColor = true;
            this.rad_3_4ths.CheckedChanged += new System.EventHandler(this.rad_3_4ths_CheckedChanged);
            // 
            // rad_half
            // 
            this.rad_half.AutoSize = true;
            this.rad_half.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rad_half.Location = new System.Drawing.Point(274, 20);
            this.rad_half.Name = "rad_half";
            this.rad_half.Size = new System.Drawing.Size(31, 30);
            this.rad_half.TabIndex = 3;
            this.rad_half.TabStop = true;
            this.rad_half.Text = "50%";
            this.rad_half.UseVisualStyleBackColor = true;
            this.rad_half.CheckedChanged += new System.EventHandler(this.rad_half_CheckedChanged);
            // 
            // rad_4th
            // 
            this.rad_4th.AutoSize = true;
            this.rad_4th.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rad_4th.Location = new System.Drawing.Point(234, 20);
            this.rad_4th.Name = "rad_4th";
            this.rad_4th.Size = new System.Drawing.Size(31, 30);
            this.rad_4th.TabIndex = 2;
            this.rad_4th.TabStop = true;
            this.rad_4th.Text = "25%";
            this.rad_4th.UseVisualStyleBackColor = true;
            this.rad_4th.CheckedChanged += new System.EventHandler(this.rad_4th_CheckedChanged);
            // 
            // rad_zero
            // 
            this.rad_zero.AutoSize = true;
            this.rad_zero.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rad_zero.Location = new System.Drawing.Point(196, 20);
            this.rad_zero.Name = "rad_zero";
            this.rad_zero.Size = new System.Drawing.Size(25, 30);
            this.rad_zero.TabIndex = 1;
            this.rad_zero.TabStop = true;
            this.rad_zero.Text = "0%";
            this.rad_zero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rad_zero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rad_zero.UseVisualStyleBackColor = true;
            this.rad_zero.CheckedChanged += new System.EventHandler(this.rad_zero_CheckedChanged);
            // 
            // txt_Completion
            // 
            this.txt_Completion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Completion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Completion.Enabled = false;
            this.txt_Completion.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Completion.Location = new System.Drawing.Point(25, 20);
            this.txt_Completion.Name = "txt_Completion";
            this.txt_Completion.Size = new System.Drawing.Size(150, 29);
            this.txt_Completion.TabIndex = 0;
            this.txt_Completion.Text = "Completion";
            this.txt_Completion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Deadline
            // 
            this.pnl_Deadline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Deadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Deadline.Controls.Add(this.chk_Deadline);
            this.pnl_Deadline.Controls.Add(this.dtp_Day);
            this.pnl_Deadline.Controls.Add(this.txt_Deadline);
            this.pnl_Deadline.Location = new System.Drawing.Point(600, 175);
            this.pnl_Deadline.Name = "pnl_Deadline";
            this.pnl_Deadline.Size = new System.Drawing.Size(270, 100);
            this.pnl_Deadline.TabIndex = 6;
            // 
            // chk_Deadline
            // 
            this.chk_Deadline.Location = new System.Drawing.Point(144, 25);
            this.chk_Deadline.Name = "chk_Deadline";
            this.chk_Deadline.Size = new System.Drawing.Size(80, 17);
            this.chk_Deadline.TabIndex = 0;
            this.chk_Deadline.UseVisualStyleBackColor = true;
            this.chk_Deadline.CheckedChanged += new System.EventHandler(this.chk_Deadline_CheckedChanged);
            // 
            // txt_Deadline
            // 
            this.txt_Deadline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Deadline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Deadline.Enabled = false;
            this.txt_Deadline.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Deadline.Location = new System.Drawing.Point(3, 15);
            this.txt_Deadline.Name = "txt_Deadline";
            this.txt_Deadline.Size = new System.Drawing.Size(150, 29);
            this.txt_Deadline.TabIndex = 0;
            this.txt_Deadline.Text = "Deadline";
            this.txt_Deadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Deadline.TextChanged += new System.EventHandler(this.txt_Deadline_TextChanged);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(20, 55);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(510, 330);
            this.rtb_Description.TabIndex = 7;
            this.rtb_Description.Text = "";
            // 
            // pnl_Description
            // 
            this.pnl_Description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Description.Controls.Add(this.txt_Description);
            this.pnl_Description.Controls.Add(this.rtb_Description);
            this.pnl_Description.Location = new System.Drawing.Point(15, 175);
            this.pnl_Description.Name = "pnl_Description";
            this.pnl_Description.Size = new System.Drawing.Size(550, 405);
            this.pnl_Description.TabIndex = 3;
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Description.Enabled = false;
            this.txt_Description.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(20, 15);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(250, 29);
            this.txt_Description.TabIndex = 0;
            this.txt_Description.Text = "Description";
            // 
            // pnl_Projects
            // 
            this.pnl_Projects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Projects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Projects.Controls.Add(this.chk_Project);
            this.pnl_Projects.Controls.Add(this.txt_Project);
            this.pnl_Projects.Controls.Add(this.lsv_Projects);
            this.pnl_Projects.Location = new System.Drawing.Point(600, 295);
            this.pnl_Projects.Name = "pnl_Projects";
            this.pnl_Projects.Size = new System.Drawing.Size(270, 285);
            this.pnl_Projects.TabIndex = 11;
            // 
            // chk_Project
            // 
            this.chk_Project.Location = new System.Drawing.Point(234, 17);
            this.chk_Project.Name = "chk_Project";
            this.chk_Project.Size = new System.Drawing.Size(80, 17);
            this.chk_Project.TabIndex = 11;
            this.chk_Project.UseVisualStyleBackColor = true;
            // 
            // txt_Project
            // 
            this.txt_Project.Enabled = false;
            this.txt_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Project.Location = new System.Drawing.Point(20, 15);
            this.txt_Project.Name = "txt_Project";
            this.txt_Project.Size = new System.Drawing.Size(208, 20);
            this.txt_Project.TabIndex = 2;
            this.txt_Project.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsv_Projects
            // 
            this.lsv_Projects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_Projects,
            this.clh_Completion});
            this.lsv_Projects.Location = new System.Drawing.Point(20, 42);
            this.lsv_Projects.MultiSelect = false;
            this.lsv_Projects.Name = "lsv_Projects";
            this.lsv_Projects.Size = new System.Drawing.Size(230, 223);
            this.lsv_Projects.TabIndex = 3;
            this.lsv_Projects.UseCompatibleStateImageBehavior = false;
            this.lsv_Projects.View = System.Windows.Forms.View.Details;
            this.lsv_Projects.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsv_Projects_ItemSelectionChanged);
            // 
            // clh_Projects
            // 
            this.clh_Projects.Text = "Projects";
            this.clh_Projects.Width = 138;
            // 
            // clh_Completion
            // 
            this.clh_Completion.Text = "Completion";
            this.clh_Completion.Width = 66;
            // 
            // btn_Save_Event
            // 
            this.btn_Save_Event.Location = new System.Drawing.Point(30, 595);
            this.btn_Save_Event.Name = "btn_Save_Event";
            this.btn_Save_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Save_Event.TabIndex = 8;
            this.btn_Save_Event.Text = "Save Event";
            this.btn_Save_Event.UseVisualStyleBackColor = true;
            this.btn_Save_Event.Click += new System.EventHandler(this.btn_Save_Event_Click);
            // 
            // btn_Del_Event
            // 
            this.btn_Del_Event.Location = new System.Drawing.Point(160, 595);
            this.btn_Del_Event.Name = "btn_Del_Event";
            this.btn_Del_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Del_Event.TabIndex = 12;
            this.btn_Del_Event.Text = "Delete Event";
            this.btn_Del_Event.UseVisualStyleBackColor = true;
            this.btn_Del_Event.Click += new System.EventHandler(this.btn_Del_Event_Click);
            // 
            // btn_Del_Project
            // 
            this.btn_Del_Project.Location = new System.Drawing.Point(750, 595);
            this.btn_Del_Project.Name = "btn_Del_Project";
            this.btn_Del_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Del_Project.TabIndex = 14;
            this.btn_Del_Project.Text = "Delete Project";
            this.btn_Del_Project.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "New Project";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btn_Del_Project);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Del_Event);
            this.Controls.Add(this.btn_Save_Event);
            this.Controls.Add(this.pnl_Projects);
            this.Controls.Add(this.pnl_Description);
            this.Controls.Add(this.pnl_Deadline);
            this.Controls.Add(this.pnl_Completion);
            this.Controls.Add(this.pnl_Title);
            this.Name = "Add_Event";
            this.Text = "Edit Event";
            this.Load += new System.EventHandler(this.Events_Load);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.Controls.SetChildIndex(this.pnl_Completion, 0);
            this.Controls.SetChildIndex(this.pnl_Deadline, 0);
            this.Controls.SetChildIndex(this.pnl_Description, 0);
            this.Controls.SetChildIndex(this.pnl_Projects, 0);
            this.Controls.SetChildIndex(this.btn_Save_Event, 0);
            this.Controls.SetChildIndex(this.btn_Del_Event, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.btn_Del_Project, 0);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.pnl_Completion.ResumeLayout(false);
            this.pnl_Completion.PerformLayout();
            this.pnl_Deadline.ResumeLayout(false);
            this.pnl_Deadline.PerformLayout();
            this.pnl_Description.ResumeLayout(false);
            this.pnl_Description.PerformLayout();
            this.pnl_Projects.ResumeLayout(false);
            this.pnl_Projects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Event;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.DateTimePicker dtp_Day;
        private System.Windows.Forms.Panel pnl_Completion;
        private System.Windows.Forms.TextBox txt_Completion;
        private System.Windows.Forms.RadioButton rad_zero;
        private System.Windows.Forms.RadioButton rad_done;
        private System.Windows.Forms.RadioButton rad_3_4ths;
        private System.Windows.Forms.RadioButton rad_half;
        private System.Windows.Forms.RadioButton rad_4th;
        private System.Windows.Forms.Panel pnl_Deadline;
        private System.Windows.Forms.TextBox txt_Deadline;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Panel pnl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Panel pnl_Projects;
        private System.Windows.Forms.DateTimePicker dtp_Complete_Date;
        private System.Windows.Forms.Button btn_Save_Event;
        private System.Windows.Forms.Button btn_Del_Event;
        private System.Windows.Forms.Button btn_Del_Project;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lsv_Projects;
        private System.Windows.Forms.ColumnHeader clh_Projects;
        private System.Windows.Forms.ColumnHeader clh_Completion;
        private System.Windows.Forms.CheckBox chk_Deadline;
        private System.Windows.Forms.CheckBox chk_Project;
        private System.Windows.Forms.TextBox txt_Project;
    }
}