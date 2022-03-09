using Domain.Enties;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositoy
{
    public class LineaRecta : IDepreciacion
    {
        public List<double> Depreacion(Activo activo)
        {
            List<double> deprecaiones = new List<double>();
            for (int i = 1; i < activo.años + 1; i++)
            {
                double depreciacion = (activo.vida - activo.vidautil) / activo.años;
                deprecaiones.Add(depreciacion);


            }
            return deprecaiones;
        }
    }
}
