using System.Windows.Forms;

namespace MyApp
{
    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "MyApp";
            this.Width = 800;
            this.Height = 600;

            var label = new Label();
            label.Text = "Hello from WinForms";
            label.AutoSize = true;
            label.Left = 10;
            label.Top = 10;
            this.Controls.Add(label);
        }
    }
}
