namespace LearnMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.IdentityUserRoles");
            AlterColumn("dbo.IdentityUserRoles", "RoleId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ApplicationUsers", "Birthday", c => c.DateTime());
            AddPrimaryKey("dbo.IdentityUserRoles", new[] { "UserId", "RoleId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.IdentityUserRoles");
            AlterColumn("dbo.ApplicationUsers", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.IdentityUserRoles", "RoleId", c => c.String());
            AddPrimaryKey("dbo.IdentityUserRoles", "UserId");
        }
    }
}
