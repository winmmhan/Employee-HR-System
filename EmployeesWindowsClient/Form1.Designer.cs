namespace EmployeesWindowsClient
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addemployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyPaidEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyPaidEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyPaidEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempHourlyPaidEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addpostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeemployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removepostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPostHistoryEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalWeeklyPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDisplay = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ssEmployee = new System.Windows.Forms.StatusStrip();
            this.sslDisplayInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ssEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addtoolStripMenuItem,
            this.removetoolStripMenuItem,
            this.displayToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addtoolStripMenuItem
            // 
            this.addtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addemployeeToolStripMenuItem,
            this.addpostToolStripMenuItem});
            this.addtoolStripMenuItem.Name = "addtoolStripMenuItem";
            this.addtoolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.addtoolStripMenuItem.Text = "Add";
            // 
            // addemployeeToolStripMenuItem
            // 
            this.addemployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyPaidEmployeeToolStripMenuItem,
            this.weeklyPaidEmployeeToolStripMenuItem,
            this.hourlyPaidEmployeeToolStripMenuItem,
            this.tempHourlyPaidEmployeeToolStripMenuItem});
            this.addemployeeToolStripMenuItem.Name = "addemployeeToolStripMenuItem";
            this.addemployeeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addemployeeToolStripMenuItem.Text = "Employee";
            // 
            // monthlyPaidEmployeeToolStripMenuItem
            // 
            this.monthlyPaidEmployeeToolStripMenuItem.Name = "monthlyPaidEmployeeToolStripMenuItem";
            this.monthlyPaidEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.monthlyPaidEmployeeToolStripMenuItem.Text = "Monthly Paid";
            this.monthlyPaidEmployeeToolStripMenuItem.Click += new System.EventHandler(this.monthlyPaidEmployeeToolStripMenuItem_Click);
            // 
            // weeklyPaidEmployeeToolStripMenuItem
            // 
            this.weeklyPaidEmployeeToolStripMenuItem.Name = "weeklyPaidEmployeeToolStripMenuItem";
            this.weeklyPaidEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.weeklyPaidEmployeeToolStripMenuItem.Text = "Weekly Paid";
            this.weeklyPaidEmployeeToolStripMenuItem.Click += new System.EventHandler(this.weeklyPaidEmployeeToolStripMenuItem_Click);
            // 
            // hourlyPaidEmployeeToolStripMenuItem
            // 
            this.hourlyPaidEmployeeToolStripMenuItem.Name = "hourlyPaidEmployeeToolStripMenuItem";
            this.hourlyPaidEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.hourlyPaidEmployeeToolStripMenuItem.Text = "Hourly Paid";
            this.hourlyPaidEmployeeToolStripMenuItem.Click += new System.EventHandler(this.hourlyPaidEmployeeToolStripMenuItem_Click);
            // 
            // tempHourlyPaidEmployeeToolStripMenuItem
            // 
            this.tempHourlyPaidEmployeeToolStripMenuItem.Name = "tempHourlyPaidEmployeeToolStripMenuItem";
            this.tempHourlyPaidEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.tempHourlyPaidEmployeeToolStripMenuItem.Text = "Temporary Hourly Paid ";
            this.tempHourlyPaidEmployeeToolStripMenuItem.Click += new System.EventHandler(this.tempHourlyPaidEmployeeToolStripMenuItem_Click);
            // 
            // addpostToolStripMenuItem
            // 
            this.addpostToolStripMenuItem.Name = "addpostToolStripMenuItem";
            this.addpostToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addpostToolStripMenuItem.Text = "Post";
            this.addpostToolStripMenuItem.Click += new System.EventHandler(this.addpostToolStripMenuItem_Click);
            // 
            // removetoolStripMenuItem
            // 
            this.removetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeemployeeToolStripMenuItem,
            this.removepostToolStripMenuItem});
            this.removetoolStripMenuItem.Name = "removetoolStripMenuItem";
            this.removetoolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.removetoolStripMenuItem.Text = "Remove";
            // 
            // removeemployeeToolStripMenuItem
            // 
            this.removeemployeeToolStripMenuItem.Name = "removeemployeeToolStripMenuItem";
            this.removeemployeeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.removeemployeeToolStripMenuItem.Text = "Employee";
            this.removeemployeeToolStripMenuItem.Click += new System.EventHandler(this.removeemployeeToolStripMenuItem_Click);
            // 
            // removepostToolStripMenuItem
            // 
            this.removepostToolStripMenuItem.Name = "removepostToolStripMenuItem";
            this.removepostToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.removepostToolStripMenuItem.Text = "Post";
            this.removepostToolStripMenuItem.Click += new System.EventHandler(this.removepostToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayEmployeeToolStripMenuItem,
            this.allEmployeeToolStripMenuItem,
            this.iPostHistoryEmployeesToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // displayEmployeeToolStripMenuItem
            // 
            this.displayEmployeeToolStripMenuItem.Name = "displayEmployeeToolStripMenuItem";
            this.displayEmployeeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.displayEmployeeToolStripMenuItem.Text = "Employee";
            this.displayEmployeeToolStripMenuItem.Click += new System.EventHandler(this.displayEmployeeToolStripMenuItem_Click);
            // 
            // allEmployeeToolStripMenuItem
            // 
            this.allEmployeeToolStripMenuItem.Name = "allEmployeeToolStripMenuItem";
            this.allEmployeeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.allEmployeeToolStripMenuItem.Text = "All Employees";
            this.allEmployeeToolStripMenuItem.Click += new System.EventHandler(this.allEmployeeToolStripMenuItem_Click);
            // 
            // iPostHistoryEmployeesToolStripMenuItem
            // 
            this.iPostHistoryEmployeesToolStripMenuItem.Name = "iPostHistoryEmployeesToolStripMenuItem";
            this.iPostHistoryEmployeesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.iPostHistoryEmployeesToolStripMenuItem.Text = "IPostHistory Employees";
            this.iPostHistoryEmployeesToolStripMenuItem.Click += new System.EventHandler(this.iPostHistoryEmployeesToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalWeeklyPayToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // totalWeeklyPayToolStripMenuItem
            // 
            this.totalWeeklyPayToolStripMenuItem.Name = "totalWeeklyPayToolStripMenuItem";
            this.totalWeeklyPayToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.totalWeeklyPayToolStripMenuItem.Text = "Total Weekly Pay";
            this.totalWeeklyPayToolStripMenuItem.Click += new System.EventHandler(this.totalWeeklyPayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainDisplay
            // 
            this.mainDisplay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mainDisplay.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplay.Location = new System.Drawing.Point(0, 111);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(634, 316);
            this.mainDisplay.TabIndex = 3;
            this.mainDisplay.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Employee HR System";
            // 
            // ssEmployee
            // 
            this.ssEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslDisplayInfo});
            this.ssEmployee.Location = new System.Drawing.Point(0, 503);
            this.ssEmployee.Name = "ssEmployee";
            this.ssEmployee.Size = new System.Drawing.Size(634, 22);
            this.ssEmployee.TabIndex = 9;
            this.ssEmployee.Text = "statusStrip1";
            // 
            // sslDisplayInfo
            // 
            this.sslDisplayInfo.Name = "sslDisplayInfo";
            this.sslDisplayInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(256, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(634, 525);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ssEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mainDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HR System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssEmployee.ResumeLayout(false);
            this.ssEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addemployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addpostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeemployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removepostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPostHistoryEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalWeeklyPayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyPaidEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyPaidEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyPaidEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempHourlyPaidEmployeeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox mainDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssEmployee;
        private System.Windows.Forms.ToolStripStatusLabel sslDisplayInfo;
        private System.Windows.Forms.Button btnClear;
    }
}

