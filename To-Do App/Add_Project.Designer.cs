namespace To_Do_App
{
    partial class Add_Project
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
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.btn_Delete_Project = new System.Windows.Forms.Button();
            this.btn_Save_Project = new System.Windows.Forms.Button();
            this.btn_Del_Event = new System.Windows.Forms.Button();
            this.btn_Add_Event = new System.Windows.Forms.Button();
            this.pnl_Events = new System.Windows.Forms.Panel();
            this.lsv_Events = new System.Windows.Forms.ListView();
            this.clh_Events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_Completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Description = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.pnl_Deadline = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.dtp_Day = new System.Windows.Forms.DateTimePicker();
            this.txt_Deadline = new System.Windows.Forms.TextBox();
            this.pnl_Completion = new System.Windows.Forms.Panel();
            this.chk_done = new System.Windows.Forms.CheckBox();
            this.dtp_Complete_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Completion = new System.Windows.Forms.TextBox();
            this.pnl_Title.SuspendLayout();
            this.pnl_Events.SuspendLayout();
            this.pnl_Description.SuspendLayout();
            this.pnl_Deadline.SuspendLayout();
            this.pnl_Completion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Title.Controls.Add(this.textBox2);
            this.pnl_Title.Controls.Add(this.txt_Title);
            this.pnl_Title.Location = new System.Drawing.Point(15, 45);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(400, 100);
            this.pnl_Title.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 33);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Title.Enabled = false;
            this.txt_Title.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(75, 5);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(250, 39);
            this.txt_Title.TabIndex = 0;
            this.txt_Title.Text = "Project";
            this.txt_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Delete_Project
            // 
            this.btn_Delete_Project.Location = new System.Drawing.Point(160, 595);
            this.btn_Delete_Project.Name = "btn_Delete_Project";
            this.btn_Delete_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Delete_Project.TabIndex = 23;
            this.btn_Delete_Project.Text = "Delete Project";
            this.btn_Delete_Project.UseVisualStyleBackColor = true;
            // 
            // btn_Save_Project
            // 
            this.btn_Save_Project.Location = new System.Drawing.Point(30, 595);
            this.btn_Save_Project.Name = "btn_Save_Project";
            this.btn_Save_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Save_Project.TabIndex = 22;
            this.btn_Save_Project.Text = "Save Project";
            this.btn_Save_Project.UseVisualStyleBackColor = true;
            this.btn_Save_Project.Click += new System.EventHandler(this.btn_Save_Project_Click);
            // 
            // btn_Del_Event
            // 
            this.btn_Del_Event.Location = new System.Drawing.Point(750, 595);
            this.btn_Del_Event.Name = "btn_Del_Event";
            this.btn_Del_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Del_Event.TabIndex = 21;
            this.btn_Del_Event.Text = "Delete Event";
            this.btn_Del_Event.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Event
            // 
            this.btn_Add_Event.Location = new System.Drawing.Point(620, 595);
            this.btn_Add_Event.Name = "btn_Add_Event";
            this.btn_Add_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Event.TabIndex = 19;
            this.btn_Add_Event.Text = "New Event";
            this.btn_Add_Event.UseVisualStyleBackColor = true;
            this.btn_Add_Event.Click += new System.EventHandler(this.btn_Add_Event_Click);
            // 
            // pnl_Events
            // 
            this.pnl_Events.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Events.Controls.Add(this.lsv_Events);
            this.pnl_Events.Location = new System.Drawing.Point(600, 295);
            this.pnl_Events.Name = "pnl_Events";
            this.pnl_Events.Size = new System.Drawing.Size(270, 285);
            this.pnl_Events.TabIndex = 20;
            // 
            // lsv_Events
            // 
            this.lsv_Events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_Events,
            this.clh_Completion});
            this.lsv_Events.Location = new System.Drawing.Point(20, 20);
            this.lsv_Events.Name = "lsv_Events";
            this.lsv_Events.Size = new System.Drawing.Size(230, 245);
            this.lsv_Events.TabIndex = 2;
            this.lsv_Events.UseCompatibleStateImageBehavior = false;
            this.lsv_Events.View = System.Windows.Forms.View.Details;
            // 
            // clh_Events
            // 
            this.clh_Events.Text = "Events";
            this.clh_Events.Width = 138;
            // 
            // clh_Completion
            // 
            this.clh_Completion.Text = "Completion";
            this.clh_Completion.Width = 66;
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
            this.pnl_Description.TabIndex = 16;
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
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(20, 55);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(510, 330);
            this.rtb_Description.TabIndex = 7;
            this.rtb_Description.Text = "";
            // 
            // pnl_Deadline
            // 
            this.pnl_Deadline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Deadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Deadline.Controls.Add(this.radioButton4);
            this.pnl_Deadline.Controls.Add(this.radioButton5);
            this.pnl_Deadline.Controls.Add(this.dtp_Day);
            this.pnl_Deadline.Controls.Add(this.txt_Deadline);
            this.pnl_Deadline.Location = new System.Drawing.Point(600, 175);
            this.pnl_Deadline.Name = "pnl_Deadline";
            this.pnl_Deadline.Size = new System.Drawing.Size(270, 100);
            this.pnl_Deadline.TabIndex = 18;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.Location = new System.Drawing.Point(224, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(25, 30);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "No";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton5.Location = new System.Drawing.Point(165, 14);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(29, 30);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Yes";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // dtp_Day
            // 
            this.dtp_Day.Enabled = false;
            this.dtp_Day.Location = new System.Drawing.Point(24, 62);
            this.dtp_Day.Name = "dtp_Day";
            this.dtp_Day.Size = new System.Drawing.Size(227, 20);
            this.dtp_Day.TabIndex = 10;
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
            // 
            // pnl_Completion
            // 
            this.pnl_Completion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Completion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Completion.Controls.Add(this.chk_done);
            this.pnl_Completion.Controls.Add(this.dtp_Complete_Date);
            this.pnl_Completion.Controls.Add(this.txt_Completion);
            this.pnl_Completion.Location = new System.Drawing.Point(470, 45);
            this.pnl_Completion.Name = "pnl_Completion";
            this.pnl_Completion.Size = new System.Drawing.Size(400, 100);
            this.pnl_Completion.TabIndex = 17;
            // 
            // chk_done
            // 
            this.chk_done.AutoSize = true;
            this.chk_done.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_done.Location = new System.Drawing.Point(69, 62);
            this.chk_done.Name = "chk_done";
            this.chk_done.Size = new System.Drawing.Size(52, 17);
            this.chk_done.TabIndex = 12;
            this.chk_done.Text = "Done";
            this.chk_done.UseVisualStyleBackColor = true;
            this.chk_done.CheckedChanged += new System.EventHandler(this.chk_done_CheckedChanged);
            // 
            // dtp_Complete_Date
            // 
            this.dtp_Complete_Date.Enabled = false;
            this.dtp_Complete_Date.Location = new System.Drawing.Point(155, 60);
            this.dtp_Complete_Date.Name = "dtp_Complete_Date";
            this.dtp_Complete_Date.Size = new System.Drawing.Size(227, 20);
            this.dtp_Complete_Date.TabIndex = 11;
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
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.btn_Del_Event);
            this.Controls.Add(this.btn_Add_Event);
            this.Controls.Add(this.pnl_Events);
            this.Controls.Add(this.pnl_Description);
            this.Controls.Add(this.pnl_Deadline);
            this.Controls.Add(this.pnl_Completion);
            this.Controls.Add(this.btn_Delete_Project);
            this.Controls.Add(this.btn_Save_Project);
            this.Name = "Add_Project";
            this.Text = "Edit Project";
            this.Load += new System.EventHandler(this.Add_Project_Load);
            this.Controls.SetChildIndex(this.btn_Save_Project, 0);
            this.Controls.SetChildIndex(this.btn_Delete_Project, 0);
            this.Controls.SetChildIndex(this.pnl_Completion, 0);
            this.Controls.SetChildIndex(this.pnl_Deadline, 0);
            this.Controls.SetChildIndex(this.pnl_Description, 0);
            this.Controls.SetChildIndex(this.pnl_Events, 0);
            this.Controls.SetChildIndex(this.btn_Add_Event, 0);
            this.Controls.SetChildIndex(this.btn_Del_Event, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.pnl_Events.ResumeLayout(false);
            this.pnl_Description.ResumeLayout(false);
            this.pnl_Description.PerformLayout();
            this.pnl_Deadline.ResumeLayout(false);
            this.pnl_Deadline.PerformLayout();
            this.pnl_Completion.ResumeLayout(false);
            this.pnl_Completion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Button btn_Delete_Project;
        private System.Windows.Forms.Button btn_Save_Project;
        private System.Windows.Forms.Button btn_Del_Event;
        private System.Windows.Forms.Button btn_Add_Event;
        private System.Windows.Forms.Panel pnl_Events;
        private System.Windows.Forms.Panel pnl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Panel pnl_Deadline;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.DateTimePicker dtp_Day;
        private System.Windows.Forms.TextBox txt_Deadline;
        private System.Windows.Forms.Panel pnl_Completion;
        private System.Windows.Forms.DateTimePicker dtp_Complete_Date;
        private System.Windows.Forms.TextBox txt_Completion;
        private System.Windows.Forms.ListView lsv_Events;
        private System.Windows.Forms.ColumnHeader clh_Events;
        private System.Windows.Forms.ColumnHeader clh_Completion;
        private System.Windows.Forms.CheckBox chk_done;
    }
}