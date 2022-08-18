

class Location
{
    public string Name;
    public string Description;
    public List<Location> Neighbors = new List<Location> { };
}

class Program
{
    static void Main(string[] args)
    {
        var locations = new List<Location>();

        var winterfell = new Location();

        winterfell.Name = "Winterfell";
        winterfell.Description = "the capital of the Kingdom of the North";

        locations.Add(winterfell);

        var pyke = new Location
        {
            Name = "Pyke",
            Description = "the stronghold and seat of House Greyjoy"

        };

        var highgarden = new Location
        {
            Name = "Highgarden",
            Description = "the seat of House Tyrell and the regional capital of the Reach"
        };


        var riverrun = new Location
        {
            Name = "Riverrun",
            Description = "a large castle located in the central-western part of the Riverlands"
        };

        var trident = new Location
        {
            Name = "The Trident",
            Description = "one of the largest and most well-known rivers on the continent of Westeros"
        };

        var kingslanding = new Location
        {
            Name = "King's Landing",
            Description = "the capital, and largest city, of the Seven Kingdoms"
        };

        locations.Add(riverrun);

        ConnectLocations(riverrun, pyke);
        ConnectLocations(riverrun, kingslanding);
        ConnectLocations(riverrun, highgarden);
        ConnectLocations(riverrun, kingslanding);

        locations.Add(pyke);

        ConnectLocations(pyke, winterfell);
        ConnectLocations(pyke, highgarden);

        locations.Add(winterfell);

        ConnectLocations(winterfell, trident);

        locations.Add(kingslanding);

        ConnectLocations(trident, kingslanding);

        locations.Add(kingslanding);

        ConnectLocations(kingslanding, highgarden);


        Location(winterfell);



    }
    //Displays name & description of the designated parameter. Displays locations that are closeby. Asks for input.
    //If the inputted int corresponds to one of the neighbors, 'currentlocation' is replaced by the neighbor.
    static void Location(Location currentLocation)
    {

        int counter = 0;

        var travel = 0;

        var location = currentLocation;

        Console.WriteLine($"Welcome to {currentLocation.Name}. {currentLocation.Description}");

        foreach (Location Neighbors in currentLocation.Neighbors)
        {
            counter++;
            Console.WriteLine($"{counter}. {Neighbors.Name}");

        }

        Console.WriteLine("Where would you like to travel to?");

        try
        {
            travel = Convert.ToInt32(Console.ReadLine());
        }


        catch (Exception ex)
        {
            Console.WriteLine("That is not a valid destination");
        }

        Console.WriteLine(travel);

        currentLocation = (currentLocation.Neighbors[travel - 1]);

        Location(currentLocation);
   
    }

    static void ConnectLocations(Location a, Location b)
    {
        //Add a to b's list of neighbors.

        a.Neighbors.Add(b);
        b.Neighbors.Add(a);

        //Add location a to location b

    }
    // static void Journey(Travella)

    // {
    //    return 

    //}


}

