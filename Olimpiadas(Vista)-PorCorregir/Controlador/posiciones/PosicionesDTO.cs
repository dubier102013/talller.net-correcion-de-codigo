using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlador.posiciones
{
    public class PosicionesDTO
    {
        private byte idposicion;
        private string nombreposicion;

        public void setIdposicion(byte valor) {
            this.idposicion = valor;
        }
        public void setNombreposicion(string valor)
        {
            this.nombreposicion = valor;
        }

        public String getNombreposicion()
        {
            return this.nombreposicion;
        }

        public byte getIdposicion() {
            return this.idposicion;
        }

    }
}
