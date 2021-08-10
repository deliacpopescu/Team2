using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team2Application.Data.Migrations
{
    public partial class Intern : Migration
    {
        public Intern(int v1, string v2, DateTime dateTime, string v3)
        {
            V1 = v1;
            V2 = v2;
            DateTime = dateTime;
            V3 = v3;
        }

        public int V1 { get; }
        public string V2 { get; }
        public DateTime DateTime { get; }
        public string V3 { get; }

        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
