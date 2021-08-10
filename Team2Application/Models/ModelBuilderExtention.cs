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
            //builder.Entity<Intern>().ToTable("Interns");
            //builder.Entity<Skill>().ToTable("Skills");
            //builder.Entity<LibraryResource>().ToTable("LibraryResources");

            LibraryResource resource1 = new LibraryResource();


            builder.Entity<Intern>().HasData(
                new Intern
                {
                    Id = 1,
                    Name = "Delia",
                    Birthdate = new DateTime(2000, 2, 2),
                    EmailAddress = "delia@principal.com"
                }
                );
        }
    }
}
