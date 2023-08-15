using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
      /// <summary>
      /// Class <c>Weather </c> models a point in a two-dimensional plane.
      /// </summary>
    internal class Weather
    {
        public short [] Temps { get; }
        public int Period { get; }

        public Weather(int periodDays, string season)
        {
           Period = periodDays;    
           Temps = GetTemperatures(periodDays, season);
        }

        public short [] GetTemperatures( int periodDays, string season)
        {
            
            Random rand = new Random(); 
            short[] temperatures = new short [periodDays];
           
            for (int i = 0; i < periodDays-1; i++)
            {
                switch (season.ToLower())
                {
                    case "summer":
                        temperatures[i] = (short)rand.Next(16, 37);   
                        break;
                    case "winter":
                        temperatures[i] = (short)rand.Next(-10,0);
                        break;
                    case "autumn":
                        temperatures[i] = (short)rand.Next(0, 16);
                        break;
                    case "spring":
                        temperatures[i] =(short) rand.Next(0, 16);
                        break;
                }              
            }
            return temperatures;
        }
    }
}
