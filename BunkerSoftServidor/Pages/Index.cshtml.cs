using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BunkerSoftServidor.Models;

namespace BunkerSoftServidor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IApplicationRepository  _repository;

        public IndexModel(IApplicationRepository repository) => _repository = repository;
        public async Task OnGetAsync()
        {
            await _repository.Query(Pruebas);
        }
        public void OnGet()
        {

        }
    }
}
