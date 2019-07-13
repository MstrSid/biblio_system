namespace Kartoteka
{
    partial class Zaved
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
            this.mrabtbl = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Zaved = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrabtbl)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mrabtbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Zaved, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.delbtn, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mrabtbl
            // 
            this.mrabtbl.AllowUserToAddRows = false;
            this.mrabtbl.AllowUserToDeleteRows = false;
            this.mrabtbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.mrabtbl, 2);
            this.mrabtbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrabtbl.Location = new System.Drawing.Point(3, 3);
            this.mrabtbl.Name = "mrabtbl";
            this.mrabtbl.Size = new System.Drawing.Size(278, 170);
            this.mrabtbl.TabIndex = 0;
            this.mrabtbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mrabtbl_CellContentClick);
            this.mrabtbl.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mrabtbl_CellContentDoubleClick);
            this.mrabtbl.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mrabtbl_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Инфо";
            // 
            // txt_Zaved
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Zaved, 2);
            this.txt_Zaved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Zaved.Location = new System.Drawing.Point(3, 201);
            this.txt_Zaved.Name = "txt_Zaved";
            this.txt_Zaved.Size = new System.Drawing.Size(278, 20);
            this.txt_Zaved.TabIndex = 2;
            // 
            // addbtn
            // 
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.Location = new System.Drawing.Point(3, 226);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(136, 33);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delbtn.Location = new System.Drawing.Point(145, 226);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(136, 33);
            this.delbtn.TabIndex = 4;
            this.delbtn.Text = "Удалить";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Zaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Zaved";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заведующих";
            this.Shown += new System.EventHandler(this.Mrab_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrabtbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView mrabtbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Zaved;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
    }
}