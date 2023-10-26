using Azure.Core.Pipeline;
using Ex_baze_date.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ex_baze_date.dATA
{
    public class Lab3Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public Lab3Context(DbContextOptions<Lab3Context> options) : base(options) {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
