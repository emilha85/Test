namespace Models
{
    public class Player
    {
        public required string Id { get; init; }

        public required BirthData BirthData { get; init; }

        public required DeathData DeathData { get; init; }

        public required NameData NameData { get; set; }

        public PhisicalData PhisicalData { get; set; }

        public GameDetails GameDetails { get; set; }
    }

    public class PhisicalData
    {
        public int? Weight { get; set; }

        public int? Height { get; set; }
    }

    public enum Direction
    {
        None = 0,
        Right = 1,
        left = 2
    }

    public class GameDetails
    {
        public Direction Bats { get; set; }

        public Direction Throws { get; set; }

        public DateTime? Debut { get; set; }

        public DateTime? FinalGame { get; set; }
    }

    public class NameData
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string GivenName { get; set; }
    }

    public class BirthData
    {
        public DateOnly Date { get; set; }

        public LocationData Location { get; set; }
    }

    public class DeathData
    {
        public DateOnly Date { get; set; }

        public LocationData Location { get; set; }
    }  

    public class LocationData
    {
        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }
    }




}
