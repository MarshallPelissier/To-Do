namespace To_Do_App
{
    partial class Events
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
            this.btn_Add_Event = new System.Windows.Forms.Button();
            this.btn_Del_Event = new System.Windows.Forms.Button();
            this.btn_Clear_Project = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.pnl_Description = new System.Windows.Forms.Panel();
            this.lsv_Events = new System.Windows.Forms.ListView();
            this.clh_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_Date_Completed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_Date_Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pnl_Description.SuspendLayout();
            this.mnu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add_Event
            // 
            this.btn_Add_Event.Location = new System.Drawing.Point(15, 595);
            this.btn_Add_Event.Name = "btn_Add_Event";
            this.btn_Add_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Event.TabIndex = 8;
            this.btn_Add_Event.Text = "New Event";
            this.btn_Add_Event.UseVisualStyleBackColor = true;
            this.btn_Add_Event.Click += new System.EventHandler(this.btn_Add_Event_Click);
            // 
            // btn_Del_Event
            // 
            this.btn_Del_Event.Location = new System.Drawing.Point(140, 595);
            this.btn_Del_Event.Name = "btn_Del_Event";
            this.btn_Del_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Del_Event.TabIndex = 12;
            this.btn_Del_Event.Text = "Delete Event";
            this.btn_Del_Event.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_Project
            // 
            this.btn_Clear_Project.Location = new System.Drawing.Point(750, 595);
            this.btn_Clear_Project.Name = "btn_Clear_Project";
            this.btn_Clear_Project.Size = new System.Drawing.Size(100, 50);
            this.btn_Clear_Project.TabIndex = 14;
            this.btn_Clear_Project.Text = "Clear Project";
            this.btn_Clear_Project.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "New Project";
            this.button3.UseVisualStyleBackColor = true;
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
            this.txt_Description.Text = "Events";
            // 
            // pnl_Description
            // 
            this.pnl_Description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Description.Controls.Add(this.lsv_Events);
            this.pnl_Description.Controls.Add(this.txt_Description);
            this.pnl_Description.Location = new System.Drawing.Point(15, 45);
            this.pnl_Description.Name = "pnl_Description";
            this.pnl_Description.Size = new System.Drawing.Size(850, 530);
            this.pnl_Description.TabIndex = 3;
            // 
            // lsv_Events
            // 
            this.lsv_Events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_Name,
            this.clh_completion,
            this.clh_Date_Completed,
            this.clh_Date_Created,
            this.clh_Project});
            this.lsv_Events.GridLines = true;
            this.lsv_Events.Location = new System.Drawing.Point(20, 55);
            this.lsv_Events.Name = "lsv_Events";
            this.lsv_Events.Size = new System.Drawing.Size(810, 455);
            this.lsv_Events.TabIndex = 9;
            this.lsv_Events.UseCompatibleStateImageBehavior = false;
            this.lsv_Events.View = System.Windows.Forms.View.Details;
            // 
            // clh_Name
            // 
            this.clh_Name.Text = "Name";
            // 
            // clh_completion
            // 
            this.clh_completion.Text = "Completion";
            this.clh_completion.Width = 85;
            // 
            // clh_Date_Completed
            // 
            this.clh_Date_Completed.Text = "Date Completed";
            this.clh_Date_Completed.Width = 112;
            // 
            // clh_Date_Created
            // 
            this.clh_Date_Created.Text = "Date Created";
            this.clh_Date_Created.Width = 97;
            // 
            // clh_Project
            // 
            this.clh_Project.Text = "Project";
            this.clh_Project.Width = 230;
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
            this.mnu_Main.TabIndex = 15;
            this.mnu_Main.Text = "mnuMain";
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
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newEventToolStripMenuItem.Text = "New Event";
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
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.mnu_Main);
            this.Controls.Add(this.btn_Clear_Project);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Del_Event);
            this.Controls.Add(this.btn_Add_Event);
            this.Controls.Add(this.pnl_Description);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.pnl_Description.ResumeLayout(false);
            this.pnl_Description.PerformLayout();
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Event;
        private System.Windows.Forms.Button btn_Del_Event;
        private System.Windows.Forms.Button btn_Clear_Project;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Panel pnl_Description;
        private System.Windows.Forms.ListView lsv_Events;
        private System.Windows.Forms.ColumnHeader clh_Name;
        private System.Windows.Forms.ColumnHeader clh_completion;
        private System.Windows.Forms.ColumnHeader clh_Date_Completed;
        private System.Windows.Forms.ColumnHeader clh_Date_Created;
        private System.Windows.Forms.ColumnHeader clh_Project;
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
    }
}