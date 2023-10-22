namespace LibraryDBWinf
{
    partial class NamebookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamebookForm));
            this.labelname = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelInstock = new System.Windows.Forms.Label();
            this.textBoxInstock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelname.Location = new System.Drawing.Point(68, 32);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(237, 25);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Введите название книги";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(129, 159);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 53);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxname.Location = new System.Drawing.Point(12, 60);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(358, 34);
            this.textBoxname.TabIndex = 2;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(54, 369);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(265, 25);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Количество книг в наличии";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(114, 397);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(133, 34);
            this.textBoxCount.TabIndex = 2;
            // 
            // labelInstock
            // 
            this.labelInstock.AutoSize = true;
            this.labelInstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstock.Location = new System.Drawing.Point(12, 269);
            this.labelInstock.Name = "labelInstock";
            this.labelInstock.Size = new System.Drawing.Size(369, 25);
            this.labelInstock.TabIndex = 0;
            this.labelInstock.Text = "Информация о наличии данной книги ";
            // 
            // textBoxInstock
            // 
            this.textBoxInstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstock.Location = new System.Drawing.Point(17, 297);
            this.textBoxInstock.Name = "textBoxInstock";
            this.textBoxInstock.Size = new System.Drawing.Size(346, 34);
            this.textBoxInstock.TabIndex = 2;
            // 
            // NamebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.textBoxInstock);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelInstock);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "NamebookForm";
            this.Text = "Поиск книги по названию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelInstock;
        private System.Windows.Forms.TextBox textBoxInstock;
    }
}