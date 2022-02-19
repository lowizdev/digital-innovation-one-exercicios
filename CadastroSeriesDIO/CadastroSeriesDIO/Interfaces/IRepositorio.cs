using CadastroSeriesDIO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeriesDIO.Interfaces
{
    public interface IRepositorio
    {
        public Serie Create(Serie serie);
        public Serie Read(int id);
        public Serie Update(int id, Serie serie);
        public bool Delete(int id);
        public int GetLastId();
    }
}
