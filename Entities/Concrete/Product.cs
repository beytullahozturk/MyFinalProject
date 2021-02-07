using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        // public yazınca bu class a diğer katmanlarda erişebilsin demektir
        // interval yazarsak sadece NTTS erişebilir demektir

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //short small int demek
        public decimal UnitPrice { get; set; }

    }
}   
