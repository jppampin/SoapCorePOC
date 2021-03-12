using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class MyCustomModel
    {
       [DataMember]
       public int Id { get; set; }
       [DataMember]
       public string Nombre { get; set; }
       [DataMember]
       public string Apellido { get; set; }
       [DataMember]
       public List<Direccion> Direcciones {get; set;}
    }

    [DataContract]
    public class Direccion
    {
      [DataMember]
      public string Calle {get; set;}
      public string Numero {get; set;}
    }
}
