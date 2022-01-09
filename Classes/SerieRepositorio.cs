using System;
using System.Collections.Generic;
using Cadastro.Series.Interfaces;

namespace Cadastro.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            Console.WriteLine();
            Console.Write("Série atualizada com sucesso!");
            listaSerie[id] = objeto;
            Console.ReadLine();
            Console.WriteLine();
        }

        public void Exclui(int id)
        {
            Console.WriteLine();
            Console.Write("Série excluída com sucesso!");
            listaSerie[id].Excluir();
            Console.ReadLine();
            Console.WriteLine();
        }

        public void Insere(Serie objeto)
        {
            Console.WriteLine();
            Console.Write("Série inserida com sucesso!");
            listaSerie.Add(objeto);
            Console.ReadLine();
            Console.WriteLine();
        }

        public List<Serie> Lista()
        {
           return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}