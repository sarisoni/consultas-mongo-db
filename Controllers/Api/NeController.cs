using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/Ne")]
public class NeController : Controller {
    [HttpGet("listado-inmuebles-registros-baños")]
    public IActionResult ListadoInmueblesRegistrosBaños (){
        //listado de iinmuebles

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Baños, 4);

        var lista = collection.Find(filtro).ToList();
          return Ok (lista);

        }
          [HttpGet("registro-metros-construccion")]
    public IActionResult RegistrosMetrosConstruccion (){
        //listado de iinmuebles

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.MetrosConstruccion, 530);

        var lista = collection.Find(filtro).ToList();
          return Ok (lista);

        }
            [HttpGet("listado-costos-terrenos")]
    public IActionResult ListadoCostosterrenos (){
        //listado de costos

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 70000);

        var lista = collection.Find(filtro).ToList();
          return Ok (lista);

        }
           [HttpGet("registros-inmuebles")]
    public IActionResult RegistrosInmuebles (){
        //listado de los registros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Pisos, 2);

        var lista = collection.Find(filtro).ToList();
          return Ok (lista);


        }  
           [HttpGet("inmuebles-fecha-publicacion")]
           public IActionResult InmuebleFechaPublicacion (){
        //listado de los inmuebles

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
       
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.FechaPublicacion, "2025-01-10");

        var lista = collection.Find(filtro).ToList();
          return Ok (lista);
 
 
 
 
 
     }
}