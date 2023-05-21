namespace Praktikum_W12
{
    partial class Remove
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
            this.teamname = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // teamname
            // 
            this.teamname.FormattingEnabled = true;
            this.teamname.Location = new System.Drawing.Point(136, 12);
            this.teamname.Name = "teamname";
            this.teamname.Size = new System.Drawing.Size(301, 28);
            this.teamname.TabIndex = 59;
            this.teamname.SelectionChangeCommitted += new System.EventHandler(this.teamname_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 58;
            this.label16.Text = "Team Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 46);
            this.button2.TabIndex = 57;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(11, 119);
            this.dgv4.Name = "dgv4";
            this.dgv4.RowHeadersWidth = 62;
            this.dgv4.RowTemplate.Height = 28;
            this.dgv4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv4.Size = new System.Drawing.Size(589, 429);
            this.dgv4.TabIndex = 60;
            this.dgv4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv4_CellContentClick);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 560);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.teamname);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Name = "Remove";
            this.Text = "Remove";
            this.Load += new System.EventHandler(this.Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teamname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv4;
    }
}