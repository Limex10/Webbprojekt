namespace Webbprojekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gallery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArtistName = c.String(nullable: false),
                        ImageFile = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galleries");
        }
    }
}
