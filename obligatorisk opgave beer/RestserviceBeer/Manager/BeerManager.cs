using obligatorisk_opgave_beer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestserviceBeer.Manager
{
    public class BeerManager
    {
        private static int _nextId = 1;
        private static List<Beer> Beerdata = new List<Beer>()
        {
            new Beer {ID = _nextId++, Name = "Hallenstern", Price = 150, ABV = 45 },
            new Beer {ID = _nextId++, Name = "Suffering Delight", Price = 250, ABV = 75 },
            new Beer {ID = _nextId++, Name = "Exam", Price = 50, ABV = 95 },
        };

        public List<Beer> Getall()
        {
            return Beerdata;
        }

        public Beer GetById (int id)
        {
            return Beerdata.Find((beer)=> beer.ID == id);
        }

        public Beer Add (Beer newBeer)
        {
            newBeer.ID = _nextId++;
            Beerdata.Add(newBeer);
            return newBeer;
        }

        public Beer Delete (int ID)
        {
            Beer beer = Beerdata.Find(Beer1 => Beer1.ID == ID);
            if (beer == null) return null;
            Beerdata.Remove(beer);
            return beer;

        }

        public Beer Update(int ID, Beer updates)
        {
            Beer beer = Beerdata.Find(beer1 => beer1.ID == ID);
            if (beer == null) return null;
            beer.Name = updates.Name;
            beer.Price = updates.Price;
            beer.ABV = updates.ABV;
            return beer;
        }
    }
}
