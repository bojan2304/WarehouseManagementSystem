using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseManagementSystem.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseBranches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseEmployeeCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseEmployeeCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseAssets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: true),
                    PurposeShortDescription = table.Column<string>(maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarrantyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehouseAssets_WarehouseBranches_LocationId",
                        column: x => x.LocationId,
                        principalTable: "WarehouseBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehouseAssets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    WarehouseEmployeeCardId = table.Column<int>(nullable: false),
                    HomeWarehouseBranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_WarehouseBranches_HomeWarehouseBranchId",
                        column: x => x.HomeWarehouseBranchId,
                        principalTable: "WarehouseBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_WarehouseEmployeeCards_WarehouseEmployeeCardId",
                        column: x => x.WarehouseEmployeeCardId,
                        principalTable: "WarehouseEmployeeCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckoutHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseAssetId = table.Column<int>(nullable: false),
                    WarehouseEmployeeCardId = table.Column<int>(nullable: false),
                    CheckedOut = table.Column<DateTime>(nullable: false),
                    CheckedIn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_WarehouseAssets_WarehouseAssetId",
                        column: x => x.WarehouseAssetId,
                        principalTable: "WarehouseAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckoutHistories_WarehouseEmployeeCards_WarehouseEmployeeCardId",
                        column: x => x.WarehouseEmployeeCardId,
                        principalTable: "WarehouseEmployeeCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseAssetId = table.Column<int>(nullable: false),
                    WarehouseEmployeeCardId = table.Column<int>(nullable: true),
                    Since = table.Column<DateTime>(nullable: false),
                    Until = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_WarehouseAssets_WarehouseAssetId",
                        column: x => x.WarehouseAssetId,
                        principalTable: "WarehouseAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkouts_WarehouseEmployeeCards_WarehouseEmployeeCardId",
                        column: x => x.WarehouseEmployeeCardId,
                        principalTable: "WarehouseEmployeeCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_WarehouseAssetId",
                table: "CheckoutHistories",
                column: "WarehouseAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistories_WarehouseEmployeeCardId",
                table: "CheckoutHistories",
                column: "WarehouseEmployeeCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_WarehouseAssetId",
                table: "Checkouts",
                column: "WarehouseAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_WarehouseEmployeeCardId",
                table: "Checkouts",
                column: "WarehouseEmployeeCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_HomeWarehouseBranchId",
                table: "Employees",
                column: "HomeWarehouseBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WarehouseEmployeeCardId",
                table: "Employees",
                column: "WarehouseEmployeeCardId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseAssets_LocationId",
                table: "WarehouseAssets",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseAssets_StatusId",
                table: "WarehouseAssets",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTypes");

            migrationBuilder.DropTable(
                name: "CheckoutHistories");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "WarehouseAssets");

            migrationBuilder.DropTable(
                name: "WarehouseEmployeeCards");

            migrationBuilder.DropTable(
                name: "WarehouseBranches");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
