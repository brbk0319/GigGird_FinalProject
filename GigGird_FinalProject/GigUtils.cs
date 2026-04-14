using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject
{
    public class GigUtils
    {

        public static TimeSpan CalculateDaysUntilDeadline(DateTime deadline)
        {
            return deadline - DateTime.Now;
        }

        /* TODO:
         * Formatting methods, project progress methods, project quote(?)
         */
    }
}
