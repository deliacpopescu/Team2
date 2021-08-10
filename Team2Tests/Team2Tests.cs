using System;
using Team2Application.Data.Migrations;
using Xunit;

namespace Team2Tests
{
    public class Team2Tests
    {
        [Fact]
        public void GettingAgeTest()
        {
            Intern intern = new Intern(5,"Rares",new DateTime(2015, 12, 25),"email@yahoo.com");
        }
    }
}
