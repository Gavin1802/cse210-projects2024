using System;

class Program

{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 John St", "Anytown", "Idaho", "11111");
        Address receptionAddress = new Address("456 Joe St", "Othertown", "Idaho", "22222");
        Address gatheringAddress = new Address("789 Smith St", "Sometown", "Idaho", "33333");

        Lecture lectureEvent = new Lecture("Peterson's Lecture", "Lecture discussing the ideas of space/time.", "May 4, 2024", "7:00 pm - 8:30 pm", lectureAddress, "Joe Smith", 100);
        Reception receptionEvent = new Reception("The Allen's Wedding Reception", "Join us as we celebrate!", "May 4, 2024", "7:00 pm - 8:30 pm", receptionAddress, "rsvp@example.com");
        OutdoorGathering gatheringEvent = new OutdoorGathering("Le Picnic de famille Ferrier", "Bienvenue tout le monde to our festive Sunday picnic", "May 5, 2024", "2:00 pm - 4:30 pm", gatheringAddress, "Sunny");

        Console.WriteLine("Lecture Marketing Message Options:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("- - - -");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("- - - -");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Reception Marketing Message Options:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("- - - -");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("- - - -");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Marketing Message Options:");
        Console.WriteLine(gatheringEvent.GetStandardDetails());
        Console.WriteLine("- - - -");
        Console.WriteLine(gatheringEvent.GetFullDetails());
        Console.WriteLine("- - - -");
        Console.WriteLine(gatheringEvent.GetShortDescription());
    }
}