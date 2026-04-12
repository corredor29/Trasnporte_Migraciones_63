using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migraciones_Trasporte.Migrations
{
    /// <inheritdoc />
    public partial class DocumentCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "document_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(64)", maxLength: 64, nullable: false, collation: "ascii_general_ci"),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentCategoryEntityId = table.Column<Guid>(type: "char(64)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_category", x => x.id);
                    table.ForeignKey(
                        name: "FK_document_category_document_category_DocumentCategoryEntityId",
                        column: x => x.DocumentCategoryEntityId,
                        principalTable: "document_category",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_document_category_DocumentCategoryEntityId",
                table: "document_category",
                column: "DocumentCategoryEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "document_category");
        }
    }
}
