using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "NY", "USA");

        Lecture lecture = new Lecture("Intro to Programming", "Learn the basics of programming",
                                      new DateTime(2024, 2, 25), new TimeSpan(10, 0, 0),
                                      address, "John Doe", 50);

        Reception reception = new Reception("Networking Event", "Connect with industry professionals",
                                            new DateTime(2024, 3, 10), new TimeSpan(18, 30, 0),
                                            address, "RSVP at example@example.com");

        OutdoorGathering gathering = new OutdoorGathering("Picnic in the Park", "Enjoy outdoor activities",
                                                          new DateTime(2024, 4, 15), new TimeSpan(12, 0, 0),
                                                          address, "Sunny with a chance of showers");

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(gathering.GetFullDetails());
    }
}