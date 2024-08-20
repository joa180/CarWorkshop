using CarWorkshop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopSeeder(CarWorkshopDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.CarWorkshops.Any()) 
                {
                    var lexusAso = new Domain.Entities.CarWorkshop()
                    {
                        Name = "Lexus ASO",
                        Description = "Autoryzowany serwis Lexus'a",
                        About = "Jakiś tam fajny opis",
                        ContactDetails = new()
                        {
                            City = "Poznań",
                            Street = "Naramowicka 777",
                            PostalCode = "88-888",
                            PhoneNumber = "+48555666777"
                        }
                    };
                    lexusAso.EncodeName();

                    _dbContext.CarWorkshops.Add(lexusAso);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
