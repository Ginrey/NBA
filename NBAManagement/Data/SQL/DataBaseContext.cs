using System.Data.Entity;
using NBAManagement.Model;

namespace NBAManagement.Data.SQL
{                       
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("name=NBADB")
        {
        }

        public virtual DbSet<ActionType> ActionType { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Conference> Conference { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Matchup> Matchup { get; set; }
        public virtual DbSet<MatchupDetail> MatchupDetail { get; set; }
        public virtual DbSet<MatchupType> MatchupType { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerInTeamId> PlayerInTeamId { get; set; }
        public virtual DbSet<PlayerStatistics> PlayerStatistics { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Season> Season { get; set; }  
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<MatchupLog> MatchupLog { get; set; }
        public virtual DbSet<PostSeason> PostSeason { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionType>()
                .Property(e => e.ActionTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .HasMany(e => e.MatchupLog)
                .WithRequired(e => e.ActionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Jobnumber)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.ConferenceId)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .HasMany(e => e.Division)
                .WithRequired(e => e.Conference)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Division>()
                .Property(e => e.DivisionId)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .Property(e => e.ConferenceId)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Team)
                .WithRequired(e => e.Division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.MatchupId)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.SeasonId)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.MatchupTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.Team_AwayId)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.Team_HomeId)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Matchup>()
                .HasMany(e => e.MatchupDetail)
                .WithRequired(e => e.Matchup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matchup>()
                .HasMany(e => e.MatchupLog)
                .WithRequired(e => e.Matchup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matchup>()
                .HasMany(e => e.PlayerStatistics)
                .WithRequired(e => e.Matchup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatchupDetail>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupDetail>()
                .Property(e => e.MatchupId)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupType>()
                .Property(e => e.MatchupTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupType>()
                .HasMany(e => e.Matchup)
                .WithRequired(e => e.MatchupType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pictures>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Pictures>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.PlayerId)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.PositionId)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.College)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.MatchupLog)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.PlayerInTeamId)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.PlayerStatistics)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlayerInTeamId>()
                .Property(e => e.PlayerInTeamId1)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInTeamId>()
                .Property(e => e.PlayerId)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInTeamId>()
                .Property(e => e.TeamId)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInTeamId>()
                .Property(e => e.SeasonId)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInTeamId>()
                .Property(e => e.ShirtNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInTeamId>()
                .Property(e => e.Salary)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerStatistics>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerStatistics>()
                .Property(e => e.MatchupId)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerStatistics>()
                .Property(e => e.TeamId)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerStatistics>()
                .Property(e => e.PlayerId)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionId)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Abbr)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Season>()
                .Property(e => e.SeasonId)
                .IsUnicode(false);

            modelBuilder.Entity<Season>()
                .Property(e => e.SeasonName)
                .IsUnicode(false);

            modelBuilder.Entity<Season>()
                .HasMany(e => e.Matchup)
                .WithRequired(e => e.Season)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Season>()
                .HasMany(e => e.PlayerInTeamId)
                .WithRequired(e => e.Season)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Season>()
                .HasMany(e => e.PostSeason)
                .WithRequired(e => e.Season)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamId)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.DivisionId)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Coach)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Abbr)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Stadium)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Matchup)
                .WithRequired(e => e.Team)
                .HasForeignKey(e => e.Team_AwayId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Matchup1)
                .WithRequired(e => e.Team1)
                .HasForeignKey(e => e.Team_HomeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.PlayerInTeamId)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.PlayerStatistics)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.MatchupLog)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.PostSeason)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatchupLog>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupLog>()
                .Property(e => e.MatchupId)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupLog>()
                .Property(e => e.TeamId)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupLog>()
                .Property(e => e.PlayerId)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupLog>()
                .Property(e => e.ActionTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<MatchupLog>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<PostSeason>()
                .Property(e => e.TeamId)
                .IsUnicode(false);

            modelBuilder.Entity<PostSeason>()
                .Property(e => e.SeasonId)
                .IsUnicode(false);

            modelBuilder.Entity<PostSeason>()
                .Property(e => e.Rank)
                .IsUnicode(false);
        }
    }
}
