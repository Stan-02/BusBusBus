namespace BusTicketingSystem
{
    partial class Passengers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passengers));
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPassengers = new System.Windows.Forms.TextBox();
            this.btnSearchPassengers = new System.Windows.Forms.Button();
            this.btnAddPassengers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.BackgroundColor = System.Drawing.Color.White;
            this.dgvPassengers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPassengers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPassengers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPassengers.ColumnHeadersHeight = 40;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPassengers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengers.EnableHeadersVisualStyles = false;
            this.dgvPassengers.Location = new System.Drawing.Point(0, 0);
            this.dgvPassengers.Name = "dgvPassengers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPassengers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPassengers.RowHeadersVisible = false;
            this.dgvPassengers.RowHeadersWidth = 62;
            this.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengers.Size = new System.Drawing.Size(800, 410);
            this.dgvPassengers.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 8F;
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trips";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 159;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fare";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Contact #";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = " ";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 35;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = " ";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchPassengers);
            this.panel1.Controls.Add(this.btnSearchPassengers);
            this.panel1.Controls.Add(this.btnAddPassengers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Passengers";
            // 
            // txtSearchPassengers
            // 
            this.txtSearchPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPassengers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPassengers.Location = new System.Drawing.Point(545, 8);
            this.txtSearchPassengers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchPassengers.Name = "txtSearchPassengers";
            this.txtSearchPassengers.Size = new System.Drawing.Size(163, 26);
            this.txtSearchPassengers.TabIndex = 22;
            this.txtSearchPassengers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearchPassengers
            // 
            this.btnSearchPassengers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPassengers.BackgroundImage")));
            this.btnSearchPassengers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchPassengers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchPassengers.FlatAppearance.BorderSize = 0;
            this.btnSearchPassengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPassengers.Location = new System.Drawing.Point(711, 0);
            this.btnSearchPassengers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchPassengers.Name = "btnSearchPassengers";
            this.btnSearchPassengers.Size = new System.Drawing.Size(39, 40);
            this.btnSearchPassengers.TabIndex = 21;
            this.btnSearchPassengers.UseVisualStyleBackColor = true;
            // 
            // btnAddPassengers
            // 
            this.btnAddPassengers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPassengers.BackgroundImage")));
            this.btnAddPassengers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPassengers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddPassengers.FlatAppearance.BorderSize = 0;
            this.btnAddPassengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPassengers.Location = new System.Drawing.Point(750, 0);
            this.btnAddPassengers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPassengers.Name = "btnAddPassengers";
            this.btnAddPassengers.Size = new System.Drawing.Size(50, 40);
            this.btnAddPassengers.TabIndex = 2;
            this.btnAddPassengers.UseVisualStyleBackColor = true;
            this.btnAddPassengers.Click += new System.EventHandler(this.btnAddPassengers_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPassengers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 410);
            this.panel2.TabIndex = 22;
            // 
            // Passengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passengers";
            this.Text = "Passengers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPassengers;
        private System.Windows.Forms.Button btnSearchPassengers;
        private System.Windows.Forms.TextBox txtSearchPassengers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}