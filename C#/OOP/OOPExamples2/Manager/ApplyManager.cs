using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2
{
    class ApplyManager
    {
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices) 
        {

            //Evaluate applier information

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void MakeCreditPreNotification(List<ICreditManager> credits,ILoggerService loggerService)
        {
            foreach (var item in credits)
            {
                item.Calculate();
                loggerService.Log();
            }
        }
    }
}
