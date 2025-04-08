using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/Nin")]
public class NinController : Controller {
    [HttpGet("inmuebles-numero-baños")]
    public IActionResult InmueblesNumeroBaños (){
      

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(1);
        numeros.Add(2);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Baños, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    } 

        [HttpGet("inmuebles-metros-construccion")]
    public IActionResult ListaInmueblesMetrosConstruccion (){
      

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(600);
        numeros.Add(500);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.MetrosConstruccion, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

        [HttpGet("inmuebles-costo-terreno")]
    public IActionResult InmuebleCostoTerreno (){
      

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(70000);
        numeros.Add(80000);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
      }

         [HttpGet("inmuebles-que-no-tengan")]
    public IActionResult InmueblesNoTengan (){
      

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> numeros = new List<int>();
        numeros.Add(2);
        numeros.Add(3);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Pisos, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    } 

          [HttpGet("inmuebles-fecha-publicacion")]
    public IActionResult InmueblesFechaPublicacion (){
      

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> numeros = new List<string>();
        numeros.Add("2025-02-14");
        numeros.Add("2025-01-25");
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.FechaPublicacion, numeros);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}