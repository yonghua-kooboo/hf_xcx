using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mini.Migrations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mini_BaseData",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    IsDefault = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_BaseData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mini_Customers",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    OpenID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mini_Products",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    ProductType = table.Column<byte[]>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Digist = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: true),
                    End = table.Column<DateTime>(nullable: true),
                    Display = table.Column<short>(nullable: false),
                    SortIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mini_Salons",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Digist = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: true),
                    End = table.Column<DateTime>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_Salons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mini_Users",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ActiveStatu = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mini_ProductItems",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Display = table.Column<short>(nullable: false),
                    Start = table.Column<DateTime>(nullable: true),
                    End = table.Column<DateTime>(nullable: true),
                    ProductID = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_ProductItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mini_ProductItems_Mini_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Mini_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mini_Addresss",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    AddressType = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CustomerID = table.Column<byte[]>(nullable: true),
                    SalonID = table.Column<byte[]>(nullable: true),
                    Compere = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_Addresss", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mini_Addresss_Mini_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Mini_Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mini_Addresss_Mini_Salons_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Mini_Salons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mini_Orders",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<byte[]>(nullable: true),
                    SalonID = table.Column<byte[]>(nullable: true),
                    CustomerID = table.Column<byte[]>(nullable: false),
                    OrderStatu = table.Column<int>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    Complete = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mini_Orders_Mini_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Mini_Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mini_Orders_Mini_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Mini_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mini_Orders_Mini_Salons_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Mini_Salons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mini_SalonItems",
                columns: table => new
                {
                    ID = table.Column<byte[]>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Display = table.Column<short>(nullable: false),
                    SalonID = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mini_SalonItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mini_SalonItems_Mini_Salons_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Mini_Salons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mini_Addresss_CustomerID",
                table: "Mini_Addresss",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Mini_Addresss_SalonID",
                table: "Mini_Addresss",
                column: "SalonID");

            migrationBuilder.CreateIndex(
                name: "IX_Mini_Orders_CustomerID",
                table: "Mini_Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Mini_Orders_ProductID",
                table: "Mini_Orders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Mini_Orders_SalonID",
                table: "Mini_Orders",
                column: "SalonID");

            migrationBuilder.CreateIndex(
                name: "IX_Mini_ProductItems_ProductID",
                table: "Mini_ProductItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Mini_SalonItems_SalonID",
                table: "Mini_SalonItems",
                column: "SalonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mini_Addresss");

            migrationBuilder.DropTable(
                name: "Mini_BaseData");

            migrationBuilder.DropTable(
                name: "Mini_Orders");

            migrationBuilder.DropTable(
                name: "Mini_ProductItems");

            migrationBuilder.DropTable(
                name: "Mini_SalonItems");

            migrationBuilder.DropTable(
                name: "Mini_Users");

            migrationBuilder.DropTable(
                name: "Mini_Customers");

            migrationBuilder.DropTable(
                name: "Mini_Products");

            migrationBuilder.DropTable(
                name: "Mini_Salons");
        }
    }
}
