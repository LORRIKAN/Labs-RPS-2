using System;

namespace Lab4.View
{
    partial class View
    {

        void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void AboutProgBut_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }
    }
}