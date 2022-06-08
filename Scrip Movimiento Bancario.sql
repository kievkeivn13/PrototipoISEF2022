

/*Área de Contabilidad*/
create table tipocuenta(
idTipoCuenta varchar (15) primary key,
nombre varchar(35),
estado varchar(1)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table tipocuentabancos(
pkId varchar (15) primary key,
nombre varchar(35),
estado varchar(1)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table cuentacontable(
	pkId varchar(15) primary key,
    nombre varchar(35),
    fkIdTipo varchar(15),
    cargo float default 0, -- cargo de la cuenta, inicia en 0 al crear la cuenta
    abono float default 0, -- abono de la cuenta, inicia en 0 al crear la cuenta
    saldoAcumulado float default 0, -- Saldo acumulado en la cuenta, inicia en 0 al crear la cuenta
    descripcion varchar(35),
    estado varchar(1),
    foreign key (fkIdTipo) references tipocuenta(idTipoCuenta)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table cuentabancaria(
	pkId varchar(15) primary key,
    nombre varchar(35),
    fkIdTipo varchar(15),
    cargo float default 0, -- cargo de la cuenta, inicia en 0 al crear la cuenta
    abono float default 0, -- abono de la cuenta, inicia en 0 al crear la cuenta
    saldoAcumulado float default 0, -- Saldo acumulado en la cuenta, inicia en 0 al crear la cuenta
    descripcion varchar(35),
    estado varchar(1),
    foreign key (fkIdTipo) references tipocuentabancos(pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table tipomovimientosbancarios(
	pkId varchar(15) primary key,
	nombre varchar(35),
    estado varchar(1)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;