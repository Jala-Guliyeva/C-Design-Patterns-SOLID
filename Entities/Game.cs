using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace Entities
{
    public class Game
    {
        public int Id { get;  }
        private static int _id;
        
        public string Name { get; set; }
        public Platform Platform { get; set; }
        public double Price { get; set; }
        public double DisCountPercent { get; set; }
        public int Publisher { get; set; }
        public bool IsDeleted { get; set; }
        public Game(string name,Platform platform,double price)
        {
            Name = name;
            Platform = platform;
            Price = price;
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} - Name:{Name} -Platform:{Platform}- Price:{Price} - DisCountPercent:{DisCountPercent} - Publisher:{Publisher} - IsDeleted:{IsDeleted} ");
        }

        public void GetDiscountedPrice()
        {
            Console.WriteLine( Price-((Price*DisCountPercent)/100));
        }
    }
}
