namespace WindowsFormsApp1
{
    partial class frmLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibrary));
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.frmBookInquiry = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sarasavi Library home";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Location = new System.Drawing.Point(615, 428);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 66);
            this.button6.TabIndex = 12;
            this.button6.Text = "Reserve Books";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Location = new System.Drawing.Point(171, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 66);
            this.button5.TabIndex = 11;
            this.button5.Text = "Return Books";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Location = new System.Drawing.Point(615, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 66);
            this.button4.TabIndex = 10;
            this.button4.Text = "Loan Books";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // frmBookInquiry
            // 
            this.frmBookInquiry.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmBookInquiry.Location = new System.Drawing.Point(171, 298);
            this.frmBookInquiry.Name = "frmBookInquiry";
            this.frmBookInquiry.Size = new System.Drawing.Size(148, 66);
            this.frmBookInquiry.TabIndex = 9;
            this.frmBookInquiry.Text = "Book Inquiry";
            this.frmBookInquiry.UseVisualStyleBackColor = false;
            this.frmBookInquiry.Click += new System.EventHandler(this.frmBookInquiry_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(615, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 66);
            this.button2.TabIndex = 8;
            this.button2.Text = "Book Registration";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(171, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "User Registration";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.frmBookInquiry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmLibrary";
            this.Text = "Library_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button frmBookInquiry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}