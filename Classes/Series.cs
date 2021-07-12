using System;
using SeriesCRUD.Enum;

namespace SeriesCRUD.Classes
{
    public class Series: EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano {get;set;}

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id =id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Título: " + Titulo + Environment.NewLine;
             retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        internal int retornaId()
        {
            return Id;
        }

    }
}