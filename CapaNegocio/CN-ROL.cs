﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_ROL
    {

        private CD_Rol objcd_Rol = new CD_Rol();
        public List<Rol> Listar()
        {
            return objcd_Rol.Listar();
        }


    }
}
