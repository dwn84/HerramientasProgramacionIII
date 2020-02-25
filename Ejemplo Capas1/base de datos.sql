create table tblPacientes(
	PacId varchar(15) primary key,
	PacNombres varchar(50) not null,
	PacApellidos varchar(50) not null,
	PacFechaN date not null,
	PacSexo varchar(1) not null check(PacSexo in ('M','F'))
);
create table tblTratamientos(
	TraId int identity primary key,
	TraIdPaciente varchar(15) not null,
	TraFechaAsignado date not null,
	TraDetalles varchar(100) not null,
	TraFechaIni date not null,
	TraFechaFin date not null,
	TraObservaciones varchar(100),
	foreign key (TraIdPaciente) references tblPacientes(PacId) on delete cascade on update cascade
);

insert into tblPacientes values ('43555888','Lorelei','Jimenez','1991-01-31','F');