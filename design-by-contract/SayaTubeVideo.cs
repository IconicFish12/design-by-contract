using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_by_contract
{
    class SayaTubeVideo
    {
        private int id, playcount = 0;
        private string title;

        Random rnd = new Random();

        public SayaTubeVideo(string title)
        {
            this.id = rnd.Next(1, 100);
            this.title = title;
        }

        public void increasePlayCount(int count)
        {
            
        }

        public void printVideoDetails()
        {

        }
    }
}
