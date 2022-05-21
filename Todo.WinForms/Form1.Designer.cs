namespace Todos.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTC = new System.Windows.Forms.TabControl();
            this.ImportantTP = new System.Windows.Forms.TabPage();
            this.ImptNoUrgtLbl = new System.Windows.Forms.Label();
            this.ImptUrgtLbl = new System.Windows.Forms.Label();
            this.ImptNoUrgtCLB = new System.Windows.Forms.CheckedListBox();
            this.CreateImportantTodoPnl = new System.Windows.Forms.Panel();
            this.ChangeImptTodoBtn = new System.Windows.Forms.Button();
            this.ImportantTB = new System.Windows.Forms.TextBox();
            this.CreateImptTdBtn = new System.Windows.Forms.Button();
            this.ImportantTodoNameLbl = new System.Windows.Forms.Label();
            this.ImptUrgtCLB = new System.Windows.Forms.CheckedListBox();
            this.NotImportantTP = new System.Windows.Forms.TabPage();
            this.NoImptNoUrgtLbl = new System.Windows.Forms.Label();
            this.NoImpUrgtLbl = new System.Windows.Forms.Label();
            this.NoImptNoUrgtCLB = new System.Windows.Forms.CheckedListBox();
            this.NoImptUrgtCLB = new System.Windows.Forms.CheckedListBox();
            this.NotImportantPnl = new System.Windows.Forms.Panel();
            this.NotImportantTB = new System.Windows.Forms.TextBox();
            this.CreateNoImptTdBtn = new System.Windows.Forms.Button();
            this.NoImptTodoNameLbl = new System.Windows.Forms.Label();
            this.StatiscticTP = new System.Windows.Forms.TabPage();
            this.CompletedTP = new System.Windows.Forms.TabPage();
            this.MainTC.SuspendLayout();
            this.ImportantTP.SuspendLayout();
            this.CreateImportantTodoPnl.SuspendLayout();
            this.NotImportantTP.SuspendLayout();
            this.NotImportantPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTC
            // 
            this.MainTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTC.Controls.Add(this.ImportantTP);
            this.MainTC.Controls.Add(this.NotImportantTP);
            this.MainTC.Controls.Add(this.StatiscticTP);
            this.MainTC.Controls.Add(this.CompletedTP);
            this.MainTC.ItemSize = new System.Drawing.Size(110, 20);
            this.MainTC.Location = new System.Drawing.Point(12, 12);
            this.MainTC.Name = "MainTC";
            this.MainTC.SelectedIndex = 0;
            this.MainTC.Size = new System.Drawing.Size(869, 445);
            this.MainTC.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTC.TabIndex = 0;
            // 
            // ImportantTP
            // 
            this.ImportantTP.Controls.Add(this.ImptNoUrgtLbl);
            this.ImportantTP.Controls.Add(this.ImptUrgtLbl);
            this.ImportantTP.Controls.Add(this.ImptNoUrgtCLB);
            this.ImportantTP.Controls.Add(this.CreateImportantTodoPnl);
            this.ImportantTP.Controls.Add(this.ImptUrgtCLB);
            this.ImportantTP.Location = new System.Drawing.Point(4, 24);
            this.ImportantTP.Name = "ImportantTP";
            this.ImportantTP.Padding = new System.Windows.Forms.Padding(3);
            this.ImportantTP.Size = new System.Drawing.Size(861, 417);
            this.ImportantTP.TabIndex = 0;
            this.ImportantTP.Text = "Важное";
            this.ImportantTP.UseVisualStyleBackColor = true;
            this.ImportantTP.Paint += new System.Windows.Forms.PaintEventHandler(this.ImportantTP_Paint);
            // 
            // ImptNoUrgtLbl
            // 
            this.ImptNoUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImptNoUrgtLbl.Location = new System.Drawing.Point(458, 3);
            this.ImptNoUrgtLbl.Name = "ImptNoUrgtLbl";
            this.ImptNoUrgtLbl.Size = new System.Drawing.Size(394, 15);
            this.ImptNoUrgtLbl.TabIndex = 7;
            this.ImptNoUrgtLbl.Text = "Важное и не срочное";
            this.ImptNoUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImptUrgtLbl
            // 
            this.ImptUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImptUrgtLbl.Location = new System.Drawing.Point(10, 3);
            this.ImptUrgtLbl.Name = "ImptUrgtLbl";
            this.ImptUrgtLbl.Size = new System.Drawing.Size(392, 15);
            this.ImptUrgtLbl.TabIndex = 6;
            this.ImptUrgtLbl.Text = "Важное и срочное";
            this.ImptUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImptNoUrgtCLB
            // 
            this.ImptNoUrgtCLB.FormattingEnabled = true;
            this.ImptNoUrgtCLB.Location = new System.Drawing.Point(458, 22);
            this.ImptNoUrgtCLB.Name = "ImptNoUrgtCLB";
            this.ImptNoUrgtCLB.Size = new System.Drawing.Size(394, 202);
            this.ImptNoUrgtCLB.TabIndex = 5;
            // 
            // CreateImportantTodoPnl
            // 
            this.CreateImportantTodoPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateImportantTodoPnl.Controls.Add(this.ChangeImptTodoBtn);
            this.CreateImportantTodoPnl.Controls.Add(this.ImportantTB);
            this.CreateImportantTodoPnl.Controls.Add(this.CreateImptTdBtn);
            this.CreateImportantTodoPnl.Controls.Add(this.ImportantTodoNameLbl);
            this.CreateImportantTodoPnl.Location = new System.Drawing.Point(0, 255);
            this.CreateImportantTodoPnl.Name = "CreateImportantTodoPnl";
            this.CreateImportantTodoPnl.Size = new System.Drawing.Size(862, 166);
            this.CreateImportantTodoPnl.TabIndex = 4;
            // 
            // ChangeImptTodoBtn
            // 
            this.ChangeImptTodoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeImptTodoBtn.Location = new System.Drawing.Point(91, 131);
            this.ChangeImptTodoBtn.Name = "ChangeImptTodoBtn";
            this.ChangeImptTodoBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeImptTodoBtn.TabIndex = 3;
            this.ChangeImptTodoBtn.Text = "Изменить";
            this.ChangeImptTodoBtn.UseVisualStyleBackColor = true;
            this.ChangeImptTodoBtn.Click += new System.EventHandler(this.ChangeImptTodoBtn_Click);
            // 
            // ImportantTB
            // 
            this.ImportantTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportantTB.Location = new System.Drawing.Point(10, 20);
            this.ImportantTB.Multiline = true;
            this.ImportantTB.Name = "ImportantTB";
            this.ImportantTB.Size = new System.Drawing.Size(842, 103);
            this.ImportantTB.TabIndex = 0;
            // 
            // CreateImptTdBtn
            // 
            this.CreateImptTdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateImptTdBtn.Location = new System.Drawing.Point(10, 131);
            this.CreateImptTdBtn.Name = "CreateImptTdBtn";
            this.CreateImptTdBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateImptTdBtn.TabIndex = 2;
            this.CreateImptTdBtn.Text = "Создать";
            this.CreateImptTdBtn.UseVisualStyleBackColor = true;
            this.CreateImptTdBtn.Click += new System.EventHandler(this.CreateImptTdBtn_Click);
            // 
            // ImportantTodoNameLbl
            // 
            this.ImportantTodoNameLbl.AutoSize = true;
            this.ImportantTodoNameLbl.Location = new System.Drawing.Point(10, 2);
            this.ImportantTodoNameLbl.Name = "ImportantTodoNameLbl";
            this.ImportantTodoNameLbl.Size = new System.Drawing.Size(99, 15);
            this.ImportantTodoNameLbl.TabIndex = 1;
            this.ImportantTodoNameLbl.Text = "Название задачи";
            // 
            // ImptUrgtCLB
            // 
            this.ImptUrgtCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImptUrgtCLB.FormattingEnabled = true;
            this.ImptUrgtCLB.Location = new System.Drawing.Point(10, 22);
            this.ImptUrgtCLB.Name = "ImptUrgtCLB";
            this.ImptUrgtCLB.Size = new System.Drawing.Size(392, 202);
            this.ImptUrgtCLB.TabIndex = 1;
            this.ImptUrgtCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ImptUrgtCLB_ItemCheck);
            this.ImptUrgtCLB.SelectedIndexChanged += new System.EventHandler(this.ImptUrgtCLB_SelectedIndexChanged);
            this.ImptUrgtCLB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImptUrgtCLB_KeyUp);
            // 
            // NotImportantTP
            // 
            this.NotImportantTP.Controls.Add(this.NoImptNoUrgtLbl);
            this.NotImportantTP.Controls.Add(this.NoImpUrgtLbl);
            this.NotImportantTP.Controls.Add(this.NoImptNoUrgtCLB);
            this.NotImportantTP.Controls.Add(this.NoImptUrgtCLB);
            this.NotImportantTP.Controls.Add(this.NotImportantPnl);
            this.NotImportantTP.Location = new System.Drawing.Point(4, 24);
            this.NotImportantTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotImportantTP.Name = "NotImportantTP";
            this.NotImportantTP.Size = new System.Drawing.Size(861, 417);
            this.NotImportantTP.TabIndex = 2;
            this.NotImportantTP.Text = "Не важное";
            this.NotImportantTP.UseVisualStyleBackColor = true;
            // 
            // NoImptNoUrgtLbl
            // 
            this.NoImptNoUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoImptNoUrgtLbl.Location = new System.Drawing.Point(458, 3);
            this.NoImptNoUrgtLbl.Name = "NoImptNoUrgtLbl";
            this.NoImptNoUrgtLbl.Size = new System.Drawing.Size(394, 15);
            this.NoImptNoUrgtLbl.TabIndex = 11;
            this.NoImptNoUrgtLbl.Text = "Не срочное и не важное";
            this.NoImptNoUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoImpUrgtLbl
            // 
            this.NoImpUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoImpUrgtLbl.Location = new System.Drawing.Point(10, 3);
            this.NoImpUrgtLbl.Name = "NoImpUrgtLbl";
            this.NoImpUrgtLbl.Size = new System.Drawing.Size(392, 15);
            this.NoImpUrgtLbl.TabIndex = 10;
            this.NoImpUrgtLbl.Text = "Срочное не важное ";
            this.NoImpUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoImptNoUrgtCLB
            // 
            this.NoImptNoUrgtCLB.FormattingEnabled = true;
            this.NoImptNoUrgtCLB.Location = new System.Drawing.Point(458, 22);
            this.NoImptNoUrgtCLB.Name = "NoImptNoUrgtCLB";
            this.NoImptNoUrgtCLB.Size = new System.Drawing.Size(394, 202);
            this.NoImptNoUrgtCLB.TabIndex = 9;
            // 
            // NoImptUrgtCLB
            // 
            this.NoImptUrgtCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoImptUrgtCLB.FormattingEnabled = true;
            this.NoImptUrgtCLB.Location = new System.Drawing.Point(10, 22);
            this.NoImptUrgtCLB.Name = "NoImptUrgtCLB";
            this.NoImptUrgtCLB.Size = new System.Drawing.Size(392, 202);
            this.NoImptUrgtCLB.TabIndex = 8;
            // 
            // NotImportantPnl
            // 
            this.NotImportantPnl.Controls.Add(this.NotImportantTB);
            this.NotImportantPnl.Controls.Add(this.CreateNoImptTdBtn);
            this.NotImportantPnl.Controls.Add(this.NoImptTodoNameLbl);
            this.NotImportantPnl.Location = new System.Drawing.Point(0, 254);
            this.NotImportantPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotImportantPnl.Name = "NotImportantPnl";
            this.NotImportantPnl.Size = new System.Drawing.Size(862, 169);
            this.NotImportantPnl.TabIndex = 6;
            // 
            // NotImportantTB
            // 
            this.NotImportantTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotImportantTB.Location = new System.Drawing.Point(10, 21);
            this.NotImportantTB.Multiline = true;
            this.NotImportantTB.Name = "NotImportantTB";
            this.NotImportantTB.Size = new System.Drawing.Size(842, 103);
            this.NotImportantTB.TabIndex = 3;
            // 
            // CreateNoImptTdBtn
            // 
            this.CreateNoImptTdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateNoImptTdBtn.Location = new System.Drawing.Point(10, 132);
            this.CreateNoImptTdBtn.Name = "CreateNoImptTdBtn";
            this.CreateNoImptTdBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateNoImptTdBtn.TabIndex = 5;
            this.CreateNoImptTdBtn.Text = "Создать";
            this.CreateNoImptTdBtn.UseVisualStyleBackColor = true;
            // 
            // NoImptTodoNameLbl
            // 
            this.NoImptTodoNameLbl.AutoSize = true;
            this.NoImptTodoNameLbl.Location = new System.Drawing.Point(10, 3);
            this.NoImptTodoNameLbl.Name = "NoImptTodoNameLbl";
            this.NoImptTodoNameLbl.Size = new System.Drawing.Size(99, 15);
            this.NoImptTodoNameLbl.TabIndex = 4;
            this.NoImptTodoNameLbl.Text = "Название задачи";
            // 
            // StatiscticTP
            // 
            this.StatiscticTP.Location = new System.Drawing.Point(4, 24);
            this.StatiscticTP.Name = "StatiscticTP";
            this.StatiscticTP.Padding = new System.Windows.Forms.Padding(3);
            this.StatiscticTP.Size = new System.Drawing.Size(861, 417);
            this.StatiscticTP.TabIndex = 1;
            this.StatiscticTP.Text = "Статистика";
            this.StatiscticTP.UseVisualStyleBackColor = true;
            // 
            // CompletedTP
            // 
            this.CompletedTP.Location = new System.Drawing.Point(4, 24);
            this.CompletedTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompletedTP.Name = "CompletedTP";
            this.CompletedTP.Size = new System.Drawing.Size(861, 417);
            this.CompletedTP.TabIndex = 3;
            this.CompletedTP.Text = "Выполненное";
            this.CompletedTP.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 480);
            this.Controls.Add(this.MainTC);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTC.ResumeLayout(false);
            this.ImportantTP.ResumeLayout(false);
            this.CreateImportantTodoPnl.ResumeLayout(false);
            this.CreateImportantTodoPnl.PerformLayout();
            this.NotImportantTP.ResumeLayout(false);
            this.NotImportantPnl.ResumeLayout(false);
            this.NotImportantPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTC;
        private TabPage ImportantTP;
        private TabPage StatiscticTP;
        private CheckedListBox ImptUrgtCLB;
        private Panel CreateImportantTodoPnl;
        private TextBox ImportantTB;
        private Button CreateImptTdBtn;
        private Label ImportantTodoNameLbl;
        private CheckedListBox ImptNoUrgtCLB;
        private TabPage NotImportantTP;
        private Label ImptNoUrgtLbl;
        private Label ImptUrgtLbl;
        private Panel NotImportantPnl;
        private TextBox NotImportantTB;
        private Button CreateNoImptTdBtn;
        private Label NoImptTodoNameLbl;
        private TabPage CompletedTP;
        private Label NoImptNoUrgtLbl;
        private Label NoImpUrgtLbl;
        private CheckedListBox NoImptNoUrgtCLB;
        private CheckedListBox NoImptUrgtCLB;
        private Button ChangeImptTodoBtn;
    }
}