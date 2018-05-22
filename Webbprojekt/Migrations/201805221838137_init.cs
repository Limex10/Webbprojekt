namespace Webbprojekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        TwitterLink = c.String(nullable: false),
                        FacebookLink = c.String(nullable: false),
                        InstagramLink = c.String(nullable: false),
                        ImageFile = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArtistID = c.Int(nullable: false),
                        ImageFile = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galleries");
            DropTable("dbo.Artists");
        }
    }
}
