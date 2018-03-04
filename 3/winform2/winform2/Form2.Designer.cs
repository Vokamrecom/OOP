namespace winform2
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
            this.Poisk = new System.Windows.Forms.Button();
            this.ClearPoisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PoiskNomera = new System.Windows.Forms.TextBox();
            this.PoiskFamilia = new System.Windows.Forms.TextBox();
            this.PoiskBalans = new System.Windows.Forms.TextBox();
            this.PoiskTypeOperation = new System.Windows.Forms.ComboBox();
            this.SearchResult_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Poisk
            // 
            this.Poisk.Location = new System.Drawing.Point(69, 320);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(145, 49);
            this.Poisk.TabIndex = 0;
            this.Poisk.Text = "Искать";
            this.Poisk.UseVisualStyleBackColor = true;
            this.Poisk.Click += new System.EventHandler(this.Poisk_Click);
            // 
            // ClearPoisk
            // 
            this.ClearPoisk.Location = new System.Drawing.Point(269, 320);
            this.ClearPoisk.Name = "ClearPoisk";
            this.ClearPoisk.Size = new System.Drawing.Size(145, 49);
            this.ClearPoisk.TabIndex = 1;
            this.ClearPoisk.Text = "Очистить поля";
            this.ClearPoisk.UseVisualStyleBackColor = true;
            this.ClearPoisk.Click += new System.EventHandler(this.ClearPoisk_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите, что вы хотите найти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "По номеру счета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "По фамилии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "По балансу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тип операции";
            // 
            // PoiskNomera
            // 
            this.PoiskNomera.Location = new System.Drawing.Point(272, 119);
            this.PoiskNomera.Name = "PoiskNomera";
            this.PoiskNomera.Size = new System.Drawing.Size(131, 22);
            this.PoiskNomera.TabIndex = 7;
            // 
            // PoiskFamilia
            // 
            this.PoiskFamilia.Location = new System.Drawing.Point(491, 193);
            this.PoiskFamilia.Name = "PoiskFamilia";
            this.PoiskFamilia.Size = new System.Drawing.Size(131, 22);
            this.PoiskFamilia.TabIndex = 8;
            // 
            // PoiskBalans
            // 
            this.PoiskBalans.Location = new System.Drawing.Point(272, 179);
            this.PoiskBalans.Name = "PoiskBalans";
            this.PoiskBalans.Size = new System.Drawing.Size(131, 22);
            this.PoiskBalans.TabIndex = 9;
            // 
            // PoiskTypeOperation
            // 
            this.PoiskTypeOperation.FormattingEnabled = true;
            this.PoiskTypeOperation.Location = new System.Drawing.Point(272, 233);
            this.PoiskTypeOperation.Name = "PoiskTypeOperation";
            this.PoiskTypeOperation.Size = new System.Drawing.Size(131, 24);
            this.PoiskTypeOperation.TabIndex = 10;
            // 
            // SearchResult_List
            // 
            this.SearchResult_List.FormattingEnabled = true;
            this.SearchResult_List.ItemHeight = 16;
            this.SearchResult_List.Location = new System.Drawing.Point(2, 420);
            this.SearchResult_List.Name = "SearchResult_List";
            this.SearchResult_List.Size = new System.Drawing.Size(497, 100);
            this.SearchResult_List.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 517);
            this.Controls.Add(this.SearchResult_List);
            this.Controls.Add(this.PoiskTypeOperation);
            this.Controls.Add(this.PoiskBalans);
            this.Controls.Add(this.PoiskFamilia);
            this.Controls.Add(this.PoiskNomera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearPoisk);
            this.Controls.Add(this.Poisk);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Poisk;
        private System.Windows.Forms.Button ClearPoisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PoiskNomera;
        private System.Windows.Forms.TextBox PoiskFamilia;
        private System.Windows.Forms.TextBox PoiskBalans;
        private System.Windows.Forms.ComboBox PoiskTypeOperation;
        private System.Windows.Forms.ListBox SearchResult_List;
    }
}