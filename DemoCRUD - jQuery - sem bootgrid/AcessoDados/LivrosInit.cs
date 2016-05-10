using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoCRUD.AcessoDados
{
    public class LivrosInit : CreateDatabaseIfNotExists<LivrosContexto>
    {
        protected override void Seed(LivrosContexto contexto)
        {
            List<Genero> generos = new List<Genero>()
            {
                new Genero() { Nome = "Administração" },
                new Genero() { Nome = "Agropecuária" },
                new Genero() { Nome = "Artes" },
                new Genero() { Nome = "Autoajuda" },
                new Genero() { Nome = "Ciências Biológicas" },
                new Genero() { Nome = "Ciências Exatas" },
                new Genero() { Nome = "Ciências Humanas e Sociais" },
                new Genero() { Nome = "Cursos e Idiomas" },
                new Genero() { Nome = "Didáticos" },
                new Genero() { Nome = "Direito" },
                new Genero() { Nome = "Economia" },
                new Genero() { Nome = "Engenharia e Tecnologia" },
                new Genero() { Nome = "Gastronomia" },
                new Genero() { Nome = "Geografia e Historia" },
                new Genero() { Nome = "Informática" },
                new Genero() { Nome = "Linguística" },
                new Genero() { Nome = "Literatura Nacional" },
                new Genero() { Nome = "Medicina" },
                new Genero() { Nome = "Religião" },
                new Genero() { Nome = "Turismo" },
            };

            generos.ForEach(g => contexto.Generos.Add(g));

            List<Livro> livros = new List<Livro>()
            {
                new Livro() {
                            Titulo = "O Poder do Hábito - Por Que Fazemos o Que Fazemos na Vida e Nos Negócios",
                            Autor = "Duhigg, Charles",
                            AnoEdicao = 2012,
                            Valor = 40.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administração")
                },
                new Livro() {
                            Titulo = "Os Segredos da Mente Milionária - Aprenda a Enriquecer Mudando seus Conceitos Sobre o Dinheiro",
                            Autor = "Eker, T. Harv",
                            AnoEdicao = 1992,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administração")
                },
                new Livro() {
                            Titulo = "Adestramento Inteligente",
                            Autor = "Rossi, Alexandre",
                            AnoEdicao = 2015,
                            Valor = 20.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecuária")
                },
                new Livro() {
                            Titulo = "Aves Florestais do Brasil",
                            Autor = "Bini, Etson",
                            AnoEdicao = 2014,
                            Valor = 89.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecuária")
                },
                new Livro() {
                            Titulo = "Guerra Civil",
                            Autor = "McNiven, Steve; MILLAR, MARK",
                            AnoEdicao = 2010,
                            Valor = 48m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes")
                },
                new Livro() {
                            Titulo = "Batman - A Morte da Família",
                            Autor = "Capullo, Greg; Snyder, Scott",
                            AnoEdicao = 2016,
                            Valor = 60.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes")
                },
                new Livro() {
                            Titulo = "Manual de Sobrevivência do Adolescente",
                            Autor = "Loures, Camila",
                            AnoEdicao = 2016,
                            Valor = 19.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda")
                },
                new Livro() {
                            Titulo = "O Mapa da Felicidade - As Coordenadas Para Curar A Sua Vida e Nunca Mais Olhar Para Trás",
                            Autor = "Capelas, Heloísa",
                            AnoEdicao = 2014,
                            Valor = 23.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda")
                },
                new Livro() {
                            Titulo = "A Origem Das Espécies - Edição Ilustrada",
                            Autor = "Darwin, Charles",
                            AnoEdicao = 2014,
                            Valor = 71.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Biológicas")
                },
                new Livro() {
                            Titulo = "A Sexta Extinção - Uma História Não Natural",
                            Autor = "Kolbert, Elizabeth",
                            AnoEdicao = 2015,
                            Valor = 17.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Biológicas")
                },
                new Livro() {
                            Titulo = "Raciocínio Lógico Facilitado",
                            Autor = "Villar, Bruno",
                            AnoEdicao = 2016,
                            Valor = 134.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Exatas")
                },
                new Livro() {
                            Titulo = "Cálculo",
                            Autor = "Stewart, James",
                            AnoEdicao = 2015,
                            Valor = 143.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Exatas")
                },
                new Livro() {
                            Titulo = "Uma Breve História da Humanidad",
                            Autor = "Harari, Yuval Noah",
                            AnoEdicao = 2015,
                            Valor = 47.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Humanas e Sociais")
                },
                new Livro() {
                            Titulo = "O Príncipe - Obra Completa",
                            Autor = "Maquiavel, Nicolau",
                            AnoEdicao = 2007,
                            Valor = 17.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Humanas e Sociais")
                },
                new Livro() {
                            Titulo = "English Grammar In Use With Answers",
                            Autor = "Murphy, Raymond",
                            AnoEdicao = 2012,
                            Valor = 173.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Cursos e Idiomas")
                },
                new Livro() {
                            Titulo = "Gramática Y Práctica de Español",
                            Autor = "Fanjul, AdrIan",
                            AnoEdicao = 2014,
                            Valor = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Cursos e Idiomas")
                },
                new Livro() {
                            Titulo = "Novíssima Gramática da Língua Portuguesa",
                            Autor = "Cegalla, Domingos Paschoal",
                            AnoEdicao = 2009,
                            Valor = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Didáticos")
                },
                new Livro() {
                            Titulo = "Química - Vol. Único",
                            Autor = "Usberco, Joao; Salvador, Edgard",
                            AnoEdicao = 2013,
                            Valor = 194.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Didáticos")
                },
                new Livro() {
                            Titulo = "Direito Processual Civil Esquematizado",
                            Autor = "Gonçalves, Marcus Vinicius Rios; (Coord.), Pedro Lenza",
                            AnoEdicao = 2016,
                            Valor = 163.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Direito")
                },
                new Livro() {
                            Titulo = "Direito Administrativo",
                            Autor = "Pietro, Maria Sylvia Zanella Di",
                            AnoEdicao = 2016,
                            Valor = 108.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Direito")
                },
                new Livro() {
                            Titulo = "O Capital - No Século XXI",
                            Autor = "Piketty, Thomas",
                            AnoEdicao = 2014,
                            Valor = 34.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Economia")
                },
                new Livro() {
                            Titulo = "Fundamentos de Economia",
                            Autor = "Vasconcellos, Marco Antonio S.; Garcia, Manuel E.",
                            AnoEdicao = 2014,
                            Valor = 68.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Economia")
                },
                new Livro() {
                            Titulo = "Manual Do Mundo",
                            Autor = "Alfredo Luis Mateus; Ibere Thenorio",
                            AnoEdicao = 2014,
                            Valor = 39.70m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Engenharia e Tecnologia")
                },
                new Livro() {
                            Titulo = "Ciência Engenharia de Materiais -Uma Introdução",
                            Autor = "Callister Jr., William D.",
                            AnoEdicao = 2012,
                            Valor = 223.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Engenharia e Tecnologia")
                },
                new Livro() {
                            Titulo = "Bela Cozinha - As Receitas",
                            Autor = "Gil , Bela",
                            AnoEdicao = 2014,
                            Valor = 29.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Gastronomia")
                },
                new Livro() {
                            Titulo = "Por Uma Vida Mais Doce",
                            Autor = "Noce, Danielle",
                            AnoEdicao = 2014,
                            Valor = 79.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Gastronomia")
                },
                new Livro() {
                            Titulo = "1808",
                            Autor = "Gomes, Laurentino",
                            AnoEdicao = 2014,
                            Valor = 31.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Geografia e Historia")
                },
                new Livro() {
                            Titulo = "A História do Mundo Para Quem Tem Pressa -Mais de 5000 Anos de História Resumidos Em 200 Páginas",
                            Autor = "Marriot, Emma",
                            AnoEdicao = 2015,
                            Valor = 22.60m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Geografia e Historia")
                },
                new Livro() {
                            Titulo = "Redes de Computadores",
                            Autor = "Tanenbaum, Andrew S.; J.Wetherall, David",
                            AnoEdicao = 2011,
                            Valor = 166.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Informática")
                },
                new Livro() {
                            Titulo = "Lógica de Programação - Conhecendo Algoritmos e Criando Programas",
                            Autor = "Simão , Daniel Hayashida; Reis , Wellington José Dos",
                            AnoEdicao = 2015,
                            Valor = 26.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Informática")
                },
                new Livro() {
                            Titulo = "Mídia Training - Como Usar A Mídia A Seu Favor",
                            Autor = "Barbeiro, Herodoto",
                            AnoEdicao = 2015,
                            Valor = 25.30m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Linguística")
                },
                new Livro() {
                            Titulo = "Anatomia de Um Julgamento - Ifigênia Em Forest Hills",
                            Autor = "Malcolm, Janet",
                            AnoEdicao = 2012,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Linguística")
                },
                new Livro() {
                            Titulo = "Tratado de Medicina Interna Veterinária - Doenças do Cão e do Gato",
                            Autor = "Ettinger, Stephen J.; Feldman, Edward C.",
                            AnoEdicao = 2004,
                            Valor = 1309.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Medicina")
                },
                new Livro() {
                            Titulo = "Clínica Veterinária - Um Tratado de Doenças dos Bovinos, Ovinos, Suínos, Caprinos e Equinos",
                            Autor = "Outros; Blood, Douglas C.; Radostits, Otto M.",
                            AnoEdicao = 2002,
                            Valor = 1080.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Medicina")
                },
                new Livro() {
                            Titulo = "Quarto de Guerra - A Oração É Uma Arma Poderosa na Batalha Espiritual",
                            Autor = "Fabry, Chris",
                            AnoEdicao = 2015,
                            Valor = 25.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Religião")
                },
                new Livro() {
                            Titulo = "Cristianismo Puro e Simples",
                            Autor = "Lewis, C. S.",
                            AnoEdicao = 2009,
                            Valor = 36.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Religião")
                },
                new Livro() {
                            Titulo = "Não Conta Lá Em Casa",
                            Autor = "Fran, André",
                            AnoEdicao = 2013,
                            Valor = 56.60m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Turismo")
                },
                new Livro() {
                            Titulo = "O Melhor Guia de Nova York",
                            Autor = "Andrade, Pedro",
                            AnoEdicao = 2013,
                            Valor = 29.30m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Turismo")
                }
            };

            livros.ForEach(l => contexto.Livros.Add(l));

            contexto.SaveChanges();
        }
    }
}