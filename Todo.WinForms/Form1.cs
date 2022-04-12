using Todos.Infrastructure;

namespace Todos.WinForms
{
    public partial class MainForm : Form
    {
        TodoManager todoManager = new TodoManager();

        public MainForm()
        {
            InitializeComponent();
            var todos = todoManager.GetTodoList();

            foreach (var todo in todos)
            {
                TodosClb.Items.Add(todo.Title, todo.IsDone);
            }
        }

        private void TodosClb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (TodosClb.SelectedItem != null)
            {
                todoManager.DoneTodo(TodosClb.SelectedItem.ToString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            todoManager.Save();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            todoManager.AddTodo(todoTb.Text);
            TodosClb.Items.Add(todoTb.Text);
            todoTb.Text = String.Empty;
        }
    }
}