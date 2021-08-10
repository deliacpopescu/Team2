using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2Application.Models
{
    public class Skill
    {
        public Skill()
        {
        }

        public Skill(int id, string name, string description, string skillMatrixUrl, List<LibraryResource> libraryResource)
        {
            Id = id;
            Name = name;
            Description = description;
            SkillMatrixUrl = skillMatrixUrl;
            LibraryResource = libraryResource;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SkillMatrixUrl { get; set; }

        public List<LibraryResource> LibraryResource { get; set; }

        public List<LibraryResource> GetResources()
        {
            return LibraryResource;
        }
    }
}
