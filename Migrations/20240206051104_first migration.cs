using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrierWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    DocumentReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateId);
                });

            migrationBuilder.CreateTable(
                name: "CharactersDetails",
                columns: table => new
                {
                    CharterersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharterersCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersDetails", x => x.CharterersId);
                });

            migrationBuilder.CreateTable(
                name: "ShipOwnerDetails",
                columns: table => new
                {
                    ShipOwnerDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipOwnerDetails", x => x.ShipOwnerDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "VesselRegistrations",
                columns: table => new
                {
                    VesselId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselType = table.Column<int>(type: "int", nullable: false),
                    ShipIdentificationNo = table.Column<int>(type: "int", nullable: false),
                    Registrationdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameofShip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityofShip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlagStateofShip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMONo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallSignNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortofRegistration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrossRegistrationTons = table.Column<int>(type: "int", nullable: false),
                    DeadWeight = table.Column<int>(type: "int", nullable: false),
                    DisplacementWeight = table.Column<int>(type: "int", nullable: false),
                    PandIclub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beam = table.Column<int>(type: "int", nullable: false),
                    StandradDraught = table.Column<int>(type: "int", nullable: false),
                    VesselCapacity = table.Column<int>(type: "int", nullable: false),
                    AreaofOperation = table.Column<int>(type: "int", nullable: false),
                    YearBuilt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VesselTrade = table.Column<int>(type: "int", nullable: false),
                    VesselTerm = table.Column<int>(type: "int", nullable: false),
                    CargoType = table.Column<int>(type: "int", nullable: false),
                    PositionofBridge = table.Column<int>(type: "int", nullable: false),
                    TypeofHull = table.Column<int>(type: "int", nullable: false),
                    ApplicantRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VesselRegistrations", x => x.VesselId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "CharactersDetails");

            migrationBuilder.DropTable(
                name: "ShipOwnerDetails");

            migrationBuilder.DropTable(
                name: "VesselRegistrations");
        }
    }
}
