namespace Adapter
{
    public class WebClientData
    {
        public string Name;
        public int ID;
        public string IP;
        bool SSL;

        public WebClientData(string name, int id, string ip, bool ssl)
        {
            this.ID = id;
            this.Name = name;
            this.IP = ip;
            this.SSL = ssl;
        }
    }
}