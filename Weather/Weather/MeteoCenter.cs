using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class MeteoCenter
    {
        public Temperature [] MeteoData { get; }


        public MeteoCenter(Weather weather)
        {
            MeteoData = MonitorWeather(weather);
        }


        public Temperature[] MonitorWeather(Weather weather)
        {
            Temperature[] temperatures = new Temperature [weather.Period];  

            for (int i = 0; i < weather.Period ; i++)
            {
                temperatures[i] = new Temperature(weather.Temps[i],DateTime.Today.Date.AddDays(i+1));
            }
            return temperatures;
        }

        public void GetTemperatureByDate(DateTime date, out Temperature result)
        {
            result = new Temperature();

            for (int i = 0; i < MeteoData.Length-1; i++)
            {
                if (MeteoData[i].Date == date)
                {
                   result= MeteoData[i];
                }
                else
                {
                    continue;
                      
                }
            } 
        }


        public void GetTemperatureByPeriod(DateTime startDate, DateTime dueDate, out Temperature[] result)
        {
            result= new Temperature[dueDate.DayOfYear - startDate.DayOfYear];
            int matchCounter = 0;
            for (int i = 0; i < MeteoData.Length-1; i++)
            {
                if ((MeteoData[i].Date == startDate.Date.AddDays(matchCounter)) && (MeteoData[i].Date < dueDate.Date))
                {
                    result[matchCounter] = MeteoData[i];
                    matchCounter++;
                }
                else
                {
                    continue;
                }

            }
            
            
        }

    }
}
