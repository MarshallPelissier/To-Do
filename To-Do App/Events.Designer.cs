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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtp_Day = new System.Windows.Forms.DateTimePicker();
            this.pnl_Completion = new System.Windows.Forms.Panel();
            this.rad_done = new System.Windows.Forms.RadioButton();
            this.rad_3_4ths = new System.Windows.Forms.RadioButton();
            this.rad_half = new System.Windows.Forms.RadioButton();
            this.rad_4th = new System.Windows.Forms.RadioButton();
            this.rad_zero = new System.Windows.Forms.RadioButton();
            this.txt_Completion = new System.Windows.Forms.TextBox();
            this.pnl_Deadline = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.txt_Deadline = new System.Windows.Forms.TextBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.pnl_Description = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.pnl_Projects = new System.Windows.Forms.Panel();
            this.txt_Projects = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Add_Event = new System.Windows.Forms.Button();
            this.btn_Del_Event = new System.Windows.Forms.Button();
            this.btn_Clear_Project = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_Title.SuspendLayout();
            this.pnl_Completion.SuspendLayout();
            this.pnl_Deadline.SuspendLayout();
            this.pnl_Description.SuspendLayout();
            this.pnl_Projects.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
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
            this.txt_Title.Text = "Title";
            this.txt_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Title.Controls.Add(this.textBox2);
            this.pnl_Title.Controls.Add(this.txt_Title);
            this.pnl_Title.Location = new System.Drawing.Point(15, 15);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(400, 100);
            this.pnl_Title.TabIndex = 2;
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
            // dtp_Day
            // 
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
            this.pnl_Completion.Controls.Add(this.dateTimePicker1);
            this.pnl_Completion.Controls.Add(this.rad_done);
            this.pnl_Completion.Controls.Add(this.rad_3_4ths);
            this.pnl_Completion.Controls.Add(this.rad_half);
            this.pnl_Completion.Controls.Add(this.rad_4th);
            this.pnl_Completion.Controls.Add(this.rad_zero);
            this.pnl_Completion.Controls.Add(this.txt_Completion);
            this.pnl_Completion.Location = new System.Drawing.Point(470, 15);
            this.pnl_Completion.Name = "pnl_Completion";
            this.pnl_Completion.Size = new System.Drawing.Size(400, 100);
            this.pnl_Completion.TabIndex = 3;
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
            this.pnl_Deadline.Controls.Add(this.radioButton4);
            this.pnl_Deadline.Controls.Add(this.radioButton5);
            this.pnl_Deadline.Controls.Add(this.dtp_Day);
            this.pnl_Deadline.Controls.Add(this.txt_Deadline);
            this.pnl_Deadline.Location = new System.Drawing.Point(600, 135);
            this.pnl_Deadline.Name = "pnl_Deadline";
            this.pnl_Deadline.Size = new System.Drawing.Size(270, 100);
            this.pnl_Deadline.TabIndex = 6;
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
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
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
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
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
            this.rtb_Description.Size = new System.Drawing.Size(510, 375);
            this.rtb_Description.TabIndex = 7;
            this.rtb_Description.Text = "";
            // 
            // pnl_Description
            // 
            this.pnl_Description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Description.Controls.Add(this.txt_Description);
            this.pnl_Description.Controls.Add(this.rtb_Description);
            this.pnl_Description.Location = new System.Drawing.Point(15, 135);
            this.pnl_Description.Name = "pnl_Description";
            this.pnl_Description.Size = new System.Drawing.Size(550, 445);
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
            this.pnl_Projects.Controls.Add(this.txt_Projects);
            this.pnl_Projects.Controls.Add(this.treeView1);
            this.pnl_Projects.Location = new System.Drawing.Point(600, 255);
            this.pnl_Projects.Name = "pnl_Projects";
            this.pnl_Projects.Size = new System.Drawing.Size(270, 325);
            this.pnl_Projects.TabIndex = 11;
            // 
            // txt_Projects
            // 
            this.txt_Projects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Projects.Enabled = false;
            this.txt_Projects.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Projects.Location = new System.Drawing.Point(20, 15);
            this.txt_Projects.Name = "txt_Projects";
            this.txt_Projects.Size = new System.Drawing.Size(200, 29);
            this.txt_Projects.TabIndex = 1;
            this.txt_Projects.Text = "Projects";
            this.txt_Projects.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(230, 255);
            this.treeView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btn_Add_Event
            // 
            this.btn_Add_Event.Location = new System.Drawing.Point(15, 595);
            this.btn_Add_Event.Name = "btn_Add_Event";
            this.btn_Add_Event.Size = new System.Drawing.Size(100, 50);
            this.btn_Add_Event.TabIndex = 8;
            this.btn_Add_Event.Text = "New Event";
            this.btn_Add_Event.UseVisualStyleBackColor = true;
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
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btn_Clear_Project);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Del_Event);
            this.Controls.Add(this.btn_Add_Event);
            this.Controls.Add(this.pnl_Projects);
            this.Controls.Add(this.pnl_Description);
            this.Controls.Add(this.pnl_Deadline);
            this.Controls.Add(this.pnl_Completion);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.textBox1);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtp_Day;
        private System.Windows.Forms.Panel pnl_Completion;
        private System.Windows.Forms.TextBox txt_Completion;
        private System.Windows.Forms.RadioButton rad_zero;
        private System.Windows.Forms.RadioButton rad_done;
        private System.Windows.Forms.RadioButton rad_3_4ths;
        private System.Windows.Forms.RadioButton rad_half;
        private System.Windows.Forms.RadioButton rad_4th;
        private System.Windows.Forms.Panel pnl_Deadline;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox txt_Deadline;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Panel pnl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Panel pnl_Projects;
        private System.Windows.Forms.TextBox txt_Projects;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Add_Event;
        private System.Windows.Forms.Button btn_Del_Event;
        private System.Windows.Forms.Button btn_Clear_Project;
        private System.Windows.Forms.Button button3;
    }
}