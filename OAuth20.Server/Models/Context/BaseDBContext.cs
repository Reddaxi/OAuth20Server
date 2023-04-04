/*
                        GNU GENERAL PUBLIC LICENSE
                          Version 3, 29 June 2007
 Copyright (C) 2022 Mohammed Ahmed Hussien babiker Free Software Foundation, Inc. <https://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.
 */

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OAuth20.Server.Models.Entities;
using System;

namespace OAuth20.Server.Models.Context
{
    public class BaseDBContext : IdentityDbContext<AppUser>
    {
        public string DbPath { get; set; }
        public BaseDBContext(DbContextOptions<BaseDBContext> options) : base(options)
        {
            setDbPath();
        }

        private void setDbPath()
        {
            string path = "";
            var folder = Environment.SpecialFolder.CommonApplicationData;
            path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "OAuth2Server_DB/OAuth2Server.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<OAuthApplicationEntity> OAuthApplications { get; set; }
        public DbSet<OAuthTokenEntity> OAuthTokens { get; set; }
    }
}
