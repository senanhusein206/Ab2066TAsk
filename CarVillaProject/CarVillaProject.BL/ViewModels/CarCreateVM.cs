using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CarVillaProject.BL.ViewModels
{
    public class CarCreateVM
    {
        public string ImgUrl { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string SpeedBoxCategory { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public IFormFile ImgFile { get; set; }
    }
}
