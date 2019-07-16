namespace Adapter
{
    public sealed class clientData
    {
        public string Name;
        public int ID;

        public clientData(string name, int id)
        {
            this.ID = id;
            this.Name = name;
        }
   
    }
}