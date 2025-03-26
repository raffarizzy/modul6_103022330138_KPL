using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null && title !="", "Title tidak boleh kosong!");
            Debug.Assert(title.Length <= 200, "Title maksimal 200 karakter");
            
            this.id = rand.Next(10000,99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int views)
        {
            Debug.Assert(views <= 25000000, "Penambahan play count maksinal 25.000.000");
            Debug.Assert(views > 0, "Play count tidak boleh angka negatif!");
            try
            {
                checked
                {
                    this.playCount += views;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow!");
            }
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
