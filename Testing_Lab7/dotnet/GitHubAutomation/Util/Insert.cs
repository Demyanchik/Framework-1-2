using Framework_1_2.Model;
using Framework_1_2.Util;

namespace Framework_1_2.Util
{
    class Insert
    {
        public static Data GetInfoWithoutFrom()
        {
            return new Data(FromConfig.GetData("From").Value, FromConfig.GetData("To").Value);
        }

        public static Data GetInfoWithoutTo()
        {
            return new Data(ToConfig.GetData("From").Value, ToConfig.GetData("To").Value);
        }

        public static Data GetStandardInfo()
        {
            return new Data(StandardConfig.GetData("From").Value, StandardConfig.GetData("To").Value);
        }
        //public static Data Stations()
        //{
        //    return new Way(StationsReader.GetData("ArrivalCity").Value, StationsReader.GetData("DepartureCity").Value, StationsReader.GetData("Departure_date").Value);
        //}
    }
}
