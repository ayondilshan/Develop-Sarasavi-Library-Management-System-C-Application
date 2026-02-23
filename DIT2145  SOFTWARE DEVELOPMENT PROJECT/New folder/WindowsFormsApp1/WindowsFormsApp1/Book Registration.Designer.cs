namespace WindowsFormsApp1
{
    partial class frmBookO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookO));
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnaddBook = new System.Windows.Forms.Button();
            this.txtTotalR = new System.Windows.Forms.TextBox();
            this.txtTotalC = new System.Windows.Forms.TextBox();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.Color.Red;
            this.btnDelUser.Location = new System.Drawing.Point(268, 648);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(94, 57);
            this.btnDelUser.TabIndex = 35;
            this.btnDelUser.Text = "Delete";
            this.btnDelUser.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(439, 648);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 57);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.White;
            this.txtBookId.Location = new System.Drawing.Point(299, 122);
            this.txtBookId.Multiline = true;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(288, 36);
            this.txtBookId.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Book ID :-";
            // 
            // btnaddBook
            // 
            this.btnaddBook.BackColor = System.Drawing.Color.Red;
            this.btnaddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnaddBook.Location = new System.Drawing.Point(60, 650);
            this.btnaddBook.Name = "btnaddBook";
            this.btnaddBook.Size = new System.Drawing.Size(113, 55);
            this.btnaddBook.TabIndex = 31;
            this.btnaddBook.Text = "ADD";
            this.btnaddBook.UseVisualStyleBackColor = false;
            this.btnaddBook.Click += new System.EventHandler(this.btnaddBook_Click);
            // 
            // txtTotalR
            // 
            this.txtTotalR.BackColor = System.Drawing.Color.White;
            this.txtTotalR.Location = new System.Drawing.Point(299, 520);
            this.txtTotalR.Multiline = true;
            this.txtTotalR.Name = "txtTotalR";
            this.txtTotalR.Size = new System.Drawing.Size(288, 36);
            this.txtTotalR.TabIndex = 30;
            // 
            // txtTotalC
            // 
            this.txtTotalC.BackColor = System.Drawing.Color.White;
            this.txtTotalC.Location = new System.Drawing.Point(299, 460);
            this.txtTotalC.Multiline = true;
            this.txtTotalC.Name = "txtTotalC";
            this.txtTotalC.Size = new System.Drawing.Size(288, 36);
            this.txtTotalC.TabIndex = 29;
            // 
            // txtClassification
            // 
            this.txtClassification.BackColor = System.Drawing.Color.White;
            this.txtClassification.Location = new System.Drawing.Point(299, 395);
            this.txtClassification.Multiline = true;
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Size = new System.Drawing.Size(288, 36);
            this.txtClassification.TabIndex = 28;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(299, 253);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(288, 36);
            this.txtAuthor.TabIndex = 27;
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.Color.White;
            this.txtIsbn.Location = new System.Drawing.Point(299, 324);
            this.txtIsbn.Multiline = true;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(288, 36);
            this.txtIsbn.TabIndex = 26;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(299, 180);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(288, 36);
            this.txtTitle.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(34, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Copies :-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(34, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Reference Copies :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "ISBN :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Classification :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Author :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title :-";
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewUser.Location = new System.Drawing.Point(128, 776);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(305, 39);
            this.btnViewUser.TabIndex = 36;
            this.btnViewUser.Text = "View Books Registration List";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // frmBookO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 827);
            this.Controls.Add(this.btnViewUser);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnaddBook);
            this.Controls.Add(this.txtTotalR);
            this.Controls.Add(this.txtTotalC);
            this.Controls.Add(this.txtClassification);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBookO";
            this.Text = "Book_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaddBook;
        private System.Windows.Forms.TextBox txtTotalR;
        private System.Windows.Forms.TextBox txtTotalC;
        private System.Windows.Forms.TextBox txtClassification;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewUser;
    }
}