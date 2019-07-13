namespace Kartoteka
{
    partial class Streets
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.streetstbl = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streetstbl)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.streetstbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.delbtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Street, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.89744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.10256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // streetstbl
            // 
            this.streetstbl.AllowUserToAddRows = false;
            this.streetstbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.streetstbl, 2);
            this.streetstbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetstbl.Location = new System.Drawing.Point(3, 3);
            this.streetstbl.Name = "streetstbl";
            this.streetstbl.ReadOnly = true;
            this.streetstbl.Size = new System.Drawing.Size(243, 128);
            this.streetstbl.TabIndex = 0;
            this.streetstbl.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.streetstbl_CellMouseClick);
            this.streetstbl.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.streetstbl_RowHeaderMouseClick);
            // 
            // addbtn
            // 
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.Location = new System.Drawing.Point(3, 184);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(117, 32);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delbtn.Location = new System.Drawing.Point(126, 184);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(120, 32);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "Удалить";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Улица:";
            // 
            // txt_Street
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Street, 2);
            this.txt_Street.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Street.Location = new System.Drawing.Point(3, 159);
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(243, 20);
            this.txt_Street.TabIndex = 7;
            // 
            // Streets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 219);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "Streets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Улицы";
            this.Shown += new System.EventHandler(this.Streets_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streetstbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView streetstbl;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Street;
    }
}