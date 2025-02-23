#pragma warning disable CS1591

// <auto-generated />
using System;
using Jellyfin.Server.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jellyfin.Server.Implementations.Migrations
{
    [DbContext(typeof(JellyfinDbContext))]
    [Migration("20200905220533_FixDisplayPreferencesIndex")]
    partial class FixDisplayPreferencesIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("jellyfin")
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("Jellyfin.Data.Entities.AccessSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("INTEGER");

                    b.Property<double>("EndHour")
                        .HasColumnType("REAL");

                    b.Property<double>("StartHour")
                        .HasColumnType("REAL");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AccessSchedules");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ActivityLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<int>("LogSeverity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<string>("Overview")
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShortOverview")
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.DisplayPreferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChromecastVersion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(32);

                    b.Property<string>("DashboardTheme")
                        .HasColumnType("TEXT")
                        .HasMaxLength(32);

                    b.Property<bool>("EnableNextVideoInfoOverlay")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IndexBy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScrollDirection")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowBackdrop")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowSidebar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkipBackwardLength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkipForwardLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TvHome")
                        .HasColumnType("TEXT")
                        .HasMaxLength(32);

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId", "Client")
                        .IsUnique();

                    b.ToTable("DisplayPreferences");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.HomeSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisplayPreferencesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DisplayPreferencesId");

                    b.ToTable("HomeSection");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ImageInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ImageInfos");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ItemDisplayPreferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(32);

                    b.Property<int?>("IndexBy")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RememberIndexing")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RememberSorting")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SortBy")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ViewType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ItemDisplayPreferences");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("Permission_Permissions_Guid")
                        .HasColumnType("TEXT");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Permission_Permissions_Guid");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("Preference_Preferences_Guid")
                        .HasColumnType("TEXT");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.HasKey("Id");

                    b.HasIndex("Preference_Preferences_Guid");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AudioLanguagePreference")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("AuthenticationProviderId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<bool>("DisplayCollectionsView")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisplayMissingEpisodes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EasyPassword")
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.Property<bool>("EnableAutoLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableLocalPassword")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableNextEpisodeAutoPlay")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableUserPreferenceAccess")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HidePlayedInLatest")
                        .HasColumnType("INTEGER");

                    b.Property<long>("InternalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvalidLoginAttemptCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastActivityDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LoginAttemptsBeforeLockout")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MaxParentalAgeRating")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MustUpdatePassword")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.Property<string>("PasswordResetProviderId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<bool>("PlayDefaultAudioTrack")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RememberAudioSelections")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RememberSubtitleSelections")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RemoteClientBitrateLimit")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubtitleLanguagePreference")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<int>("SubtitleMode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SyncPlayAccess")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.AccessSchedule", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("AccessSchedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.DisplayPreferences", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithOne("DisplayPreferences")
                        .HasForeignKey("Jellyfin.Data.Entities.DisplayPreferences", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.HomeSection", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.DisplayPreferences", null)
                        .WithMany("HomeSections")
                        .HasForeignKey("DisplayPreferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ImageInfo", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithOne("ProfileImage")
                        .HasForeignKey("Jellyfin.Data.Entities.ImageInfo", "UserId");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ItemDisplayPreferences", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("ItemDisplayPreferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Permission", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("Permissions")
                        .HasForeignKey("Permission_Permissions_Guid");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Preference", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("Preferences")
                        .HasForeignKey("Preference_Preferences_Guid");
                });
#pragma warning restore 612, 618
        }
    }
}
