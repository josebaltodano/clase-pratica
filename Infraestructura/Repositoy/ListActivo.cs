using Domain.Enties;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositoy
{
    public class ListActivo : BaseRepository<Activo>, IActivoModel
    {
        public Activo GetById(int id)
        {
            foreach (Activo activo in data)
            {
                if(activo.Id == id)
                {
                    return activo;
                }
            }
            return null;
        }
    }
}
