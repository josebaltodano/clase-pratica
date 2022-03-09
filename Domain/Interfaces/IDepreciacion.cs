using Domain.Enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
     public interface IDepreciacion
    {
        List<double> Depreacion(Activo activo);
    }
}
