﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using XamarinSample.API.Persistence;

namespace XamarinSample.API.Migrations
{
    [DbContext(typeof(XamarinSampleDbContext))]
    [Migration("20170123160157_MakeUsernameKey")]
    partial class MakeUsernameKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XamarinSample.API.Core.Model.Entities.User", b =>
                {
                    b.Property<string>("Username");

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("DisplayName");

                    b.Property<string>("EMail");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });
        }
    }
}
