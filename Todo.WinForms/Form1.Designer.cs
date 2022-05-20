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
            this.MainTC.Location = new System.Drawing.Point(14, 16);
            this.MainTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTC.Name = "MainTC";
            this.MainTC.SelectedIndex = 0;
            this.MainTC.Size = new System.Drawing.Size(993, 593);
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
            this.ImportantTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportantTP.Name = "ImportantTP";
            this.ImportantTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportantTP.Size = new System.Drawing.Size(985, 565);
            this.ImportantTP.TabIndex = 0;
            this.ImportantTP.Text = "Важное";
            this.ImportantTP.UseVisualStyleBackColor = true;
            // 
            // ImptNoUrgtLbl
            // 
            this.ImptNoUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImptNoUrgtLbl.Location = new System.Drawing.Point(523, 4);
            this.ImptNoUrgtLbl.Name = "ImptNoUrgtLbl";
            this.ImptNoUrgtLbl.Size = new System.Drawing.Size(450, 20);
            this.ImptNoUrgtLbl.TabIndex = 7;
            this.ImptNoUrgtLbl.Text = "Важное и не срочное";
            this.ImptNoUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImptUrgtLbl
            // 
            this.ImptUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImptUrgtLbl.Location = new System.Drawing.Point(12, 4);
            this.ImptUrgtLbl.Name = "ImptUrgtLbl";
            this.ImptUrgtLbl.Size = new System.Drawing.Size(448, 20);
            this.ImptUrgtLbl.TabIndex = 6;
            this.ImptUrgtLbl.Text = "Важное и срочное";
            this.ImptUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImptNoUrgtCLB
            // 
            this.ImptNoUrgtCLB.FormattingEnabled = true;
            this.ImptNoUrgtCLB.Location = new System.Drawing.Point(523, 30);
            this.ImptNoUrgtCLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImptNoUrgtCLB.Name = "ImptNoUrgtCLB";
            this.ImptNoUrgtCLB.Size = new System.Drawing.Size(450, 268);
            this.ImptNoUrgtCLB.TabIndex = 5;
            // 
            // CreateImportantTodoPnl
            // 
            this.CreateImportantTodoPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateImportantTodoPnl.Controls.Add(this.ImportantTB);
            this.CreateImportantTodoPnl.Controls.Add(this.CreateImptTdBtn);
            this.CreateImportantTodoPnl.Controls.Add(this.ImportantTodoNameLbl);
            this.CreateImportantTodoPnl.Location = new System.Drawing.Point(0, 340);
            this.CreateImportantTodoPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateImportantTodoPnl.Name = "CreateImportantTodoPnl";
            this.CreateImportantTodoPnl.Size = new System.Drawing.Size(985, 221);
            this.CreateImportantTodoPnl.TabIndex = 4;
            // 
            // ImportantTB
            // 
            this.ImportantTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportantTB.Location = new System.Drawing.Point(11, 27);
            this.ImportantTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportantTB.Multiline = true;
            this.ImportantTB.Name = "ImportantTB";
            this.ImportantTB.Size = new System.Drawing.Size(962, 136);
            this.ImportantTB.TabIndex = 0;
            // 
            // CreateImptTdBtn
            // 
            this.CreateImptTdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateImptTdBtn.Location = new System.Drawing.Point(11, 175);
            this.CreateImptTdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateImptTdBtn.Name = "CreateImptTdBtn";
            this.CreateImptTdBtn.Size = new System.Drawing.Size(86, 31);
            this.CreateImptTdBtn.TabIndex = 2;
            this.CreateImptTdBtn.Text = "Создать";
            this.CreateImptTdBtn.UseVisualStyleBackColor = true;
            this.CreateImptTdBtn.Click += new System.EventHandler(this.CreateImptTdBtn_Click);
            // 
            // ImportantTodoNameLbl
            // 
            this.ImportantTodoNameLbl.AutoSize = true;
            this.ImportantTodoNameLbl.Location = new System.Drawing.Point(11, 3);
            this.ImportantTodoNameLbl.Name = "ImportantTodoNameLbl";
            this.ImportantTodoNameLbl.Size = new System.Drawing.Size(129, 20);
            this.ImportantTodoNameLbl.TabIndex = 1;
            this.ImportantTodoNameLbl.Text = "Название задачи";
            // 
            // ImptUrgtCLB
            // 
            this.ImptUrgtCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImptUrgtCLB.FormattingEnabled = true;
            this.ImptUrgtCLB.Location = new System.Drawing.Point(12, 30);
            this.ImptUrgtCLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImptUrgtCLB.Name = "ImptUrgtCLB";
            this.ImptUrgtCLB.Size = new System.Drawing.Size(448, 268);
            this.ImptUrgtCLB.TabIndex = 1;
            this.ImptUrgtCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ImportantAndUrgentCLB_ItemCheck);
            // 
            // NotImportantTP
            // 
            this.NotImportantTP.Controls.Add(this.NoImptNoUrgtLbl);
            this.NotImportantTP.Controls.Add(this.NoImpUrgtLbl);
            this.NotImportantTP.Controls.Add(this.NoImptNoUrgtCLB);
            this.NotImportantTP.Controls.Add(this.NoImptUrgtCLB);
            this.NotImportantTP.Controls.Add(this.NotImportantPnl);
            this.NotImportantTP.Location = new System.Drawing.Point(4, 24);
            this.NotImportantTP.Name = "NotImportantTP";
            this.NotImportantTP.Size = new System.Drawing.Size(985, 565);
            this.NotImportantTP.TabIndex = 2;
            this.NotImportantTP.Text = "Не важное";
            this.NotImportantTP.UseVisualStyleBackColor = true;
            this.NotImportantTP.Paint += new System.Windows.Forms.PaintEventHandler(this.NotImportantTP_Paint);
            // 
            // NoImptNoUrgtLbl
            // 
            this.NoImptNoUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoImptNoUrgtLbl.Location = new System.Drawing.Point(523, 4);
            this.NoImptNoUrgtLbl.Name = "NoImptNoUrgtLbl";
            this.NoImptNoUrgtLbl.Size = new System.Drawing.Size(450, 20);
            this.NoImptNoUrgtLbl.TabIndex = 11;
            this.NoImptNoUrgtLbl.Text = "Не срочное и не важное";
            this.NoImptNoUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoImpUrgtLbl
            // 
            this.NoImpUrgtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoImpUrgtLbl.Location = new System.Drawing.Point(12, 4);
            this.NoImpUrgtLbl.Name = "NoImpUrgtLbl";
            this.NoImpUrgtLbl.Size = new System.Drawing.Size(448, 20);
            this.NoImpUrgtLbl.TabIndex = 10;
            this.NoImpUrgtLbl.Text = "Срочное не важное ";
            this.NoImpUrgtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoImptNoUrgtCLB
            // 
            this.NoImptNoUrgtCLB.FormattingEnabled = true;
            this.NoImptNoUrgtCLB.Location = new System.Drawing.Point(523, 30);
            this.NoImptNoUrgtCLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoImptNoUrgtCLB.Name = "NoImptNoUrgtCLB";
            this.NoImptNoUrgtCLB.Size = new System.Drawing.Size(450, 268);
            this.NoImptNoUrgtCLB.TabIndex = 9;
            // 
            // NoImptUrgtCLB
            // 
            this.NoImptUrgtCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoImptUrgtCLB.FormattingEnabled = true;
            this.NoImptUrgtCLB.Location = new System.Drawing.Point(12, 30);
            this.NoImptUrgtCLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoImptUrgtCLB.Name = "NoImptUrgtCLB";
            this.NoImptUrgtCLB.Size = new System.Drawing.Size(448, 268);
            this.NoImptUrgtCLB.TabIndex = 8;
            // 
            // NotImportantPnl
            // 
            this.NotImportantPnl.Controls.Add(this.NotImportantTB);
            this.NotImportantPnl.Controls.Add(this.CreateNoImptTdBtn);
            this.NotImportantPnl.Controls.Add(this.NoImptTodoNameLbl);
            this.NotImportantPnl.Location = new System.Drawing.Point(0, 339);
            this.NotImportantPnl.Name = "NotImportantPnl";
            this.NotImportantPnl.Size = new System.Drawing.Size(985, 225);
            this.NotImportantPnl.TabIndex = 6;
            // 
            // NotImportantTB
            // 
            this.NotImportantTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotImportantTB.Location = new System.Drawing.Point(12, 28);
            this.NotImportantTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NotImportantTB.Multiline = true;
            this.NotImportantTB.Name = "NotImportantTB";
            this.NotImportantTB.Size = new System.Drawing.Size(962, 140);
            this.NotImportantTB.TabIndex = 3;
            // 
            // CreateNoImptTdBtn
            // 
            this.CreateNoImptTdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateNoImptTdBtn.Location = new System.Drawing.Point(12, 180);
            this.CreateNoImptTdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateNoImptTdBtn.Name = "CreateNoImptTdBtn";
            this.CreateNoImptTdBtn.Size = new System.Drawing.Size(86, 31);
            this.CreateNoImptTdBtn.TabIndex = 5;
            this.CreateNoImptTdBtn.Text = "Создать";
            this.CreateNoImptTdBtn.UseVisualStyleBackColor = true;
            // 
            // NoImptTodoNameLbl
            // 
            this.NoImptTodoNameLbl.AutoSize = true;
            this.NoImptTodoNameLbl.Location = new System.Drawing.Point(12, 4);
            this.NoImptTodoNameLbl.Name = "NoImptTodoNameLbl";
            this.NoImptTodoNameLbl.Size = new System.Drawing.Size(129, 20);
            this.NoImptTodoNameLbl.TabIndex = 4;
            this.NoImptTodoNameLbl.Text = "Название задачи";
            // 
            // StatiscticTP
            // 
            this.StatiscticTP.Location = new System.Drawing.Point(4, 24);
            this.StatiscticTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatiscticTP.Name = "StatiscticTP";
            this.StatiscticTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatiscticTP.Size = new System.Drawing.Size(985, 565);
            this.StatiscticTP.TabIndex = 1;
            this.StatiscticTP.Text = "Статистика";
            this.StatiscticTP.UseVisualStyleBackColor = true;
            // 
            // CompletedTP
            // 
            this.CompletedTP.Location = new System.Drawing.Point(4, 24);
            this.CompletedTP.Name = "CompletedTP";
            this.CompletedTP.Size = new System.Drawing.Size(985, 565);
            this.CompletedTP.TabIndex = 3;
            this.CompletedTP.Text = "Выполненное";
            this.CompletedTP.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 640);
            this.Controls.Add(this.MainTC);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}