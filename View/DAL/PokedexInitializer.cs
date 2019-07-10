using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using View.Models;
using System.Data.Entity;

namespace View.DAL
{
    public class PokedexInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<PokeDBContext>
    {
        protected override void Seed(PokeDBContext context)
        {
            var types = new List<Models.Type>
            {
                new Models.Type{Nome="Água"},
                new Models.Type{Nome="Grama"},
                new Models.Type{Nome="Terra"},
                new Models.Type{Nome="Fogo"},
                new Models.Type{Nome="Normal"},
                new Models.Type{Nome="Lutador"},
                new Models.Type{Nome="Pedra"},
                new Models.Type{Nome="Veneno"},
                new Models.Type{Nome="Dragão"},
                new Models.Type{Nome="Voador"}
            };

            types.ForEach(t => context.Types.Add(t));
            context.SaveChanges();


        }
    }
}