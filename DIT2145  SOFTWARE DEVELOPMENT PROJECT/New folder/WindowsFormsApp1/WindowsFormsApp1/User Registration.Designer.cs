namespace WindowsFormsApp1
{
    partial class frmUserO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserO));
            this.cmbUType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.button_usersave = new System.Windows.Forms.Button();
            this.chkFemale = new System.Windows.Forms.RadioButton();
            this.chkMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbUType
            // 
            this.cmbUType.FormattingEnabled = true;
            this.cmbUType.Items.AddRange(new object[] {
            "Member",
            "Visitor"});
            this.cmbUType.Location = new System.Drawing.Point(164, 432);
            this.cmbUType.Name = "cmbUType";
            this.cmbUType.Size = new System.Drawing.Size(268, 24);
            this.cmbUType.TabIndex = 33;
            this.cmbUType.SelectedIndexChanged += new System.EventHandler(this.cmbUType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "User Type :-";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(323, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 57);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.Color.Red;
            this.btnDelUser.Location = new System.Drawing.Point(193, 560);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(94, 57);
            this.btnDelUser.TabIndex = 30;
            this.btnDelUser.Text = "Delete";
            this.btnDelUser.UseVisualStyleBackColor = false;
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewUser.Location = new System.Drawing.Point(66, 642);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(305, 39);
            this.btnViewUser.TabIndex = 29;
            this.btnViewUser.Text = "View User List";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // button_usersave
            // 
            this.button_usersave.BackColor = System.Drawing.Color.Red;
            this.button_usersave.Location = new System.Drawing.Point(64, 560);
            this.button_usersave.Name = "button_usersave";
            this.button_usersave.Size = new System.Drawing.Size(94, 57);
            this.button_usersave.TabIndex = 28;
            this.button_usersave.Text = "Save";
            this.button_usersave.UseVisualStyleBackColor = false;
            this.button_usersave.Click += new System.EventHandler(this.button_usersave_Click);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFemale.Location = new System.Drawing.Point(290, 256);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(96, 26);
            this.chkFemale.TabIndex = 27;
            this.chkFemale.TabStop = true;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMale.Location = new System.Drawing.Point(174, 259);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(73, 26);
            this.chkMale.TabIndex = 26;
            this.chkMale.TabStop = true;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 178);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 28);
            this.txtName.TabIndex = 25;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(164, 313);
            this.txtNic.Multiline = true;
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(268, 28);
            this.txtNic.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(164, 375);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(268, 28);
            this.txtAddress.TabIndex = 23;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(164, 116);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(268, 28);
            this.txtUserId.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Address :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gender :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "NIC :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "User ID :-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Email :-";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(164, 479);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(268, 28);
            this.email.TabIndex = 35;
            // 
            // frmUserO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 752);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbUType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnViewUser);
            this.Controls.Add(this.button_usersave);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUserO";
            this.Text = "User_Registration";
            this.Load += new System.EventHandler(this.frmUserO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button button_usersave;
        private System.Windows.Forms.RadioButton chkFemale;
        private System.Windows.Forms.RadioButton chkMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
    }
}