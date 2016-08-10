using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoCRUD.ViewModels
{
    public class LivrosPorGeneroViewModel
    {
        public LivrosPorGeneroViewModel()
        {
            Genero = "Todos";
        }

        public string Genero { get; set; }
        public List<Livro> Livros { get; set; }
    }
}