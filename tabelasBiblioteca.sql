CREATE TABLE bibLivro
(
	idLivro INT NOT NULL PRIMARY KEY Identity,
	codigoLivro varchar(10) not null unique,
	tituloLivro varchar(50) not null,
	autorLivro varchar(50) not null
)

create table bibLeitor
(
	idLeitor int not null primary key identity,
	nomeLeitor varchar(50)  not null,
	telefoneLeitor varchar(20),
	emailLeitor varchar(50),
	enderecoLeitor varchar(100) not null
)

create table bibEmprestimo
(
	idEmprestimo int not null primary key identity,
	idLivro int not null,
	idLeitor int not null,
	dataEmprestimo datetime not null,
	dataDevolucaoPrevista datetime not null,
	dataDevolucaoReal datetime  null,
	foreign key(idLivro) references bibLivro(idLivro),
	foreign key(idLeitor) references bibLeitor(idLeitor)
)


