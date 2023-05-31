namespace Projeto_DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarBasedeDados : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sessaos", newName: "Categorias");
            DropIndex("dbo.Filmes", new[] { "Categoria_Id" });
            AddColumn("dbo.Categorias", "Nome", c => c.String());
            AddColumn("dbo.Categorias", "Ativa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categorias", "Duracao", c => c.Time(precision: 7));
            AddColumn("dbo.Categorias", "Ativo", c => c.Boolean());
            AddColumn("dbo.Categorias", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Categorias", "Categoria_Id", c => c.Int());
            AlterColumn("dbo.Categorias", "DataHoraInicio", c => c.DateTime());
            AlterColumn("dbo.Categorias", "DataHoraFim", c => c.DateTime());
            AlterColumn("dbo.Categorias", "Preco", c => c.Single());
            CreateIndex("dbo.Categorias", "Categoria_Id");
            DropTable("dbo.Filmes");
            DropTable("dbo.Categorias");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Ativa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Duracao = c.Time(nullable: false, precision: 7),
                        Ativo = c.Boolean(nullable: false),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.Categorias", new[] { "Categoria_Id" });
            AlterColumn("dbo.Categorias", "Preco", c => c.Single(nullable: false));
            AlterColumn("dbo.Categorias", "DataHoraFim", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Categorias", "DataHoraInicio", c => c.DateTime(nullable: false));
            DropColumn("dbo.Categorias", "Categoria_Id");
            DropColumn("dbo.Categorias", "Discriminator");
            DropColumn("dbo.Categorias", "Ativo");
            DropColumn("dbo.Categorias", "Duracao");
            DropColumn("dbo.Categorias", "Ativa");
            DropColumn("dbo.Categorias", "Nome");
            CreateIndex("dbo.Filmes", "Categoria_Id");
            RenameTable(name: "dbo.Categorias", newName: "Sessaos");
        }
    }
}
