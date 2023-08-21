using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    IDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Adress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Nif = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.IDCostumer);
                });

            migrationBuilder.CreateTable(
                name: "Intervection",
                columns: table => new
                {
                    IDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    NameTecnical = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervection", x => x.IDIntervection);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    IDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
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
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Nif = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.IDSupplier);
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
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerIDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.IDMoney);
                    table.ForeignKey(
                        name: "FK_Money_Customer_CustomerIDCostumer",
                        column: x => x.CustomerIDCostumer,
                        principalTable: "Customer",
                        principalColumn: "IDCostumer");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(10,3)", precision: 10, scale: 3, nullable: true),
                    NameTecnical = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerIDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IDIntervection);
                    table.ForeignKey(
                        name: "FK_Orders_Customer_CustomerIDCostumer",
                        column: x => x.CustomerIDCostumer,
                        principalTable: "Customer",
                        principalColumn: "IDCostumer");
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    IDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<decimal>(type: "decimal(10,3)", precision: 10, scale: 3, nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OrdersIDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.IDMachine);
                    table.ForeignKey(
                        name: "FK_Machine_Orders_OrdersIDIntervection",
                        column: x => x.OrdersIDIntervection,
                        principalTable: "Orders",
                        principalColumn: "IDIntervection");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,3)", precision: 10, scale: 3, nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OrderIDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IDProduct);
                    table.ForeignKey(
                        name: "FK_Product_Orders_OrderIDIntervection",
                        column: x => x.OrderIDIntervection,
                        principalTable: "Orders",
                        principalColumn: "IDIntervection");
                });

            migrationBuilder.CreateTable(
                name: "Support",
                columns: table => new
                {
                    IDSupport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Nif = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Adress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IntervectionIDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrdersIDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Support", x => x.IDSupport);
                    table.ForeignKey(
                        name: "FK_Support_Intervection_IntervectionIDIntervection",
                        column: x => x.IntervectionIDIntervection,
                        principalTable: "Intervection",
                        principalColumn: "IDIntervection");
                    table.ForeignKey(
                        name: "FK_Support_Orders_OrdersIDIntervection",
                        column: x => x.OrdersIDIntervection,
                        principalTable: "Orders",
                        principalColumn: "IDIntervection");
                });

            migrationBuilder.CreateTable(
                name: "IntervectionMachine",
                columns: table => new
                {
                    InteractionIDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineIDMachine = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntervectionMachine", x => new { x.InteractionIDIntervection, x.MachineIDMachine });
                    table.ForeignKey(
                        name: "FK_IntervectionMachine_Intervection_InteractionIDIntervection",
                        column: x => x.InteractionIDIntervection,
                        principalTable: "Intervection",
                        principalColumn: "IDIntervection",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntervectionMachine_Machine_MachineIDMachine",
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

            migrationBuilder.CreateIndex(
                name: "IX_IntervectionMachine_MachineIDMachine",
                table: "IntervectionMachine",
                column: "MachineIDMachine");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_OrdersIDIntervection",
                table: "Machine",
                column: "OrdersIDIntervection");

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
                name: "IX_Money_CustomerIDCostumer",
                table: "Money",
                column: "CustomerIDCostumer");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerIDCostumer",
                table: "Orders",
                column: "CustomerIDCostumer");

            migrationBuilder.CreateIndex(
                name: "IX_PositionProduct_ProductIDProduct",
                table: "PositionProduct",
                column: "ProductIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderIDIntervection",
                table: "Product",
                column: "OrderIDIntervection");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_SupplierIDSupplier",
                table: "ProductSupplier",
                column: "SupplierIDSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_Support_IntervectionIDIntervection",
                table: "Support",
                column: "IntervectionIDIntervection");

            migrationBuilder.CreateIndex(
                name: "IX_Support_OrdersIDIntervection",
                table: "Support",
                column: "OrdersIDIntervection");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntervectionMachine");

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
                name: "Intervection");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
