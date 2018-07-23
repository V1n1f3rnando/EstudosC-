CREATE TABLE Pessoa(
    [IdPessoa]       INT          IDENTITY (1, 1) NOT NULL,
    [nome]           VARCHAR (50) NOT NULL,
    [dataNascimento] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC)
);
