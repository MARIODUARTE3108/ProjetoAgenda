CREATE PROCEDURE SP_ALTERARTELEFONE
@IDTELEFONE UNIQUEIDENTIFIER,
@NUMERO NVARCHAR(11),
@IDCONTATO UNIQUEIDENTIFIER
AS
BEGIN
UPDATE TELEFONE SET
NUMERO = @NUMERO,
IDCONTATO = @IDCONTATO
WHERE
IDTELEFONE = @IDTELEFONE
END