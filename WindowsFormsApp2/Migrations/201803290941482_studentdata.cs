namespace WindowsFormsApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDatas",
                c => new
                    {
                        Age = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mobile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Age);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentDatas");
        }
    }
}
