namespace BusTicketingSystem
{
    partial class Busses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busses));
            this.dgvBusses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBusses = new System.Windows.Forms.TextBox();
            this.btnSearchBusses = new System.Windows.Forms.Button();
            this.btnAddBusses = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusses
            // 
            this.dgvBusses.AllowUserToAddRows = false;
            this.dgvBusses.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusses.ColumnHeadersHeight = 40;
            this.dgvBusses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBusses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBusses.EnableHeadersVisualStyles = false;
            this.dgvBusses.Location = new System.Drawing.Point(0, 0);
            this.dgvBusses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBusses.Name = "dgvBusses";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusses.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusses.RowHeadersVisible = false;
            this.dgvBusses.RowHeadersWidth = 62;
            this.dgvBusses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusses.Size = new System.Drawing.Size(1200, 630);
            this.dgvBusses.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchBusses);
            this.panel1.Controls.Add(this.btnSearchBusses);
            this.panel1.Controls.Add(this.btnAddBusses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 62);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Busses";
            // 
            // txtSearchBusses
            // 
            this.txtSearchBusses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBusses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBusses.Location = new System.Drawing.Point(826, 12);
            this.txtSearchBusses.Name = "txtSearchBusses";
            this.txtSearchBusses.Size = new System.Drawing.Size(234, 35);
            this.txtSearchBusses.TabIndex = 22;
            // 
            // btnSearchBusses
            // 
            this.btnSearchBusses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBusses.BackgroundImage")));
            this.btnSearchBusses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchBusses.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchBusses.FlatAppearance.BorderSize = 0;
            this.btnSearchBusses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBusses.Location = new System.Drawing.Point(1067, 0);
            this.btnSearchBusses.Name = "btnSearchBusses";
            this.btnSearchBusses.Size = new System.Drawing.Size(58, 62);
            this.btnSearchBusses.TabIndex = 21;
            this.btnSearchBusses.UseVisualStyleBackColor = true;
            // 
            // btnAddBusses
            // 
            this.btnAddBusses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBusses.BackgroundImage")));
            this.btnAddBusses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddBusses.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddBusses.FlatAppearance.BorderSize = 0;
            this.btnAddBusses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBusses.Location = new System.Drawing.Point(1125, 0);
            this.btnAddBusses.Name = "btnAddBusses";
            this.btnAddBusses.Size = new System.Drawing.Size(75, 62);
            this.btnAddBusses.TabIndex = 2;
            this.btnAddBusses.UseVisualStyleBackColor = true;
            this.btnAddBusses.Click += new System.EventHandler(this.btnAddBusses_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBusses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 630);
            this.panel2.TabIndex = 24;
            // 
            // Busses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Busses";
            this.Text = "Busses";
            this.Load += new System.EventHandler(this.Busses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBusses;
        private System.Windows.Forms.Button btnSearchBusses;
        private System.Windows.Forms.Button btnAddBusses;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvBusses;
    }
}