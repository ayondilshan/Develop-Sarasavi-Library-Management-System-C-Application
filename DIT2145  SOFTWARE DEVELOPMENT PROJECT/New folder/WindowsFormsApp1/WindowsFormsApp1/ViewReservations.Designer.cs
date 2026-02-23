namespace WindowsFormsApp1
{
    partial class frmViewReservations
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(318, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "View Reserve Book List";
            // 
            // dgvReservations
            // 
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReservations.Location = new System.Drawing.Point(50, 123);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(828, 650);
            this.dgvReservations.TabIndex = 30;
            this.dgvReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(252, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 57);
            this.button1.TabIndex = 54;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(565, 779);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 57);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Exit";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(928, 846);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservations);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmViewReservations";
            this.Text = "ViewReservations";
            this.Load += new System.EventHandler(this.frmViewReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
    }
}