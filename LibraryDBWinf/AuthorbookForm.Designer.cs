namespace LibraryDBWinf
{
    partial class AuthorbookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorbookForm));
            this.labelauthor = new System.Windows.Forms.Label();
            this.textBoxauthor = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelInstock = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxInstock = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelauthor
            // 
            this.labelauthor.AutoSize = true;
            this.labelauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelauthor.Location = new System.Drawing.Point(68, 32);
            this.labelauthor.Name = "labelauthor";
            this.labelauthor.Size = new System.Drawing.Size(216, 25);
            this.labelauthor.TabIndex = 0;
            this.labelauthor.Text = "Введите автора книги";
            // 
            // textBoxauthor
            // 
            this.textBoxauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxauthor.Location = new System.Drawing.Point(12, 60);
            this.textBoxauthor.Name = "textBoxauthor";
            this.textBoxauthor.Size = new System.Drawing.Size(348, 34);
            this.textBoxauthor.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(129, 159);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 53);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            // textBoxInstock
            // 
            this.textBoxInstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstock.Location = new System.Drawing.Point(12, 297);
            this.textBoxInstock.Name = "textBoxInstock";
            this.textBoxInstock.Size = new System.Drawing.Size(348, 34);
            this.textBoxInstock.TabIndex = 1;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(105, 397);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(142, 34);
            this.textBoxCount.TabIndex = 1;
            // 
            // AuthorbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxInstock);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxauthor);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelInstock);
            this.Controls.Add(this.labelauthor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "AuthorbookForm";
            this.Text = "Поиск книги по автору";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelauthor;
        private System.Windows.Forms.TextBox textBoxauthor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelInstock;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxInstock;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}