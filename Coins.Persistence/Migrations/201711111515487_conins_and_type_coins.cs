namespace Coins.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conins_and_type_coins : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TypecoinId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeCoins", t => t.TypecoinId)
                .Index(t => t.TypecoinId);
            
            CreateTable(
                "dbo.TypeCoins",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Tag = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "TypecoinId", "dbo.TypeCoins");
            DropIndex("dbo.Coins", new[] { "TypecoinId" });
            DropTable("dbo.TypeCoins");
            DropTable("dbo.Coins");
        }
    }
}
