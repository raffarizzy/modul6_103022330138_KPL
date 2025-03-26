using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330138
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        Random rand = new Random();

        public SayaTubeUser(string username)
        {
            this.id = rand.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
            this.Username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getPlayCount();
            }   
            return total;
        }

        public void AddVideo(SayaTubeVideo newVideo)
        {
            this.uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this,Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + ": " + uploadedVideos[i].getTitle());
            }
        }
    }
}
