using Microsoft.EntityFrameworkCore;
using TechStore.Server.Entities;

namespace TechStore.Server.Data
{
    public class TechStoreDbContext : DbContext
    {
        public TechStoreDbContext(DbContextOptions<TechStoreDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Case Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Corsair 4000D Airflow Computer Case",
                Description = "ATX Mid / Black / Steel / Plastic / Tempered Glass.",
                ImageURL = "",
                Price = 104.99M,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Corsair iCUE 5000X RGB Computer Case",
                Description = "ATX Mid / White / Steel / Plastic / Tempered Glass.",
                ImageURL = "",
                Price = 204.99M,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Phanteks Eclipse G360A Computer Case",
                Description = "ATX Mid / Black / Steel / Tempered Glass.",
                ImageURL = "",
                Price = 99.99M,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "LIAN LI 011 Dynamic EVO Computer Case",
                Description = "ATX Mid / Aluminum / Steel.",
                ImageURL = "",
                Price = 175.99M,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Thermaltake S100 TG Snow Computer Case",
                Description = "MicroATX / White / Steel / Tempered Glass.",
                ImageURL = "",
                Price = 67.99M,
                Qty = 85,
                CategoryId = 1

            });
            //CPU Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "AMD Ryzen 7 5800X3D Desktop Processor",
                Description = "8-Core / 3.4 GHz / DDR4 3200 / 105W.",
                ImageURL = "",
                Price = 356.99M,
                Qty = 120,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Intel Core i7-12700K Desktop Processor",
                Description = "12-Core (8P+4E) / 3.6 GHz / DDR5 4800 / 125W.",
                ImageURL = "",
                Price = 323.99M,
                Qty = 200,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "AMD Ryzen 7 5700X Desktop Processor",
                Description = "8-Core / 3.4 GHz / DDR4 3200 / 65W",
                ImageURL = "",
                Price = 196.99M,
                Qty = 200,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Intel Core i9-13900K Desktop Processor",
                Description = "24-Core (8P+16E) / 2.2 GHz / DDR5 5600 / 125W.",
                ImageURL = "",
                Price = 609.99M,
                Qty = 20,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "AMD Ryzen 9 5950X Desktop Processor",
                Description = "16-Core / 3.4 GHz / DDR4 3200 / 105W.",
                ImageURL = "",
                Price = 543.99M,
                Qty = 15,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "AMD Ryzen 9 5900X Desktop Processor",
                Description = "12-Core / 3.7 GHz / DDR4 3200 / 105W.",
                ImageURL = "",
                Price = 347.99M,
                Qty = 60,
                CategoryId = 2
            });
            //Motherboard Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Asus Strix B550-F Wi-Fi Motherboard",
                Description = "AM4 / ATX / 128GB / 4x288pin (DDR4) / AMD B550.",
                ImageURL = "",
                Price = 204.99M,
                Qty = 212,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Gigabyte B650 Aorus Elite AX Motherboard",
                Description = "AM5 / ATX / 128GB / 4x288pin (DDR5) / AMD B650.",
                ImageURL = "",
                Price = 229.99M,
                Qty = 112,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "MSI Mag Z490 Tomahawk ATX Motherboard",
                Description = "LGA 1200 / ATX / 128GB / 4x288pin (DDR4) / Intel Z490.",
                ImageURL = "",
                Price = 122.99M,
                Qty = 90,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Asus ROG Strix Z790-E Wi-Fi Motherboard",
                Description = "LGA 1700 / ATX / 128GB / 4x288pin (DDR5) / Intel Z790",
                ImageURL = "",
                Price = 499.99M,
                Qty = 95,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "MSI Pro Z790-P Wi-Fi Motherboard",
                Description = "LGA 1700 / ATX / 128GB / 4x288pin (DDR4) / Intel Z790.",
                ImageURL = "",
                Price = 239.99M,
                Qty = 100,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Asus Crosshair X670E Hero Wi-Fi Motherboard",
                Description = "AM5 / ATX / 128GB / 4x288pin (DDR5) / AMD X670E.",
                ImageURL = "",
                Price = 699.99M,
                Qty = 73,
                CategoryId = 3
            });
            //Memory Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "G.Skill Trident Z RGB Memory",
                Description = "DDR4 / 16GB (2 x 8GB) / Black / 18.",
                ImageURL = "",
                Price = 70.99M,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "G.Skill Trident Z5 RGB Memory",
                Description = "DDR5 / 32GB (2 x 16GB) / Black / 32.",
                ImageURL = "",
                Price = 199.99M,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Corsair Vengeance RGB Pro SL Memory",
                Description = "DDR4 / 32GB (2 x 16GB) / Black / 16.",
                ImageURL = "",
                Price = 106.99M,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "OLOy Blade RGB Memory",
                Description = "DDR5 / 16GB (2 x 8GB) / Platinum / 36.",
                ImageURL = "",
                Price = 94.99M,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Corsair Vengeance LPX Memory",
                Description = "DDR4 / 64GB (2 x 32GB) / Black / 16.",
                ImageURL = "",
                Price = 184.99M,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "G.Skill Trident Z5 RGB Memory",
                Description = "DDR5 / 32GB (2 x 16GB) / Black / 36.",
                ImageURL = "",
                Price = 374.99M,
                Qty = 150,
                CategoryId = 4
            });
            //Video Card Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "MSI RTX 3060 Ventus 2X GPU",
                Description = "GeForce RTX 3060 / 12GB / 1807 MHz / PCI Express 4.0.",
                ImageURL = "",
                Price = 369.99M,
                Qty = 150,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = "Peladn Gaming RTX 3080 RGB GPU",
                Description = "GeForce RTX 3080 / 10GB / 1440 MHz / PCI Express 4.0.",
                ImageURL = "",
                Price = 699.99M,
                Qty = 150,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = "MSI RX 6700 XT Mech 2X GPU",
                Description = "Radeon RX 6700 XT / 12GB / 2620 MHz / PCI Express 4.0.",
                ImageURL = "",
                Price = 369.99M,
                Qty = 150,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = "Asus ROG Strix RTX 4080 GPU",
                Description = "GeForce RTX 4080 / 16GB / 2625 MHz / PCI Express 4.0.",
                ImageURL = "",
                Price = 1675.99M,
                Qty = 150,
                CategoryId = 5
            });
            //Power Supply
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = "Corsair RMx Series RM750 Power Supply",
                Description = "ATX12V/EPS12V / 80 Plus Gold Certified / 750W / Full Modular.",
                ImageURL = "",
                Price = 114.99M,
                Qty = 150,
                CategoryId = 6
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 29,
                Name = "Thermaltake Smart 500W Power Supply",
                Description = "ATX12V/EPS12V / 80 Plus Gold Cerified / 500W / Non Modular.",
                ImageURL = "",
                Price = 39.99M,
                Qty = 150,
                CategoryId = 6
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 30,
                Name = "SeaSonic Prime Ultra Titanium Power Supply",
                Description = "ATX12V/EPS12V / 80 Plus Gold Certified / 1000W / Full Modular.",
                ImageURL = "",
                Price = 328.99M,
                Qty = 150,
                CategoryId = 6
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 31,
                Name = "EVGA SuperNova 1300 G+ Power Supply",
                Description = "ATX12V/EPS12V / 80 Plus Gold Certified / 1300W / Full Modular.",
                ImageURL = "",
                Price = 225.99M,
                Qty = 150,
                CategoryId = 6
            });
            //Storage
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 32,
                Name = "Seagate Hard Drives ST4000DM004 Storage",
                Description = ".",
                ImageURL = "4TB / 5400 RPM / 256MB / 3.5 / SATA 6.0Gb/s",
                Price = 67.99M,
                Qty = 150,
                CategoryId = 7
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 33,
                Name = "Seagate IronWolf ST12000VN0008 Storage",
                Description = "12TB / 7200 RPM / 256MB / 3.5 / SATA 6.0Gb/s.",
                ImageURL = "",
                Price = 199.99M,
                Qty = 150,
                CategoryId = 7
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 34,
                Name = "Samsung 980 PRO MZ-V8P1T0B/AM Storage",
                Description = "1TB / 1024MB / M.2 2280 / PCI Express 4.0 x4.",
                ImageURL = "",
                Price = 129.99M,
                Qty = 150,
                CategoryId = 7
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 35,
                Name = "Seagate BarraCuda Q5 ZP1000CV3A001 Storage",
                Description = "1TB / M.2 2280 / PCI Express 3.0 x4.",
                ImageURL = "",
                Price = 130.99M,
                Qty = 150,
                CategoryId = 7
            });
            //CPU Cooler Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 36,
                Name = "Cooler Master RR-2V2E-18PK-R2 CPU Cooler",
                Description = "Variable / Variable / Black.",
                ImageURL = "",
                Price = 54.99M,
                Qty = 150,
                CategoryId = 8
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 37,
                Name = "Deepcool AK620 CPU Cooler",
                Description = "Variable / 25-30 dBA / Black.",
                ImageURL = "",
                Price = 64.99M,
                Qty = 150,
                CategoryId = 8
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 38,
                Name = "Corsair CW-9060047-WW CPU Water Cooler",
                Description = "Variable / 10-36 dBA / Black / RGB.",
                ImageURL = "",
                Price = 169.99M,
                Qty = 150,
                CategoryId = 8
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 39,
                Name = "NZXT RL-KRX53-01 CPU Water Cooler",
                Description = "Variable / 31-36 dBA / Black / RGB.",
                ImageURL = "",
                Price = 134.99M,
                Qty = 150,
                CategoryId = 8
            });
            //Operating System Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 40,
                Name = "Microsoft Windows 11 Home 64-bit, DVD",
                Description = "Home / 64-bit.",
                ImageURL = "",
                Price = 119.99M,
                Qty = 150,
                CategoryId = 9
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 41,
                Name = "Windows 11 Pro 64-bit, USB",
                Description = "Pro / 64-bit.",
                ImageURL = "",
                Price = 199.99M,
                Qty = 150,
                CategoryId = 9
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 42,
                Name = "Windows 10 Home 64-bit, DVD",
                Description = "Home / 64-bit.",
                ImageURL = "",
                Price = 374.99M,
                Qty = 150,
                CategoryId = 9
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 43,
                Name = "Windows 10 Pro 32-bit, OEM",
                Description = "Professional / 32-bit.",
                ImageURL = "",
                Price = 159.99M,
                Qty = 150,
                CategoryId = 9
            });
            // Accessories Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 44,
                Name = "Razer Basilisk V3 Pro Wireless Mouse",
                Description = "Chroma RGB / 11 Programable Buttons / Black.",
                ImageURL = "",
                Price = 159.99M,
                Qty = 150,
                CategoryId = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 45,
                Name = "HyperX Alloy MKW100 Mechanical Keyboard",
                Description = "Wired / Red.",
                ImageURL = "",
                Price = 79.99M,
                Qty = 150,
                CategoryId = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 46,
                Name = "LG 32in 32GN50R-B UltraGear Full HD 1080p",
                Description = "31.5 / 165 Hz / 5ms / VA.",
                ImageURL = "",
                Price = 248.99M,
                Qty = 150,
                CategoryId = 10
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 47,
                Name = "Logitech C920x HD Pro Webcam Full HD 1080p",
                Description = "USB / Black / 30fps.",
                ImageURL = "",
                Price = 69.99M,
                Qty = 150,
                CategoryId = 10
            });


            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Matthew"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sutter"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Case"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "CPU"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Motherboard"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Memory"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 5,
                Name = "VideoCards"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 6,
                Name = "PowerSupply"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 7,
                Name = "Storage"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 8,
                Name = "CPUCooler"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 9,
                Name = "OperatingSystem"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 10,
                Name = "Accessories"
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get;}
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
