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
                        TimeRaised = c.DateTime(nullable: false),
                        EventClass = c.Guid(nullable: false),
                        EventId = c.Int(nullable: false),
                        SourceId = c.Int(nullable: false),
                        Text = c.String(),
                        SourceName = c.String(),
                    })
                .PrimaryKey(t => new { t.TimeRaised, t.EventClass, t.EventId, t.SourceId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
