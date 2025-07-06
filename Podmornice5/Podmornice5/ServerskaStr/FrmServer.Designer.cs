namespace ServerskaStr
{
    partial class FrmServer
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            btnPokreniIgru = new Button();
            lblIme = new Label();
            lblPrezime = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 62);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(54, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(173, 62);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(54, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(29, 95);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(54, 27);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(99, 95);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(54, 27);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(173, 95);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(54, 27);
            textBox9.TabIndex = 8;
            // 
            // btnPokreniIgru
            // 
            btnPokreniIgru.Location = new Point(29, 144);
            btnPokreniIgru.Name = "btnPokreniIgru";
            btnPokreniIgru.Size = new Size(198, 29);
            btnPokreniIgru.TabIndex = 9;
            btnPokreniIgru.Text = "Pokreni igru";
            btnPokreniIgru.UseVisualStyleBackColor = true;
            btnPokreniIgru.Click += btnPokreniIgru_Click;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(49, 214);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(50, 20);
            lblIme.TabIndex = 10;
            lblIme.Text = "label1";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(137, 214);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(50, 20);
            lblPrezime.TabIndex = 11;
            lblPrezime.Text = "label1";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 306);
            Controls.Add(lblPrezime);
            Controls.Add(lblIme);
            Controls.Add(btnPokreniIgru);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmServer";
            Text = "FrmGlavna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button btnPokreniIgru;
        private Label lblIme;
        private Label lblPrezime;
    }
}