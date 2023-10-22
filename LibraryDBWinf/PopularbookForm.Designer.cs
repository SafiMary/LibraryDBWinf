namespace LibraryDBWinf
{
    partial class PopularbookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopularbookForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonpopular = new System.Windows.Forms.Button();
            this.buttonUnpopular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonpopular
            // 
            this.buttonpopular.Location = new System.Drawing.Point(12, 418);
            this.buttonpopular.Name = "buttonpopular";
            this.buttonpopular.Size = new System.Drawing.Size(156, 39);
            this.buttonpopular.TabIndex = 1;
            this.buttonpopular.Text = "Популярные книги";
            this.buttonpopular.UseVisualStyleBackColor = true;
            this.buttonpopular.Click += new System.EventHandler(this.buttonpopular_Click);
            // 
            // buttonUnpopular
            // 
            this.buttonUnpopular.Location = new System.Drawing.Point(214, 418);
            this.buttonUnpopular.Name = "buttonUnpopular";
            this.buttonUnpopular.Size = new System.Drawing.Size(156, 39);
            this.buttonUnpopular.TabIndex = 2;
            this.buttonUnpopular.Text = "Непопулярные книги";
            this.buttonUnpopular.UseVisualStyleBackColor = true;
            this.buttonUnpopular.Click += new System.EventHandler(this.buttonUnpopular_Click);
            // 
            // PopularbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.buttonUnpopular);
            this.Controls.Add(this.buttonpopular);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "PopularbookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейтинг книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonpopular;
        private System.Windows.Forms.Button buttonUnpopular;
    }
}