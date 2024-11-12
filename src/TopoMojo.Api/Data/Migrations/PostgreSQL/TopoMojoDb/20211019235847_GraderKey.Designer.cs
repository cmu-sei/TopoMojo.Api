// Copyright 2025 Carnegie Mellon University. All Rights Reserved.
// Released under a 3 Clause BSD-style license. See LICENSE.md in the project root for license information.

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TopoMojo.Api.Data;

namespace TopoMojo.Api.Data.Migrations.PostgreSQL.TopoMojoDb
{
    [DbContext(typeof(TopoMojoDbContextPostgreSQL))]
    [Migration("20211019235847_GraderKey")]
    partial class GraderKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TopoMojo.Api.Data.ApiKey", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Hash")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("character varying(36)");

                    b.Property<DateTimeOffset>("WhenCreated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Hash");

                    b.HasIndex("UserId");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Gamespace", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<bool>("AllowReset")
                        .HasColumnType("boolean");

                    b.Property<string>("Challenge")
                        .HasColumnType("text");

                    b.Property<bool>("Cleaned")
                        .HasColumnType("boolean");

                    b.Property<int>("CleanupGraceMinutes")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ExpirationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("GraderKey")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("text");

                    b.Property<string>("ManagerName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Variant")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("WhenCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WorkspaceId")
                        .HasColumnType("character varying(36)");

                    b.HasKey("Id");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Gamespaces");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Player", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("GamespaceId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<int>("Permission")
                        .HasColumnType("integer");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("SubjectId", "GamespaceId");

                    b.HasIndex("GamespaceId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Template", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Audience")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Detail")
                        .HasMaxLength(4096)
                        .HasColumnType("character varying(4096)");

                    b.Property<string>("Guestinfo")
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<string>("Iso")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Networks")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("ParentId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<int>("Replicas")
                        .HasColumnType("integer");

                    b.Property<int>("Variant")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("WhenCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WorkspaceId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<int>("GamespaceCleanupGraceMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("GamespaceLimit")
                        .HasColumnType("integer");

                    b.Property<int>("GamespaceMaxMinutes")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Scope")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("WhenCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WorkspaceLimit")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Worker", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("WorkspaceId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<int>("Permission")
                        .HasColumnType("integer");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("SubjectId", "WorkspaceId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Workspace", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Audience")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Author")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Challenge")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("integer");

                    b.Property<bool>("HostAffinity")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("LastActivity")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LaunchCount")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("ShareCode")
                        .HasColumnType("text");

                    b.Property<int>("TemplateLimit")
                        .HasColumnType("integer");

                    b.Property<string>("TemplateScope")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<bool>("UseUplinkSwitch")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("WhenCreated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Workspaces");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.ApiKey", b =>
                {
                    b.HasOne("TopoMojo.Api.Data.User", "User")
                        .WithMany("ApiKeys")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Gamespace", b =>
                {
                    b.HasOne("TopoMojo.Api.Data.Workspace", "Workspace")
                        .WithMany("Gamespaces")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Player", b =>
                {
                    b.HasOne("TopoMojo.Api.Data.Gamespace", "Gamespace")
                        .WithMany("Players")
                        .HasForeignKey("GamespaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gamespace");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Template", b =>
                {
                    b.HasOne("TopoMojo.Api.Data.Template", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TopoMojo.Api.Data.Workspace", "Workspace")
                        .WithMany("Templates")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Worker", b =>
                {
                    b.HasOne("TopoMojo.Api.Data.Workspace", "Workspace")
                        .WithMany("Workers")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Gamespace", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Template", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.User", b =>
                {
                    b.Navigation("ApiKeys");
                });

            modelBuilder.Entity("TopoMojo.Api.Data.Workspace", b =>
                {
                    b.Navigation("Gamespaces");

                    b.Navigation("Templates");

                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
