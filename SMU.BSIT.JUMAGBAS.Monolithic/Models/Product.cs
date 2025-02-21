﻿using SQLite;

namespace SMU.BSIT.JUMAGBAS.Monolithic.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
    }
}
