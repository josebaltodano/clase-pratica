using Domain.Enties;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositoy
{
    public class SDA : IDepreciacion
    {
        public List<double> Depreacion(Activo activo)
        {
            List<double> depreciaciones = new List<double>();
            double TotalVidaUtil = 0;
            for (int i = 1; i < activo.años + 1; i++)
            {
                TotalVidaUtil += i;
            }
            for (int i = 1; i < activo.años + 1; i++)
            {
                double depreciacion = (i * (activo.vida - activo.vidautil)) / TotalVidaUtil;
                depreciaciones.Add(depreciacion);
            }
            return depreciaciones;

        }
    }
}
