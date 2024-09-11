/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Player VALUES ('Arthur', 'arthur@kaamelott.com')
INSERT INTO Player VALUES ('Merlin', 'enchanteur@kaamelott.com')
INSERT INTO Player VALUES ('Leodagan', 'leo@kaamelott.com')

INSERT INTO Game VALUES ('World of Warcraft', 'Blizzard', 2004, 'MMORPG')
, ('Elden Ring', 'From Software', 2022, 'Action RPG')
, ('Jeu de panpan', 'EA Games', 2023, 'FPS')

INSERT INTO PlayerGame VALUES (1, 1), (1, 2), (2, 1), (3, 3), (3, 1)