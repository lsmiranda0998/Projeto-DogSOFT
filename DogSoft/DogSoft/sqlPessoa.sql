CREATE TABLE Pessoa (
	pes_cod INTEGER IDENTITY (1,1) NOT NULL,
	pes_nome VARCHAR (100) NOT NULL,
	pes_telefone VARCHAR (45) NOT NULL,
	pes_email VARCHAR(100) NOT NULL,
	pes_rua VARCHAR(100) NOT NULL,
	pes_complemento VARCHAR(100),
	pes_bairro VARCHAR(100) NOT NULL,
	pes_num INTEGER,
	pes_cep VARCHAR(45) NOT NULL,
	cid_cod INTEGER NOT NULL,
	CONSTRAINT pkPes PRIMARY KEY (pes_cod),
	CONSTRAINT fkPes FOREIGN KEY(cid_cod) REFERENCES Cidade
);