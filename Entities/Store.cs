using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Utils.Exceptions;

namespace Entities
{
    internal class Store:IEnumerable
    {
        public int Id { get;  }
        public string Name { get; set; }

        private List<Game> _games;

        public Store()
        {
            _games= new List<Game>();
        }
        public void AddGame(Game game)
        {
            if (game == null)
                throw new NullReferenceException("null ola bilmez");

            if (_games.Exists(g => !g.IsDeleted && g.Name == game.Name))

                throw new AlreadyExistsException("bu adda game var");


                _games.Add(game);
                return;
            

            
        }

        public void GetGameById(int? id)
        {
            
                if (id == null)
                    throw new NullReferenceException("id null ola bilmez");

            Game game = _games.Find(g => !g.IsDeleted && g.Id == id);
            return ;
            
        }

       public void RemoveGameById(int? id)
        {
           {
                if (id == null)
                    throw new NullReferenceException("id null ola bilmez");

               Game game=_games.Find(b => !b.IsDeleted && b.Id == id);
                if (id == null)
                    throw new NotFoundException("bu idli GAME yoxdur");

                game.IsDeleted = true;
            }
        }

       public List<Game> FilterGamesByPrice(double minPrice,double maxPrice)
        {
            {
                if (_games == null)
                  throw new NotFoundException("bu idli game yoxdur");
                    return _games .FindAll(g => !g.IsDeleted && g.Price >= minPrice && g.Price <= maxPrice);
                
            }
        }

        public List<Game> FilterGamesByDoublePrice(double  minDisCountPrice, double maxDisCountPrice)
        {
            {
                if (_games == null)
                    throw new NotFoundException("bu idli game yoxdur");
                return _games.FindAll(g => !g.IsDeleted && g.DisCountPercent >= minDisCountPrice && g.DisCountPercent <= maxDisCountPrice);

            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Game item in _games)
            {
                yield return item;
            }
        }


    }
    
}
