using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    class Mywindow : Form
    {
        static void Main()
        {
            Mywindow form = new Mywindow();
            form.Text = " My First Time";

            Button button = new Button();
            button.Text = " click me ";
            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}
