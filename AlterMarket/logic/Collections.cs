﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlterMarket.logic
{
    class Collections
    {
        /// <summary>
        /// This class contains the items that will be put in the list.
        /// </summary>
        public class Items
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Description { get; set; }
            public List<Versions> Versions { get; set; }
        }

        /// <summary>
        /// This class contains all the information about the different versions that can be downloaded.
        /// </summary>
        public class Versions
        {
            public string game_id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Version { get; set; }
            public string Description { get; set; }
            public string Download { get; set; }
            public decimal Size { get; set; }
        }
    }
}