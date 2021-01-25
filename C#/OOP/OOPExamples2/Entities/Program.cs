using OOPExamples2.Manager;
using System;
using System.Collections.Generic;

namespace OOPExamples2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needLoanManager = new NeedLoanManager();
            ICreditManager autoLoanManager = new AutoLoanManager();
            ICreditManager housingLoanManager = new HousingLoanManager();

            ApplyManager applyManager = new ApplyManager();
            List<ILoggerService> loggerServices = new List<ILoggerService>() {new DataBaseLoggerService(),new FileLoggerService() };
            applyManager.Apply(needLoanManager,new List<ILoggerService> { new DataBaseLoggerService(),new CreditLoggerService()});
            applyManager.Apply(autoLoanManager,loggerServices);
            
            //applyManager.Apply(housingLoanManager, new List<ILoggerService> { new DataBaseLoggerService(), new CreditLoggerService() });
            //applyManager.Apply(new ArtisanLoanManager(), new List<ILoggerService> { new DataBaseLoggerService(), new CreditLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>()
            { needLoanManager,autoLoanManager };
            //applyManager.MakeCreditPreNotification(credits);



        }
    }
}
