--Create DataBase Alpha;
--GO
--USE [ProjectManhattan]
--GO
Use Alpha
GO
--Create Tables
--Drop TABLE Language
--Go
CREATE TABLE Language
 (
 LanguageID INT NOT NULL IDENTITY(1,1),
 LanguageName varchar(255)
 PRIMARY KEY (LanguageID)
 );
GO

--Drop TABLE CriticSites
--Go

CREATE TABLE CriticSites
 (
 CriticSiteId Int NOT NULL  IDENTITY(1,1),
 SiteName varchar(255),
 WebUrl varchar(255),
 AlexaRating Int ,
 PRIMARY KEY (CriticSiteId),
 );
GO

--Drop TABLE Movie
--Go
CREATE TABLE Movie
 (
 MovieID int NOT NULL  IDENTITY(1,1),
 Name varchar(255),
 SmallPictureUrl varchar(255),
 LargePictureUrl varchar(255),
 HasReleased varchar(10) NOT NULL CHECK (HasReleased IN('Released', 'ComingSoon')) ,
 LanguageID int NOT NULL,
 PRIMARY KEY(MovieID),
 FOREIGN KEY (LanguageID) REFERENCES Language(LanguageID)
 ); 
GO

--Drop TABLE MovieDetail
--Go
CREATE TABLE MovieDetail
 (
 MovieDetailID int Not NULL  IDENTITY(1,1),
 MovieID int NOT NULL,
 DetailsUrl varchar(255),
 GalleryUrl varchar(255),
 TraillerUrl varchar(255),
 ScheduleUrl varchar(255),
 PRIMARY KEY (MovieDetailID),
 FOREIGN KEY (MovieID) REFERENCES Movie(MovieID)
  );
GO

--Drop TABLE CriticRating
--Go
CREATE TABLE CriticRating
 (
 CriticRatingId Int NOT NULL  IDENTITY(1,1),
 CriticSiteId Int,
 MovieDetailID Int NOT NULL,
 Rating Decimal(5,3),
 PRIMARY KEY (CriticRatingId),
 FOREIGN KEY (MovieDetailID) REFERENCES MovieDetail(MovieDetailID),
 FOREIGN KEY (CriticSiteId) REFERENCES CriticSites(CriticSiteId)
 );
GO

--Drop TABLE UserRating
--Go
CREATE TABLE UserRating
 (
 UserRatingId int NOT NULL  IDENTITY(1,1),
 MovieDetailID Int NOT NULL,
 Rating Decimal(5,3),
 NumberOfUsers int NOT NULL
 PRIMARY KEY (UserRatingId),
 FOREIGN KEY (MovieDetailID) REFERENCES MovieDetail(MovieDetailID)
 );
GO

--Drop TABLE MovieLoader
--Go
CREATE TABLE MovieLoader
 (
 MovieID int NOT NULL  IDENTITY(1,1),
 Name varchar(255),
 SmallPictureUrl varchar(255),
 LargePictureUrl varchar(255),
 ReleaseDate date,
 LanguageID int NOT NULL,
 PRIMARY KEY(MovieID),
 FOREIGN KEY (LanguageID) REFERENCES Language(LanguageID)
 ); 
GO

--Drop TABLE MovieDetailLoader
--Go
CREATE TABLE MovieDetailLoader
 (
 MovieDetailID int Not NULL  IDENTITY(1,1),
 MovieID int NOT NULL,
 DetailsUrl varchar(255),
 GalleryUrl varchar(255),
 TraillerUrl varchar(255),
 ScheduleUrl varchar(255),
 PRIMARY KEY (MovieDetailID),
 FOREIGN KEY (MovieID) REFERENCES MovieLoader(MovieID)
  );
GO

--Drop TABLE CriticRatingLoader
--Go
CREATE TABLE CriticRatingLoader
 (
 CriticRatingId Int NOT NULL  IDENTITY(1,1),
 CriticSiteId Int,
 MovieDetailID Int NOT NULL,
 Rating Decimal(5,3),
 PRIMARY KEY (CriticRatingId),
 FOREIGN KEY (MovieDetailID) REFERENCES MovieDetailLoader(MovieDetailID),
 FOREIGN KEY (CriticSiteId) REFERENCES CriticSites(CriticSiteId)
 );
