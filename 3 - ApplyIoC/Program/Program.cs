using BusinessFacade;
using Domain;
using Utility;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Инициализируем связи
            // Конфигурирование связей отделено от их использования
            ServiceLocator.RegisterService<IReportBuilder>(typeof(ReportBuilder));
            ServiceLocator.RegisterService<IReportSender>(typeof(EmailReportSender));
            ServiceLocator.RegisterService<IReporter>(typeof(Reporter));
            
            
            // Вызываем "сохраненную" ссылку на нужную реализацию
            var reporter = ReporterFactory.Create();
            reporter.SendReports();
        }
    }
}