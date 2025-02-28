using System;
using System.IO;
using CodeWalker;
using CodeWalker.GameFiles;
using CodeWalker.Utils;
using System.Xml.Linq;

namespace YmapCheckerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: YmapChecker <ymap_file>");
                return;
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found.");
                return;
            }

            try
            {
                // Attempt to load the YMAP file using CodeWalker
                YmapFile ymap = new YmapFile();
                byte[] fileData = File.ReadAllBytes(filePath);
                ymap.Load(fileData);

                if (ymap.Meta == null)
                {
                    Console.WriteLine("YMAP appears to be encrypted or invalid.");
                    return;
                }

                Console.WriteLine("YMAP is not encrypted. Analyzing coordinates...");

                // Use CodeWalker's MetaXml.GetXml() function to extract XML data
                string xmlFilename;
                string xmlContent = MetaXml.GetXml(ymap, out xmlFilename);
                
                // Parse XML and extract coordinates
                XDocument xmlDoc = XDocument.Parse(xmlContent);
                var entities = xmlDoc.Descendants("Item");
                bool foundCoordinates = false;

                foreach (var entity in entities)
                {
                    var position = entity.Element("position");
                    if (position != null)
                    {
                        string x = position.Attribute("x")?.Value ?? "0";
                        string y = position.Attribute("y")?.Value ?? "0";
                        string z = position.Attribute("z")?.Value ?? "0";
                        Console.WriteLine($"Object: X={x}, Y={y}, Z={z}");
                        foundCoordinates = true;
                    }
                }

                if (!foundCoordinates)
                {
                    Console.WriteLine("No coordinates found in the YMAP file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing YMAP file: " + ex.Message);
            }
        }
    }
}
