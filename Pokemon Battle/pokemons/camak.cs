using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    internal class Lechonk : character
    {
        public Lechonk()
        {
            this.name = "คาเม็กซ์";
            Random random = new Random();
            this._image = Properties.Resources._004;


        }
        public int Blood { get; set; }
        public Lechonk(int blood)
        {

            this.Blood = 30 - blood;

        }
    }
}

    
