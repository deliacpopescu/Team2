using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2Application.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Intern>().ToTable("Interns");
            builder.Entity<Skill>().ToTable("Skills");
            builder.Entity<LibraryResource>().ToTable("LibraryResources");

            LibraryResource resource1 = new LibraryResource(1,"how to create a Controller in C#","for begginers","https");
            LibraryResource resource2 = new LibraryResource(2,"how to use Entity Class in Python","for begginers","https");
            LibraryResource resource3 = new LibraryResource(3,"how to use a Dictionary in Python","for begginers","https");

            builder.Entity<LibraryResource>().HasData(resource1, resource2, resource3);


            List <LibraryResource> listResources1 = new List<LibraryResource>();
            listResources1.Add(resource1);
            List<LibraryResource> listResources2 = new List<LibraryResource>();
            listResources2.Add(resource2);
            listResources2.Add(resource3);

            Skill skill1 = new Skill(1, "C#", "for internship", "https", listResources1);
            Skill skill2 = new Skill(2, "Python", "extra", "https", listResources2);

            builder.Entity <Skill>().HasData(skill1,skill2);

            List<Skill> listSkill1 = new List<Skill>();
            listSkill1.Add(skill1);
            List<Skill> listSkill2 = new List<Skill>();
            listSkill2.Add(skill2);


            builder.Entity<Intern>().HasData(
                new Intern
                {
                    Id = 1,
                    Name = "Delia",
                    Birthdate = new DateTime(2000, 2, 2),
                    EmailAddress = "delia@principal.com",
                    Skills = listSkill1
                },
                new Intern
                {
                    Id = 2,
                    Name = "Rares",
                    Birthdate = new DateTime(2000, 12, 12),
                    EmailAddress = "rares@principal.com",
                    Skills = listSkill2
                }
                );
        }
    }
}
