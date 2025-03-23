using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_by_contract
{
    class SayaTubeVideo
    {
        private int id, playcount;
        private string title;

        Random rnd = new Random();

        public SayaTubeVideo(string title)
        {
            this.id = rnd.Next(1, 100);
            this.title = title;
            this.playcount = 0;
        }

        
    }
}
