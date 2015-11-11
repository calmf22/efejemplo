namespace demobasedatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correcciondep : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empleadoes", "Departamentos_id", "dbo.Departamentos");
            DropIndex("dbo.Empleadoes", new[] { "Departamentos_id" });
            RenameColumn(table: "dbo.Empleadoes", name: "Departamentos_id", newName: "DepartamentosId");
            AlterColumn("dbo.Empleadoes", "DepartamentosId", c => c.Int(nullable: false));
            CreateIndex("dbo.Empleadoes", "DepartamentosId");
            AddForeignKey("dbo.Empleadoes", "DepartamentosId", "dbo.Departamentos", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "DepartamentosId", "dbo.Departamentos");
            DropIndex("dbo.Empleadoes", new[] { "DepartamentosId" });
            AlterColumn("dbo.Empleadoes", "DepartamentosId", c => c.Int());
            RenameColumn(table: "dbo.Empleadoes", name: "DepartamentosId", newName: "Departamentos_id");
            CreateIndex("dbo.Empleadoes", "Departamentos_id");
            AddForeignKey("dbo.Empleadoes", "Departamentos_id", "dbo.Departamentos", "id");
        }
    }
}
