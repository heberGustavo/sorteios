﻿--ALTER TABLE Sorteio DROP CONSTRAINT DF__Sorteio__excluid__3D2915A8 GO;
--ALTER TABLE Sorteio DROP COLUMN excluido GO;

ALTER TABLE Sorteio ADD excluido BIT NOT NULL DEFAULT 0 GO;