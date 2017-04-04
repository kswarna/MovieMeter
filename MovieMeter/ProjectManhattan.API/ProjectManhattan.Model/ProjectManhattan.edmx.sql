
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/25/2016 09:51:49
-- Generated from EDMX file: C:\Users\Pattabhi\Source\FloydTech\ProjectManhattan.API\ProjectManhattan.Model\ProjectManhattan.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProjectManhattan];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__CriticArt__Criti__20C1E124]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticArtistRatings] DROP CONSTRAINT [FK__CriticArt__Criti__20C1E124];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticArt__Movie__21B6055D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticArtistRatings] DROP CONSTRAINT [FK__CriticArt__Movie__21B6055D];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Criti__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieRatings] DROP CONSTRAINT [FK__CriticMov__Criti__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Criti__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieRatingComments] DROP CONSTRAINT [FK__CriticMov__Criti__4AB81AF0];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Criti__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieRatingComments] DROP CONSTRAINT [FK__CriticMov__Criti__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Criti__59063A47]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieTrailerComments] DROP CONSTRAINT [FK__CriticMov__Criti__59063A47];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Criti__72C60C4A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMoviePhotoComments] DROP CONSTRAINT [FK__CriticMov__Criti__72C60C4A];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Movie__38996AB5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieRatings] DROP CONSTRAINT [FK__CriticMov__Movie__38996AB5];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Movie__4CA06362]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieRatingComments] DROP CONSTRAINT [FK__CriticMov__Movie__4CA06362];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Movie__5812160E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieTrailerComments] DROP CONSTRAINT [FK__CriticMov__Movie__5812160E];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Movie__59FA5E80]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMovieTrailerComments] DROP CONSTRAINT [FK__CriticMov__Movie__59FA5E80];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Movie__71D1E811]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMoviePhotoComments] DROP CONSTRAINT [FK__CriticMov__Movie__71D1E811];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticMov__Movie__73BA3083]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticMoviePhotoComments] DROP CONSTRAINT [FK__CriticMov__Movie__73BA3083];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticSon__Criti__300424B4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticSongRatings] DROP CONSTRAINT [FK__CriticSon__Criti__300424B4];
GO
IF OBJECT_ID(N'[dbo].[FK__CriticSon__Movie__30F848ED]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriticSongRatings] DROP CONSTRAINT [FK__CriticSon__Movie__30F848ED];
GO
IF OBJECT_ID(N'[dbo].[FK__Finance__MovieId__4316F928]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Finances] DROP CONSTRAINT [FK__Finance__MovieId__4316F928];
GO
IF OBJECT_ID(N'[dbo].[FK__Movie__LanguageI__1A14E395]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movies] DROP CONSTRAINT [FK__Movie__LanguageI__1A14E395];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieArti__Artis__1DE57479]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieArtists] DROP CONSTRAINT [FK__MovieArti__Artis__1DE57479];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieArti__Movie__1CF15040]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieArtists] DROP CONSTRAINT [FK__MovieArti__Movie__1CF15040];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieDist__Distr__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieDistributors] DROP CONSTRAINT [FK__MovieDist__Distr__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieDist__Movie__5EBF139D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieDistributors] DROP CONSTRAINT [FK__MovieDist__Movie__5EBF139D];
GO
IF OBJECT_ID(N'[dbo].[FK__MoviePhot__Artis__6A30C649]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MoviePhotoArtists] DROP CONSTRAINT [FK__MoviePhot__Artis__6A30C649];
GO
IF OBJECT_ID(N'[dbo].[FK__MoviePhot__Movie__66603565]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MoviePhotoes] DROP CONSTRAINT [FK__MoviePhot__Movie__66603565];
GO
IF OBJECT_ID(N'[dbo].[FK__MoviePhot__Movie__693CA210]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MoviePhotoArtists] DROP CONSTRAINT [FK__MoviePhot__Movie__693CA210];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieSong__Artis__29572725]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieSongs] DROP CONSTRAINT [FK__MovieSong__Artis__29572725];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieSong__Artis__2D27B809]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieSongArtists] DROP CONSTRAINT [FK__MovieSong__Artis__2D27B809];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieSong__Movie__286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieSongs] DROP CONSTRAINT [FK__MovieSong__Movie__286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieSong__Movie__2C3393D0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieSongArtists] DROP CONSTRAINT [FK__MovieSong__Movie__2C3393D0];
GO
IF OBJECT_ID(N'[dbo].[FK__MovieTrai__Movie__4F7CD00D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieTrailers] DROP CONSTRAINT [FK__MovieTrai__Movie__4F7CD00D];
GO
IF OBJECT_ID(N'[dbo].[FK__Schedule__MovieI__3F466844]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedules] DROP CONSTRAINT [FK__Schedule__MovieI__3F466844];
GO
IF OBJECT_ID(N'[dbo].[FK__Schedule__Theatr__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedules] DROP CONSTRAINT [FK__Schedule__Theatr__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__UserArtis__Movie__25869641]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserArtistRatings] DROP CONSTRAINT [FK__UserArtis__Movie__25869641];
GO
IF OBJECT_ID(N'[dbo].[FK__UserArtis__UserI__24927208]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserArtistRatings] DROP CONSTRAINT [FK__UserArtis__UserI__24927208];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__Movie__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieComments] DROP CONSTRAINT [FK__UserMovie__Movie__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__Movie__47DBAE45]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieRatingComments] DROP CONSTRAINT [FK__UserMovie__Movie__47DBAE45];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__Movie__534D60F1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieTrailerComments] DROP CONSTRAINT [FK__UserMovie__Movie__534D60F1];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__Movie__5535A963]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieTrailerComments] DROP CONSTRAINT [FK__UserMovie__Movie__5535A963];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__Movie__6D0D32F4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMoviePhotoComments] DROP CONSTRAINT [FK__UserMovie__Movie__6D0D32F4];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__Movie__6EF57B66]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMoviePhotoComments] DROP CONSTRAINT [FK__UserMovie__Movie__6EF57B66];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__UserI__3B75D760]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieComments] DROP CONSTRAINT [FK__UserMovie__UserI__3B75D760];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__UserI__46E78A0C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieRatingComments] DROP CONSTRAINT [FK__UserMovie__UserI__46E78A0C];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__UserI__5441852A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieTrailerComments] DROP CONSTRAINT [FK__UserMovie__UserI__5441852A];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__UserI__6E01572D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMoviePhotoComments] DROP CONSTRAINT [FK__UserMovie__UserI__6E01572D];
GO
IF OBJECT_ID(N'[dbo].[FK__UserMovie__UserM__45F365D3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserMovieRatingComments] DROP CONSTRAINT [FK__UserMovie__UserM__45F365D3];
GO
IF OBJECT_ID(N'[dbo].[FK__UserPrefe__Langu__6383C8BA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserPreferences] DROP CONSTRAINT [FK__UserPrefe__Langu__6383C8BA];
GO
IF OBJECT_ID(N'[dbo].[FK__UserPrefe__UserI__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserPreferences] DROP CONSTRAINT [FK__UserPrefe__UserI__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK__UserSongR__Movie__34C8D9D1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSongRatings] DROP CONSTRAINT [FK__UserSongR__Movie__34C8D9D1];
GO
IF OBJECT_ID(N'[dbo].[FK__UserSongR__UserI__33D4B598]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSongRatings] DROP CONSTRAINT [FK__UserSongR__UserI__33D4B598];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Artists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artists];
GO
IF OBJECT_ID(N'[dbo].[CriticArtistRatings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriticArtistRatings];
GO
IF OBJECT_ID(N'[dbo].[CriticMoviePhotoComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriticMoviePhotoComments];
GO
IF OBJECT_ID(N'[dbo].[CriticMovieRatingComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriticMovieRatingComments];
GO
IF OBJECT_ID(N'[dbo].[CriticMovieRatings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriticMovieRatings];
GO
IF OBJECT_ID(N'[dbo].[CriticMovieTrailerComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriticMovieTrailerComments];
GO
IF OBJECT_ID(N'[dbo].[Critics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Critics];
GO
IF OBJECT_ID(N'[dbo].[CriticSongRatings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriticSongRatings];
GO
IF OBJECT_ID(N'[dbo].[Distributors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Distributors];
GO
IF OBJECT_ID(N'[dbo].[Finances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Finances];
GO
IF OBJECT_ID(N'[dbo].[Languages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Languages];
GO
IF OBJECT_ID(N'[dbo].[MovieArtists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieArtists];
GO
IF OBJECT_ID(N'[dbo].[MovieDistributors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieDistributors];
GO
IF OBJECT_ID(N'[dbo].[MoviePhotoArtists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoviePhotoArtists];
GO
IF OBJECT_ID(N'[dbo].[MoviePhotoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoviePhotoes];
GO
IF OBJECT_ID(N'[dbo].[Movies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Movies];
GO
IF OBJECT_ID(N'[dbo].[MovieSongArtists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieSongArtists];
GO
IF OBJECT_ID(N'[dbo].[MovieSongs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieSongs];
GO
IF OBJECT_ID(N'[dbo].[MovieTrailers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieTrailers];
GO
IF OBJECT_ID(N'[dbo].[Schedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedules];
GO
IF OBJECT_ID(N'[dbo].[Theatres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Theatres];
GO
IF OBJECT_ID(N'[dbo].[UserArtistRatings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserArtistRatings];
GO
IF OBJECT_ID(N'[dbo].[UserMovieComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserMovieComments];
GO
IF OBJECT_ID(N'[dbo].[UserMoviePhotoComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserMoviePhotoComments];
GO
IF OBJECT_ID(N'[dbo].[UserMovieRatingComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserMovieRatingComments];
GO
IF OBJECT_ID(N'[dbo].[UserMovieTrailerComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserMovieTrailerComments];
GO
IF OBJECT_ID(N'[dbo].[UserPreferences]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserPreferences];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[UserSongRatings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSongRatings];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Artists'
CREATE TABLE [dbo].[Artists] (
    [ArtistId] int IDENTITY(1,1) NOT NULL,
    [ArtistName] nvarchar(255)  NOT NULL,
    [ArtistType] nvarchar(255)  NOT NULL,
    [ArtistDOB] datetime  NULL,
    [ArtistTitle] nvarchar(255)  NULL,
    [ArtistNickName] nvarchar(255)  NULL
);
GO

-- Creating table 'CriticArtistRatings'
CREATE TABLE [dbo].[CriticArtistRatings] (
    [CriticArtistRatingId] int IDENTITY(1,1) NOT NULL,
    [CriticId] int  NOT NULL,
    [MovieArtistId] int  NOT NULL,
    [Rating] decimal(5,3)  NULL,
    [ReviewDescription] nvarchar(max)  NULL,
    [ReviewTypeId] int  NULL,
    [RatingDate] datetime  NOT NULL
);
GO

-- Creating table 'CriticMoviePhotoComments'
CREATE TABLE [dbo].[CriticMoviePhotoComments] (
    [CriticMoviePhotoCommentId] int IDENTITY(1,1) NOT NULL,
    [MoviePhotoId] int  NOT NULL,
    [CriticId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Feedback] bit  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'CriticMovieRatingComments'
CREATE TABLE [dbo].[CriticMovieRatingComments] (
    [CriticMovieRatingCommentId] int IDENTITY(1,1) NOT NULL,
    [CriticMovieRatingId] int  NOT NULL,
    [CriticId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Feedback] bit  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'CriticMovieRatings'
CREATE TABLE [dbo].[CriticMovieRatings] (
    [CriticMovieRatingId] int IDENTITY(1,1) NOT NULL,
    [CriticId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Rating] decimal(5,3)  NULL,
    [ReviewDescription] nvarchar(max)  NULL,
    [ReviewTypeId] int  NULL,
    [RatingDate] datetime  NOT NULL
);
GO

-- Creating table 'CriticMovieTrailerComments'
CREATE TABLE [dbo].[CriticMovieTrailerComments] (
    [CriticMovieTrailerCommentId] int IDENTITY(1,1) NOT NULL,
    [MovieTrailerId] int  NOT NULL,
    [CriticId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Feedback] bit  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'Critics'
CREATE TABLE [dbo].[Critics] (
    [CriticId] int IDENTITY(1,1) NOT NULL,
    [SiteName] nvarchar(255)  NULL,
    [WebUrl] nvarchar(255)  NULL,
    [AlexaRating] int  NULL
);
GO

-- Creating table 'CriticSongRatings'
CREATE TABLE [dbo].[CriticSongRatings] (
    [CriticSongRatingId] int IDENTITY(1,1) NOT NULL,
    [CriticId] int  NOT NULL,
    [MovieSongId] int  NOT NULL,
    [Rating] decimal(5,3)  NULL,
    [ReviewDescription] nvarchar(max)  NULL,
    [ReviewTypeId] int  NULL,
    [RatingDate] datetime  NOT NULL
);
GO

-- Creating table 'Distributors'
CREATE TABLE [dbo].[Distributors] (
    [DistributorId] int IDENTITY(1,1) NOT NULL,
    [Address1] nvarchar(256)  NOT NULL,
    [Address2] nvarchar(256)  NULL,
    [City] nvarchar(64)  NOT NULL,
    [State] nvarchar(64)  NOT NULL,
    [Country] nvarchar(64)  NOT NULL,
    [ZipCode] nvarchar(16)  NULL,
    [Name] nvarchar(128)  NOT NULL,
    [ContactPersonName] nvarchar(128)  NULL,
    [ContactNumber] nvarchar(128)  NULL
);
GO

-- Creating table 'Finances'
CREATE TABLE [dbo].[Finances] (
    [FinanceId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [MovieProductionCost] float  NULL,
    [MovieProductionDuration] int  NULL
);
GO

-- Creating table 'Languages'
CREATE TABLE [dbo].[Languages] (
    [LanguageId] int IDENTITY(1,1) NOT NULL,
    [LanguageName] nvarchar(255)  NULL
);
GO

-- Creating table 'MovieArtists'
CREATE TABLE [dbo].[MovieArtists] (
    [MovieArtistId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [ArtistId] int  NOT NULL
);
GO

-- Creating table 'MovieDistributors'
CREATE TABLE [dbo].[MovieDistributors] (
    [MovieDistributorId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [DistributorId] int  NOT NULL
);
GO

-- Creating table 'MoviePhotoArtists'
CREATE TABLE [dbo].[MoviePhotoArtists] (
    [MoviePhotoArtistId] int IDENTITY(1,1) NOT NULL,
    [MoviePhotoId] int  NOT NULL,
    [ArtistId] int  NOT NULL
);
GO

-- Creating table 'MoviePhotoes'
CREATE TABLE [dbo].[MoviePhotoes] (
    [MoviePhotoId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [MoviePhotoURL] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [MovieId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NULL,
    [SmallPictureUrl] nvarchar(255)  NULL,
    [LargePictureUrl] nvarchar(255)  NULL,
    [ReleaseDate] datetime  NOT NULL,
    [HasReleased] nvarchar(10)  NOT NULL,
    [LanguageId] int  NOT NULL,
    [DetailsUrl] nvarchar(255)  NULL,
    [GalleryUrl] nvarchar(255)  NULL,
    [TraillerUrl] nvarchar(255)  NULL,
    [ScheduleUrl] nvarchar(255)  NULL
);
GO

-- Creating table 'MovieSongArtists'
CREATE TABLE [dbo].[MovieSongArtists] (
    [MovieSongArtistId] int IDENTITY(1,1) NOT NULL,
    [MovieSongId] int  NOT NULL,
    [ArtistId] int  NOT NULL
);
GO

-- Creating table 'MovieSongs'
CREATE TABLE [dbo].[MovieSongs] (
    [MovieSongId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [ArtistId] int  NOT NULL,
    [SongName] nvarchar(128)  NULL,
    [SongLyrics] nvarchar(max)  NULL,
    [Singers] nvarchar(255)  NULL
);
GO

-- Creating table 'MovieTrailers'
CREATE TABLE [dbo].[MovieTrailers] (
    [MovieTrailerId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [TrailerPath] nvarchar(256)  NOT NULL,
    [TrailerType] int  NOT NULL
);
GO

-- Creating table 'Schedules'
CREATE TABLE [dbo].[Schedules] (
    [ScheduleId] int IDENTITY(1,1) NOT NULL,
    [MovieId] int  NOT NULL,
    [TheatreId] int  NOT NULL,
    [ScheduleTime] datetime  NOT NULL,
    [ScheduleScreenName] nvarchar(128)  NULL
);
GO

-- Creating table 'Theatres'
CREATE TABLE [dbo].[Theatres] (
    [TheatreId] int IDENTITY(1,1) NOT NULL,
    [TheatreName] nvarchar(255)  NOT NULL,
    [TheatreLatitude] float  NULL,
    [TheatreLongitude] float  NULL,
    [NumberOfScreens] int  NOT NULL
);
GO

-- Creating table 'UserArtistRatings'
CREATE TABLE [dbo].[UserArtistRatings] (
    [UserArtistRatingId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [MovieArtistId] int  NOT NULL,
    [Rating] decimal(5,3)  NULL,
    [ReviewDescription] nvarchar(max)  NULL,
    [ReviewTypeId] int  NULL,
    [RatingDate] datetime  NOT NULL
);
GO

-- Creating table 'UserMovieComments'
CREATE TABLE [dbo].[UserMovieComments] (
    [UserMovieCommentId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Rating] decimal(5,3)  NULL,
    [ReviewDescription] nvarchar(max)  NULL,
    [ReviewTypeId] int  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'UserMoviePhotoComments'
CREATE TABLE [dbo].[UserMoviePhotoComments] (
    [UserMoviePhotoCommentId] int IDENTITY(1,1) NOT NULL,
    [MoviePhotoId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Feedback] bit  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'UserMovieRatingComments'
CREATE TABLE [dbo].[UserMovieRatingComments] (
    [UserMovieRatingCommentId] int IDENTITY(1,1) NOT NULL,
    [UserMovieRatingId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Feedback] bit  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'UserMovieTrailerComments'
CREATE TABLE [dbo].[UserMovieTrailerComments] (
    [UserMovieTrailerCommentId] int IDENTITY(1,1) NOT NULL,
    [MovieTrailerId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [Feedback] bit  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [CommentDate] datetime  NOT NULL
);
GO

-- Creating table 'UserPreferences'
CREATE TABLE [dbo].[UserPreferences] (
    [UserPreferenceId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [LanguageId] int  NOT NULL,
    [Address1] nvarchar(100)  NULL,
    [Address2] nvarchar(100)  NULL,
    [City] nvarchar(50)  NULL,
    [ZipCode] nvarchar(10)  NULL,
    [State] nvarchar(50)  NULL,
    [Country] nvarchar(50)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(32)  NOT NULL,
    [Password] nvarchar(255)  NULL,
    [BlogURL] nvarchar(255)  NULL,
    [FacebookId] nvarchar(255)  NULL,
    [TwitterId] nvarchar(255)  NULL
);
GO

-- Creating table 'UserSongRatings'
CREATE TABLE [dbo].[UserSongRatings] (
    [UserSongRatingId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [MovieSongId] int  NOT NULL,
    [Rating] decimal(5,3)  NULL,
    [ReviewDescription] nvarchar(max)  NULL,
    [ReviewTypeId] int  NULL,
    [RatingDate] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ArtistId] in table 'Artists'
ALTER TABLE [dbo].[Artists]
ADD CONSTRAINT [PK_Artists]
    PRIMARY KEY CLUSTERED ([ArtistId] ASC);
GO

-- Creating primary key on [CriticArtistRatingId] in table 'CriticArtistRatings'
ALTER TABLE [dbo].[CriticArtistRatings]
ADD CONSTRAINT [PK_CriticArtistRatings]
    PRIMARY KEY CLUSTERED ([CriticArtistRatingId] ASC);
GO

-- Creating primary key on [CriticMoviePhotoCommentId] in table 'CriticMoviePhotoComments'
ALTER TABLE [dbo].[CriticMoviePhotoComments]
ADD CONSTRAINT [PK_CriticMoviePhotoComments]
    PRIMARY KEY CLUSTERED ([CriticMoviePhotoCommentId] ASC);
GO

-- Creating primary key on [CriticMovieRatingCommentId] in table 'CriticMovieRatingComments'
ALTER TABLE [dbo].[CriticMovieRatingComments]
ADD CONSTRAINT [PK_CriticMovieRatingComments]
    PRIMARY KEY CLUSTERED ([CriticMovieRatingCommentId] ASC);
GO

-- Creating primary key on [CriticMovieRatingId] in table 'CriticMovieRatings'
ALTER TABLE [dbo].[CriticMovieRatings]
ADD CONSTRAINT [PK_CriticMovieRatings]
    PRIMARY KEY CLUSTERED ([CriticMovieRatingId] ASC);
GO

-- Creating primary key on [CriticMovieTrailerCommentId] in table 'CriticMovieTrailerComments'
ALTER TABLE [dbo].[CriticMovieTrailerComments]
ADD CONSTRAINT [PK_CriticMovieTrailerComments]
    PRIMARY KEY CLUSTERED ([CriticMovieTrailerCommentId] ASC);
GO

-- Creating primary key on [CriticId] in table 'Critics'
ALTER TABLE [dbo].[Critics]
ADD CONSTRAINT [PK_Critics]
    PRIMARY KEY CLUSTERED ([CriticId] ASC);
GO

-- Creating primary key on [CriticSongRatingId] in table 'CriticSongRatings'
ALTER TABLE [dbo].[CriticSongRatings]
ADD CONSTRAINT [PK_CriticSongRatings]
    PRIMARY KEY CLUSTERED ([CriticSongRatingId] ASC);
GO

-- Creating primary key on [DistributorId] in table 'Distributors'
ALTER TABLE [dbo].[Distributors]
ADD CONSTRAINT [PK_Distributors]
    PRIMARY KEY CLUSTERED ([DistributorId] ASC);
GO

-- Creating primary key on [FinanceId] in table 'Finances'
ALTER TABLE [dbo].[Finances]
ADD CONSTRAINT [PK_Finances]
    PRIMARY KEY CLUSTERED ([FinanceId] ASC);
GO

-- Creating primary key on [LanguageId] in table 'Languages'
ALTER TABLE [dbo].[Languages]
ADD CONSTRAINT [PK_Languages]
    PRIMARY KEY CLUSTERED ([LanguageId] ASC);
GO

-- Creating primary key on [MovieArtistId] in table 'MovieArtists'
ALTER TABLE [dbo].[MovieArtists]
ADD CONSTRAINT [PK_MovieArtists]
    PRIMARY KEY CLUSTERED ([MovieArtistId] ASC);
GO

-- Creating primary key on [MovieDistributorId] in table 'MovieDistributors'
ALTER TABLE [dbo].[MovieDistributors]
ADD CONSTRAINT [PK_MovieDistributors]
    PRIMARY KEY CLUSTERED ([MovieDistributorId] ASC);
GO

-- Creating primary key on [MoviePhotoArtistId] in table 'MoviePhotoArtists'
ALTER TABLE [dbo].[MoviePhotoArtists]
ADD CONSTRAINT [PK_MoviePhotoArtists]
    PRIMARY KEY CLUSTERED ([MoviePhotoArtistId] ASC);
GO

-- Creating primary key on [MoviePhotoId] in table 'MoviePhotoes'
ALTER TABLE [dbo].[MoviePhotoes]
ADD CONSTRAINT [PK_MoviePhotoes]
    PRIMARY KEY CLUSTERED ([MoviePhotoId] ASC);
GO

-- Creating primary key on [MovieId] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([MovieId] ASC);
GO

-- Creating primary key on [MovieSongArtistId] in table 'MovieSongArtists'
ALTER TABLE [dbo].[MovieSongArtists]
ADD CONSTRAINT [PK_MovieSongArtists]
    PRIMARY KEY CLUSTERED ([MovieSongArtistId] ASC);
GO

-- Creating primary key on [MovieSongId] in table 'MovieSongs'
ALTER TABLE [dbo].[MovieSongs]
ADD CONSTRAINT [PK_MovieSongs]
    PRIMARY KEY CLUSTERED ([MovieSongId] ASC);
GO

-- Creating primary key on [MovieTrailerId] in table 'MovieTrailers'
ALTER TABLE [dbo].[MovieTrailers]
ADD CONSTRAINT [PK_MovieTrailers]
    PRIMARY KEY CLUSTERED ([MovieTrailerId] ASC);
GO

-- Creating primary key on [ScheduleId] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [PK_Schedules]
    PRIMARY KEY CLUSTERED ([ScheduleId] ASC);
GO

-- Creating primary key on [TheatreId] in table 'Theatres'
ALTER TABLE [dbo].[Theatres]
ADD CONSTRAINT [PK_Theatres]
    PRIMARY KEY CLUSTERED ([TheatreId] ASC);
GO

-- Creating primary key on [UserArtistRatingId] in table 'UserArtistRatings'
ALTER TABLE [dbo].[UserArtistRatings]
ADD CONSTRAINT [PK_UserArtistRatings]
    PRIMARY KEY CLUSTERED ([UserArtistRatingId] ASC);
GO

-- Creating primary key on [UserMovieCommentId] in table 'UserMovieComments'
ALTER TABLE [dbo].[UserMovieComments]
ADD CONSTRAINT [PK_UserMovieComments]
    PRIMARY KEY CLUSTERED ([UserMovieCommentId] ASC);
GO

-- Creating primary key on [UserMoviePhotoCommentId] in table 'UserMoviePhotoComments'
ALTER TABLE [dbo].[UserMoviePhotoComments]
ADD CONSTRAINT [PK_UserMoviePhotoComments]
    PRIMARY KEY CLUSTERED ([UserMoviePhotoCommentId] ASC);
GO

-- Creating primary key on [UserMovieRatingCommentId] in table 'UserMovieRatingComments'
ALTER TABLE [dbo].[UserMovieRatingComments]
ADD CONSTRAINT [PK_UserMovieRatingComments]
    PRIMARY KEY CLUSTERED ([UserMovieRatingCommentId] ASC);
GO

-- Creating primary key on [UserMovieTrailerCommentId] in table 'UserMovieTrailerComments'
ALTER TABLE [dbo].[UserMovieTrailerComments]
ADD CONSTRAINT [PK_UserMovieTrailerComments]
    PRIMARY KEY CLUSTERED ([UserMovieTrailerCommentId] ASC);
GO

-- Creating primary key on [UserPreferenceId] in table 'UserPreferences'
ALTER TABLE [dbo].[UserPreferences]
ADD CONSTRAINT [PK_UserPreferences]
    PRIMARY KEY CLUSTERED ([UserPreferenceId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [UserSongRatingId] in table 'UserSongRatings'
ALTER TABLE [dbo].[UserSongRatings]
ADD CONSTRAINT [PK_UserSongRatings]
    PRIMARY KEY CLUSTERED ([UserSongRatingId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ArtistId] in table 'MovieArtists'
ALTER TABLE [dbo].[MovieArtists]
ADD CONSTRAINT [FK__MovieArti__Artis__1DE57479]
    FOREIGN KEY ([ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieArti__Artis__1DE57479'
CREATE INDEX [IX_FK__MovieArti__Artis__1DE57479]
ON [dbo].[MovieArtists]
    ([ArtistId]);
GO

-- Creating foreign key on [ArtistId] in table 'MoviePhotoArtists'
ALTER TABLE [dbo].[MoviePhotoArtists]
ADD CONSTRAINT [FK__MoviePhot__Artis__6A30C649]
    FOREIGN KEY ([ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MoviePhot__Artis__6A30C649'
CREATE INDEX [IX_FK__MoviePhot__Artis__6A30C649]
ON [dbo].[MoviePhotoArtists]
    ([ArtistId]);
GO

-- Creating foreign key on [ArtistId] in table 'MovieSongs'
ALTER TABLE [dbo].[MovieSongs]
ADD CONSTRAINT [FK__MovieSong__Artis__29572725]
    FOREIGN KEY ([ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieSong__Artis__29572725'
CREATE INDEX [IX_FK__MovieSong__Artis__29572725]
ON [dbo].[MovieSongs]
    ([ArtistId]);
GO

-- Creating foreign key on [ArtistId] in table 'MovieSongArtists'
ALTER TABLE [dbo].[MovieSongArtists]
ADD CONSTRAINT [FK__MovieSong__Artis__2D27B809]
    FOREIGN KEY ([ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieSong__Artis__2D27B809'
CREATE INDEX [IX_FK__MovieSong__Artis__2D27B809]
ON [dbo].[MovieSongArtists]
    ([ArtistId]);
GO

-- Creating foreign key on [CriticId] in table 'CriticArtistRatings'
ALTER TABLE [dbo].[CriticArtistRatings]
ADD CONSTRAINT [FK__CriticArt__Criti__20C1E124]
    FOREIGN KEY ([CriticId])
    REFERENCES [dbo].[Critics]
        ([CriticId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticArt__Criti__20C1E124'
CREATE INDEX [IX_FK__CriticArt__Criti__20C1E124]
ON [dbo].[CriticArtistRatings]
    ([CriticId]);
GO

-- Creating foreign key on [MovieArtistId] in table 'CriticArtistRatings'
ALTER TABLE [dbo].[CriticArtistRatings]
ADD CONSTRAINT [FK__CriticArt__Movie__21B6055D]
    FOREIGN KEY ([MovieArtistId])
    REFERENCES [dbo].[MovieArtists]
        ([MovieArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticArt__Movie__21B6055D'
CREATE INDEX [IX_FK__CriticArt__Movie__21B6055D]
ON [dbo].[CriticArtistRatings]
    ([MovieArtistId]);
GO

-- Creating foreign key on [CriticId] in table 'CriticMoviePhotoComments'
ALTER TABLE [dbo].[CriticMoviePhotoComments]
ADD CONSTRAINT [FK__CriticMov__Criti__72C60C4A]
    FOREIGN KEY ([CriticId])
    REFERENCES [dbo].[Critics]
        ([CriticId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Criti__72C60C4A'
CREATE INDEX [IX_FK__CriticMov__Criti__72C60C4A]
ON [dbo].[CriticMoviePhotoComments]
    ([CriticId]);
GO

-- Creating foreign key on [MoviePhotoId] in table 'CriticMoviePhotoComments'
ALTER TABLE [dbo].[CriticMoviePhotoComments]
ADD CONSTRAINT [FK__CriticMov__Movie__71D1E811]
    FOREIGN KEY ([MoviePhotoId])
    REFERENCES [dbo].[MoviePhotoes]
        ([MoviePhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Movie__71D1E811'
CREATE INDEX [IX_FK__CriticMov__Movie__71D1E811]
ON [dbo].[CriticMoviePhotoComments]
    ([MoviePhotoId]);
GO

-- Creating foreign key on [MovieId] in table 'CriticMoviePhotoComments'
ALTER TABLE [dbo].[CriticMoviePhotoComments]
ADD CONSTRAINT [FK__CriticMov__Movie__73BA3083]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Movie__73BA3083'
CREATE INDEX [IX_FK__CriticMov__Movie__73BA3083]
ON [dbo].[CriticMoviePhotoComments]
    ([MovieId]);
GO

-- Creating foreign key on [CriticMovieRatingId] in table 'CriticMovieRatingComments'
ALTER TABLE [dbo].[CriticMovieRatingComments]
ADD CONSTRAINT [FK__CriticMov__Criti__4AB81AF0]
    FOREIGN KEY ([CriticMovieRatingId])
    REFERENCES [dbo].[CriticMovieRatings]
        ([CriticMovieRatingId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Criti__4AB81AF0'
CREATE INDEX [IX_FK__CriticMov__Criti__4AB81AF0]
ON [dbo].[CriticMovieRatingComments]
    ([CriticMovieRatingId]);
GO

-- Creating foreign key on [CriticId] in table 'CriticMovieRatingComments'
ALTER TABLE [dbo].[CriticMovieRatingComments]
ADD CONSTRAINT [FK__CriticMov__Criti__4BAC3F29]
    FOREIGN KEY ([CriticId])
    REFERENCES [dbo].[Critics]
        ([CriticId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Criti__4BAC3F29'
CREATE INDEX [IX_FK__CriticMov__Criti__4BAC3F29]
ON [dbo].[CriticMovieRatingComments]
    ([CriticId]);
GO

-- Creating foreign key on [MovieId] in table 'CriticMovieRatingComments'
ALTER TABLE [dbo].[CriticMovieRatingComments]
ADD CONSTRAINT [FK__CriticMov__Movie__4CA06362]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Movie__4CA06362'
CREATE INDEX [IX_FK__CriticMov__Movie__4CA06362]
ON [dbo].[CriticMovieRatingComments]
    ([MovieId]);
GO

-- Creating foreign key on [CriticId] in table 'CriticMovieRatings'
ALTER TABLE [dbo].[CriticMovieRatings]
ADD CONSTRAINT [FK__CriticMov__Criti__37A5467C]
    FOREIGN KEY ([CriticId])
    REFERENCES [dbo].[Critics]
        ([CriticId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Criti__37A5467C'
CREATE INDEX [IX_FK__CriticMov__Criti__37A5467C]
ON [dbo].[CriticMovieRatings]
    ([CriticId]);
GO

-- Creating foreign key on [MovieId] in table 'CriticMovieRatings'
ALTER TABLE [dbo].[CriticMovieRatings]
ADD CONSTRAINT [FK__CriticMov__Movie__38996AB5]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Movie__38996AB5'
CREATE INDEX [IX_FK__CriticMov__Movie__38996AB5]
ON [dbo].[CriticMovieRatings]
    ([MovieId]);
GO

-- Creating foreign key on [CriticId] in table 'CriticMovieTrailerComments'
ALTER TABLE [dbo].[CriticMovieTrailerComments]
ADD CONSTRAINT [FK__CriticMov__Criti__59063A47]
    FOREIGN KEY ([CriticId])
    REFERENCES [dbo].[Critics]
        ([CriticId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Criti__59063A47'
CREATE INDEX [IX_FK__CriticMov__Criti__59063A47]
ON [dbo].[CriticMovieTrailerComments]
    ([CriticId]);
GO

-- Creating foreign key on [MovieTrailerId] in table 'CriticMovieTrailerComments'
ALTER TABLE [dbo].[CriticMovieTrailerComments]
ADD CONSTRAINT [FK__CriticMov__Movie__5812160E]
    FOREIGN KEY ([MovieTrailerId])
    REFERENCES [dbo].[MovieTrailers]
        ([MovieTrailerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Movie__5812160E'
CREATE INDEX [IX_FK__CriticMov__Movie__5812160E]
ON [dbo].[CriticMovieTrailerComments]
    ([MovieTrailerId]);
GO

-- Creating foreign key on [MovieId] in table 'CriticMovieTrailerComments'
ALTER TABLE [dbo].[CriticMovieTrailerComments]
ADD CONSTRAINT [FK__CriticMov__Movie__59FA5E80]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticMov__Movie__59FA5E80'
CREATE INDEX [IX_FK__CriticMov__Movie__59FA5E80]
ON [dbo].[CriticMovieTrailerComments]
    ([MovieId]);
GO

-- Creating foreign key on [CriticId] in table 'CriticSongRatings'
ALTER TABLE [dbo].[CriticSongRatings]
ADD CONSTRAINT [FK__CriticSon__Criti__300424B4]
    FOREIGN KEY ([CriticId])
    REFERENCES [dbo].[Critics]
        ([CriticId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticSon__Criti__300424B4'
CREATE INDEX [IX_FK__CriticSon__Criti__300424B4]
ON [dbo].[CriticSongRatings]
    ([CriticId]);
GO

-- Creating foreign key on [MovieSongId] in table 'CriticSongRatings'
ALTER TABLE [dbo].[CriticSongRatings]
ADD CONSTRAINT [FK__CriticSon__Movie__30F848ED]
    FOREIGN KEY ([MovieSongId])
    REFERENCES [dbo].[MovieSongs]
        ([MovieSongId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CriticSon__Movie__30F848ED'
CREATE INDEX [IX_FK__CriticSon__Movie__30F848ED]
ON [dbo].[CriticSongRatings]
    ([MovieSongId]);
GO

-- Creating foreign key on [DistributorId] in table 'MovieDistributors'
ALTER TABLE [dbo].[MovieDistributors]
ADD CONSTRAINT [FK__MovieDist__Distr__5FB337D6]
    FOREIGN KEY ([DistributorId])
    REFERENCES [dbo].[Distributors]
        ([DistributorId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieDist__Distr__5FB337D6'
CREATE INDEX [IX_FK__MovieDist__Distr__5FB337D6]
ON [dbo].[MovieDistributors]
    ([DistributorId]);
GO

-- Creating foreign key on [MovieId] in table 'Finances'
ALTER TABLE [dbo].[Finances]
ADD CONSTRAINT [FK__Finance__MovieId__4316F928]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Finance__MovieId__4316F928'
CREATE INDEX [IX_FK__Finance__MovieId__4316F928]
ON [dbo].[Finances]
    ([MovieId]);
GO

-- Creating foreign key on [LanguageId] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [FK__Movie__LanguageI__1A14E395]
    FOREIGN KEY ([LanguageId])
    REFERENCES [dbo].[Languages]
        ([LanguageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Movie__LanguageI__1A14E395'
CREATE INDEX [IX_FK__Movie__LanguageI__1A14E395]
ON [dbo].[Movies]
    ([LanguageId]);
GO

-- Creating foreign key on [LanguageId] in table 'UserPreferences'
ALTER TABLE [dbo].[UserPreferences]
ADD CONSTRAINT [FK__UserPrefe__Langu__6383C8BA]
    FOREIGN KEY ([LanguageId])
    REFERENCES [dbo].[Languages]
        ([LanguageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserPrefe__Langu__6383C8BA'
CREATE INDEX [IX_FK__UserPrefe__Langu__6383C8BA]
ON [dbo].[UserPreferences]
    ([LanguageId]);
GO

-- Creating foreign key on [MovieId] in table 'MovieArtists'
ALTER TABLE [dbo].[MovieArtists]
ADD CONSTRAINT [FK__MovieArti__Movie__1CF15040]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieArti__Movie__1CF15040'
CREATE INDEX [IX_FK__MovieArti__Movie__1CF15040]
ON [dbo].[MovieArtists]
    ([MovieId]);
GO

-- Creating foreign key on [MovieArtistId] in table 'UserArtistRatings'
ALTER TABLE [dbo].[UserArtistRatings]
ADD CONSTRAINT [FK__UserArtis__Movie__25869641]
    FOREIGN KEY ([MovieArtistId])
    REFERENCES [dbo].[MovieArtists]
        ([MovieArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserArtis__Movie__25869641'
CREATE INDEX [IX_FK__UserArtis__Movie__25869641]
ON [dbo].[UserArtistRatings]
    ([MovieArtistId]);
GO

-- Creating foreign key on [MovieId] in table 'MovieDistributors'
ALTER TABLE [dbo].[MovieDistributors]
ADD CONSTRAINT [FK__MovieDist__Movie__5EBF139D]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieDist__Movie__5EBF139D'
CREATE INDEX [IX_FK__MovieDist__Movie__5EBF139D]
ON [dbo].[MovieDistributors]
    ([MovieId]);
GO

-- Creating foreign key on [MoviePhotoId] in table 'MoviePhotoArtists'
ALTER TABLE [dbo].[MoviePhotoArtists]
ADD CONSTRAINT [FK__MoviePhot__Movie__693CA210]
    FOREIGN KEY ([MoviePhotoId])
    REFERENCES [dbo].[MoviePhotoes]
        ([MoviePhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MoviePhot__Movie__693CA210'
CREATE INDEX [IX_FK__MoviePhot__Movie__693CA210]
ON [dbo].[MoviePhotoArtists]
    ([MoviePhotoId]);
GO

-- Creating foreign key on [MovieId] in table 'MoviePhotoes'
ALTER TABLE [dbo].[MoviePhotoes]
ADD CONSTRAINT [FK__MoviePhot__Movie__66603565]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MoviePhot__Movie__66603565'
CREATE INDEX [IX_FK__MoviePhot__Movie__66603565]
ON [dbo].[MoviePhotoes]
    ([MovieId]);
GO

-- Creating foreign key on [MoviePhotoId] in table 'UserMoviePhotoComments'
ALTER TABLE [dbo].[UserMoviePhotoComments]
ADD CONSTRAINT [FK__UserMovie__Movie__6D0D32F4]
    FOREIGN KEY ([MoviePhotoId])
    REFERENCES [dbo].[MoviePhotoes]
        ([MoviePhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__Movie__6D0D32F4'
CREATE INDEX [IX_FK__UserMovie__Movie__6D0D32F4]
ON [dbo].[UserMoviePhotoComments]
    ([MoviePhotoId]);
GO

-- Creating foreign key on [MovieId] in table 'MovieSongs'
ALTER TABLE [dbo].[MovieSongs]
ADD CONSTRAINT [FK__MovieSong__Movie__286302EC]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieSong__Movie__286302EC'
CREATE INDEX [IX_FK__MovieSong__Movie__286302EC]
ON [dbo].[MovieSongs]
    ([MovieId]);
GO

-- Creating foreign key on [MovieId] in table 'MovieTrailers'
ALTER TABLE [dbo].[MovieTrailers]
ADD CONSTRAINT [FK__MovieTrai__Movie__4F7CD00D]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieTrai__Movie__4F7CD00D'
CREATE INDEX [IX_FK__MovieTrai__Movie__4F7CD00D]
ON [dbo].[MovieTrailers]
    ([MovieId]);
GO

-- Creating foreign key on [MovieId] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [FK__Schedule__MovieI__3F466844]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Schedule__MovieI__3F466844'
CREATE INDEX [IX_FK__Schedule__MovieI__3F466844]
ON [dbo].[Schedules]
    ([MovieId]);
GO

-- Creating foreign key on [MovieId] in table 'UserMovieComments'
ALTER TABLE [dbo].[UserMovieComments]
ADD CONSTRAINT [FK__UserMovie__Movie__3C69FB99]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__Movie__3C69FB99'
CREATE INDEX [IX_FK__UserMovie__Movie__3C69FB99]
ON [dbo].[UserMovieComments]
    ([MovieId]);
GO

-- Creating foreign key on [MovieId] in table 'UserMovieRatingComments'
ALTER TABLE [dbo].[UserMovieRatingComments]
ADD CONSTRAINT [FK__UserMovie__Movie__47DBAE45]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__Movie__47DBAE45'
CREATE INDEX [IX_FK__UserMovie__Movie__47DBAE45]
ON [dbo].[UserMovieRatingComments]
    ([MovieId]);
GO

-- Creating foreign key on [MovieId] in table 'UserMovieTrailerComments'
ALTER TABLE [dbo].[UserMovieTrailerComments]
ADD CONSTRAINT [FK__UserMovie__Movie__5535A963]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__Movie__5535A963'
CREATE INDEX [IX_FK__UserMovie__Movie__5535A963]
ON [dbo].[UserMovieTrailerComments]
    ([MovieId]);
GO

-- Creating foreign key on [MovieId] in table 'UserMoviePhotoComments'
ALTER TABLE [dbo].[UserMoviePhotoComments]
ADD CONSTRAINT [FK__UserMovie__Movie__6EF57B66]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__Movie__6EF57B66'
CREATE INDEX [IX_FK__UserMovie__Movie__6EF57B66]
ON [dbo].[UserMoviePhotoComments]
    ([MovieId]);
GO

-- Creating foreign key on [MovieSongId] in table 'MovieSongArtists'
ALTER TABLE [dbo].[MovieSongArtists]
ADD CONSTRAINT [FK__MovieSong__Movie__2C3393D0]
    FOREIGN KEY ([MovieSongId])
    REFERENCES [dbo].[MovieSongs]
        ([MovieSongId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MovieSong__Movie__2C3393D0'
CREATE INDEX [IX_FK__MovieSong__Movie__2C3393D0]
ON [dbo].[MovieSongArtists]
    ([MovieSongId]);
GO

-- Creating foreign key on [MovieSongId] in table 'UserSongRatings'
ALTER TABLE [dbo].[UserSongRatings]
ADD CONSTRAINT [FK__UserSongR__Movie__34C8D9D1]
    FOREIGN KEY ([MovieSongId])
    REFERENCES [dbo].[MovieSongs]
        ([MovieSongId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserSongR__Movie__34C8D9D1'
CREATE INDEX [IX_FK__UserSongR__Movie__34C8D9D1]
ON [dbo].[UserSongRatings]
    ([MovieSongId]);
GO

-- Creating foreign key on [MovieTrailerId] in table 'UserMovieTrailerComments'
ALTER TABLE [dbo].[UserMovieTrailerComments]
ADD CONSTRAINT [FK__UserMovie__Movie__534D60F1]
    FOREIGN KEY ([MovieTrailerId])
    REFERENCES [dbo].[MovieTrailers]
        ([MovieTrailerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__Movie__534D60F1'
CREATE INDEX [IX_FK__UserMovie__Movie__534D60F1]
ON [dbo].[UserMovieTrailerComments]
    ([MovieTrailerId]);
GO

-- Creating foreign key on [TheatreId] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [FK__Schedule__Theatr__403A8C7D]
    FOREIGN KEY ([TheatreId])
    REFERENCES [dbo].[Theatres]
        ([TheatreId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Schedule__Theatr__403A8C7D'
CREATE INDEX [IX_FK__Schedule__Theatr__403A8C7D]
ON [dbo].[Schedules]
    ([TheatreId]);
GO

-- Creating foreign key on [UserId] in table 'UserArtistRatings'
ALTER TABLE [dbo].[UserArtistRatings]
ADD CONSTRAINT [FK__UserArtis__UserI__24927208]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserArtis__UserI__24927208'
CREATE INDEX [IX_FK__UserArtis__UserI__24927208]
ON [dbo].[UserArtistRatings]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserMovieComments'
ALTER TABLE [dbo].[UserMovieComments]
ADD CONSTRAINT [FK__UserMovie__UserI__3B75D760]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__UserI__3B75D760'
CREATE INDEX [IX_FK__UserMovie__UserI__3B75D760]
ON [dbo].[UserMovieComments]
    ([UserId]);
GO

-- Creating foreign key on [UserMovieRatingId] in table 'UserMovieRatingComments'
ALTER TABLE [dbo].[UserMovieRatingComments]
ADD CONSTRAINT [FK__UserMovie__UserM__45F365D3]
    FOREIGN KEY ([UserMovieRatingId])
    REFERENCES [dbo].[UserMovieComments]
        ([UserMovieCommentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__UserM__45F365D3'
CREATE INDEX [IX_FK__UserMovie__UserM__45F365D3]
ON [dbo].[UserMovieRatingComments]
    ([UserMovieRatingId]);
GO

-- Creating foreign key on [UserId] in table 'UserMoviePhotoComments'
ALTER TABLE [dbo].[UserMoviePhotoComments]
ADD CONSTRAINT [FK__UserMovie__UserI__6E01572D]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__UserI__6E01572D'
CREATE INDEX [IX_FK__UserMovie__UserI__6E01572D]
ON [dbo].[UserMoviePhotoComments]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserMovieRatingComments'
ALTER TABLE [dbo].[UserMovieRatingComments]
ADD CONSTRAINT [FK__UserMovie__UserI__46E78A0C]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__UserI__46E78A0C'
CREATE INDEX [IX_FK__UserMovie__UserI__46E78A0C]
ON [dbo].[UserMovieRatingComments]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserMovieTrailerComments'
ALTER TABLE [dbo].[UserMovieTrailerComments]
ADD CONSTRAINT [FK__UserMovie__UserI__5441852A]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserMovie__UserI__5441852A'
CREATE INDEX [IX_FK__UserMovie__UserI__5441852A]
ON [dbo].[UserMovieTrailerComments]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserPreferences'
ALTER TABLE [dbo].[UserPreferences]
ADD CONSTRAINT [FK__UserPrefe__UserI__628FA481]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserPrefe__UserI__628FA481'
CREATE INDEX [IX_FK__UserPrefe__UserI__628FA481]
ON [dbo].[UserPreferences]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserSongRatings'
ALTER TABLE [dbo].[UserSongRatings]
ADD CONSTRAINT [FK__UserSongR__UserI__33D4B598]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserSongR__UserI__33D4B598'
CREATE INDEX [IX_FK__UserSongR__UserI__33D4B598]
ON [dbo].[UserSongRatings]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------