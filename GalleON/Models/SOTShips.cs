using System;
using Contentful.Core.Models;

namespace GalleON.Models
{
    public class SOTShips
    {
        public string ShipName { get; set; }

        public Asset ShipImage { get; set; }

        public int CrewSize { get; set; }

        public int NumberofMasts { get; set; }

        public int NumberofDecks { get; set; }


    }
}
