﻿CREATE PROCEDURE SP_OBTERQUANDIDADEDENUMEROS
@IDCONTATO UNIQUEIDENTIFIER
AS
BEGIN
SELECT COUNT(*) FROM TELEFONE
WHERE IDCONTATO = @IDCONTATO

END