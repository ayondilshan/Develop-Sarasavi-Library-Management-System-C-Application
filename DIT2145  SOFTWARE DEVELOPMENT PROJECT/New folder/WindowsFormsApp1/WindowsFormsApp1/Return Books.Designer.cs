namespace WindowsFormsApp1
{
    partial class frmReturnBooks
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnaddBook = new System.Windows.Forms.Button();
            this.txtuserId = new System.Windows.Forms.TextBox();
            this.txtCopyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 681);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(428, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 27;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaddBook
            // 
            this.btnaddBook.BackColor = System.Drawing.Color.Red;
            this.btnaddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnaddBook.Location = new System.Drawing.Point(169, 491);
            this.btnaddBook.Name = "btnaddBook";
            this.btnaddBook.Size = new System.Drawing.Size(113, 55);
            this.btnaddBook.TabIndex = 26;
            this.btnaddBook.Text = "RETURN  BOOK";
            this.btnaddBook.UseVisualStyleBackColor = false;
            this.btnaddBook.Click += new System.EventHandler(this.btnaddBook_Click);
            // 
            // txtuserId
            // 
            this.txtuserId.BackColor = System.Drawing.Color.White;
            this.txtuserId.Location = new System.Drawing.Point(326, 194);
            this.txtuserId.Multiline = true;
            this.txtuserId.Name = "txtuserId";
            this.txtuserId.Size = new System.Drawing.Size(267, 36);
            this.txtuserId.TabIndex = 25;
            // 
            // txtCopyId
            // 
            this.txtCopyId.BackColor = System.Drawing.Color.White;
            this.txtCopyId.Location = new System.Drawing.Point(326, 279);
            this.txtCopyId.Multiline = true;
            this.txtCopyId.Name = "txtCopyId";
            this.txtCopyId.Size = new System.Drawing.Size(267, 36);
            this.txtCopyId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(108, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Copy ID :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(108, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "User ID :-";
            // 
            // btnViewReturn
            // 
            this.btnViewReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewReturn.Location = new System.Drawing.Point(197, 620);
            this.btnViewReturn.Name = "btnViewReturn";
            this.btnViewReturn.Size = new System.Drawing.Size(305, 39);
            this.btnViewReturn.TabIndex = 31;
            this.btnViewReturn.Text = "View Return Books  List";
            this.btnViewReturn.UseVisualStyleBackColor = false;
            this.btnViewReturn.Click += new System.EventHandler(this.btnViewReturn_Click);
            // 
            // frmReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(701, 741);
            this.Controls.Add(this.btnViewReturn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnaddBook);
            this.Controls.Add(this.txtuserId);
            this.Controls.Add(this.txtCopyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReturnBooks";
            this.Text = "Return_Books";
            this.Load += new System.EventHandler(this.frmReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnaddBook;
        private System.Windows.Forms.TextBox txtuserId;
        private System.Windows.Forms.TextBox txtCopyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewReturn;
    }
}