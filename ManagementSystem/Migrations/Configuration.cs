namespace ManagementSystem.Migrations
{
    using ManagementSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            CreateCounties(context);
        }

        private void CreateCounties(ApplicationDbContext context)
        {
            foreach (var County in SeedCounties)
            {
                var exist = context.Counties.FirstOrDefault(x => x.Name.Equals(County.Name, StringComparison.OrdinalIgnoreCase));

                if (exist == null)
                {
                    context.Counties.Add(County);
                }
            }
        }

        private static List<County> SeedCounties = new List<County> {
            new County() { Name = "Avon" },
            new County() { Name = "Bedfordshire"},
            new County() { Name = "Berkshire" },
            new County() { Name = "Buckinghamshire"},
            new County() { Name = "Cambridgeshire"},
            new County() { Name = "Cheshire"},
            new County() { Name = "Cleveland"  },
            new County() { Name = "Cornwall"},
            new County() { Name = "County Durham" },
            new County() { Name = "Cumbria"},
            new County() { Name = "Derbyshire"},
            new County() { Name = "Devon"},
            new County() { Name = "Dorset"},
            new County() { Name = "East Sussex"},
            new County() { Name = "Essex"},
            new County() { Name = "Gloucestershire"},
            new County() { Name = "Hampshire"},
            new County() { Name = "Herefordshire"},
            new County() { Name = "Hertfordshire"},
            new County() { Name = "Isle of Wight"},
            new County() { Name = "Kent"},
            new County() { Name = "Lancashire"},
            new County() { Name = "Leicestershire"},
            new County() { Name = "Lincolnshire"},
            new County() { Name = "London"},
            new County() { Name = "Merseyside"},
            new County() { Name = "Middlesex"},
            new County() { Name = "Norfolk"},
            new County() { Name = "North Humberside"},
            new County() { Name = "North Yorkshire"},
            new County() { Name = "Northamptonshire"},
            new County() { Name = "Northumberland"},
            new County() { Name = "Nottinghamshire"},
            new County() { Name = "Oxfordshire"},
            new County() { Name = "Shropshire"},
            new County() { Name = "Somerset"},
            new County() { Name = "South Humberside"},
            new County() { Name = "South Yorkshire"},
            new County() { Name = "Staffordshire"},
            new County() { Name = "Suffolk"},
            new County() { Name = "Surrey"},
            new County() { Name = "Tyne and Wear"},
            new County() { Name = "Warwickshire"},
            new County() { Name = "West Midlands"},
            new County() { Name = "West Sussex"},
            new County() { Name = "West Yorkshire"},
            new County() { Name = "Wiltshire"},
            new County() { Name = "Worcestershire"},
        };
    }
}
