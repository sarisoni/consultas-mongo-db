using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller {
    [HttpGet("registro-de-baños-menores")]
    public IActionResult RegistrosBañosMenores (){
        //listar todos los baños

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroTipo = Builders<Inmueble>.Filter.Lt(x => x.Tipo, "Terreno");
        var filtroBaños = Builders<Inmueble>.Filter.Lt(x => x.Baños, 3);
        
        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroTipo, filtroBaños);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
    }

         [HttpGet("registros-metros-contruccion-menores")]
    public IActionResult RegistrosMetrosConstruccionMenores (){
        //listar todos metros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 518);
        
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

          [HttpGet("registros-costos-menores")]
    public IActionResult RegistrosCostosMenores (){
        //listar todos los costos menores

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroTipo = Builders<Inmueble>.Filter.Lt(x => x.Tipo, "Terreno");
        var filtroCosto = Builders<Inmueble>.Filter.Lt(x => x.Costo, 70000);
        
         var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroTipo, filtroCosto);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
    }

        
          [HttpGet("registros-año-publicacion-menores")]
    public IActionResult RegistrosAñoPublicacionMenores (){
        //listar todos los años menores

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroTipo = Builders<Inmueble>.Filter.Lt(x => x.Tipo, "Terreno");
        var filtroFechaPublicacion = Builders<Inmueble>.Filter.Lt(x => x.FechaPublicacion, "2025");
        
         var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroTipo, filtroFechaPublicacion);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);

    }
        [HttpGet("registros-pisos-menores")]
    public IActionResult RegistrosPisosMenores (){
        //listar todos los pisos menores

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroTipo = Builders<Inmueble>.Filter.Lt(x => x.Tipo, "Terreno");
        var filtroPisos = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 3);
        
         var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroTipo, filtroPisos);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
    }
}