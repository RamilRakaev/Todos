using Todos.Infrastructure;

namespace Todos.WinForms
{
    public partial class MainForm : Form
    {
        readonly TodoManager todoManager = new();

        public MainForm()
        {
            InitializeComponent();
            var todos = todoManager.GetTodoList();

            foreach (var todo in todos)
            {
                ImptUrgtCLB.Items.Add(todo.Title, todo.IsDone);
            }
        }

        private void ImportantAndUrgentCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ImptUrgtCLB.SelectedItem != null)
            {
                todoManager.DoneTodo(title: ImptUrgtCLB.SelectedItem.ToString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            todoManager.Save();
        }

        private void CreateImptTdBtn_Click(object sender, EventArgs e)
        {
            todoManager.AddTodo(ImportantTB.Text);
            ImptUrgtCLB.Items.Add(ImportantTB.Text);
            ImportantTB.Text = string.Empty;
        }

        private void NotImportantTP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}