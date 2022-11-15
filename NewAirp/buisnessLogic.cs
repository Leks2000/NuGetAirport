namespace NewAirp
{
    public class buisnessLogic<FL> where FL : class
    {
        private List<FL> flights = new List<FL>();

        public buisnessLogic() { }
        public List<FL> Get()
        {
            return flights;
        }

        public void AddRace(FL data)
        {
            flights.Add(data);
        }
        public void Delete(FL data)
        {
            flights.Remove(data);
        }

        public void Change(FL id, FL data)
        {
            var index = flights.IndexOf(id);
            flights[index] = data;
        }
    }
}
