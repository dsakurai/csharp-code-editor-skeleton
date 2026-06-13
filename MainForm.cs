using System.Windows.Forms;
using ScintillaNET;

namespace MyApp
{
    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "MyApp";
            this.Width = 800;
            this.Height = 600;

            var editor = new Scintilla();
            editor.Dock = DockStyle.Fill;
            // Basic configuration
            editor.Margins[0].Width = 20;
            editor.WrapMode = WrapMode.None;
            editor.LexerName = null;
            editor.Text = """
                // Welcome to the Scintilla editor
                // Add your code here...
                """;

            this.Controls.Add(editor);
        }
    }
}
