using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using auto2;

namespace auto2
{
    public class auto5
    {
        public int ID { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public DateTime Fecha { get; set; }
        public bool Usado { get; set; }
        public bool Importado { get; set; }


    }

    public class AutoNegocio
    {
        public List<auto5> listar()
        {
            List<auto5> lista = new List<auto5>();
            lista.Add(new auto5());
            lista.Add(new auto5());

            lista[0].ID = 1;
            lista[0].Modelo = "Golf";
            lista[0].Descripcion = "Media de gama de vw";
            lista[0].Color = "Rojo";
            lista[0].Fecha = DateTime.Now;
            lista[0].Usado = true;
            lista[0].Importado = true;


            lista[1].ID = 2;
            lista[1].Modelo = "Gol";
            lista[1].Descripcion = "baja de gama de vw";
            lista[1].Color = "Blanco";
            lista[1].Fecha = DateTime.Now;
            lista[1].Usado = false;
            lista[1].Importado = true;

            return lista;



        }




    }
}