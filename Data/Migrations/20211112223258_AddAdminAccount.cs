using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

namespace ShopWebApp.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "da9f05ca-468a-4b88-8d6b-27f8482c4022";
        const string ADMIN_ROLE_GUID = "4369d905-8208-47f9-8abc-0c7e54b580df";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var passwordHash = hasher.HashPassword(null,"Password"); //TODO: Hide password from code
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp,FirstName)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{ADMIN_USER_GUID}'");
            sb.AppendLine(",'admin@shopapp.co.uk'");
            sb.AppendLine(",'ADMIN@shopapp.CO.UK'");
            sb.AppendLine(",'admin@shopapp.co.uk'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(",'ADMIN@shopapp.CO.UK'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", ''");
            sb.AppendLine(",'Admin'");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{ADMIN_ROLE_GUID}','Admin','ADMIN')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");
        }
    }
}
