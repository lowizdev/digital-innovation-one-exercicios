using CadastroSeriesDIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeriesDIO.Entidades
{
    public class RepositorioSeries : IRepositorio
    {
        private List<Serie> Series = new List<Serie>();
        public Serie Create(Serie serie)
        {
            Series.Add(serie);
            return serie;
        }

        public bool Delete(int id)
        {
            var res = Series.RemoveAll(serie => serie.Id == id);

            if (res > 0) {
                return true;
            }

            return false;

        }

        public int GetLastId()
        {
            return Series.Count + 1;
        }

        public Serie Read(int id)
        {
            return Series.Find(serie => serie.Id == id);
        }

        public Serie Update(int id, Serie serie)
        {
            //var serieEncontrada = Series.Find(serie => serie.Id == id);

            Delete(id);
            Create(serie);

            return serie;
            
        }
    }
}
