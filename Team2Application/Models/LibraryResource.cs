using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2Application.Models
{
    public class LibraryResource
    {
        public LibraryResource()
        {
        }

        public LibraryResource(int id, string name, string recommandation, string url)
        {
            Id = id;
            Name = name;
            Recommandation = recommandation;
            Url = url;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Recommandation { get; set; }

        public string Url { get; set; }

        public void Play()
        {
            /*Starts playing video*/
        }

        public void RetrieveInformation()
        {
            /*Retrives information*/
        }
    }
}
