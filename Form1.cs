using System.Linq.Expressions;
using TaskManager.Properties;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.IconSmiley;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActivePanel.Visible = false;
            CompletedPanel.Visible = false;
        }

        private void ActiveButton_Click(object sender, EventArgs e)
        {
            ActivePanel.Show();
            CreateNewActive.Show();
            CompletedPanel.Hide();
        }

        private void CompleteButton(object sender, EventArgs e)
        {
            ActivePanel.Hide();
            CreateNewActive.Hide();
            CompletedPanel.Show();
        }

        private void CreateNewActive_Click(object sender, EventArgs e)
        {
            String name = NewActiveName.Text;
            String due_Date = NewActiveDate.Text;
            ActiveList.Items.Add(name + " (Due: " + due_Date + ")");

        }

        private void RemoveCompletedItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < CompletedList.Items.Count - 1; i++)
                {
                    if (CompletedList.GetItemChecked(i))
                    {
                        CompletedList.Items.RemoveAt(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("welp");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ActiveList.Items.Count - 1; i++)
                {
                    var item = ActiveList.Items[i];
                    if (ActiveList.GetItemChecked(i))
                    {
                        CompletedList.Items.Add(item);
                        break;
                    }
                }
                for (int i = 0; i < ActiveList.Items.Count - 1; i++)
                {
                    if (ActiveList.GetItemChecked(i))
                    {
                        ActiveList.Items.RemoveAt(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("oops");
            }
        }
    }
}
