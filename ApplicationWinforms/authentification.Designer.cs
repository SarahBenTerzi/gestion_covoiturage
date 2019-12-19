namespace ApplicationWinforms
{
    partial class authentification
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mDPLabel;
            System.Windows.Forms.Label cINLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authentification));
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cinComboBox = new System.Windows.Forms.ComboBox();
            this.db_clientsDataSet = new ApplicationWinforms.utilisateurs_offres_reservationsDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new ApplicationWinforms.utilisateurs_offres_reservationsDataSetTableAdapters.utilisateurTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.utilisateuroffreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offreTableAdapter = new ApplicationWinforms.utilisateurs_offres_reservationsDataSetTableAdapters.offreTableAdapter();
            this.utilisateuroffreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.offrereservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new ApplicationWinforms.utilisateurs_offres_reservationsDataSetTableAdapters.reservationTableAdapter();
            mDPLabel = new System.Windows.Forms.Label();
            cINLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_clientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateuroffreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateuroffreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrereservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mDPLabel
            // 
            mDPLabel.AutoSize = true;
            mDPLabel.BackColor = System.Drawing.Color.Black;
            mDPLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mDPLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            mDPLabel.Location = new System.Drawing.Point(67, 148);
            mDPLabel.Name = "mDPLabel";
            mDPLabel.Size = new System.Drawing.Size(52, 22);
            mDPLabel.TabIndex = 3;
            mDPLabel.Text = "MDP";
            // 
            // cINLabel
            // 
            cINLabel.AutoSize = true;
            cINLabel.BackColor = System.Drawing.Color.Black;
            cINLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cINLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            cINLabel.Location = new System.Drawing.Point(73, 94);
            cINLabel.Name = "cINLabel";
            cINLabel.Size = new System.Drawing.Size(43, 22);
            cINLabel.TabIndex = 6;
            cINLabel.Text = "CIN";
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.Location = new System.Drawing.Point(130, 148);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(151, 20);
            this.mdpTextBox.TabIndex = 4;
            this.mdpTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cinComboBox
            // 
            this.cinComboBox.FormattingEnabled = true;
            this.cinComboBox.Location = new System.Drawing.Point(130, 94);
            this.cinComboBox.Name = "cinComboBox";
            this.cinComboBox.Size = new System.Drawing.Size(151, 21);
            this.cinComboBox.TabIndex = 7;
            // 
            // db_clientsDataSet
            // 
            this.db_clientsDataSet.DataSetName = "db_clientsDataSet";
            this.db_clientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.db_clientsDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "afficher les caractéres";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // utilisateuroffreBindingSource
            // 
            this.utilisateuroffreBindingSource.DataMember = "utilisateuroffre";
            this.utilisateuroffreBindingSource.DataSource = this.utilisateurBindingSource;
            // 
            // offreTableAdapter
            // 
            this.offreTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateuroffreBindingSource1
            // 
            this.utilisateuroffreBindingSource1.DataMember = "utilisateuroffre";
            this.utilisateuroffreBindingSource1.DataSource = this.utilisateurBindingSource;
            // 
            // offrereservationBindingSource
            // 
            this.offrereservationBindingSource.DataMember = "offrereservation";
            this.offrereservationBindingSource.DataSource = this.utilisateuroffreBindingSource1;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 360);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(cINLabel);
            this.Controls.Add(this.cinComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(mDPLabel);
            this.Controls.Add(this.mdpTextBox);
            this.Name = "authentification";
            this.Text = "authentification";
            this.Load += new System.EventHandler(this.authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_clientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateuroffreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateuroffreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrereservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cinComboBox;
        private utilisateurs_offres_reservationsDataSet db_clientsDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private utilisateurs_offres_reservationsDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource utilisateuroffreBindingSource;
        private utilisateurs_offres_reservationsDataSetTableAdapters.offreTableAdapter offreTableAdapter;
        private System.Windows.Forms.BindingSource utilisateuroffreBindingSource1;
        private System.Windows.Forms.BindingSource offrereservationBindingSource;
        private utilisateurs_offres_reservationsDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
    }
}