namespace Kartoteka
{
    partial class Books
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bookstbl = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Shifr = new System.Windows.Forms.TextBox();
            this.txt_Avtor = new System.Windows.Forms.TextBox();
            this.txt_Nazv = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookstbl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.06464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.93536F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.bookstbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Shifr, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Avtor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nazv, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.updbtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.delbtn, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.28205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bookstbl
            // 
            this.bookstbl.AllowUserToAddRows = false;
            this.bookstbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.bookstbl, 3);
            this.bookstbl.ContextMenuStrip = this.contextMenuStrip1;
            this.bookstbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookstbl.Location = new System.Drawing.Point(3, 3);
            this.bookstbl.Name = "bookstbl";
            this.bookstbl.Size = new System.Drawing.Size(278, 167);
            this.bookstbl.TabIndex = 0;
            this.bookstbl.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookstbl_RowHeaderMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Инв. №";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название";
            // 
            // txt_Shifr
            // 
            this.txt_Shifr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Shifr.Location = new System.Drawing.Point(3, 198);
            this.txt_Shifr.Name = "txt_Shifr";
            this.txt_Shifr.Size = new System.Drawing.Size(73, 20);
            this.txt_Shifr.TabIndex = 4;
            // 
            // txt_Avtor
            // 
            this.txt_Avtor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Avtor.Location = new System.Drawing.Point(82, 198);
            this.txt_Avtor.Name = "txt_Avtor";
            this.txt_Avtor.Size = new System.Drawing.Size(108, 20);
            this.txt_Avtor.TabIndex = 5;
            // 
            // txt_Nazv
            // 
            this.txt_Nazv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Nazv.Location = new System.Drawing.Point(196, 198);
            this.txt_Nazv.Name = "txt_Nazv";
            this.txt_Nazv.Size = new System.Drawing.Size(85, 20);
            this.txt_Nazv.TabIndex = 6;
            // 
            // addbtn
            // 
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.Location = new System.Drawing.Point(3, 234);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(73, 25);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updbtn.Location = new System.Drawing.Point(82, 234);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(108, 25);
            this.updbtn.TabIndex = 8;
            this.updbtn.Text = "Обновить";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delbtn.Location = new System.Drawing.Point(196, 234);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(85, 25);
            this.delbtn.TabIndex = 9;
            this.delbtn.Text = "Списать";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Shown += new System.EventHandler(this.Books_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookstbl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView bookstbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Shifr;
        private System.Windows.Forms.TextBox txt_Avtor;
        private System.Windows.Forms.TextBox txt_Nazv;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}