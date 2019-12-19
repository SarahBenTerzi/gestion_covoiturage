namespace ApplicationWinforms
{
    partial class authen_consult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authen_consult));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurs_offres_reservationsDataSet = new ApplicationWinforms.utilisateurs_offres_reservationsDataSet();
            this.utilisateurTableAdapter = new ApplicationWinforms.utilisateurs_offres_reservationsDataSetTableAdapters.utilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurs_offres_reservationsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(368, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Précédent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cINDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseemailDataGridViewTextBoxColumn,
            this.numerotelephoneDataGridViewTextBoxColumn,
            this.datenaissanceDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.mDPDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilisateurBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 69);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cINDataGridViewTextBoxColumn
            // 
            this.cINDataGridViewTextBoxColumn.DataPropertyName = "CIN";
            this.cINDataGridViewTextBoxColumn.HeaderText = "CIN";
            this.cINDataGridViewTextBoxColumn.Name = "cINDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adresseemailDataGridViewTextBoxColumn
            // 
            this.adresseemailDataGridViewTextBoxColumn.DataPropertyName = "adresse_email";
            this.adresseemailDataGridViewTextBoxColumn.HeaderText = "adresse_email";
            this.adresseemailDataGridViewTextBoxColumn.Name = "adresseemailDataGridViewTextBoxColumn";
            // 
            // numerotelephoneDataGridViewTextBoxColumn
            // 
            this.numerotelephoneDataGridViewTextBoxColumn.DataPropertyName = "numero_telephone";
            this.numerotelephoneDataGridViewTextBoxColumn.HeaderText = "numero_telephone";
            this.numerotelephoneDataGridViewTextBoxColumn.Name = "numerotelephoneDataGridViewTextBoxColumn";
            // 
            // datenaissanceDataGridViewTextBoxColumn
            // 
            this.datenaissanceDataGridViewTextBoxColumn.DataPropertyName = "date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn.HeaderText = "date_naissance";
            this.datenaissanceDataGridViewTextBoxColumn.Name = "datenaissanceDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // mDPDataGridViewTextBoxColumn
            // 
            this.mDPDataGridViewTextBoxColumn.DataPropertyName = "MDP";
            this.mDPDataGridViewTextBoxColumn.HeaderText = "MDP";
            this.mDPDataGridViewTextBoxColumn.Name = "mDPDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.utilisateurs_offres_reservationsDataSet;
            // 
            // utilisateurs_offres_reservationsDataSet
            // 
            this.utilisateurs_offres_reservationsDataSet.DataSetName = "utilisateurs_offres_reservationsDataSet";
            this.utilisateurs_offres_reservationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // authen_consult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1173, 299);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "authen_consult";
            this.Text = "authen_consult";
            this.Load += new System.EventHandler(this.authen_consult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurs_offres_reservationsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private utilisateurs_offres_reservationsDataSet utilisateurs_offres_reservationsDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerotelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private utilisateurs_offres_reservationsDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
    }
}