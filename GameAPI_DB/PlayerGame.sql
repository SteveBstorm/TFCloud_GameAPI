CREATE TABLE [dbo].[PlayerGame]
(
	PlayerId INT,
	GameId INT
	CONSTRAINT FK_PG_Game FOREIGN KEY (GameId) 
		REFERENCES Game(Id),
	CONSTRAINT FK_PG_Player FOREIGN KEY (PlayerId)
		REFERENCES Player(Id)		
)
