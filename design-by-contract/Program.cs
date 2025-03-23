using design_by_contract;
using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial C#");

        for (int i = 0; i < 100; i++)
        {
            video.increasePlayCount(1_000_000);
        }

        video.printVideoDetails();
    }
}