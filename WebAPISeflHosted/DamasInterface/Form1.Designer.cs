namespace DamasInterface
{
    partial class InterFace
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
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.Txb_Origin = new System.Windows.Forms.TextBox();
            this.Txb_End = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Move = new System.Windows.Forms.Button();
            this.Btn_End = new System.Windows.Forms.Button();
            this.DG_res = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_res)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Iniciar.TabIndex = 0;
            this.Btn_Iniciar.Text = "Start";
            this.Btn_Iniciar.UseVisualStyleBackColor = true;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // Txb_Origin
            // 
            this.Txb_Origin.Location = new System.Drawing.Point(12, 82);
            this.Txb_Origin.Name = "Txb_Origin";
            this.Txb_Origin.Size = new System.Drawing.Size(100, 20);
            this.Txb_Origin.TabIndex = 1;
            // 
            // Txb_End
            // 
            this.Txb_End.Location = new System.Drawing.Point(12, 123);
            this.Txb_End.Name = "Txb_End";
            this.Txb_End.Size = new System.Drawing.Size(100, 20);
            this.Txb_End.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Position Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position End";
            // 
            // Btn_Move
            // 
            this.Btn_Move.Location = new System.Drawing.Point(12, 149);
            this.Btn_Move.Name = "Btn_Move";
            this.Btn_Move.Size = new System.Drawing.Size(75, 23);
            this.Btn_Move.TabIndex = 6;
            this.Btn_Move.Text = "Move";
            this.Btn_Move.UseVisualStyleBackColor = true;
            this.Btn_Move.Click += new System.EventHandler(this.Btn_Move_Click);
            // 
            // Btn_End
            // 
            this.Btn_End.Location = new System.Drawing.Point(12, 251);
            this.Btn_End.Name = "Btn_End";
            this.Btn_End.Size = new System.Drawing.Size(75, 23);
            this.Btn_End.TabIndex = 7;
            this.Btn_End.Text = "End Game";
            this.Btn_End.UseVisualStyleBackColor = true;
            this.Btn_End.Click += new System.EventHandler(this.Btn_End_Click);
            // 
            // DG_res
            // 
            this.DG_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_res.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DG_res.Location = new System.Drawing.Point(137, 12);
            this.DG_res.Name = "DG_res";
            this.DG_res.Size = new System.Drawing.Size(376, 284);
            this.DG_res.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Renglon";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "0";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "3";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "4";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "5";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "6";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "7";
            this.Column9.Name = "Column9";
            // 
            // InterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 308);
            this.Controls.Add(this.DG_res);
            this.Controls.Add(this.Btn_End);
            this.Controls.Add(this.Btn_Move);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_End);
            this.Controls.Add(this.Txb_Origin);
            this.Controls.Add(this.Btn_Iniciar);
            this.Name = "InterFace";
            this.Text = "Interface Damas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.TextBox Txb_Origin;
        private System.Windows.Forms.TextBox Txb_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Move;
        private System.Windows.Forms.Button Btn_End;
        private System.Windows.Forms.DataGridView DG_res;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

