namespace WindowsFormsApp1
{
    partial class frmViewReturnBooks
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
            this.dgvCopies = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(250, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "View Return Books  List";
            // 
            // dgvCopies
            // 
            this.dgvCopies.BackgroundColor = System.Drawing.Color.White;
            this.dgvCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopies.Location = new System.Drawing.Point(12, 68);
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.RowHeadersWidth = 51;
            this.dgvCopies.RowTemplate.Height = 24;
            this.dgvCopies.Size = new System.Drawing.Size(828, 650);
            this.dgvCopies.TabIndex = 30;
            this.dgvCopies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(469, 746);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 57);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Exit";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(241, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 57);
            this.button1.TabIndex = 51;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmViewReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(872, 806);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCopies);
            this.Name = "frmViewReturnBooks";
            this.Text = "ViewReturnBooks";
            this.Load += new System.EventHandler(this.frmViewReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCopies;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}