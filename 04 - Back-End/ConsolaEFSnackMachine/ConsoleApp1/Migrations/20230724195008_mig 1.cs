using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intervetion",
                columns: table => new
                {
                    IDIntervetion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    NameTecnical = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervetion", x => x.IDIntervetion);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    IDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.IDMachine);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IDOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IDOrder);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    IDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripiton = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.IDPosition);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    IDSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    NIF = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Adrress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.IDSupplier);
                });

            migrationBuilder.CreateTable(
                name: "Support",
                columns: table => new
                {
                    IDSupport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Nif = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Adress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Support", x => x.IDSupport);
                });

            migrationBuilder.CreateTable(
                name: "IntervetionMachine",
                columns: table => new
                {
                    IDIntervetion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntervetionMachine", x => new { x.IDIntervetion, x.IDMachine });
                    table.ForeignKey(
                        name: "FK_IntervetionMachine_Intervetion_IDMachine",
                        column: x => x.IDMachine,
                        principalTable: "Intervetion",
                        principalColumn: "IDIntervetion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntervetionMachine_Machine_IDIntervetion",
                        column: x => x.IDIntervetion,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Costumer",
                columns: table => new
                {
                    IDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Adress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumer", x => x.IDCostumer);
                    table.ForeignKey(
                        name: "FK_Costumer_Orders_IDCostumer",
                        column: x => x.IDCostumer,
                        principalTable: "Orders",
                        principalColumn: "IDOrder",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDProduto = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IDProduct);
                    table.ForeignKey(
                        name: "FK_Product_Orders_IDProduto",
                        column: x => x.IDProduto,
                        principalTable: "Orders",
                        principalColumn: "IDOrder");
                });

            migrationBuilder.CreateTable(
                name: "MachinePosition",
                columns: table => new
                {
                    IDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachinePosition", x => x.IDPosition);
                    table.ForeignKey(
                        name: "FK_MachinePosition_Machine_IDPosition",
                        column: x => x.IDPosition,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachinePosition_Position_IDPosition",
                        column: x => x.IDPosition,
                        principalTable: "Position",
                        principalColumn: "IDPosition",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineSupport",
                columns: table => new
                {
                    IDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSupport = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineSupport", x => new { x.IDMachine, x.IDSupport });
                    table.ForeignKey(
                        name: "FK_MachineSupport_Machine_IDSupport",
                        column: x => x.IDSupport,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineSupport_Support_IDMachine",
                        column: x => x.IDMachine,
                        principalTable: "Support",
                        principalColumn: "IDSupport",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    IDMoney = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiveEuro = table.Column<int>(type: "int", nullable: false),
                    OneCent = table.Column<int>(type: "int", nullable: false),
                    OneEuro = table.Column<int>(type: "int", nullable: false),
                    QuarterCent = table.Column<int>(type: "int", nullable: false),
                    TenCent = table.Column<int>(type: "int", nullable: false),
                    TwentyCent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.IDMoney);
                    table.ForeignKey(
                        name: "FK_Money_Costumer_IDMoney",
                        column: x => x.IDMoney,
                        principalTable: "Costumer",
                        principalColumn: "IDCostumer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineProduct",
                columns: table => new
                {
                    IDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineProduct", x => new { x.IDMachine, x.IDProduct });
                    table.ForeignKey(
                        name: "FK_MachineProduct_Machine_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineProduct_Product_IDMachine",
                        column: x => x.IDMachine,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PositionProduct",
                columns: table => new
                {
                    IDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionProduct", x => x.IDPosition);
                    table.ForeignKey(
                        name: "FK_PositionProduct_Position_IDPosition",
                        column: x => x.IDPosition,
                        principalTable: "Position",
                        principalColumn: "IDPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionProduct_Product_IDPosition",
                        column: x => x.IDPosition,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSupplier",
                columns: table => new
                {
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSupplier", x => new { x.IDProduct, x.IDSupplier });
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Product_IDSupplier",
                        column: x => x.IDSupplier,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Supplier_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Supplier",
                        principalColumn: "IDSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntervetionMachine_IDMachine",
                table: "IntervetionMachine",
                column: "IDMachine");

            migrationBuilder.CreateIndex(
                name: "IX_MachineProduct_IDProduct",
                table: "MachineProduct",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_MachineSupport_IDSupport",
                table: "MachineSupport",
                column: "IDSupport");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IDProduto",
                table: "Product",
                column: "IDProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_IDSupplier",
                table: "ProductSupplier",
                column: "IDSupplier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntervetionMachine");

            migrationBuilder.DropTable(
                name: "MachinePosition");

            migrationBuilder.DropTable(
                name: "MachineProduct");

            migrationBuilder.DropTable(
                name: "MachineSupport");

            migrationBuilder.DropTable(
                name: "Money");

            migrationBuilder.DropTable(
                name: "PositionProduct");

            migrationBuilder.DropTable(
                name: "ProductSupplier");

            migrationBuilder.DropTable(
                name: "Intervetion");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Support");

            migrationBuilder.DropTable(
                name: "Costumer");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
