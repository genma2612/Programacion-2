﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase13
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        public string LavaderoToString
        {
            get
            {
                string retorno = "RAZON SOCIAL :" + this._razonSocial;
                retorno += "\nPRECIO AUTO: $" + _precioAuto;
                retorno += "\nPRECIO CAMION $: " + _precioCamion;
                retorno += "\nPRECIO MOTO: $" + _precioMoto;
                retorno += "\nVEHICULOS:\n";
                foreach (Vehiculo v in this._vehiculos)
                {
                    if (v is Auto)
                        retorno += "AUTO: \n";
                    if (v is Camion)
                        retorno += "CAMION: \n";
                    if (v is Moto)
                        retorno += "MOTO: \n";
                    retorno += v.ToString();
                }
                return retorno;
            }
        }

        public List<Vehiculo> Vehiculos { get { return this._vehiculos; } }

        public double MostrarTotalFacturado()
        {
            return MostrarTotalFacturado(EVehiculos.Auto) + MostrarTotalFacturado(EVehiculos.Camion) + MostrarTotalFacturado(EVehiculos.Moto);
        }

        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            double facturado = 0;
            int contAuto = 0;
            int contCamion = 0;
            int contMoto = 0;
            foreach (Vehiculo v in this._vehiculos)
            {
                if (v is Auto)
                    contAuto++;
                if (v is Camion)
                    contCamion++;
                if (v is Moto)
                    contMoto++;
            }
            switch (tipo)
            {
                case EVehiculos.Auto:
                    facturado = contAuto * _precioAuto;
                    break;
                case EVehiculos.Camion:
                    facturado = contCamion * _precioCamion;
                    break;
                case EVehiculos.Moto:
                    facturado = contMoto * _precioMoto;
                    break;
                default:
                    break;
            }
            return facturado;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo V1, Vehiculo V2)
        {
            int retorno = -1;
            if (V1.Patente == V2.Patente)
                retorno = 0;
            if (string.Compare(V1.Patente, V2.Patente) > 0)
                retorno = 1;
            return retorno;
        }

        public int OrdenarVehiculosPorMarca(Vehiculo V1, Vehiculo V2)
        {
            int retorno = -1;
            if (V1.Marca == V2.Marca)
                retorno = 0;
            if (string.Compare(V1.Patente, V2.Patente) > 0)
                retorno = 1;
            return retorno;
        }


        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach (Vehiculo v in lavadero._vehiculos)
            {
                if (v == vehiculo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static int operator ==(Vehiculo vehiculo, Lavadero lavadero)
        {
            int retorno = -1;
            for (int i = 0; i < lavadero._vehiculos.Count; i++)
            {
                if(vehiculo == lavadero._vehiculos[i])
                {
                    retorno = i;
                }
            }
            return retorno;
        }

        public static int operator !=(Vehiculo vehiculo, Lavadero lavadero)
        {
            return -2;
        }

        public static Lavadero operator +(Lavadero L, Vehiculo V)
        {
            foreach (Vehiculo item in L._vehiculos)
            {
                if (V == item)
                    return L;
            }
            L._vehiculos.Add(V);
            return L;
        }

        public static Lavadero operator -(Lavadero L, Vehiculo V)
        {
            foreach (Vehiculo item in L._vehiculos)
            {
                if (V == item)
                {
                    L._vehiculos.Remove(V);
                    break;
                }
                    
            }
            return L;
        }

        static Lavadero()
        {
            Random n = new Random();
            _precioAuto = n.Next(150, 565);
            _precioCamion = n.Next(150, 565);
            _precioMoto = n.Next(150, 565);
        }

        private Lavadero()
        {
            _vehiculos = new List<Vehiculo>();
        }


        public Lavadero(string razonSocial) : this()
        {
            this._razonSocial = razonSocial;
        }

    }
}