﻿
using Microsoft.AspNetCore.Mvc;

namespace HandMadeCakes.Models
{
    public class CakeModel
    {
        public int Id { get; set; }
        public string Flavor { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }

    }

}