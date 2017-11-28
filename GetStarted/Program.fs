// Learn more about F# at http://fsharp.org

open Suave
open LiteDB
open LiteDB.FSharp
open Suave.OData.LiteDB
open System.IO
type Company = {
    Id: int
    Name: string
}
[<EntryPoint>]
let main _ =
  let mapper = FSharpBsonMapper()
  use memoryStream = new MemoryStream()
  use db = new LiteRepository(memoryStream, mapper)    
  db.Insert({Id=1;Name="testCompany"})
  let odataRouter=resource "odata/company" (db.Database.GetCollection<Company>()) |> OData.CRUD
  let app=choose[
                   odataRouter
                   //other Suave Router
  ]
  startWebServer defaultConfig app
  0 
