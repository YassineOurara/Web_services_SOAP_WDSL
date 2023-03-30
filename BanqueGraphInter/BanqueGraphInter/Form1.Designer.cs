namespace BanqueGraphInter
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBoxMT = new TextBox();
            btnConversion = new Button();
            btnComptes = new Button();
            textBoxRes = new TextBox();
            dataGridView1 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            solde = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 62);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Montant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Résultat";
            // 
            // textBoxMT
            // 
            textBoxMT.Location = new Point(147, 63);
            textBoxMT.Name = "textBoxMT";
            textBoxMT.Size = new Size(161, 27);
            textBoxMT.TabIndex = 2;
            // 
            // btnConversion
            // 
            btnConversion.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnConversion.FlatAppearance.BorderSize = 2;
            btnConversion.Location = new Point(431, 61);
            btnConversion.Name = "btnConversion";
            btnConversion.Size = new Size(94, 29);
            btnConversion.TabIndex = 3;
            btnConversion.Text = "Conversion";
            btnConversion.UseVisualStyleBackColor = true;
            btnConversion.Click += btnConversion_Click;
            // 
            // btnComptes
            // 
            btnComptes.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnComptes.FlatAppearance.BorderSize = 2;
            btnComptes.Location = new Point(255, 184);
            btnComptes.Name = "btnComptes";
            btnComptes.Size = new Size(94, 29);
            btnComptes.TabIndex = 4;
            btnComptes.Text = "Comptes";
            btnComptes.UseVisualStyleBackColor = true;
            btnComptes.Click += btnComptes_Click;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(147, 133);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(161, 27);
            textBoxRes.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code, solde });
            dataGridView1.Location = new Point(41, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(514, 144);
            dataGridView1.TabIndex = 6;
            // 
            // code
            // 
            code.DataPropertyName = "code";
            code.HeaderText = "code";
            code.MinimumWidth = 15;
            code.Name = "code";
            code.Width = 125;
            // 
            // solde
            // 
            solde.DataPropertyName = "solde";
            solde.HeaderText = "solde";
            solde.MinimumWidth = 6;
            solde.Name = "solde";
            solde.Width = 360;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 65);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "EURO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 136);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "MAD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 420);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxRes);
            Controls.Add(btnComptes);
            Controls.Add(btnConversion);
            Controls.Add(textBoxMT);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMT;
        private Button btnConversion;
        private Button btnComptes;
        private TextBox textBoxRes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn solde;
        private Label label3;
        private Label label4;
    }
}