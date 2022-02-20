namespace EventLoggerConnector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventClass = c.Guid(nullable: false),
                        EventId = c.Int(nullable: false),
                        Text = c.String(),
                        TimeRaised = c.DateTime(nullable: false),
                        SourceId = c.Int(nullable: false),
                        SourceName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
