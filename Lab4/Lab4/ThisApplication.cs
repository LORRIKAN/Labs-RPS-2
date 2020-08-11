using Autofac;
using Lab4.Model;
using Lab4.Presenter;
using Lab4.Repository;
using Lab4.View;
using Lab4.View.MessageService;
using System.Windows.Forms;

namespace Lab4
{
    public static class ThisApplication
    {
        public static void Run()
        {

            var builder = new ContainerBuilder();

            builder.RegisterType<Debtor>();
            builder.RegisterType<Debt>();

            builder.RegisterType<Repository<Debtor>>().As<IRepository<Debtor>>();
            builder.RegisterType<Repository<Debt>>().As<IRepository<Debt>>();

            builder.RegisterType<ExcelExport>().As<IFileExportService>();
            builder.RegisterType<Presenter.Presenter>().As<IPresenter>();

            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<View.View>().As<IView>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = builder.Build();
            container.Resolve<IPresenter>().RunApplication();
        }
    }
}