namespace Projeto_DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilhetes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lugar = c.String(),
                        Estado = c.String(),
                        Cliente_Id = c.Int(),
                        Funcionario_Id = c.Int(),
                        Sessao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_Id)
                .ForeignKey("dbo.Sessaos", t => t.Sessao_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.Sessao_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumFiscal = c.Int(nullable: false),
                        Nome = c.String(),
                        Morada = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salario = c.Single(nullable: false),
                        Funcao = c.String(),
                        Nome = c.String(),
                        Morada = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHoraInicio = c.DateTime(nullable: false),
                        DataHoraFim = c.DateTime(nullable: false),
                        Preco = c.Single(nullable: false),
                        Filme_Id = c.Int(),
                        Sala_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filmes", t => t.Filme_Id)
                .ForeignKey("dbo.Salas", t => t.Sala_Id)
                .Index(t => t.Filme_Id)
                .Index(t => t.Sala_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
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
                "dbo.Salas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Colunas = c.String(),
                        Filas = c.Int(nullable: false),
                        Cinema_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cinemas", t => t.Cinema_Id)
                .Index(t => t.Cinema_Id);
            
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Morada = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessaos", "Sala_Id", "dbo.Salas");
            DropForeignKey("dbo.Salas", "Cinema_Id", "dbo.Cinemas");
            DropForeignKey("dbo.Sessaos", "Filme_Id", "dbo.Filmes");
            DropForeignKey("dbo.Filmes", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Bilhetes", "Sessao_Id", "dbo.Sessaos");
            DropForeignKey("dbo.Bilhetes", "Funcionario_Id", "dbo.Funcionarios");
            DropForeignKey("dbo.Bilhetes", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Salas", new[] { "Cinema_Id" });
            DropIndex("dbo.Filmes", new[] { "Categoria_Id" });
            DropIndex("dbo.Sessaos", new[] { "Sala_Id" });
            DropIndex("dbo.Sessaos", new[] { "Filme_Id" });
            DropIndex("dbo.Bilhetes", new[] { "Sessao_Id" });
            DropIndex("dbo.Bilhetes", new[] { "Funcionario_Id" });
            DropIndex("dbo.Bilhetes", new[] { "Cliente_Id" });
            DropTable("dbo.Cinemas");
            DropTable("dbo.Salas");
            DropTable("dbo.Categorias");
            DropTable("dbo.Filmes");
            DropTable("dbo.Sessaos");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Bilhetes");
        }
    }
}
