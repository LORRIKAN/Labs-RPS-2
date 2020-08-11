using Lab4.View.MessageService;
using System;
using System.Data;

namespace Lab4.View
{
    interface IView
    {
        IMessageService MessageService { get; }
        NestedTable.NestedTable Table { get; }
        DataSet TableDataSet { get; set; }
        string ExportPath { get; }

        event EventHandler FormLoad;

        event EventHandler RefreshBut_Click;
        event EventHandler SaveBut_Click;

        event EventHandler ExportCertainDebtorBut_Click;
        event EventHandler ExportAllDebtorsAndDebtsBut_Click;
        void Show();
    }
}