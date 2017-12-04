namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Venta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No_Factura = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empleados", t => t.EmpleadoId, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.ProductoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "ProductoId", "dbo.Productos");
            DropForeignKey("dbo.Ventas", "EmpleadoId", "dbo.Empleados");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Ventas", new[] { "ProductoId" });
            DropIndex("dbo.Ventas", new[] { "EmpleadoId" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropTable("dbo.Ventas");
        }
    }
}
