using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Case" },
                    { 2, "CPU" },
                    { 3, "Motherboard" },
                    { 4, "Memory" },
                    { 5, "VideoCards" },
                    { 6, "PowerSupply" },
                    { 7, "Storage" },
                    { 8, "CPUCooler" },
                    { 9, "OperatingSystem" },
                    { 10, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "ATX Mid / Black / Steel / Plastic / Tempered Glass.", "", "Corsair 4000D Airflow Computer Case", 104.99m, 100 },
                    { 2, 1, "ATX Mid / White / Steel / Plastic / Tempered Glass.", "", "Corsair iCUE 5000X RGB Computer Case", 204.99m, 45 },
                    { 3, 1, "ATX Mid / Black / Steel / Tempered Glass.", "", "Phanteks Eclipse G360A Computer Case", 99.99m, 30 },
                    { 4, 1, "ATX Mid / Aluminum / Steel.", "", "LIAN LI 011 Dynamic EVO Computer Case", 175.99m, 60 },
                    { 5, 1, "MicroATX / White / Steel / Tempered Glass.", "", "Thermaltake S100 TG Snow Computer Case", 67.99m, 85 },
                    { 6, 2, "8-Core / 3.4 GHz / DDR4 3200 / 105W.", "", "AMD Ryzen 7 5800X3D Desktop Processor", 356.99m, 120 },
                    { 7, 2, "12-Core (8P+4E) / 3.6 GHz / DDR5 4800 / 125W.", "", "Intel Core i7-12700K Desktop Processor", 323.99m, 200 },
                    { 8, 2, "8-Core / 3.4 GHz / DDR4 3200 / 65W", "", "AMD Ryzen 7 5700X Desktop Processor", 196.99m, 200 },
                    { 9, 2, "24-Core (8P+16E) / 2.2 GHz / DDR5 5600 / 125W.", "", "Intel Core i9-13900K Desktop Processor", 609.99m, 20 },
                    { 10, 2, "16-Core / 3.4 GHz / DDR4 3200 / 105W.", "", "AMD Ryzen 9 5950X Desktop Processor", 543.99m, 15 },
                    { 11, 2, "12-Core / 3.7 GHz / DDR4 3200 / 105W.", "", "AMD Ryzen 9 5900X Desktop Processor", 347.99m, 60 },
                    { 12, 3, "AM4 / ATX / 128GB / 4x288pin (DDR4) / AMD B550.", "", "Asus Strix B550-F Wi-Fi Motherboard", 204.99m, 212 },
                    { 13, 3, "AM5 / ATX / 128GB / 4x288pin (DDR5) / AMD B650.", "", "Gigabyte B650 Aorus Elite AX Motherboard", 229.99m, 112 },
                    { 14, 3, "LGA 1200 / ATX / 128GB / 4x288pin (DDR4) / Intel Z490.", "", "MSI Mag Z490 Tomahawk ATX Motherboard", 122.99m, 90 },
                    { 15, 3, "LGA 1700 / ATX / 128GB / 4x288pin (DDR5) / Intel Z790", "", "Asus ROG Strix Z790-E Wi-Fi Motherboard", 499.99m, 95 },
                    { 16, 3, "LGA 1700 / ATX / 128GB / 4x288pin (DDR4) / Intel Z790.", "", "MSI Pro Z790-P Wi-Fi Motherboard", 239.99m, 100 },
                    { 17, 3, "AM5 / ATX / 128GB / 4x288pin (DDR5) / AMD X670E.", "", "Asus Crosshair X670E Hero Wi-Fi Motherboard", 699.99m, 73 },
                    { 18, 4, "DDR4 / 16GB (2 x 8GB) / Black / 18.", "", "G.Skill Trident Z RGB Memory", 70.99m, 50 },
                    { 19, 4, "DDR5 / 32GB (2 x 16GB) / Black / 32.", "", "G.Skill Trident Z5 RGB Memory", 199.99m, 60 },
                    { 20, 4, "DDR4 / 32GB (2 x 16GB) / Black / 16.", "", "Corsair Vengeance RGB Pro SL Memory", 106.99m, 70 },
                    { 21, 4, "DDR5 / 16GB (2 x 8GB) / Platinum / 36.", "", "OLOy Blade RGB Memory", 94.99m, 120 },
                    { 22, 4, "DDR4 / 64GB (2 x 32GB) / Black / 16.", "", "Corsair Vengeance LPX Memory", 184.99m, 100 },
                    { 23, 4, "DDR5 / 32GB (2 x 16GB) / Black / 36.", "", "G.Skill Trident Z5 RGB Memory", 374.99m, 150 },
                    { 24, 5, "GeForce RTX 3060 / 12GB / 1807 MHz / PCI Express 4.0.", "", "MSI RTX 3060 Ventus 2X GPU", 369.99m, 150 },
                    { 25, 5, "GeForce RTX 3080 / 10GB / 1440 MHz / PCI Express 4.0.", "", "Peladn Gaming RTX 3080 RGB GPU", 699.99m, 150 },
                    { 26, 5, "Radeon RX 6700 XT / 12GB / 2620 MHz / PCI Express 4.0.", "", "MSI RX 6700 XT Mech 2X GPU", 369.99m, 150 },
                    { 27, 5, "GeForce RTX 4080 / 16GB / 2625 MHz / PCI Express 4.0.", "", "Asus ROG Strix RTX 4080 GPU", 1675.99m, 150 },
                    { 28, 6, "ATX12V/EPS12V / 80 Plus Gold Certified / 750W / Full Modular.", "", "Corsair RMx Series RM750 Power Supply", 114.99m, 150 },
                    { 29, 6, "ATX12V/EPS12V / 80 Plus Gold Cerified / 500W / Non Modular.", "", "Thermaltake Smart 500W Power Supply", 39.99m, 150 },
                    { 30, 6, "ATX12V/EPS12V / 80 Plus Gold Certified / 1000W / Full Modular.", "", "SeaSonic Prime Ultra Titanium Power Supply", 328.99m, 150 },
                    { 31, 6, "ATX12V/EPS12V / 80 Plus Gold Certified / 1300W / Full Modular.", "", "EVGA SuperNova 1300 G+ Power Supply", 225.99m, 150 },
                    { 32, 7, ".", "4TB / 5400 RPM / 256MB / 3.5 / SATA 6.0Gb/s", "Seagate Hard Drives ST4000DM004 Storage", 67.99m, 150 },
                    { 33, 7, "12TB / 7200 RPM / 256MB / 3.5 / SATA 6.0Gb/s.", "", "Seagate IronWolf ST12000VN0008 Storage", 199.99m, 150 },
                    { 34, 7, "1TB / 1024MB / M.2 2280 / PCI Express 4.0 x4.", "", "Samsung 980 PRO MZ-V8P1T0B/AM Storage", 129.99m, 150 },
                    { 35, 7, "1TB / M.2 2280 / PCI Express 3.0 x4.", "", "Seagate BarraCuda Q5 ZP1000CV3A001 Storage", 130.99m, 150 },
                    { 36, 8, "Variable / Variable / Black.", "", "Cooler Master RR-2V2E-18PK-R2 CPU Cooler", 54.99m, 150 },
                    { 37, 8, "Variable / 25-30 dBA / Black.", "", "Deepcool AK620 CPU Cooler", 64.99m, 150 },
                    { 38, 8, "Variable / 10-36 dBA / Black / RGB.", "", "Corsair CW-9060047-WW CPU Water Cooler", 169.99m, 150 },
                    { 39, 8, "Variable / 31-36 dBA / Black / RGB.", "", "NZXT RL-KRX53-01 CPU Water Cooler", 134.99m, 150 },
                    { 40, 9, "Home / 64-bit.", "", "Microsoft Windows 11 Home 64-bit, DVD", 119.99m, 150 },
                    { 41, 9, "Pro / 64-bit.", "", "Windows 11 Pro 64-bit, USB", 199.99m, 150 },
                    { 42, 9, "Home / 64-bit.", "", "Windows 10 Home 64-bit, DVD", 374.99m, 150 },
                    { 43, 9, "Professional / 32-bit.", "", "Windows 10 Pro 32-bit, OEM", 159.99m, 150 },
                    { 44, 10, "Chroma RGB / 11 Programable Buttons / Black.", "", "Razer Basilisk V3 Pro Wireless Mouse", 159.99m, 150 },
                    { 45, 10, "Wired / Red.", "", "HyperX Alloy MKW100 Mechanical Keyboard", 79.99m, 150 },
                    { 46, 10, "31.5 / 165 Hz / 5ms / VA.", "", "LG 32in 32GN50R-B UltraGear Full HD 1080p", 248.99m, 150 },
                    { 47, 10, "USB / Black / 30fps.", "", "Logitech C920x HD Pro Webcam Full HD 1080p", 69.99m, 150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Matthew" },
                    { 2, "Sutter" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
