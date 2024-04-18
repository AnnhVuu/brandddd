using Microsoft.EntityFrameworkCore;


namespace Shop_ReactApp.Server.Models
{
    public class DataWeb : DbContext
    {
        public DataWeb(DbContextOptions<DataWeb>options): base(options) { }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        //Add database: Sửa đường dẫn ở trong appsetting.json
        //Mở CMD dùng câu lệnh sau để cập nhập dotnet: dotnet tool install --global dotnet-ef --version 8.*
        //Mở Console của nuget: dotnet ef migrations add InitialCreate --project Shop-ReactApp.Server
        //Đợi nó chạy rồi tiếp tục dùng câu sau: dotnet ef database update --project Shop-ReactApp.Server
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
      
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }

        public virtual DbSet<DetailsBill> DetailsBill { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

    }
}
