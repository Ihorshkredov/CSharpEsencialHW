namespace Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weather summerWeather = new Weather(10, "Summer"); //Generate summer weather for next 10 days
            
            MeteoCenter meteoCenter = new MeteoCenter(summerWeather);// Meteocenter analize generated weather and receive meteodata
           
            var requestDate = DateTime.Now.Date.AddDays(5);// request weather in 5 days after today

            meteoCenter.GetTemperatureByDate(requestDate, out Temperature result);


            var dateFrom = DateTime.Now.Date.AddDays(3);
            var dateTo = DateTime.Now.Date.AddDays(7);


            meteoCenter.GetTemperatureByPeriod(dateFrom,dateTo,out Temperature [] prognoze);

            Console.ReadLine();
            

            
        }
    }
}