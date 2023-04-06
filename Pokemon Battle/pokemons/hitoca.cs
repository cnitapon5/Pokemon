using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    internal class Beedrill : character
    {
        public Beedrill()
        {
            this.name = "ฮิโตคาเงะ";
            Random random = new Random();
            this._image = Properties.Resources._002;
        }
    }
}
