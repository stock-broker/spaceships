namespace spaceships.Data
{
//    Ask
//I want to be able to search against the swapi.dev starship API to find all starships that contain the
//search term in the ship name.In the results, I require to know the name, cost, crew and
//manufacturer.
    public class ShipResult
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public Ships[] results { get; set; }
    }
}
