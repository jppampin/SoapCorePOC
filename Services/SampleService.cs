using Models;
using System;
using System.Xml.Linq;

namespace Services
{
  public class SampleService : ISampleService
  {
    public string Test(string s)
    {
      Console.WriteLine("Test Method Executed!");
      return s;
    }
    public void XmlMethod(XElement xml)
    {
      Console.WriteLine(xml.ToString());
    }
    public MyCustomModel TestCustomModel(MyCustomModel customModel)
    {
      customModel.Apellido += " Modificado!";
      foreach( var direccion in customModel.Direcciones) 
      {
	direccion.Calle += " Modificado!";
      }
      return customModel;
    }
  }
}
