using MagicVila_Restful_Course.Models;
using Microsoft.EntityFrameworkCore;


namespace MagicVila_Restful_Course.Data
{
    //for mac, we are unable to use nuget console to run migration so, i tried this from stack overflow : https://stackoverflow.com/questions/45382536/how-to-enable-migrations-in-visual-studio-for-mac
    // in short, we can alternatively use terminal and run those commands ,
    // key commands : (be sure to cd in the project dir or use --projectName)
    // dotnet ef migrations add initial
    // dotnet ef database update


    //to add new table in the db, be sure to create the class in Model directory, andd add the Dbset<newTableName> newTableNames below


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}

