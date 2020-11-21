namespace AndreMotos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NomeProduto = c.String(nullable: false, maxLength: 150, unicode: false),
                        CodigoProduto = c.Int(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
