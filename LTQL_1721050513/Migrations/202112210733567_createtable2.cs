namespace LTQL_1721050513.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SanPham513", newName: "NTHSanPham513");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.NTHSanPham513", newName: "SanPham513");
        }
    }
}
