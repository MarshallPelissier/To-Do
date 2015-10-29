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
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Del_Event = new System.Windows.Forms.Button();
            this.btn_Add_Project = new System.Windows.Forms.Button();
            this.btn_Del_Project = new System.Windows.Forms.Button();
            this.pnl_Date.SuspendLayout();
            this.mnu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnc_Date
            // 
            this.mnc_Date.Location = new System.Drawing.Point(639, 45);
            this.mnc_Date.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.mnc_Date.MaxSelectionCount = 1;
            this.mnc_Date.Name = "mnc_Date";
            this.mnc_Date.TabIndex = 3;
            this.mnc_Date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // trv_Daily_Events
            // 
            this.trv_Daily_Events.Location = new System.Drawing.Point(15, 145);
            this.trv_Daily_Events.Name = "trv_Daily_Events";
            this.trv_Daily_Events.Size = new System.Drawing.Size(585, 440);
            this.trv_Daily_Events.TabIndex = 2;
            // 
            // lsv_Due_Dates
            // 
            this.lsv_Due_Dates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_Events,
            this.clm_Due_Date});
            this.lsv_Due_Dates.GridLines = true;
            this.lsv_Due_Dates.Location = new System.Drawing.Point(639, 219);
            this.lsv_Due_Dates.Name = "lsv_Due_Dates";
            this.lsv_Due_Dates.Size = new System.Drawing.Size(227, 431);
            this.lsv_Due_Dates.TabIndex = 4;
            this.lsv_Due_Dates.UseCompatibleStateImageBehavior = false;
            this.lsv_Due_Dates.View = System.Windows.Forms.View.Details;
            // 
            // clm_Events
            // 
            this.clm_Events.Text = "Events";
            this.clm_Events.Width = 90;
            // 
            // clm_Due_Date
            // 
            this.clm_Due_Date.Text = "Due Date";
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
            this.btn_Add_Event.Location = new System.Drawing.Point(15, 600);
            this.btn_Add_Event.Name = "btn_Add_Event";
            this.btn_Add_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Event.TabIndex = 5;
            this.btn_Add_Event.Text = "New Event";
            this.btn_Add_Event.UseVisualStyleBackColor = true;
            this.btn_Add_Event.Click += new System.EventHandler(this.btn_Add_Event_Click);
            // 
            // mnu_Main
            // 
            this.mnu_Main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.projectsToolStripMenuItem});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Size = new System.Drawing.Size(884, 24);
            this.mnu_Main.TabIndex = 0;
            this.mnu_Main.Text = "mnuMain";
            this.mnu_Main.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEventToolStripMenuItem,
            this.eventListToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newEventToolStripMenuItem.Text = "New Event";
            this.newEventToolStripMenuItem.Click += new System.EventHandler(this.newEventToolStripMenuItem_Click_1);
            // 
            // eventListToolStripMenuItem
            // 
            this.eventListToolStripMenuItem.Name = "eventListToolStripMenuItem";
            this.eventListToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.eventListToolStripMenuItem.Text = "Event List";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.projectListToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // projectListToolStripMenuItem
            // 
            this.projectListToolStripMenuItem.Name = "projectListToolStripMenuItem";
            this.projectListToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.projectListToolStripMenuItem.Text = "Project List";
            // 
            // btn_Del_Event
            // 
            this.btn_Del_Event.Location = new System.Drawing.Point(385, 600);
            this.btn_Del_Event.Name = "btn_Del_Event";
            this.btn_Del_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Del_Event.TabIndex = 7;
            this.btn_Del_Event.Text = "Delete Event";
            this.btn_Del_Event.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Project
            // 
            this.btn_Add_Project.Location = new System.Drawing.Point(130, 600);
            this.btn_Add_Project.Name = "btn_Add_Project";
            this.btn_Add_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Project.TabIndex = 6;
            this.btn_Add_Project.Text = "New Project";
            this.btn_Add_Project.UseVisualStyleBackColor = true;
            // 
            // btn_Del_Project
            // 
            this.btn_Del_Project.Location = new System.Drawing.Point(500, 600);
            this.btn_Del_Project.Name = "btn_Del_Project";
            this.btn_Del_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Del_Project.TabIndex = 8;
            this.btn_Del_Project.Text = "Delete Project";
            this.btn_Del_Project.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btn_Del_Project);
            this.Controls.Add(this.btn_Add_Project);
            this.Controls.Add(this.btn_Del_Event);
            this.Controls.Add(this.btn_Add_Event);
            this.Controls.Add(this.pnl_Date);
            this.Controls.Add(this.lsv_Due_Dates);
            this.Controls.Add(this.trv_Daily_Events);
            this.Controls.Add(this.mnc_Date);
            this.Controls.Add(this.mnu_Main);
            this.MainMenuStrip = this.mnu_Main;
            this.Name = "Form1";
            this.Text = "TO DO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Date.ResumeLayout(false);
            this.pnl_Date.PerformLayout();
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
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
        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectListToolStripMenuItem;
        private System.Windows.Forms.Button btn_Del_Event;
        private System.Windows.Forms.Button btn_Add_Project;
        private System.Windows.Forms.Button btn_Del_Project;
    }
}

