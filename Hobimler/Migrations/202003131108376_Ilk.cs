namespace Hobimler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hobiler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HobiAd = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ogrenciler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OgrenciAd = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OgrenciHobis",
                c => new
                    {
                        Ogrenci_Id = c.Int(nullable: false),
                        Hobi_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_Id, t.Hobi_Id })
                .ForeignKey("dbo.Ogrenciler", t => t.Ogrenci_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hobiler", t => t.Hobi_Id, cascadeDelete: true)
                .Index(t => t.Ogrenci_Id)
                .Index(t => t.Hobi_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciHobis", "Hobi_Id", "dbo.Hobiler");
            DropForeignKey("dbo.OgrenciHobis", "Ogrenci_Id", "dbo.Ogrenciler");
            DropIndex("dbo.OgrenciHobis", new[] { "Hobi_Id" });
            DropIndex("dbo.OgrenciHobis", new[] { "Ogrenci_Id" });
            DropTable("dbo.OgrenciHobis");
            DropTable("dbo.Ogrenciler");
            DropTable("dbo.Hobiler");
        }
    }
}
