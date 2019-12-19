namespace ApplicationWinforms
{
    partial class resultats_recherche
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.utilisateurs_offres_reservationsDataSet = new ApplicationWinforms.utilisateurs_offres_reservationsDataSet();
            this.offreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offreTableAdapter = new ApplicationWinforms.utilisateurs_offres_reservationsDataSetTableAdapters.offreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurs_offres_reservationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // utilisateurs_offres_reservationsDataSet
            // 
            this.utilisateurs_offres_reservationsDataSet.DataSetName = "utilisateurs_offres_reservationsDataSet";
            this.utilisateurs_offres_reservationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offreBindingSource
            // 
            this.offreBindingSource.DataMember = "offre";
            this.offreBindingSource.DataSource = this.utilisateurs_offres_reservationsDataSet;
            // 
            // offreTableAdapter
            // 
            this.offreTableAdapter.ClearBeforeFill = true;
            // 
            // resultats_recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 233);
            this.Controls.Add(this.dataGridView1);
            this.Name = "resultats_recherche";
            this.Text = "resultats_recherche";
            this.Load += new System.EventHandler(this.resultats_recherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurs_offres_reservationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private utilisateurs_offres_reservationsDataSet utilisateurs_offres_reservationsDataSet;
        private System.Windows.Forms.BindingSource offreBindingSource;
        private utilisateurs_offres_reservationsDataSetTableAdapters.offreTableAdapter offreTableAdapter;
    }
}