
namespace Lab2._3_Lift
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.elevatorImg = new System.Windows.Forms.PictureBox();
            this.floor1Btn = new System.Windows.Forms.Button();
            this.floor2Btn = new System.Windows.Forms.Button();
            this.floor3Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorImg)).BeginInit();
            this.SuspendLayout();
            // 
            // elevatorImg
            // 
            this.elevatorImg.Image = ((System.Drawing.Image)(resources.GetObject("elevatorImg.Image")));
            this.elevatorImg.Location = new System.Drawing.Point(339, 639);
            this.elevatorImg.Name = "elevatorImg";
            this.elevatorImg.Size = new System.Drawing.Size(154, 108);
            this.elevatorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevatorImg.TabIndex = 0;
            this.elevatorImg.TabStop = false;
            // 
            // floor1Btn
            // 
            this.floor1Btn.Location = new System.Drawing.Point(51, 639);
            this.floor1Btn.Name = "floor1Btn";
            this.floor1Btn.Size = new System.Drawing.Size(40, 32);
            this.floor1Btn.TabIndex = 1;
            this.floor1Btn.Text = "1";
            this.floor1Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.floor1Btn.UseVisualStyleBackColor = true;
            this.floor1Btn.Click += new System.EventHandler(this.floor1Btn_Click);
            // 
            // floor2Btn
            // 
            this.floor2Btn.Location = new System.Drawing.Point(51, 677);
            this.floor2Btn.Name = "floor2Btn";
            this.floor2Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.floor2Btn.Size = new System.Drawing.Size(40, 32);
            this.floor2Btn.TabIndex = 2;
            this.floor2Btn.Text = "2";
            this.floor2Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.floor2Btn.UseVisualStyleBackColor = true;
            this.floor2Btn.Click += new System.EventHandler(this.floor2Btn_Click);
            // 
            // floor3Btn
            // 
            this.floor3Btn.Location = new System.Drawing.Point(51, 715);
            this.floor3Btn.Name = "floor3Btn";
            this.floor3Btn.Size = new System.Drawing.Size(40, 32);
            this.floor3Btn.TabIndex = 3;
            this.floor3Btn.Text = "3";
            this.floor3Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.floor3Btn.UseVisualStyleBackColor = true;
            this.floor3Btn.Click += new System.EventHandler(this.floor3Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.floor3Btn);
            this.Controls.Add(this.floor2Btn);
            this.Controls.Add(this.floor1Btn);
            this.Controls.Add(this.elevatorImg);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elevatorImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox elevatorImg;
        private System.Windows.Forms.Button floor1Btn;
        private System.Windows.Forms.Button floor2Btn;
        private System.Windows.Forms.Button floor3Btn;
    }
}

