create table pessoa(
cpf_pessoa varchar(14) not null,
codigo_pessoa integer not null,
nome varchar(50) not null,
rg varchar(15),
data_nascimento date,
telefone varchar(10),
sexo char,
estado_civil varchar(10),
email varchar(30),
rua varchar(40),
numero integer,
bairro varchar(30),
estado varchar(2),
cep varchar(10),
cidade varchar(20),
primary key(cpf_pessoa));

create table cliente(
cpf_cliente varchar(14) not null,
primary key (cpf_cliente),
foreign key (cpf_cliente) references pessoa(cpf_pessoa));

create table funcionario(
cpf_funcionario varchar(14) not null,
codigo_funcionario integer not null,
username varchar(20),
senha varchar(10),
cargo varchar(30),
salario_base float,
data_inicio date,
primary key (cpf_funcionario),
foreign key (cpf_funcionario) references pessoa(cpf_pessoa));

create table jogos(
codigo_jogo integer not null,
nome varchar(40) not null,
preco float,
console varchar(20),
genero varchar(20),
qnt_estoque integer,
primary key (codigo_jogo));

create table pagamento(
codigo_pagamento integer not null,
tipo varchar(10) not null,
primary key (codigo_pagamento));

create table venda(
codigo_venda integer not null auto_increment,
cpf_cli varchar(14) not null,
cpf_func varchar(14) not null,
cod_jogos integer not null,
cod_pagamento integer not null,
quantidade integer,
numero_parcelas integer,
valor_parcelas float,
valor_total float,
primary key (codigo_venda, cpf_cli, cpf_func, cod_jogos, cod_pagamento),
foreign key (cpf_cli) references cliente(cpf_cliente),
foreign key (cpf_func) references funcionario(cpf_funcionario),
foreign key (cod_jogos) references jogos(codigo_jogo),
foreign key (cod_pagamento) references pagamento (codigo_pagamento));

create table aluguel(
codigo_aluguel integer not null auto_increment,
cpf_cli varchar(14) not null,
cpf_func varchar(14) not null,
cod_jogos integer not null,
cod_pagamento integer not null,
quantidade integer,
dias_aluguel integer,
valor_total float,
primary key (codigo_aluguel, cpf_cli, cpf_func, cod_jogos, cod_pagamento),
foreign key (cpf_cli) references cliente(cpf_cliente),
foreign key (cpf_func) references funcionario(cpf_funcionario),
foreign key (cod_jogos) references jogos(codigo_jogo),
foreign key (cod_pagamento) references pagamento(codigo_pagamento));


