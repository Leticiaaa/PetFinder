namespace PetFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Adocao",
                c => new
                    {
                        AdocaoId = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(),
                        DataFim = c.DateTime(),
                        Vizualizacao = c.Int(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.AdocaoId);
            
            CreateTable(
                "public.AdocaoInteresse",
                c => new
                    {
                        AdocaoInteresseId = c.Int(nullable: false, identity: true),
                        Mensagem = c.String(maxLength: 100),
                        InteressadoId = c.Int(nullable: false),
                        Aprovado = c.Int(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.AdocaoInteresseId);
            
            CreateTable(
                "public.Cidade",
                c => new
                    {
                        CidadeId = c.Int(nullable: false, identity: true),
                        CodigoIbge = c.Int(nullable: false),
                        Nome = c.String(maxLength: 100),
                        EstadoId = c.Int(nullable: false),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.CidadeId)
                .ForeignKey("public.Estado", t => t.EstadoId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "public.Estado",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        CodigoIbge = c.Int(nullable: false),
                        Nome = c.String(maxLength: 100),
                        Uf = c.String(maxLength: 100),
                        Ddd = c.String(maxLength: 100),
                        PaisId = c.Int(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.EstadoId)
                .ForeignKey("public.Pais", t => t.PaisId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "public.Pais",
                c => new
                    {
                        PaisId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Sigla = c.String(maxLength: 100),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.PaisId);
            
            CreateTable(
                "public.Endereco",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Rua = c.String(maxLength: 100),
                        Numero = c.String(maxLength: 100),
                        Referencia = c.String(maxLength: 100),
                        EstadoId = c.Int(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
            CreateTable(
                "public.PetImagem",
                c => new
                    {
                        PetImagemId = c.Int(nullable: false, identity: true),
                        PetId = c.Int(nullable: false),
                        Nome = c.String(maxLength: 100),
                        Arquivo = c.Binary(),
                        Formato = c.Int(nullable: false),
                        Capa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PetImagemId)
                .ForeignKey("public.Pet", t => t.PetId)
                .Index(t => t.PetId);
            
            CreateTable(
                "public.Pet",
                c => new
                    {
                        PetId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Observacao = c.String(maxLength: 100),
                        RacaId = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Porte = c.Int(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Castrado = c.Int(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.PetId)
                .ForeignKey("public.Raca", t => t.RacaId)
                .Index(t => t.RacaId);
            
            CreateTable(
                "public.Raca",
                c => new
                    {
                        RacaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Descricao = c.String(maxLength: 100),
                        Tipo = c.Int(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                        DataUltimaAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.RacaId);
            
            CreateTable(
                "public.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Sobrenome = c.String(maxLength: 100),
                        DataNascimento = c.DateTime(),
                        Telefone = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        Cpf = c.String(maxLength: 100),
                        DataUltimaAlteracao = c.DateTime(),
                        UsuarioCriacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.PetImagem", "PetId", "public.Pet");
            DropForeignKey("public.Pet", "RacaId", "public.Raca");
            DropForeignKey("public.Cidade", "EstadoId", "public.Estado");
            DropForeignKey("public.Estado", "PaisId", "public.Pais");
            DropIndex("public.Pet", new[] { "RacaId" });
            DropIndex("public.PetImagem", new[] { "PetId" });
            DropIndex("public.Estado", new[] { "PaisId" });
            DropIndex("public.Cidade", new[] { "EstadoId" });
            DropTable("public.Usuario");
            DropTable("public.Raca");
            DropTable("public.Pet");
            DropTable("public.PetImagem");
            DropTable("public.Endereco");
            DropTable("public.Pais");
            DropTable("public.Estado");
            DropTable("public.Cidade");
            DropTable("public.AdocaoInteresse");
            DropTable("public.Adocao");
        }
    }
}
