namespace TaskManagerDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quote",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuoteType = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        TaskDescription = c.String(),
                        DueDate = c.DateTime(nullable: false),
                        TaskType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quote");
        }
    }
}
