# Introduccion

Este es un proyecto para probar el paquete de SoapCore y generar servicios SOAP

## Metodo con Modelos Complejo

Para invocar la operación con un modelo complejo utilizar la siguiente trama XML

``` xml
<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <TestCustomModel xmlns="http://tempuri.org/">
      <inputModel>
        <Id>1231</Id>
        <Nombre>John</Nombre>
        <Apellido>Doe</Apellido>
        <Direcciones>
           <Direccion>
             <Calle>Mariano Acha</Calle>
             <Numero>1033</Numero>
           </Direccion>
            <Direccion>
             <Calle>Palpa</Calle>
             <Numero>1020</Numero>
           </Direccion>
        </Direcciones>
      </inputModel>
    </TestCustomModel>
  </soap:Body>
</soap:Envelope>
```
## Response Esperado

Este es un ejemplo de la respuesta

``` xml
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <s:Body>
        <TestCustomModelResponse xmlns="http://tempuri.org/">
            <TestCustomModelResult>
                <Id>1231</Id>
                <Nombre>John</Nombre>
                <Apellido>Doe Modificado!</Apellido>
                <Direcciones>
                    <Direccion>
                        <Calle>Mariano Acha Modificado!</Calle>
                        <Numero>1033</Numero>
                    </Direccion>
                    <Direccion>
                        <Calle>Palpa Modificado!</Calle>
                        <Numero>1020</Numero>
                    </Direccion>
                </Direcciones>
            </TestCustomModelResult>
        </TestCustomModelResponse>
    </s:Body>
</s:Envelope>
```

