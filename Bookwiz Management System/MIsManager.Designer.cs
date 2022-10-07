namespace Bookwiz_Management_System
{
    partial class MIsManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxUserFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserLastName = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxChoiceUser = new System.Windows.Forms.ComboBox();
            this.labelInfoUser = new System.Windows.Forms.Label();
            this.textBoxInputUser = new System.Windows.Forms.TextBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonListUsers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonListEmployees = new System.Windows.Forms.Button();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.textBoxInputEmployee = new System.Windows.Forms.TextBox();
            this.labelInfoEmployee = new System.Windows.Forms.Label();
            this.comboBoxChoiceEmployee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxEmpLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmpFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEMPID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listViewManager = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(138, 40);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(112, 22);
            this.textBoxUID.TabIndex = 3;
            // 
            // textBoxUserFirstName
            // 
            this.textBoxUserFirstName.Location = new System.Drawing.Point(138, 96);
            this.textBoxUserFirstName.Name = "textBoxUserFirstName";
            this.textBoxUserFirstName.Size = new System.Drawing.Size(112, 22);
            this.textBoxUserFirstName.TabIndex = 4;
            // 
            // textBoxUserLastName
            // 
            this.textBoxUserLastName.Location = new System.Drawing.Point(138, 153);
            this.textBoxUserLastName.Name = "textBoxUserLastName";
            this.textBoxUserLastName.Size = new System.Drawing.Size(112, 22);
            this.textBoxUserLastName.TabIndex = 5;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(367, 96);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(84, 23);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Option";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxChoiceUser
            // 
            this.comboBoxChoiceUser.FormattingEnabled = true;
            this.comboBoxChoiceUser.Items.AddRange(new object[] {
            "User ID",
            "First Name",
            "Last Name"});
            this.comboBoxChoiceUser.Location = new System.Drawing.Point(521, 83);
            this.comboBoxChoiceUser.Name = "comboBoxChoiceUser";
            this.comboBoxChoiceUser.Size = new System.Drawing.Size(136, 24);
            this.comboBoxChoiceUser.TabIndex = 8;
            this.comboBoxChoiceUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiceUser_SelectedIndexChanged);
            // 
            // labelInfoUser
            // 
            this.labelInfoUser.AutoSize = true;
            this.labelInfoUser.Location = new System.Drawing.Point(518, 127);
            this.labelInfoUser.Name = "labelInfoUser";
            this.labelInfoUser.Size = new System.Drawing.Size(69, 16);
            this.labelInfoUser.TabIndex = 9;
            this.labelInfoUser.Text = "Input Info";
            this.labelInfoUser.Click += new System.EventHandler(this.labelInfoUser_Click);
            // 
            // textBoxInputUser
            // 
            this.textBoxInputUser.Location = new System.Drawing.Point(521, 156);
            this.textBoxInputUser.Name = "textBoxInputUser";
            this.textBoxInputUser.Size = new System.Drawing.Size(112, 22);
            this.textBoxInputUser.TabIndex = 10;
            this.textBoxInputUser.TextChanged += new System.EventHandler(this.textBoxInputUser_TextChanged);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.Location = new System.Drawing.Point(705, 120);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(84, 23);
            this.buttonSearchUser.TabIndex = 11;
            this.buttonSearchUser.Text = "Search";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.Location = new System.Drawing.Point(902, 96);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(119, 47);
            this.buttonListUsers.TabIndex = 12;
            this.buttonListUsers.Text = "List Users";
            this.buttonListUsers.UseVisualStyleBackColor = true;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 13;
            // 
            // buttonListEmployees
            // 
            this.buttonListEmployees.Location = new System.Drawing.Point(916, 313);
            this.buttonListEmployees.Name = "buttonListEmployees";
            this.buttonListEmployees.Size = new System.Drawing.Size(132, 55);
            this.buttonListEmployees.TabIndex = 27;
            this.buttonListEmployees.Text = "List Employees";
            this.buttonListEmployees.UseVisualStyleBackColor = true;
            this.buttonListEmployees.Click += new System.EventHandler(this.buttonListEmployees_Click);
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(716, 326);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(84, 23);
            this.buttonSearchEmployee.TabIndex = 26;
            this.buttonSearchEmployee.Text = "Search";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // textBoxInputEmployee
            // 
            this.textBoxInputEmployee.Location = new System.Drawing.Point(521, 369);
            this.textBoxInputEmployee.Name = "textBoxInputEmployee";
            this.textBoxInputEmployee.Size = new System.Drawing.Size(112, 22);
            this.textBoxInputEmployee.TabIndex = 25;
            // 
            // labelInfoEmployee
            // 
            this.labelInfoEmployee.AutoSize = true;
            this.labelInfoEmployee.Location = new System.Drawing.Point(518, 333);
            this.labelInfoEmployee.Name = "labelInfoEmployee";
            this.labelInfoEmployee.Size = new System.Drawing.Size(69, 16);
            this.labelInfoEmployee.TabIndex = 24;
            this.labelInfoEmployee.Text = "Input Info";
            // 
            // comboBoxChoiceEmployee
            // 
            this.comboBoxChoiceEmployee.FormattingEnabled = true;
            this.comboBoxChoiceEmployee.Items.AddRange(new object[] {
            "Employee ID",
            "First Name",
            "Last Name"});
            this.comboBoxChoiceEmployee.Location = new System.Drawing.Point(521, 275);
            this.comboBoxChoiceEmployee.Name = "comboBoxChoiceEmployee";
            this.comboBoxChoiceEmployee.Size = new System.Drawing.Size(136, 24);
            this.comboBoxChoiceEmployee.TabIndex = 23;
            this.comboBoxChoiceEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiceEmployee_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Select Option";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(367, 305);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(120, 44);
            this.buttonAddEmployee.TabIndex = 21;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // textBoxEmpLastName
            // 
            this.textBoxEmpLastName.Location = new System.Drawing.Point(172, 363);
            this.textBoxEmpLastName.Name = "textBoxEmpLastName";
            this.textBoxEmpLastName.Size = new System.Drawing.Size(112, 22);
            this.textBoxEmpLastName.TabIndex = 20;
            // 
            // textBoxEmpFirstName
            // 
            this.textBoxEmpFirstName.Location = new System.Drawing.Point(172, 306);
            this.textBoxEmpFirstName.Name = "textBoxEmpFirstName";
            this.textBoxEmpFirstName.Size = new System.Drawing.Size(112, 22);
            this.textBoxEmpFirstName.TabIndex = 19;
            // 
            // textBoxEMPID
            // 
            this.textBoxEMPID.Location = new System.Drawing.Point(172, 250);
            this.textBoxEMPID.Name = "textBoxEMPID";
            this.textBoxEMPID.Size = new System.Drawing.Size(112, 22);
            this.textBoxEMPID.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "First Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Employee ID";
            // 
            // listViewManager
            // 
            this.listViewManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewManager.HideSelection = false;
            this.listViewManager.Location = new System.Drawing.Point(84, 449);
            this.listViewManager.Name = "listViewManager";
            this.listViewManager.Size = new System.Drawing.Size(962, 126);
            this.listViewManager.TabIndex = 28;
            this.listViewManager.UseCompatibleStateImageBehavior = false;
            this.listViewManager.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 272;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 239;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(937, 597);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 30);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MIsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 639);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listViewManager);
            this.Controls.Add(this.buttonListEmployees);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.textBoxInputEmployee);
            this.Controls.Add(this.labelInfoEmployee);
            this.Controls.Add(this.comboBoxChoiceEmployee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.textBoxEmpLastName);
            this.Controls.Add(this.textBoxEmpFirstName);
            this.Controls.Add(this.textBoxEMPID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonListUsers);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.textBoxInputUser);
            this.Controls.Add(this.labelInfoUser);
            this.Controls.Add(this.comboBoxChoiceUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.textBoxUserLastName);
            this.Controls.Add(this.textBoxUserFirstName);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MIsManager";
            this.Text = "MIsManager";
            this.Load += new System.EventHandler(this.MIsManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.TextBox textBoxUserFirstName;
        private System.Windows.Forms.TextBox textBoxUserLastName;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxChoiceUser;
        private System.Windows.Forms.Label labelInfoUser;
        private System.Windows.Forms.TextBox textBoxInputUser;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonListUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonListEmployees;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.TextBox textBoxInputEmployee;
        private System.Windows.Forms.Label labelInfoEmployee;
        private System.Windows.Forms.ComboBox comboBoxChoiceEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TextBox textBoxEmpLastName;
        private System.Windows.Forms.TextBox textBoxEmpFirstName;
        private System.Windows.Forms.TextBox textBoxEMPID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewManager;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonExit;
    }
}