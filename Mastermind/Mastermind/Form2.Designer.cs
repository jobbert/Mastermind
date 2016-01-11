namespace Mastermind
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        */

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            //this.mastermindHighscoreDataSet = new Mastermind.mastermindHighscoreDataSet();
            this.highscoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.highscoreTableAdapter = new Mastermind.mastermindHighscoreDataSetTableAdapters.highscoreTableAdapter();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tijdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.mastermindHighscoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).BeginInit();
            //this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naamDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.tijdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highscoreBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // mastermindHighscoreDataSet
            // 
            //this.mastermindHighscoreDataSet.DataSetName = "mastermindHighscoreDataSet";
            //this.mastermindHighscoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highscoreBindingSource
            // 
            this.highscoreBindingSource.DataMember = "highscore";
            //this.highscoreBindingSource.DataSource = this.mastermindHighscoreDataSet;
            // 
            // highscoreTableAdapter
            // 
            //this.highscoreTableAdapter.ClearBeforeFill = true;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "naam";
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tijdDataGridViewTextBoxColumn
            // 
            this.tijdDataGridViewTextBoxColumn.DataPropertyName = "tijd";
            this.tijdDataGridViewTextBoxColumn.HeaderText = "tijd";
            this.tijdDataGridViewTextBoxColumn.Name = "tijdDataGridViewTextBoxColumn";
            this.tijdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            /*
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastermindHighscoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            */
        }

        #endregion
        // private mastermindHighscoreDataSet mastermindHighscoreDataSet;
        private System.Windows.Forms.BindingSource highscoreBindingSource;
        // private mastermindHighscoreDataSetTableAdapters.highscoreTableAdapter highscoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tijdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}