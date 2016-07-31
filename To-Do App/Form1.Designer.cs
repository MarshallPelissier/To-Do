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
            this.components = new System.ComponentModel.Container();
            this.mnc_Date = new System.Windows.Forms.MonthCalendar();
            this.trv_Daily_Events = new System.Windows.Forms.TreeView();
            this.lsv_Due_Dates = new System.Windows.Forms.ListView();
            this.clm_Events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Due_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Date = new System.Windows.Forms.Panel();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.btn_Add_Event = new System.Windows.Forms.Button();
            this.btn_Edit_Event = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Delete_Event = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.txt_selected = new System.Windows.Forms.TextBox();
            this.pnl_Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.trv_Daily_Events.TabStop = false;
            this.trv_Daily_Events.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trv_Daily_Events_BeforeSelect);
            this.trv_Daily_Events.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_Daily_Events_AfterSelect);
            this.trv_Daily_Events.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trv_Daily_Events_NodeMouseClick);
            this.trv_Daily_Events.DoubleClick += new System.EventHandler(this.trv_Daily_Events_DoubleClick);
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
            this.lsv_Due_Dates.SelectedIndexChanged += new System.EventHandler(this.lsv_Due_Dates_SelectedIndexChanged);
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
            // btn_Delete_Event
            // 
            this.btn_Delete_Event.Location = new System.Drawing.Point(290, 595);
            this.btn_Delete_Event.Name = "btn_Delete_Event";
            this.btn_Delete_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Delete_Event.TabIndex = 8;
            this.btn_Delete_Event.Text = "Delete Event";
            this.btn_Delete_Event.UseVisualStyleBackColor = true;
            this.btn_Delete_Event.Click += new System.EventHandler(this.btn_Delete_Event_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Up.Location = new System.Drawing.Point(420, 595);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Up.Size = new System.Drawing.Size(68, 50);
            this.btn_Up.TabIndex = 9;
            this.btn_Up.Text = "Move Up";
            this.btn_Up.UseVisualStyleBackColor = false;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Down.Location = new System.Drawing.Point(520, 595);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(65, 50);
            this.btn_Down.TabIndex = 10;
            this.btn_Down.Text = "Move Down";
            this.btn_Down.UseVisualStyleBackColor = false;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // txt_selected
            // 
            this.txt_selected.Enabled = false;
            this.txt_selected.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selected.Location = new System.Drawing.Point(350, 145);
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.Size = new System.Drawing.Size(250, 46);
            this.txt_selected.TabIndex = 1;
            this.txt_selected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txt_selected);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_Delete_Event);
            this.Controls.Add(this.btn_Edit_Event);
            this.Controls.Add(this.btn_Add_Event);
            this.Controls.Add(this.pnl_Date);
            this.Controls.Add(this.lsv_Due_Dates);
            this.Controls.Add(this.trv_Daily_Events);
            this.Controls.Add(this.mnc_Date);
            this.Name = "Form1";
            this.Text = "TO DO";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.mnc_Date, 0);
            this.Controls.SetChildIndex(this.trv_Daily_Events, 0);
            this.Controls.SetChildIndex(this.lsv_Due_Dates, 0);
            this.Controls.SetChildIndex(this.pnl_Date, 0);
            this.Controls.SetChildIndex(this.btn_Add_Event, 0);
            this.Controls.SetChildIndex(this.btn_Edit_Event, 0);
            this.Controls.SetChildIndex(this.btn_Delete_Event, 0);
            this.Controls.SetChildIndex(this.btn_Up, 0);
            this.Controls.SetChildIndex(this.btn_Down, 0);
            this.Controls.SetChildIndex(this.txt_selected, 0);
            this.pnl_Date.ResumeLayout(false);
            this.pnl_Date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_Delete_Event;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.TextBox txt_selected;
    }
}

