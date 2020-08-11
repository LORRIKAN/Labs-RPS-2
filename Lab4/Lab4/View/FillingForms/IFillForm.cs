using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Lab4.View.FillingForms
{
    public interface IFillForm
    {

        event Action<List<Control>> FormClosed;

        void Show();

        void Show(DataRow dataSource);
    }
}