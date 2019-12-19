namespace ApplicationWinforms
{
    partial class fjy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fjy));
            this.button1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "retour à la page d\'accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.a.Location = new System.Drawing.Point(57, 44);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(139, 20);
            this.a.TabIndex = 1;
            this.a.Text = "CIN";
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            this.a.Enter += new System.EventHandler(this.a_enter);
            this.a.Leave += new System.EventHandler(this.a_leave);
            // 
            // b
            // 
            this.b.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.b.Location = new System.Drawing.Point(57, 82);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(139, 20);
            this.b.TabIndex = 2;
            this.b.Text = "Nom";
            this.b.Enter += new System.EventHandler(this.b_enter);
            this.b.Leave += new System.EventHandler(this.b_leave);
            // 
            // c
            // 
            this.c.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.c.Location = new System.Drawing.Point(57, 118);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(139, 20);
            this.c.TabIndex = 3;
            this.c.Text = "Prenom";
            this.c.Enter += new System.EventHandler(this.c_enter);
            this.c.Leave += new System.EventHandler(this.c_leave);
            // 
            // f
            // 
            this.f.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.f.Location = new System.Drawing.Point(241, 118);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(200, 20);
            this.f.TabIndex = 6;
            this.f.Text = "Numero de telephone";
            this.f.Enter += new System.EventHandler(this.f_enter);
            this.f.Leave += new System.EventHandler(this.f_leave);
            // 
            // email
            // 
            this.email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.email.Location = new System.Drawing.Point(241, 82);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 20);
            this.email.TabIndex = 5;
            this.email.Text = "NomPrenom@exemple.com";
            this.email.Enter += new System.EventHandler(this.email_enter);
            this.email.Leave += new System.EventHandler(this.email_leave);
            // 
            // d
            // 
            this.d.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.d.Location = new System.Drawing.Point(57, 161);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(139, 20);
            this.d.TabIndex = 4;
            this.d.Text = "Sexe";
            this.d.Enter += new System.EventHandler(this.d_enter);
            this.d.Leave += new System.EventHandler(this.d_leave);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(241, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Mot de passe";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fjy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(619, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.email);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button1);
            this.Name = "fjy";
            this.Text = "fjy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}