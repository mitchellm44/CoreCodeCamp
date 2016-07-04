﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreCodeCamp.Data;

namespace CoreCodeCamp.Migrations
{
    [DbContext(typeof(CodeCampContext))]
    [Migration("20160704082613_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("TalkId");

                    b.HasKey("Id");

                    b.HasIndex("TalkId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.CodeCampUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.EventInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventDate");

                    b.Property<short>("EventLength");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsPublic");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Moniker");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("CodeCampEvents");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<string>("Blog");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyUrl");

                    b.Property<int?>("EventId");

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.Property<string>("TwitterHandle");

                    b.Property<string>("UserName");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.Property<bool>("Paid");

                    b.Property<string>("SponsorLevel");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract");

                    b.Property<bool>("Approved");

                    b.Property<string>("CodeCampUserId");

                    b.Property<string>("Level");

                    b.Property<int?>("RoomId");

                    b.Property<int?>("SpeakerId");

                    b.Property<int?>("TalkTimeId");

                    b.Property<string>("Title");

                    b.Property<int?>("TrackId");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.HasIndex("CodeCampUserId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SpeakerId");

                    b.HasIndex("TalkTimeId");

                    b.HasIndex("TrackId");

                    b.ToTable("Talks");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.TalkTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TalkTimes");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.EventLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Facility");

                    b.Property<string>("Link");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StateProvince");

                    b.HasKey("Id");

                    b.ToTable("EventLocation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Category", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.Talk")
                        .WithMany("Categories")
                        .HasForeignKey("TalkId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.EventInfo", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.EventLocation", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Speaker", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.EventInfo", "Event")
                        .WithMany()
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Sponsor", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.EventInfo", "Event")
                        .WithMany()
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Talk", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.CodeCampUser")
                        .WithMany("Talks")
                        .HasForeignKey("CodeCampUserId");

                    b.HasOne("CoreCodeCamp.Data.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("CoreCodeCamp.Data.Entities.Speaker")
                        .WithMany("Talks")
                        .HasForeignKey("SpeakerId");

                    b.HasOne("CoreCodeCamp.Data.Entities.TalkTime", "TalkTime")
                        .WithMany()
                        .HasForeignKey("TalkTimeId");

                    b.HasOne("CoreCodeCamp.Data.Entities.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Entities.Track", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.EventInfo", "Event")
                        .WithMany()
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.CodeCampUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Entities.CodeCampUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreCodeCamp.Data.Entities.CodeCampUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}