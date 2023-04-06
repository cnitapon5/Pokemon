using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    internal class spear : character
    {
        public spear()
        {
            this.name = "สเปียร์";
            Random random = new Random();
            this._image = Properties.Resources._005;
        }
    }
}
