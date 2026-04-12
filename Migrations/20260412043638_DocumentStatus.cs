using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migraciones_Trasporte.Migrations
{
    /// <inheritdoc />
    public partial class DocumentStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "DocumentCategoryEntityId",
                table: "document_category",
                type: "char(64)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(64)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "document_category",
                type: "char(64)",
                maxLength: 64,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(64)",
                oldMaxLength: 64)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "document_status",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(64)", maxLength: 64, nullable: false, collation: "ascii_general_ci"),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentStatusEntityId = table.Column<Guid>(type: "char(64)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_status", x => x.id);
                    table.ForeignKey(
                        name: "FK_document_status_document_status_DocumentStatusEntityId",
                        column: x => x.DocumentStatusEntityId,
                        principalTable: "document_status",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_document_status_DocumentStatusEntityId",
                table: "document_status",
                column: "DocumentStatusEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "document_status");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentCategoryEntityId",
                table: "document_category",
                type: "char(64)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(64)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "document_category",
                type: "char(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(64)",
                oldMaxLength: 64)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");
        }
    }
}
