using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.Prompt
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.None,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 200, Top = 20, Text = text ,Width=200};
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "زياد كردن", Height = 40, Left = 350, Width = 100, Top = 90, DialogResult = DialogResult.OK };
            Button cancellation = new Button() { Text = "داخستن",Height=40, Left = 200, Width = 100, Top = 90, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(cancellation);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancellation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "cancelled";
        }
    }
}
