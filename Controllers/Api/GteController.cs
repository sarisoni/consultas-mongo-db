using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {
    [HttpGet("cantidad-baños-casa")]
    public IActionResult CantidadBañosCasa (){
        //listar todas las cantidades 

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Baños, 2);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
        [HttpGet("terrenos-metros-de-construccion")]
    public IActionResult TerrenosMetrosConstruccion (){
        //listar todas los metros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, 350);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
          [HttpGet("cantidad-nombres-de-agentes")]
    public IActionResult CantidadNombresAgentes (){
        //listar todas los metros

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gte(x => x.NombreAgente, "Ana Torres");
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
          [HttpGet("fechas-publicadas-del-mismo-año")]
    public IActionResult FechaPublicadasMismoAño (){
        //listar todas las fechas publicadas

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gte(x => x.FechaPublicacion, "2024-01-01,2025-01-01");
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
             [HttpGet("lista-de-costos")]
    public IActionResult ListaCostos (){
        //listar todas las listas de costos

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 600000);
        
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
 }