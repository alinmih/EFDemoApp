using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using EfDataAccessLibrary.DataAccess;
using EfDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFDemoUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _db;

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            LoadData();

            var people = _db.People
                .Include(a => a.Addresses)
                .Include(e => e.EmailAddresses)
                //.Where(x=> AprovedAge(x.Age))
                .Where(x=> x.Age >=18 && x.Age<=65)
                .ToList();
              
        }

        private bool AprovedAge(int age)
        {
            return (age >= 18 && age <= 65);
        }

        private void LoadData()
        {
            if (_db.People.Count() ==0)
            {
                string text = System.IO.File.ReadAllText("generated.json");
                var people = JsonSerializer.Deserialize<List<Person>>(text);
                _db.AddRange(people);
                _db.SaveChanges();

            }
        }
    }
}
