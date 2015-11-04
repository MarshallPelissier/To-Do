namespace To_Do_App
{
    partial class Form1
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
            this.mnc_Date = new System.Windows.Forms.MonthCalendar();
            this.trv_Daily_Events = new System.Windows.Forms.TreeView();
            this.lsv_Due_Dates = new System.Windows.Forms.ListView();
            this.clm_Events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Due_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Date = new System.Windows.Forms.Panel();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.btn_Add_Event = new System.Windows.Forms.Button();
            this.btn_Edit_Event = new System.Windows.Forms.Button();
            this.btn_Add_Project = new System.Windows.Forms.Button();
            this.btn_Edit_Project = new System.Windows.Forms.Button();
            this.pnl_Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnc_Date
            // 
            this.mnc_Date.Location = new System.Drawing.Point(640, 45);
            this.mnc_Date.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.mnc_Date.MaxSelectionCount = 1;
            this.mnc_Date.Name = "mnc_Date";
            this.mnc_Date.TabIndex = 3;
            this.mnc_Date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // trv_Daily_Events
            // 
            this.trv_Daily_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv_Daily_Events.Location = new System.Drawing.Point(15, 145);
            this.trv_Daily_Events.Name = "trv_Daily_Events";
            this.trv_Daily_Events.Size = new System.Drawing.Size(585, 435);
            this.trv_Daily_Events.TabIndex = 2;
            // 
            // lsv_Due_Dates
            // 
            this.lsv_Due_Dates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_Events,
            this.clm_Due_Date});
            this.lsv_Due_Dates.GridLines = true;
            this.lsv_Due_Dates.Location = new System.Drawing.Point(640, 220);
            this.lsv_Due_Dates.Name = "lsv_Due_Dates";
            this.lsv_Due_Dates.Size = new System.Drawing.Size(227, 425);
            this.lsv_Due_Dates.TabIndex = 4;
            this.lsv_Due_Dates.UseCompatibleStateImageBehavior = false;
            this.lsv_Due_Dates.View = System.Windows.Forms.View.Details;
            // 
            // clm_Events
            // 
            this.clm_Events.Text = "Events";
            this.clm_Events.Width = 94;
            // 
            // clm_Due_Date
            // 
            this.clm_Due_Date.Text = "Due Date";
            this.clm_Due_Date.Width = 125;
            // 
            // pnl_Date
            // 
            this.pnl_Date.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Date.Controls.Add(this.txt_Date);
            this.pnl_Date.Location = new System.Drawing.Point(50, 45);
            this.pnl_Date.Name = "pnl_Date";
            this.pnl_Date.Size = new System.Drawing.Size(500, 80);
            this.pnl_Date.TabIndex = 1;
            // 
            // txt_Date
            // 
            this.txt_Date.Enabled = false;
            this.txt_Date.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Location = new System.Drawing.Point(125, 17);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(250, 46);
            this.txt_Date.TabIndex = 0;
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Add_Event
            // 
            this.btn_Add_Event.Location = new System.Drawing.Point(30, 595);
            this.btn_Add_Event.Name = "btn_Add_Event";
            this.btn_Add_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Event.TabIndex = 5;
            this.btn_Add_Event.Text = "New Event";
            this.btn_Add_Event.UseVisualStyleBackColor = true;
            this.btn_Add_Event.Click += new System.EventHandler(this.btn_Add_Event_Click);
            // 
            // btn_Edit_Event
            // 
            this.btn_Edit_Event.Location = new System.Drawing.Point(160, 595);
            this.btn_Edit_Event.Name = "btn_Edit_Event";
            this.btn_Edit_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Edit_Event.TabIndex = 7;
            this.btn_Edit_Event.Text = "Edit Event";
            this.btn_Edit_Event.UseVisualStyleBackColor = true;
            this.btn_Edit_Event.Click += new System.EventHandler(this.btn_Edit_Event_Click);
            // 
            // btn_Add_Project
            // 
            this.btn_Add_Project.Location = new System.Drawing.Point(370, 595);
            this.btn_Add_Project.Name = "btn_Add_Project";
            this.btn_Add_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Project.TabIndex = 6;
            this.btn_Add_Project.Text = "New Project";
            this.btn_Add_Project.UseVisualStyleBackColor = true;
            this.btn_Add_Project.Click += new System.EventHandler(this.btn_Add_Project_Click);
            // 
            // btn_Edit_Project
            // 
            this.btn_Edit_Project.Location = new System.Drawing.Point(500, 595);
            this.btn_Edit_Project.Name = "btn_Edit_Project";
            this.btn_Edit_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Edit_Project.TabIndex = 8;
            this.btn_Edit_Project.Text = "Edit Project";
            this.btn_Edit_Project.UseVisualStyleBackColor = true;
            this.btn_Edit_Project.Click += new System.EventHandler(this.btn_Edit_Project_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btn_Edit_Project);
            this.Controls.Add(this.btn_Edit_Event);
            this.Controls.Add(this.btn_Add_Event);
            this.Controls.Add(this.pnl_Date);
            this.Controls.Add(this.lsv_Due_Dates);
            this.Controls.Add(this.trv_Daily_Events);
            this.Controls.Add(this.mnc_Date);
            this.Controls.Add(this.btn_Add_Project);
            this.Name = "Form1";
            this.Text = "TO DO";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.btn_Add_Project, 0);
            this.Controls.SetChildIndex(this.mnc_Date, 0);
            this.Controls.SetChildIndex(this.trv_Daily_Events, 0);
            this.Controls.SetChildIndex(this.lsv_Due_Dates, 0);
            this.Controls.SetChildIndex(this.pnl_Date, 0);
            this.Controls.SetChildIndex(this.btn_Add_Event, 0);
            this.Controls.SetChildIndex(this.btn_Edit_Event, 0);
            this.Controls.SetChildIndex(this.btn_Edit_Project, 0);
            this.pnl_Date.ResumeLayout(false);
            this.pnl_Date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mnc_Date;
        private System.Windows.Forms.TreeView trv_Daily_Events;
        private System.Windows.Forms.ListView lsv_Due_Dates;
        private System.Windows.Forms.ColumnHeader clm_Events;
        private System.Windows.Forms.ColumnHeader clm_Due_Date;
        private System.Windows.Forms.Panel pnl_Date;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Button btn_Add_Event;
        private System.Windows.Forms.Button btn_Edit_Event;
        private System.Windows.Forms.Button btn_Add_Project;
        private System.Windows.Forms.Button btn_Edit_Project;
    }
}

