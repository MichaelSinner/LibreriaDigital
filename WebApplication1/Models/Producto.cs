//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int idProducto { get; set; }
        public string NombreProducto { get; set; }
        public int TipoProducto { get; set; }
        public string EditorialProducto { get; set; }
        public string ISBNProducto { get; set; }
        public string AutorProducto { get; set; }
        public int PrecioProducto { get; set; }
        public int PrecioDescProducto { get; set; }
        public string Idioma { get; set; }
        public int Paginas { get; set; }
    }
}