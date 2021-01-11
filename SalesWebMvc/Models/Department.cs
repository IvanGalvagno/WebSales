using System;
using System.Linq;
using System.Collections.Generic;
namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Association
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //Constructors
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //methods
       public void AddSeler(Seller seller)
        {
            Sellers.Add(seller);
        }
       public void RemoveSeller(Seller seller)
        {
            Sellers.Remove(seller);
        }
        public double TotalSeler(DateTime inital, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(inital, final));   
        }
    }
}
