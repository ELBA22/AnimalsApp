using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICita Citas {get;}
        ICiudad Ciudades {get;}
        ICliente Clientes {get;}
        IClienteDireccion ClienteDirecciones {get;}
        IClienteTelefono ClienteTelefonos {get;}
        IDepartamento Departamentos {get;}
        IMascota Mascotas {get;}
        IPais Paises {get;}
        IRaza Razas {get;}
        IServicio Servicios {get;}
        IRefreshToken RefreshTokens {get;}

        IRol Rols {get;}
        IUser Users {get;}
        Task<int> SaveAsync();
    }
}