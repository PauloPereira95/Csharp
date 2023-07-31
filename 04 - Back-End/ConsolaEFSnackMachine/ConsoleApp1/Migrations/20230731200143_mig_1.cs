using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });

            migrationBuilder.CreateTable(
                name: "Intervetion",
                columns: table => new
                {
                    IDIntervetion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    NameTecnical = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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
                    Adress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Support", x => x.IDSupport);
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
                    TwentyCent = table.Column<int>(type: "int", nullable: false),
                    CostumerIDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.IDMoney);
                    table.ForeignKey(
                        name: "FK_Money_Costumer_CostumerIDCostumer",
                        column: x => x.CostumerIDCostumer,
                        principalTable: "Costumer",
                        principalColumn: "IDCostumer");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IDOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostumerIDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IDOrder);
                    table.ForeignKey(
                        name: "FK_Orders_Costumer_CostumerIDCostumer",
                        column: x => x.CostumerIDCostumer,
                        principalTable: "Costumer",
                        principalColumn: "IDCostumer");
                });

            migrationBuilder.CreateTable(
                name: "IntervetionMachine",
                columns: table => new
                {
                    IntervetionIDIntervetion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineIDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntervetionMachine", x => new { x.IntervetionIDIntervetion, x.MachineIDMachine });
                    table.ForeignKey(
                        name: "FK_IntervetionMachine_Intervetion_IntervetionIDIntervetion",
                        column: x => x.IntervetionIDIntervetion,
                        principalTable: "Intervetion",
                        principalColumn: "IDIntervetion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntervetionMachine_Machine_MachineIDMachine",
                        column: x => x.MachineIDMachine,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachinePosition",
                columns: table => new
                {
                    MachineIDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionIDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachinePosition", x => new { x.MachineIDMachine, x.PositionIDPosition });
                    table.ForeignKey(
                        name: "FK_MachinePosition_Machine_MachineIDMachine",
                        column: x => x.MachineIDMachine,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachinePosition_Position_PositionIDPosition",
                        column: x => x.PositionIDPosition,
                        principalTable: "Position",
                        principalColumn: "IDPosition",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineSupport",
                columns: table => new
                {
                    MachineIDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupportIDSupport = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineSupport", x => new { x.MachineIDMachine, x.SupportIDSupport });
                    table.ForeignKey(
                        name: "FK_MachineSupport_Machine_MachineIDMachine",
                        column: x => x.MachineIDMachine,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineSupport_Support_SupportIDSupport",
                        column: x => x.SupportIDSupport,
                        principalTable: "Support",
                        principalColumn: "IDSupport",
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
                    OrderIDOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IDProduct);
                    table.ForeignKey(
                        name: "FK_Product_Orders_OrderIDOrder",
                        column: x => x.OrderIDOrder,
                        principalTable: "Orders",
                        principalColumn: "IDOrder");
                });

            migrationBuilder.CreateTable(
                name: "MachineProduct",
                columns: table => new
                {
                    MachineIDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineProduct", x => new { x.MachineIDMachine, x.ProductIDProduct });
                    table.ForeignKey(
                        name: "FK_MachineProduct_Machine_MachineIDMachine",
                        column: x => x.MachineIDMachine,
                        principalTable: "Machine",
                        principalColumn: "IDMachine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineProduct_Product_ProductIDProduct",
                        column: x => x.ProductIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PositionProduct",
                columns: table => new
                {
                    PositionIDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionProduct", x => new { x.PositionIDPosition, x.ProductIDProduct });
                    table.ForeignKey(
                        name: "FK_PositionProduct_Position_PositionIDPosition",
                        column: x => x.PositionIDPosition,
                        principalTable: "Position",
                        principalColumn: "IDPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionProduct_Product_ProductIDProduct",
                        column: x => x.ProductIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSupplier",
                columns: table => new
                {
                    ProductIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierIDSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSupplier", x => new { x.ProductIDProduct, x.SupplierIDSupplier });
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Product_ProductIDProduct",
                        column: x => x.ProductIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Supplier_SupplierIDSupplier",
                        column: x => x.SupplierIDSupplier,
                        principalTable: "Supplier",
                        principalColumn: "IDSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntervetionMachine_MachineIDMachine",
                table: "IntervetionMachine",
                column: "MachineIDMachine");

            migrationBuilder.CreateIndex(
                name: "IX_MachinePosition_PositionIDPosition",
                table: "MachinePosition",
                column: "PositionIDPosition");

            migrationBuilder.CreateIndex(
                name: "IX_MachineProduct_ProductIDProduct",
                table: "MachineProduct",
                column: "ProductIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_MachineSupport_SupportIDSupport",
                table: "MachineSupport",
                column: "SupportIDSupport");

            migrationBuilder.CreateIndex(
                name: "IX_Money_CostumerIDCostumer",
                table: "Money",
                column: "CostumerIDCostumer");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CostumerIDCostumer",
                table: "Orders",
                column: "CostumerIDCostumer");

            migrationBuilder.CreateIndex(
                name: "IX_PositionProduct_ProductIDProduct",
                table: "PositionProduct",
                column: "ProductIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderIDOrder",
                table: "Product",
                column: "OrderIDOrder");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_SupplierIDSupplier",
                table: "ProductSupplier",
                column: "SupplierIDSupplier");
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
                name: "Position");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Costumer");
        }
    }
}