GO

--Drop TABLE UserRatingLoader
--Go
CREATE TABLE UserRatingLoader
 (
 UserRatingId int NOT NULL  IDENTITY(1,1),
 MovieDetailID Int NOT NULL,
 Rating Decimal(5,3),
 NumberOfUsers int NOT NULL
 PRIMARY KEY (UserRatingId),
 FOREIGN KEY (MovieDetailID) REFERENCES MovieDetailLoader(MovieDetailID)
 );
GO
-- -- Add Views

--DROP VIEW [CriticRatingWithSiteInfo]
--GO
--USE Test
--GO
--CREATE VIEW [CriticRatingWithSiteInfo] AS
----SELECT CriticRating.MovieDetailID,CriticRating.Rating,CriticSites.AlexaRating,CriticSites.SiteName,CriticSites.WebUrl
--SELECT CriticRating.CriticRatingId,CriticRating.MovieDetailID,CriticRating.Rating,CriticSites.*
--FROM CriticRating
--JOIN CriticSites ON
--CriticRating.CriticSiteId = CriticSites.CriticSiteId;
--GO

--USE Test
--GO
--DROP VIEW [MovieInfo]
--GO
--USE Test
--GO
--CREATE VIEW [MovieInfo] AS
--SELECT Movie.HasReleased,Movie.LanguageID,Movie.LargePictureUrl,Movie.Name,Movie.SmallPictureUrl,MovieDetail.*,UserRating.NumberOfUsers,UserRating.Rating,UserRating.UserRatingId
--FROM dbo.Movie
--JOIN MovieDetail ON
--Movie.MovieID = MovieDetail.MovieID
--LEFT JOIN UserRating ON
--MovieDetail.MovieDetailID = UserRating.MovieDetailID
--GO

---- Add Stored Procedure
--USE Test
--GO
----DROP PROCEDURE MovieDetailsPageFromTables
----GO
--CREATE PROCEDURE MovieDetailsPageFromTables
--    @MovieIDFromProc INT 
--AS 
--	DECLARE @CalcMovieDetailId INT
--    SET NOCOUNT ON;

--    SELECT *
--	FROM Movie
--	JOIN MovieDetail ON
--	Movie.MovieID = MovieDetail.MovieID
--	LEFT JOIN UserRating ON
--	MovieDetail.MovieDetailID = UserRating.MovieDetailID
--	Where Movie.MovieID= @MovieIDFromProc

--	SELECT @CalcMovieDetailId MovieDetailID FROM MovieDetail WHERE	 MovieDetail.MovieID = @MovieIDFromProc

--	SELECT *
--	FROM CriticRating
--	JOIN CriticSites ON
--	CriticRating.CriticSiteId = CriticSites.CriticSiteId
--	Where CriticRating.MovieDetailID = @CalcMovieDetailId
--	GO

----DROP PROCEDURE MovieInfoFromViews
----GO
--CREATE PROCEDURE MovieInfoFromViews
--@MovieIDFromProc INT 
--AS 
--	DECLARE @CalcMovieDetailId INT
--    SET NOCOUNT ON;
--    SELECT *
--	FROM [MovieInfo]
--	Where [MovieInfo].MovieID= @MovieIDFromProc
--GO

--Use Test 
--GO
--DROP PROCEDURE CriticRatingFromViews
--GO
--CREATE PROCEDURE CriticRatingFromViews
--@MovieIDFromProc INT 
--AS 
----	DECLARE @CalcMovieDetailId INT
--    SET NOCOUNT ON;
----	SET @CalcMovieDetailId MovieDetailID FROM MovieDetail WHERE	 MovieDetail.MovieID = @MovieIDFromProc
--	SELECT [CriticRatingWithSiteInfo].*
--	FROM [CriticRatingWithSiteInfo]
--	JOIN MovieDetail ON 
--	[CriticRatingWithSiteInfo].MovieDetailID = MovieDetail.MovieDetailID
--	Where MovieDetail.MovieID = @MovieIDFromProc
--GO

