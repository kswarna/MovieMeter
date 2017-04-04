Use Alpha;
GO
INSERT INTO MovieLoader(LanguageID,LargePictureUrl,SmallPictureUrl,Name)
SELECT LanguageID,LargePictureUrl,SmallPictureUrl,Name FROM Movie;
GO
INSERT INTO MovieDetailLoader(DetailsUrl,GalleryUrl,MovieID,ScheduleUrl,TraillerUrl)
SELECT DetailsUrl,GalleryUrl,MovieID,ScheduleUrl,TraillerUrl FROM MovieDetail;
GO
INSERT INTO CriticRatingLoader(CriticSiteId,MovieDetailID,Rating)
SELECT CriticSiteId,MovieDetailID,Rating FROM CriticRating;
GO
INSERT INTO UserRatingLoader(MovieDetailID,NumberOfUsers,Rating)
SELECT MovieDetailID,NumberOfUsers,Rating FROM UserRating;
GO
