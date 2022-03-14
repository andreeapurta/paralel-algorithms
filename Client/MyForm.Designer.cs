namespace Client
{
  partial class MyForm
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
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.lNume = new System.Windows.Forms.Label();
            this.SendtxtBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.textBoxMesaje = new System.Windows.Forms.TextBox();
            this.ClientsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(190, 22);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(84, 24);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtBox.TabIndex = 1;
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Location = new System.Drawing.Point(12, 27);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(66, 13);
            this.lNume.TabIndex = 2;
            this.lNume.Text = "Your Name :";
            // 
            // SendtxtBox
            // 
            this.SendtxtBox.Location = new System.Drawing.Point(200, 380);
            this.SendtxtBox.Multiline = true;
            this.SendtxtBox.Name = "SendtxtBox";
            this.SendtxtBox.Size = new System.Drawing.Size(422, 44);
            this.SendtxtBox.TabIndex = 3;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(644, 380);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(83, 44);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // textBoxMesaje
            // 
            this.textBoxMesaje.Location = new System.Drawing.Point(200, 69);
            this.textBoxMesaje.Multiline = true;
            this.textBoxMesaje.Name = "textBoxMesaje";
            this.textBoxMesaje.Size = new System.Drawing.Size(422, 291);
            this.textBoxMesaje.TabIndex = 6;
            // 
            // ClientsListBox
            // 
            this.ClientsListBox.FormattingEnabled = true;
            this.ClientsListBox.Location = new System.Drawing.Point(12, 69);
            this.ClientsListBox.Name = "ClientsListBox";
            this.ClientsListBox.Size = new System.Drawing.Size(157, 355);
            this.ClientsListBox.TabIndex = 5;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMesaje);
            this.Controls.Add(this.ClientsListBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.SendtxtBox);
            this.Controls.Add(this.lNume);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.ConnectBtn);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ConnectBtn;
    private System.Windows.Forms.TextBox NameTxtBox;
    private System.Windows.Forms.Label lNume;
    private System.Windows.Forms.TextBox SendtxtBox;
    private System.Windows.Forms.Button SendBtn;
    public System.Windows.Forms.TextBox textBoxMesaje;
        public System.Windows.Forms.ListBox ClientsListBox;
    }
}

