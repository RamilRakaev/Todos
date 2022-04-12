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
            this.ListTp = new System.Windows.Forms.TabPage();
            this.TodosClb = new System.Windows.Forms.CheckedListBox();
            this.StatiscticTP = new System.Windows.Forms.TabPage();
            this.createTodoPnl = new System.Windows.Forms.Panel();
            this.todoTb = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.TodoNameLbl = new System.Windows.Forms.Label();
            this.MainTC.SuspendLayout();
            this.ListTp.SuspendLayout();
            this.createTodoPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTC
            // 
            this.MainTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTC.Controls.Add(this.ListTp);
            this.MainTC.Controls.Add(this.StatiscticTP);
            this.MainTC.ItemSize = new System.Drawing.Size(110, 20);
            this.MainTC.Location = new System.Drawing.Point(12, 12);
            this.MainTC.Name = "MainTC";
            this.MainTC.SelectedIndex = 0;
            this.MainTC.Size = new System.Drawing.Size(869, 445);
            this.MainTC.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTC.TabIndex = 0;
            // 
            // ListTp
            // 
            this.ListTp.Controls.Add(this.createTodoPnl);
            this.ListTp.Controls.Add(this.TodosClb);
            this.ListTp.Location = new System.Drawing.Point(4, 24);
            this.ListTp.Name = "ListTp";
            this.ListTp.Padding = new System.Windows.Forms.Padding(3);
            this.ListTp.Size = new System.Drawing.Size(861, 417);
            this.ListTp.TabIndex = 0;
            this.ListTp.Text = "Список задач";
            this.ListTp.UseVisualStyleBackColor = true;
            // 
            // TodosClb
            // 
            this.TodosClb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodosClb.FormattingEnabled = true;
            this.TodosClb.Location = new System.Drawing.Point(6, 6);
            this.TodosClb.Name = "TodosClb";
            this.TodosClb.Size = new System.Drawing.Size(846, 220);
            this.TodosClb.TabIndex = 1;
            this.TodosClb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TodosClb_ItemCheck);
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
            // createTodoPnl
            // 
            this.createTodoPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createTodoPnl.Controls.Add(this.todoTb);
            this.createTodoPnl.Controls.Add(this.CreateBtn);
            this.createTodoPnl.Controls.Add(this.TodoNameLbl);
            this.createTodoPnl.Location = new System.Drawing.Point(6, 269);
            this.createTodoPnl.Name = "createTodoPnl";
            this.createTodoPnl.Size = new System.Drawing.Size(849, 142);
            this.createTodoPnl.TabIndex = 4;
            // 
            // todoTb
            // 
            this.todoTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoTb.Location = new System.Drawing.Point(3, 20);
            this.todoTb.Multiline = true;
            this.todoTb.Name = "todoTb";
            this.todoTb.Size = new System.Drawing.Size(843, 79);
            this.todoTb.TabIndex = 0;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateBtn.Location = new System.Drawing.Point(13, 105);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Создать";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // TodoNameLbl
            // 
            this.TodoNameLbl.AutoSize = true;
            this.TodoNameLbl.Location = new System.Drawing.Point(0, 2);
            this.TodoNameLbl.Name = "TodoNameLbl";
            this.TodoNameLbl.Size = new System.Drawing.Size(99, 15);
            this.TodoNameLbl.TabIndex = 1;
            this.TodoNameLbl.Text = "Название задачи";
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
            this.ListTp.ResumeLayout(false);
            this.createTodoPnl.ResumeLayout(false);
            this.createTodoPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTC;
        private TabPage ListTp;
        private TabPage StatiscticTP;
        private CheckedListBox TodosClb;
        private Panel createTodoPnl;
        private TextBox todoTb;
        private Button CreateBtn;
        private Label TodoNameLbl;
    }
}