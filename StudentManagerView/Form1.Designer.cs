namespace StudentManagerView
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specializare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLbl = new System.Windows.Forms.Label();
            this.specializareLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.averageLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.specializareTxtBox = new System.Windows.Forms.TextBox();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.averageTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Specializare,
            this.Year,
            this.Average});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(543, 321);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Specializare
            // 
            this.Specializare.HeaderText = "Specializare";
            this.Specializare.Name = "Specializare";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.Name = "Average";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(18, 397);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(39, 15);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // specializareLbl
            // 
            this.specializareLbl.AutoSize = true;
            this.specializareLbl.Location = new System.Drawing.Point(18, 441);
            this.specializareLbl.Name = "specializareLbl";
            this.specializareLbl.Size = new System.Drawing.Size(68, 15);
            this.specializareLbl.TabIndex = 3;
            this.specializareLbl.Text = "Specializare";
            this.specializareLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(18, 479);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(29, 15);
            this.yearLbl.TabIndex = 4;
            this.yearLbl.Text = "Year";
            this.yearLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // averageLbl
            // 
            this.averageLbl.AutoSize = true;
            this.averageLbl.Location = new System.Drawing.Point(18, 519);
            this.averageLbl.Name = "averageLbl";
            this.averageLbl.Size = new System.Drawing.Size(50, 15);
            this.averageLbl.TabIndex = 5;
            this.averageLbl.Text = "Average";
            this.averageLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(63, 394);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(257, 23);
            this.nameTxtBox.TabIndex = 7;
            // 
            // specializareTxtBox
            // 
            this.specializareTxtBox.Location = new System.Drawing.Point(92, 438);
            this.specializareTxtBox.Name = "specializareTxtBox";
            this.specializareTxtBox.Size = new System.Drawing.Size(228, 23);
            this.specializareTxtBox.TabIndex = 8;
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(63, 476);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(257, 23);
            this.yearTxtBox.TabIndex = 9;
            // 
            // averageTxtBox
            // 
            this.averageTxtBox.Location = new System.Drawing.Point(74, 519);
            this.averageTxtBox.Name = "averageTxtBox";
            this.averageTxtBox.Size = new System.Drawing.Size(246, 23);
            this.averageTxtBox.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(402, 366);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 46);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(402, 425);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(153, 46);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(402, 496);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(153, 46);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // idTxtbox
            // 
            this.idTxtbox.Enabled = false;
            this.idTxtbox.Location = new System.Drawing.Point(63, 358);
            this.idTxtbox.Name = "idTxtbox";
            this.idTxtbox.Size = new System.Drawing.Size(257, 23);
            this.idTxtbox.TabIndex = 15;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 588);
            this.Controls.Add(this.idTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.averageTxtBox);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.specializareTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.averageLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.specializareLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.dataGridView);
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specializare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label specializareLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label averageLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox specializareTxtBox;
        private System.Windows.Forms.TextBox yearTxtBox;
        private System.Windows.Forms.TextBox averageTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxtbox;
    }
}
