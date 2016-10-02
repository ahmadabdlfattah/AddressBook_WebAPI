using AddressBook.Models;

namespace AddressBook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AddressBook.Models.AddressBookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AddressBook.Models.AddressBookContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Addresses.AddOrUpdate(
              p => p.Id,
              new Address()
              {
                  Id = 1,
                  Name = "Ahmad",
                  GUId = "345d354f35sdf",
                  Email = "ahmad@gmail.com",
                  PhysicalAddress = "Roland Rainer Platz 1, 1150 Wien, Austria",
                  PhoneNumber = "23456789",
                  JobPosition = "Manager",
                  Institution = "IIASA"
              },
              new Address()
              {
                  Id = 2,
                  Name = "Jhon",
                  GUId = "345d394835sdf",
                  Email = "Jhon@gmail.com",
                  PhysicalAddress = "Rooseveltplatz, 1090 Wien, Austria",
                  PhoneNumber = "54678904",
                  JobPosition = "Developer",
                  Institution = "WSAA"
              },
              new Address()
              {
                  Id = 3,
                  Name = "Sam",
                  GUId = "345d354fkisdf",
                  Email = "Sam@gmail.com",
                  PhysicalAddress = "Prinz Eugen-Straﬂe 27, 1030 Wien, Austria",
                  PhoneNumber = "35675790",
                  JobPosition = "HR Manager",
                  Institution = "MST"
              }
            );

        }
    }
}
