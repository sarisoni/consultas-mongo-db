using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {
    [HttpGet("lista-de-inmuebles-metros-construccion")]
    public IActionResult ListaInmueblesMetrosConstruccion (){
        //listar todos los inmuebles  

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 0);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

        [HttpGet("lista-de-inmuebles-menores")]
    public IActionResult ListaInmueblesMenores (){
        //listar todos los inmuebles menores  

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 2);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
         [HttpGet("lista-de-nombre-agente")]
    public IActionResult ListaNombreAgente (){
        //listar todos los nombres de agentes

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Lte(x => x.NombreAgente, "Maria Lopez");
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);

    }
          [HttpGet("lista-de-inmuebles-area-construccion")]
    public IActionResult ListaInmueblesAreaConstruccion (){
        //listar todos los inmuebles

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 280);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);

    }
         [HttpGet("lista-inmuebles-construidos")]
    public IActionResult ListaInmueblesConstruidos (){
        //listar todos los inmuebles construidos

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Lte(x => x.FechaPublicacion, "2025");
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}