namespace WindowsFormsBiblio
{
    partial class FormEmpEnCours
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcdStChristopheDataSet1 = new WindowsFormsBiblio.bcdStChristopheDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classeTableAdapter1 = new WindowsFormsBiblio.bcdStChristopheDataSetTableAdapters.ClasseTableAdapter();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcdStChristopheDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classeBindingSource1;
            this.comboBox1.DisplayMember = "Nomclasse";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Nomclasse";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // classeBindingSource1
            // 
            this.classeBindingSource1.DataMember = "Classe";
            this.classeBindingSource1.DataSource = this.bcdStChristopheDataSet1;
            // 
            // bcdStChristopheDataSet1
            // 
            this.bcdStChristopheDataSet1.DataSetName = "bcdStChristopheDataSet";
            this.bcdStChristopheDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Learning Curve", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez la classe";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 629);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prénom";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Titre";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date d\'emprunt";
            this.columnHeader4.Width = 87;
            // 
            // classeTableAdapter1
            // 
            this.classeTableAdapter1.ClearBeforeFill = true;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(WindowsFormsBiblio.AdoBcdSc);
            // 
            // FormEmpEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 712);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 150);
            this.Name = "FormEmpEnCours";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Emprunts en cours";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmprunts_FormClosed);
            this.Load += new System.EventHandler(this.FormEmpEnCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcdStChristopheDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private bcdStChristopheDataSet bcdStChristopheDataSet;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private bcdStChristopheDataSetTableAdapters.ClasseTableAdapter classeTableAdapter;
        private bcdStChristopheDataSet bcdStChristopheDataSet1;
        private System.Windows.Forms.BindingSource classeBindingSource1;
        private bcdStChristopheDataSetTableAdapters.ClasseTableAdapter classeTableAdapter1;
    }
}