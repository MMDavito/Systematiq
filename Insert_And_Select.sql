USE systematiq_competition;

--INSERT INTO Competitions(Name) VALUES('TEST');
SELECT * FROM Competitions;
SELECT * FROM Competitors ORDER BY CompetitorId ASC;


SELECT * FROM Competitions
LEFT JOIN Competitors 
	ON Competitions.CompetitionId = Competitors.CompetitionId;