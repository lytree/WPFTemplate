// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPFTemplate.Configuration.Repository;

#nullable disable

namespace WPFTemplate.Configuration.Migrations
{
    [DbContext(typeof(ConfigContext))]
    [Migration("20230119050150_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("WPFTemplate.Configuration.Entity.MenuConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("create_time");

                    b.Property<string>("IconName")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("icon_name");

                    b.Property<bool?>("IsVisible")
                        .HasColumnType("int")
                        .HasColumnName("is_visible");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.Property<string>("QueriesText")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("queries_text");

                    b.Property<string>("TargetCtlName")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("target_ctl_name");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("update_time");

                    b.HasKey("Id");

                    b.ToTable("menu_config");
                });

            modelBuilder.Entity("WPFTemplate.Configuration.Entity.OptionConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("create_time");

                    b.Property<string>("OptionDesc")
                        .HasColumnType("TEXT")
                        .HasColumnName("option_desc");

                    b.Property<string>("OptionGroup")
                        .HasColumnType("TEXT")
                        .HasColumnName("option_group");

                    b.Property<string>("OptionKey")
                        .HasColumnType("TEXT")
                        .HasColumnName("option_key");

                    b.Property<string>("OptionName")
                        .HasColumnType("TEXT")
                        .HasColumnName("option_name");

                    b.Property<int?>("OptionPriority")
                        .HasColumnType("INTEGER")
                        .HasColumnName("option_priority");

                    b.Property<int?>("OptionStatus")
                        .HasColumnType("INTEGER")
                        .HasColumnName("option_status");

                    b.Property<string>("OptionValue")
                        .HasColumnType("TEXT")
                        .HasColumnName("option_value");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("update_time");

                    b.HasKey("Id");

                    b.ToTable("option_config");
                });

            modelBuilder.Entity("WPFTemplate.Configuration.Entity.OptionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("create_time");

                    b.Property<string>("GroupDesc")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("group_desc");

                    b.Property<string>("GroupKey")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("group_key");

                    b.Property<string>("GroupName")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("group_name");

                    b.Property<int?>("GroupType")
                        .HasColumnType("int")
                        .HasColumnName("group_type");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("update_time");

                    b.HasKey("Id");

                    b.ToTable("option_group");
                });
#pragma warning restore 612, 618
        }
    }
}
