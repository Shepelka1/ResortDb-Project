namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RootDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BarOrders",
                c => new
                    {
                        BarOrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BarOrderId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.RoomReservations",
                c => new
                    {
                        RoomReservationId = c.Int(nullable: false, identity: true),
                        ArrivalDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RoomReservationId);
            
            CreateTable(
                "dbo.RestaurantOrders",
                c => new
                    {
                        RestaurantOrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RestaurantOrderId);
            
            CreateTable(
                "dbo.SpaSessions",
                c => new
                    {
                        SpaSessionId = c.Int(nullable: false, identity: true),
                        SessionDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SpaSessionId);
            
            CreateTable(
                "dbo.ClientBarOrders",
                c => new
                    {
                        Client_ClientId = c.Int(nullable: false),
                        BarOrder_BarOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Client_ClientId, t.BarOrder_BarOrderId })
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .ForeignKey("dbo.BarOrders", t => t.BarOrder_BarOrderId, cascadeDelete: true)
                .Index(t => t.Client_ClientId)
                .Index(t => t.BarOrder_BarOrderId);
            
            CreateTable(
                "dbo.RoomReservationClients",
                c => new
                    {
                        RoomReservation_RoomReservationId = c.Int(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomReservation_RoomReservationId, t.Client_ClientId })
                .ForeignKey("dbo.RoomReservations", t => t.RoomReservation_RoomReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .Index(t => t.RoomReservation_RoomReservationId)
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.RestaurantOrderClients",
                c => new
                    {
                        RestaurantOrder_RestaurantOrderId = c.Int(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RestaurantOrder_RestaurantOrderId, t.Client_ClientId })
                .ForeignKey("dbo.RestaurantOrders", t => t.RestaurantOrder_RestaurantOrderId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .Index(t => t.RestaurantOrder_RestaurantOrderId)
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.SpaSessionClients",
                c => new
                    {
                        SpaSession_SpaSessionId = c.Int(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SpaSession_SpaSessionId, t.Client_ClientId })
                .ForeignKey("dbo.SpaSessions", t => t.SpaSession_SpaSessionId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .Index(t => t.SpaSession_SpaSessionId)
                .Index(t => t.Client_ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpaSessionClients", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.SpaSessionClients", "SpaSession_SpaSessionId", "dbo.SpaSessions");
            DropForeignKey("dbo.RestaurantOrderClients", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.RestaurantOrderClients", "RestaurantOrder_RestaurantOrderId", "dbo.RestaurantOrders");
            DropForeignKey("dbo.RoomReservationClients", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.RoomReservationClients", "RoomReservation_RoomReservationId", "dbo.RoomReservations");
            DropForeignKey("dbo.ClientBarOrders", "BarOrder_BarOrderId", "dbo.BarOrders");
            DropForeignKey("dbo.ClientBarOrders", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.SpaSessionClients", new[] { "Client_ClientId" });
            DropIndex("dbo.SpaSessionClients", new[] { "SpaSession_SpaSessionId" });
            DropIndex("dbo.RestaurantOrderClients", new[] { "Client_ClientId" });
            DropIndex("dbo.RestaurantOrderClients", new[] { "RestaurantOrder_RestaurantOrderId" });
            DropIndex("dbo.RoomReservationClients", new[] { "Client_ClientId" });
            DropIndex("dbo.RoomReservationClients", new[] { "RoomReservation_RoomReservationId" });
            DropIndex("dbo.ClientBarOrders", new[] { "BarOrder_BarOrderId" });
            DropIndex("dbo.ClientBarOrders", new[] { "Client_ClientId" });
            DropTable("dbo.SpaSessionClients");
            DropTable("dbo.RestaurantOrderClients");
            DropTable("dbo.RoomReservationClients");
            DropTable("dbo.ClientBarOrders");
            DropTable("dbo.SpaSessions");
            DropTable("dbo.RestaurantOrders");
            DropTable("dbo.RoomReservations");
            DropTable("dbo.Clients");
            DropTable("dbo.BarOrders");
        }
    }
}
