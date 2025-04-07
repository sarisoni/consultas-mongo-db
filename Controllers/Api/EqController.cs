using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-propietario")]
    public IActionResult ListarPropietario (){
        //listar todos los registros de tipo 

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //que el tipo sea terreno
        var filtroTipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        //que el agente sea Juan Perez
        var filtroNombreAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Juan Pérez");

        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroTipo, filtroNombreAgente);
        var lista = collection.Find(filtroCompuesto).ToList();
          return Ok (lista);
 
 }


 [HttpGet("listar-metros")]
    public IActionResult ListarMetros (){
        //listar todos los registros de metros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //que el tipo sea Casa
        var filtroTipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
        //que los metros terreno sea 553
        var filtroMetrosTerreno = Builders<Inmueble>.Filter.Eq(x => x.MetrosTerreno, 553);

        var filtroCompuesto = Builders<Inmueble>.Filter.And( filtroTipo, filtroMetrosTerreno);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
 }


 [HttpGet("listar-renta")]
    public IActionResult ListarRenta (){
        //listar todos los registros de renta

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //que el tipo sea terreno
        var filtroTipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        //que la operacion sea renta
        var filtroOperacion = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Renta");

        var filtroCompuesto = Builders<Inmueble>.Filter.And( filtroTipo, filtroOperacion);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
  }


 [HttpGet("listar-preciosterreno")]
    public IActionResult ListarPreciosTerrenos (){
        //listar todos los registros de renta

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //que el tipo sea terreno
        var filtroTipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        //que el costo sea 33421
        var filtroCosto = Builders<Inmueble>.Filter.Eq(x => x.Costo, 33421);

        var filtroCompuesto = Builders<Inmueble>.Filter.And( filtroTipo, filtroCosto);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
}

        [HttpGet("listar-fechapublicacion")]
    public IActionResult ListarFechaPublicacion (){
        //listar todos los registros de Fecha Publicacion

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.FechaPublicacion, "2025-02-26");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}



