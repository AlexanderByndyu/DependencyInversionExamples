using Domain;
using Utility;

namespace BusinessFacade
{
    public static class ReporterFactory
    {
        public static IReporter Create()
        {
            return ServiceLocator.Resolve<IReporter>();
        }
    }
}