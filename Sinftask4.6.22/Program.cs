using Entities;
using System;


namespace Sinftask4._6._22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game("test1",Utils.Enums.Platform.Xbox,120);
            game.Publisher = 100;
            game.DisCountPercent = 120;
            Game game1 = new Game("test2", Utils.Enums.Platform.Pc, 200);

            Store store = new Store()
            {
                
                Name ="Store"
            };
           

            foreach (var item in store.FilterGamesByDoublePrice(10,20))
            {
                item.ShowInfo();
               
            }



        }
    }
}
