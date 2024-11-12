﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TicketResell_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TicketResell_API.Controllers.CartController.Model.Cart", b =>
                {
                    b.Property<string>("cartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("eventImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maxQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("sellerId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("sellerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ticketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ticketRow")
                        .HasColumnType("int");

                    b.Property<string>("ticketSection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("cartId");

                    b.HasIndex("sellerId");

                    b.HasIndex("ticketId");

                    b.HasIndex("userId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.Chat", b =>
                {
                    b.Property<string>("seUserId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("seUserId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.ChatData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChatSeUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("lastMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("messageId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("messageSeen")
                        .HasColumnType("bit");

                    b.Property<string>("reUserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ChatSeUserId");

                    b.HasIndex("messageId");

                    b.ToTable("ChatData");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.Message", b =>
                {
                    b.Property<string>("messageId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("messageId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.MessageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeUserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("messageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("messageId");

                    b.ToTable("MessageData");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.CommentController.Model.Comment", b =>
                {
                    b.Property<string>("commentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("rating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime2");

                    b.Property<string>("toUserId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("commentId");

                    b.HasIndex("orderId");

                    b.HasIndex("toUserId");

                    b.HasIndex("userId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.EventController.Model.Event", b =>
                {
                    b.Property<string>("eventId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("eventTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("eventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.OrderController.Model.OrderDetail", b =>
                {
                    b.Property<int?>("orderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("orderDetailId"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("eventImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("paymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("receiverEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiverPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ticketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("orderDetailId");

                    b.HasIndex("orderId");

                    b.HasIndex("ticketId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.RefundController.Model.RefundRequest", b =>
                {
                    b.Property<string>("requestId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("refundDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("requestId");

                    b.HasIndex("orderId")
                        .IsUnique()
                        .HasFilter("[orderId] IS NOT NULL");

                    b.ToTable("RefundRequests");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.TicketController.Model.Ticket", b =>
                {
                    b.Property<string>("ticketId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("createAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("originPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("row")
                        .HasColumnType("int");

                    b.Property<string>("section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("userId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ticketId");

                    b.HasIndex("eventId");

                    b.HasIndex("userId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.User.Model.Order", b =>
                {
                    b.Property<string>("orderId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("orderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("totalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("userId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("orderId");

                    b.HasIndex("userId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.UserController.Model.MainUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("FailedConfirmationAttemps")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bio")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("userImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TicketResell_API.Controllers.WalletController.Model.Transaction", b =>
                {
                    b.Property<string>("transactionId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("balanceAfter")
                        .HasColumnType("int");

                    b.Property<int>("balanceBefore")
                        .HasColumnType("int");

                    b.Property<string>("orderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<string>("transactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("walletId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("transactionId");

                    b.HasIndex("walletId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.WalletController.Model.Wallet", b =>
                {
                    b.Property<string>("walletId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("balance")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("walletId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TicketResell_API.Controllers.CartController.Model.Cart", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "Seller")
                        .WithMany()
                        .HasForeignKey("sellerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TicketResell_API.Controllers.TicketController.Model.Ticket", "Tickets")
                        .WithMany()
                        .HasForeignKey("ticketId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "User")
                        .WithMany("Carts")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Seller");

                    b.Navigation("Tickets");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.Chat", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "User")
                        .WithMany("Chats")
                        .HasForeignKey("seUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.ChatData", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.ChatController.Model.Chat", "Chat")
                        .WithMany("ChatData")
                        .HasForeignKey("ChatSeUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketResell_API.Controllers.ChatController.Model.Message", "Message")
                        .WithMany()
                        .HasForeignKey("messageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Chat");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.MessageData", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.ChatController.Model.Message", "Message")
                        .WithMany("Messages")
                        .HasForeignKey("messageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.CommentController.Model.Comment", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.User.Model.Order", "Order")
                        .WithMany("Comments")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "ToUser")
                        .WithMany()
                        .HasForeignKey("toUserId");

                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Order");

                    b.Navigation("ToUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.OrderController.Model.OrderDetail", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.User.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketResell_API.Controllers.TicketController.Model.Ticket", "Tickets")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ticketId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Order");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.RefundController.Model.RefundRequest", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.User.Model.Order", "Orders")
                        .WithOne("RefundRequests")
                        .HasForeignKey("TicketResell_API.Controllers.RefundController.Model.RefundRequest", "orderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.TicketController.Model.Ticket", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.EventController.Model.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("eventId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.User.Model.Order", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.WalletController.Model.Transaction", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.WalletController.Model.Wallet", "Wallets")
                        .WithMany("Transactions")
                        .HasForeignKey("walletId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.WalletController.Model.Wallet", b =>
                {
                    b.HasOne("TicketResell_API.Controllers.UserController.Model.MainUser", "User")
                        .WithOne("Wallets")
                        .HasForeignKey("TicketResell_API.Controllers.WalletController.Model.Wallet", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.Chat", b =>
                {
                    b.Navigation("ChatData");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.ChatController.Model.Message", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.EventController.Model.Event", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.TicketController.Model.Ticket", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.User.Model.Order", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("OrderDetails");

                    b.Navigation("RefundRequests");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.UserController.Model.MainUser", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Chats");

                    b.Navigation("Comments");

                    b.Navigation("Orders");

                    b.Navigation("Tickets");

                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("TicketResell_API.Controllers.WalletController.Model.Wallet", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
