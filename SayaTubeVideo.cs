using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330138
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random rand = new Random();

        public SayaTubeVideo(string title)
        {
            this.id = rand.Next(10000,99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int views)
        {
            this.playCount += views;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + this.id);
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Views : " + this.playCount);
        }

        public string getTitle()
        {
            return this.title;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }
    }
}
