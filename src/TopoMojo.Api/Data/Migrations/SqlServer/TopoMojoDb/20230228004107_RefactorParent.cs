// Copyright 2025 Carnegie Mellon University. All Rights Reserved.
// Released under a 3 Clause BSD-style license. See LICENSE.md in the project root for license information.

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopoMojo.Api.Data.Migrations.SqlServer.TopoMojoDb
{
    public partial class RefactorParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Templates_ParentId",
                table: "Templates");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Workspaces_WorkspaceId",
                table: "Templates");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Workspaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsLinked",
                table: "Templates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Templates_ParentId",
                table: "Templates",
                column: "ParentId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Workspaces_WorkspaceId",
                table: "Templates",
                column: "WorkspaceId",
                principalTable: "Workspaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            // any with parent at this point is linked
            migrationBuilder.Sql(
                "UPDATE Templates SET IsLinked=true WHERE ParentId IS NOT NULL;"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Templates_ParentId",
                table: "Templates");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Workspaces_WorkspaceId",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Workspaces");

            migrationBuilder.DropColumn(
                name: "IsLinked",
                table: "Templates");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Templates_ParentId",
                table: "Templates",
                column: "ParentId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Workspaces_WorkspaceId",
                table: "Templates",
                column: "WorkspaceId",
                principalTable: "Workspaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
