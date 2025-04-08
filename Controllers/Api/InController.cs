using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller {
    [HttpGet("metros-de-construccion-mayor-menor")]
    public IActionResult MetrosConstruccionMayorMenor (){
        //listar todas los metros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(314);
        numeros.Add(699);
        var filtro = Builders<Inmueble>.Filter.In(x => x.MetrosConstruccion, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
         [HttpGet("propiedades-venta-precio-menor")]
    public IActionResult PropiedadesVentaPrecioMenor (){
        //listar todas las propiedades

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(11514);
        numeros.Add(1331777);
        var filtro = Builders<Inmueble>.Filter.In(x => x.Costo, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
         [HttpGet("registro-fechas-ventas-publicadas")]
    public IActionResult RegistroFechasVentasPublicadas (){
        //listar todas las propiedades

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> numeros = new List<string>();
        numeros.Add("2024-01-01");
        numeros.Add("2025-02-26");
        var filtro = Builders<Inmueble>.Filter.In(x => x.FechaPublicacion, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);

    }
        
         [HttpGet("registros-pisos-alquiler")]
    public IActionResult RegistosPisosAlquiler (){
        //listar todas los registros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(0);
        numeros.Add(2);
        var filtro = Builders<Inmueble>.Filter.In(x => x.Pisos, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
         [HttpGet("registros-propiedades-precio-mensual")]
    public IActionResult RegistosPropiedadesPrecioMensual (){
        //listar todas los registros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(1956026);
        numeros.Add(12495);
        var filtro = Builders<Inmueble>.Filter.In(x => x.Costo, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }


}        