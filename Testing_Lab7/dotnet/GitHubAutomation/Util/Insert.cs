using Framework_1_2.Model;
using Framework_1_2.Util;

namespace Framework_1_2.Util
{
    class Insert
    {
        public static Data GetInfoWithoutFrom()
        {
            return new Data(Configs.GetData(Configs.WithoutFrom, "From").Value, Configs.GetData(Configs.WithoutFrom, "To").Value);
        }

        public static Data GetInfoWithoutTo()
        {
            return new Data(Configs.GetData(Configs.WithoutTo, "From").Value, Configs.GetData(Configs.WithoutTo, "To").Value);
        }

        public static Data GetStandardInfo()
        {
            return new Data(Configs.GetData(Configs.Standard, "From").Value, Configs.GetData(Configs.Standard, "To").Value);
        }

        public static TicketInfo GetTicketInfo()
        {
            return new TicketInfo(Configs.GetData(Configs.TicketInfo, "title").Value, Configs.GetData(Configs.TicketInfo, "firstname").Value, Configs.GetData(Configs.TicketInfo, "lastname").Value);
        }

        public static TicketInfo GetInfoWithoutTitle()
        {
            return new TicketInfo(Configs.GetData(Configs.WithoutTitle, "title").Value, Configs.GetData(Configs.WithoutTitle, "firstname").Value, Configs.GetData(Configs.WithoutTitle, "lastname").Value);
        }

        public static TicketInfo GetInfoWithoutFirstname()
        {
            return new TicketInfo(Configs.GetData(Configs.WithoutFirstname, "title").Value, Configs.GetData(Configs.WithoutFirstname, "firstname").Value, Configs.GetData(Configs.WithoutFirstname, "lastname").Value);
        }
    }
}
