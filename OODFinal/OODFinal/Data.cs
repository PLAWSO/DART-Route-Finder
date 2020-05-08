using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OODFinal
{
    class Data : Read
    {
        private List<Stop> stops = new List<Stop>();
        private List<Route> routes = new List<Route>();
        private List<Bus> buses = new List<Bus>();
        int numStops = 0, numRoutes = 0, numBuses = 0;

        public Data()
        {
            this.AddStops("~stops.txt");
            this.AddRoutes("~routes.txt");
            this.AddBuses("~buses.txt");
        }

        public Data(string stopFileName, string routeFileName, string busFileName)
        {
            this.AddStops(stopFileName);
            this.AddRoutes(routeFileName);
            this.AddBuses(busFileName);
        }

        ~Data()
        {

        }

        public List<Stop> GetStops()
        {
            return this.stops;
        }

        public List<string> GetStopNames()
        {
            List<string> stopNames = new List<string>();
            for (int z = 0; z < this.numStops; z++)
                stopNames.Add(stops[z].GetName());
            return stopNames;
        }

        public override void AddStops(string fileName)
        {
            TextReader stopFile = File.OpenText(fileName);
            this.numStops += int.Parse(stopFile.ReadLine());
            string nameBuf, googleIDBuf;
            for (int z = 0; z < this.numStops; z++)
            {
                nameBuf = stopFile.ReadLine();
                googleIDBuf = stopFile.ReadLine();
                this.stops.Add(new Stop(nameBuf, googleIDBuf));
            }
            stopFile.Close();
        }

        public override void AddRoutes(string fileName)
        {
            TextReader routeFile = File.OpenText(fileName);
            this.numRoutes += int.Parse(routeFile.ReadLine());
            List<Stop> pathBuf = new List<Stop>();
            for (int z = 0; z < this.numRoutes; z++)
            {
                foreach (string num in routeFile.ReadLine().Split())
                {
                    pathBuf.Add(stops[int.Parse(num)]);
                }
                this.routes.Add(new Route(pathBuf));
            }
            routeFile.Close();
        }

        public override void AddBuses(string fileName)
        {
            TextReader busFile = File.OpenText(fileName);
            this.numBuses += int.Parse(busFile.ReadLine());
            string[] datBuf;
            for (int z = 0; z < this.numBuses; z++)
            {
                datBuf = busFile.ReadLine().Split();
                this.buses.Add(new Bus(stops[int.Parse(datBuf[0])], routes[int.Parse(datBuf[1])]));
            }
            busFile.Close();
        }

        public void FindShortestPath(Stop start, Stop dest)
        {
            int[,] map = new int[this.numStops, this.numStops];
            this.FillSptSet(map);
            string stringy;
            for (int z = 0; z < this.numStops; z++)
            {
                stringy = "";
                for (int y = 0; y < this.numStops; y++)
                {
                    stringy += " " + map[z, y];
                }
                Console.WriteLine(stringy);
            }
        }

        private void FillSptSet(int[,] map)
        {
            for (int z = 0; z < numStops; z++)
            {
                for (int y = 0; y < numStops; y++)
                {
                    if (z != y)
                    {
                        map[z, y] = this.AskGoogle(stops[z].GetGoogleID(), stops[y].GetGoogleID());
                    }
                    else
                    {
                        map[z, y] = 0;
                    }
                }
            }
        }

        private int AskGoogle(string googleID1, string googleID2)
        {
            WebClient wc = new WebClient();
            string address = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=place_id:" + googleID1 + "&destinations=place_id:" + googleID2 + "&traffic_mode1&key=AIzaSyAoUTNzt9-svENg0YWlrLpCP_ipSiBUwZo";
            string rawJson = wc.DownloadString(address);

            if (rawJson.Contains("REQUEST_DENIED"))
            {
                Console.WriteLine("Google Distance Matrix API Request Denied\nending execution...\n");
                System.Windows.Forms.Application.Exit();
            }
            else if (rawJson.Contains("INVALID_REQUEST"))
            {
                Console.WriteLine("Invalid Google Distance Matrix API Request\nending execution...\n");
                System.Windows.Forms.Application.Exit();
            }

            dynamic desJson = JsonConvert.DeserializeObject(rawJson);

            return desJson.rows[0].elements[0].duration.value;
        }
    }
}