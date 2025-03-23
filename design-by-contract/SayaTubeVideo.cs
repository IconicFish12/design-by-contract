using System;
using System.Diagnostics;

namespace design_by_contract
{
    class SayaTubeVideo
    {
        private int id, playcount;
        private string title;

        Random rnd = new Random();

        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title), "Judul tidak boleh null atau kosong.");
            Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 karakter.");

            this.id = rnd.Next(1, 100);
            this.title = title;
            this.playcount = 0;
        }

        public void increasePlayCount(int count)
        {
            Debug.Assert(count <= 10_000_000, "Input penambahan play count melebihi batas 10.000.000 per panggilan.");

            try
            {
                checked
                {
                    playcount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void printVideoDetails()
        {
            Console.WriteLine($"Video dengan Judul {title}, pada id {id}, dengan playcount {playcount}");
        }
    }
}
