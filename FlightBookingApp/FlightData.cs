using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public static class FlightData
{
    private static string filePath = "flights.xml";

    public static List<Flight> LoadFlights()
    {
        if (File.Exists(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Flight>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Flight>)serializer.Deserialize(fs);
            }
        }
        else
        {
            return new List<Flight>();
        }
    }

    public static void SaveFlights(List<Flight> flights)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Flight>));
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            serializer.Serialize(fs, flights);
        }
    }
}