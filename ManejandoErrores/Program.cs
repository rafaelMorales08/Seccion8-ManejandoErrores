//debug writeLine de apunte
using ManejandoErrores;
using System.Diagnostics;

var escritorConsola = new TextWriterTraceListener(System.Console.Out);
Trace.Listeners.Add(escritorConsola);

Console.WriteLine("esta linea se ha ejucutado");
Debug.WriteLine("Este mensaje solo aparecen en modo debug");

var escritorPeronalizaod = new TextWriterTraceListener(new EscritorPersonalizado());
Trace.Listeners.Add(escritorPeronalizaod);
Trace.Listeners.Add(escritorConsola);

//tracePoint


//excepciones

Console.WriteLine("antes del error");

throw new Exception();

Console.WriteLine("despues del error");



try
{
    Console.WriteLine("antes del error");

    throw new Exception();

    Console.WriteLine("despues del error");


}
catch (NotImplementedException ex)
{
    Console.WriteLine("hA OCURRIDO UNA EXCEPCION ");
    Console.WriteLine(ex.Message );
	throw;
}
finally
{

    Console.WriteLine("bloque fanaly");
}
