namespace teamproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name_ID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Teams", t => t.Name_ID)
                .Index(t => t.Name_ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cups", "Name_ID", "dbo.Teams");
            DropIndex("dbo.Cups", new[] { "Name_ID" });
            DropTable("dbo.Teams");
            DropTable("dbo.Cups");
        }
    }
}
