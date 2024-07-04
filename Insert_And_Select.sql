USE systematiq_competition;

--INSERT INTO Competitions(Name) VALUES('TEST');
SELECT * FROM Competitions;
SELECT * FROM Competitors ORDER BY CompetitorId ASC;


SELECT Competitions.CompetitionId, Competitions.Name, Competitors.CompetitorId, Competitors.Name  
FROM Competitions
LEFT JOIN Competitors 
	ON Competitions.CompetitionId = Competitors.CompetitionId
ORDER BY Competitions.CompetitionId;
