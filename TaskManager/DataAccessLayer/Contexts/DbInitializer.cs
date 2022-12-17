using ApplicationLayer.Projects.Commands.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Contexts
{
    public class DbInitializer
    {
        public static void Initialize(TaskManagerDbContext db)
        {
            db.Database.EnsureCreated();
        }
    }
}
