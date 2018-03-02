namespace ControleFinanceiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movimentacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Tipo = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        Usuario_IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_IdUsuario, cascadeDelete: true)
                .Index(t => t.Usuario_IdUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentacaos", "Usuario_IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Movimentacaos", new[] { "Usuario_IdUsuario" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Movimentacaos");
        }
    }
}
