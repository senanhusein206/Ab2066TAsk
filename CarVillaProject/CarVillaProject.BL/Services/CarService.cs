using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarVillaProject.BL.ViewModels;
using CarVillaProject.DAL.Contexts;
using CarVillaProject.DAL.Models;

namespace CarVillaProject.BL.Services
{
    public class CarService
    {
        private readonly AppDbContext _context;
        public CarService()
        {
            _context = new AppDbContext();
        }

        #region Create

        public void Create(CarCreateVM car)
        {
            Car newcar = new Car();
            newcar.Brand = car.Brand;
            newcar.Model=car.Model;
            newcar.Price = car.Price;
            newcar.SpeedBoxCategory = car.SpeedBoxCategory;
            newcar.Description = car.Description;



            string filename = Path.GetFileNameWithoutExtension(car.ImgFile.FileName);
            string extension = Path.GetExtension(car.ImgFile.FileName);
            string resulname = filename + Guid.NewGuid().ToString() + extension;

            string uploadedPath = "C:\\Users\\Senan\\source\\repos\\CarVillaProject\\CarVillaProject.MVC\\wwwroot\\assets\\uploadImages";
            if (!Directory.Exists(uploadedPath))
            {
                Directory.CreateDirectory(uploadedPath);
            }
            uploadedPath = Path.Combine(uploadedPath,resulname);

           using FileStream stream = new FileStream(uploadedPath,FileMode.Create);
            car.ImgFile.CopyTo(stream);

         
            newcar.ImgUrl = resulname;
            _context.Cars.Add(newcar);
            _context.SaveChanges();
        }
        #endregion

        #region Read

        public List<Car> GetAllCars()
        {
            List<Car> cars = _context.Cars.ToList();
            return cars;

        }

        public Car GetCArById(int id)
        {
            Car ftcar = _context.Cars.Find(id);
            if (ftcar is null)
            {
                throw new Exception($"Databasede {id} li data yoxdur");
            }
            return ftcar;
        }
        #endregion

        #region Update

        public void Update(int id, Car car)
        {
            Car? ftcar = _context.Cars.Find(id);

            if (ftcar.Id != id)
            {
                throw new Exception("Idler ust-uste dusmur");
            }

            if (ftcar is null)
            {
                throw new Exception($"Databasede {id} li data yoxdur");
            }


            ftcar.Description = car.Description;
            ftcar.Price = car.Price;
            ftcar.SpeedBoxCategory = car.SpeedBoxCategory;
            ftcar.Brand = car.Brand;
            ftcar.ImgUrl = car.ImgUrl;
            ftcar.Model = car.Model;
            _context.SaveChanges();

        }
        #endregion

        #region Delete
        public void Delete(int id)
        {
            Car? ftcar = _context.Cars.Find(id);
            if (ftcar is null)
            {
                throw new Exception($"Databasede {id} li data yoxdur");
            }
            _context.Cars.Remove(ftcar);
            _context.SaveChanges();
        }
        #endregion


    }
}
