using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace UberFrba
{
    public class DateTimeHelper
    {
        public static DateTime GetSystemDate()
        {
            DateTime date;
            int time;

            try
            {
                date = GetDate();
                date = GetTime(date);
            }
            catch(Exception ex)
            {
                date = DateTime.Now;
            }

            return date;
           
        }

        private static DateTime GetTime(DateTime date)
        {
            int time = 0;
            if (ConfigurationManager.AppSettings["HoraSistema"] != null)
            {
                var timeStr = ConfigurationManager.AppSettings["HoraSistema"].ToString();
                time = int.Parse(timeStr);
                if (time < 24)
                {
                    TimeSpan ts = new TimeSpan(time, 0, 0);
                    date = date + ts;
                }
                
            }
            return date;
        }

        private static DateTime GetDate()
        {
            DateTime date;
            if (ConfigurationManager.AppSettings["FechaSistema"] != null)
            {
                var dateStr = ConfigurationManager.AppSettings["FechaSistema"].ToString();
                date = Convert.ToDateTime(dateStr, new CultureInfo("es-AR"));
            }
            else
            {
                date = DateTime.Today.Date;
            }
            return date;
        }
    }
}
