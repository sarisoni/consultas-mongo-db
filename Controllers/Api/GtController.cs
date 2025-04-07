using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
    [HttpGet("costo-de-agentes-tipo-terreno")]
    public IActionResult CostoAgentesTipoTerreno (){
        //listar todos los registros de tipo 

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtroTipo = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        var filtroCosto = Builders<Inmueble>.Filter.Gt(x => x.Costo, 43141 );

        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroTipo, filtroCosto);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
    }
          [HttpGet("organizaciones-cada-piso-mayores")]
           public IActionResult OrganizacionesCadaPisoMayores (){
        //listar todos los registros de tipo 

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 0);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
        }

           
        [HttpGet("registros-precios-mayores")]
        public IActionResult RegitrosPreciosMayores (){
        //listar todos los registros precios mayores

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 5000-3000);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);

    }
        [HttpGet("registro-verificacion-costo-mayor")]
        public IActionResult RegitroVerificacionCostoMayor (){
        //listar todos los registros verificacion

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 28000);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
        }


            [HttpGet("cantidad-metros-terreno-mayors")]
        public IActionResult CantidadMetrosTerrenoMayores(){
        //listar todos las cantidades

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 500);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    

    }
    

    
 }

