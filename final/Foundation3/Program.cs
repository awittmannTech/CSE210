using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("1 Street", "City", "ST", "Country");
        Lecture lecture = new Lecture(
            "Lecture",
            "this is a description 1.",
            "2026-01-01",
            "1:00 PM",
            lectureAddress,
            "Jim Halpert",
            50
        );

        Address receptionAddress = new Address("2 Street", "City", "ST", "Country");
        Reception reception = new Reception(
            "Reception",
            "this is a description 2.",
            "2026-01-02",
            "2:00 PM",
            receptionAddress,
            "email@example.com"
        );

        Address outdoorAddress = new Address("3 Street", "City", "ST", "Country");
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Outdoor Event",
            "this is a description 3",
            "2026-01-03",
            "3:00 PM",
            outdoorAddress,
            "Super Hot Outside"
        );

        var events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }
    }
}