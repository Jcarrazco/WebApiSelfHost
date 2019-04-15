namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Txb_Resp = new System.Windows.Forms.TextBox();
            this.Txb_Ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Txb_Resp
            // 
            this.Txb_Resp.Location = new System.Drawing.Point(12, 116);
            this.Txb_Resp.Multiline = true;
            this.Txb_Resp.Name = "Txb_Resp";
            this.Txb_Resp.Size = new System.Drawing.Size(282, 244);
            this.Txb_Resp.TabIndex = 1;
            // 
            // Txb_Ip
            // 
            this.Txb_Ip.Location = new System.Drawing.Point(114, 29);
            this.Txb_Ip.Name = "Txb_Ip";
            this.Txb_Ip.Size = new System.Drawing.Size(162, 20);
            this.Txb_Ip.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txb_Ip);
            this.Controls.Add(this.Txb_Resp);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txb_Resp;
        private System.Windows.Forms.TextBox Txb_Ip;
    }
}

