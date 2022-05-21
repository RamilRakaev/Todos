using Todos.Infrastructure;

namespace Todos.WinForms
{
    public partial class MainForm : Form
    {
        readonly TodoManager todoManager = new();
        private bool paintedImportantTP;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            todoManager.Save();
        }

        #region Important
        private void CreateImptTdBtn_Click(object sender, EventArgs e)
        {
            todoManager.AddTodo(ImportantTB.Text);
            ImptUrgtCLB.Items.Add(ImportantTB.Text);
            ImportantTB.Text = string.Empty;
        }

        private void ImptUrgtCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ImptUrgtCLB.SelectedItem != null)
            {
                todoManager.DoneTodo(title: ImptUrgtCLB.SelectedItem.ToString());
            }
        }

        private void ImptUrgtCLB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && ImptUrgtCLB.SelectedItems.Count > 0)
            {
                var title = (string)ImptUrgtCLB.SelectedItem;
                todoManager.Remove(title);
                ImptUrgtCLB.Items.Remove(title);
            }
        }

        private void ImptUrgtCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImptUrgtCLB.SelectedItem != null)
            {
                var title = (string)ImptUrgtCLB.SelectedItem;
                ImportantTB.Text = title;
            }
        }

        private void ChangeImptTodoBtn_Click(object sender, EventArgs e)
        {
            if (ImptUrgtCLB.SelectedItem != null)
            {
                var oldTitle = (string)ImptUrgtCLB.SelectedItem;
                var newTitle = ImportantTB.Text;
                var todo = todoManager.GetTodo(oldTitle);
                todo.Title = newTitle;
                ImptUrgtCLB.Items.Remove(oldTitle);
                ImptUrgtCLB.Items.Add(todo.Title, todo.IsDone);
            }
        }

        private void ImportantTP_Paint(object sender, PaintEventArgs e)
        {
            if (paintedImportantTP == false)
            {
                var todos = todoManager.GetTodoList();

                foreach (var todo in todos)
                {
                    ImptUrgtCLB.Items.Add(todo.Title, todo.IsDone);
                }
                paintedImportantTP = true;
            }
        }
        #endregion
    }
}