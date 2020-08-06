using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryManager.Migrations
{
    public partial class addSubdivisionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subdivisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Category = table.Column<string>(maxLength: 64, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subdivisions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 529, DateTimeKind.Local).AddTicks(8275), new DateTime(2020, 8, 6, 16, 1, 11, 529, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1224), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1351), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1370), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1387), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1406), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1422), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1440), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1458), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1476), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1493), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1511), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1529), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1546), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1565), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1583), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1597), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1613), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1629), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1645), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1662), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1679), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1697), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1715), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1733), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1750), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1765), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1781), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1797), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1812), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1829), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1847), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1867), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1885), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1903), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1921), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1937), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1953), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1968), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1982), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2001), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2018), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2036), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2053), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2069), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2085), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2103), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2122), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2139), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2156), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2174), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2190), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2209), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2227), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2243), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2260), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2280), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2297), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2315), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2332), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2346), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2362), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2377), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2396), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2414), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2508), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2525), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2545), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2565), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2579), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2596), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2613), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2631), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2649), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2664), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2683), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2698), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2715), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2734), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2750), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2768), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2806), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2817), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2826), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2850), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2873), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2898), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2932), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2941), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2951), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2959), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2977), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2988), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3007), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3017), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3031), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3053), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3061), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3080), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3099), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3111), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3126), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3149), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3189), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3200), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3212), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3251), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3272), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3286), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3303), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3317), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3331), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3346), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3360), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3374), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3388), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3402), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3416), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3431), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3445), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3460), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3475), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3489), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3503), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3519), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3532), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3549), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3563), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3577), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3591), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3605), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3619), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3633), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3647), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3661), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3675), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3688), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3703), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3717), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3731), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3745), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3760), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3774), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3789), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3804), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3818), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3832), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3846), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3860), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3874), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3888), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3902), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3916), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3931), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3945), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3959), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3977), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3991), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4005), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4019), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4033), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4047), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4060), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4097), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4116), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4126), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4136), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4187), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4194), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4204), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4210), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4216), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4223), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4229), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4235), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4241), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4248), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4261), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4267), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4273), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4280), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4292), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4298), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4304), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4310), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4316), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4323), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4329), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4335), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4341), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4347), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4354), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4360), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4366), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4372), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4379), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4385), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4391), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4397), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4404), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4410), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4417), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4423), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4429), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4435), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4442), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4448), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4454), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4460), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4467), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4473), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4479), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4485), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4491), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4498), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4508), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4514), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4520), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4527), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4533), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4539), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4545), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4552), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4558), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4564), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4571), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4577), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4583), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4589), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4595), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4601), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4608), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4614), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4620), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4626), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4633), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4639), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4646), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4652), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4658), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4664), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4671), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4677), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4683), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4689), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4695), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4702), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4708), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4714), new DateTime(2020, 8, 6, 16, 1, 11, 530, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.InsertData(
                table: "Subdivisions",
                columns: new[] { "Id", "Category", "Code", "CountryId", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 31, "state", "MX-YUC", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1814), true, "Yucatán", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1816) },
                    { 2, "state", "MX-AGU", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1488), true, "Aguascalientes", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1504) },
                    { 3, "state", "MX-BCN", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1579), true, "Baja California", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1582) },
                    { 4, "state", "MX-BCS", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1586), true, "Baja California Sur", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1589) },
                    { 5, "state", "MX-CAM", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1593), true, "Campeche", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1596) },
                    { 6, "state", "MX-COA", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1599), true, "Coahuila de Zaragoza", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1602) },
                    { 7, "state", "MX-COL", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1606), true, "Colima", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1609) },
                    { 8, "state", "MX-CHP", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1612), true, "Chiapas", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1616) },
                    { 9, "state", "MX-CHH", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1619), true, "Chihuahua", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1622) },
                    { 10, "state", "MX-DUR", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1625), true, "Durango", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1628) },
                    { 11, "state", "MX-GUA", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1632), true, "Guanajuato", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1635) },
                    { 12, "state", "MX-GRO", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1638), true, "Guerrero", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1641) },
                    { 13, "state", "MX-HID", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1645), true, "Hidalgo", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1648) },
                    { 14, "state", "MX-JAL", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1651), true, "Jalisco", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1654) },
                    { 15, "state", "MX-MEX", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1658), true, "México", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1661) },
                    { 16, "state", "MX-MIC", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1664), true, "Michoacán de Ocampo", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1667) },
                    { 17, "state", "MX-MOR", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1670), true, "Morelos", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1673) },
                    { 18, "state", "MX-NAY", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1677), true, "Nayarit", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1680) },
                    { 19, "state", "MX-NLE", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1683), true, "Nuevo León", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1686) },
                    { 20, "state", "MX-OAX", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1739), true, "Oaxaca", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1742) },
                    { 21, "state", "MX-PUE", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1746), true, "Puebla", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1749) },
                    { 22, "state", "MX-QUE", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1756), true, "Querétaro", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1759) },
                    { 23, "state", "MX-ROO", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1763), true, "Quintana Roo", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1766) },
                    { 24, "state", "MX-SLP", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1769), true, "San Luis Potosí", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1772) },
                    { 25, "state", "MX-SIN", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1775), true, "Sinaloa", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1778) },
                    { 26, "state", "MX-SON", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1782), true, "Sonora", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1785) },
                    { 27, "state", "MX-TAB", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1788), true, "Tabasco", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1791) },
                    { 28, "state", "MX-TAM", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1794), true, "Tamaulipas", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1797) },
                    { 29, "state", "MX-TLA", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1801), true, "Tlaxcala", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1804) },
                    { 30, "state", "MX-VER", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1807), true, "Veracruz de Ignacio de la Llave", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1810) },
                    { 32, "state", "MX-ZAC", 143, new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1820), true, "Zacatecas", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(1823) },
                    { 1, "capital", "MX-CMX", 143, new DateTime(2020, 8, 6, 16, 1, 11, 540, DateTimeKind.Local).AddTicks(9953), true, "Ciudad de México", new DateTime(2020, 8, 6, 16, 1, 11, 541, DateTimeKind.Local).AddTicks(2) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subdivisions_Code",
                table: "Subdivisions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subdivisions_Name",
                table: "Subdivisions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subdivisions_CountryId_Code",
                table: "Subdivisions",
                columns: new[] { "CountryId", "Code" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subdivisions");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(4894), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7458), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7568), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7580), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7588), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7597), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7605), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7614), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7622), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7631), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7639), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7651), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7659), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7668), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7677), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7686), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7694), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7704), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7713), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7725), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7735), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7744), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7755), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7765), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7775), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7783), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7794), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7803), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7812), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7821), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7829), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7838), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7846), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7855), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7864), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7874), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7883), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7892), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7902), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7911), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7921), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7931), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7941), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7953), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7964), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7972), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7980), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7989), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(7998), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8008), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8015), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8026), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8033), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8043), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8051), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8060), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8069), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8077), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8086), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8095), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8103), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8112), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8122), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8132), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8143), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8152), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8162), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8171), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8179), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8188), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8197), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8204), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8213), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8221), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8231), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8240), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8249), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8257), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8266), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8276), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8285), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8297), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8308), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8319), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8330), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8341), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8352), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8362), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8373), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8384), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8395), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8409), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8494), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8509), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8520), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8531), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8542), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8551), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8561), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8571), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8580), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8588), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8598), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8606), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8616), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8625), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8637), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8644), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8653), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8661), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8669), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8677), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8685), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8694), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8703), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8711), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8719), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8729), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8738), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8746), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8754), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8763), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8772), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8780), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8788), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8796), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8806), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8814), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8821), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8829), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8838), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8847), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8858), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8866), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8874), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8893), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8905), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8914), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8923), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8932), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8941), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8949), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8958), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8966), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8974), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8983), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8993), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9003), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9012), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9022), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9033), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9041), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9051), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9065), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9075), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9084), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9093), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9102), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9112), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9122), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9131), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9140), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9148), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9157), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9165), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9182), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9193), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9203), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9213), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9223), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9230), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9239), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9249), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9258), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9267), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9276), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9286), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9296), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9306), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9315), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9322), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9330), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9339), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9348), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9359), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9368), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9377), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9385), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9395), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9410), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9424), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9434), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9442), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9452), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9461), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9469), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9476), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9483), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9491), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9515), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9552), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9562), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9570), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9579), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9587), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9671), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9704), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9721), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9736), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9753), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9791), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9801), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9809), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9819), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9843), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9863), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9874), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9884), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9895), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9905), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9914), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9925), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9935), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9949), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9962), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9971), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9980), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9989), new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 788, DateTimeKind.Local).AddTicks(9998), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(6), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(13), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(20), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(57), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(76), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(83), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(89), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(95), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(102), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(108), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(114), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(120), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(127), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(133), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(140), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(149), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(157), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(187), new DateTime(2020, 8, 6, 14, 59, 5, 789, DateTimeKind.Local).AddTicks(195) });
        }
    }
}
