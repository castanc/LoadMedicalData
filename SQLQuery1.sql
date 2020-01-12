select * from CXCJUAN
SELECT * FROM MOVIMIENTOS

SELECT * FROM REGISTROSTARJETAS
where CardHolder = 'BROU CESAR'
order by detalle, fecha

SELECT * FROM REGISTROSTARJETAS
where CardHolder = 'BROU CESAR'
and detalle like 'trf e-brou%'
order by detalle, fecha

SELECT sum(debito),sum(credito) FROM REGISTROSTARJETAS
where CardHolder = 'BROU CESAR'
and detalle like 'trf e-brou%'
group by detalle
order by detalle




SELECT distinct detalle FROM REGISTROSTARJETAS
where CardHolder = 'BROU CESAR'
order by 1




select max(id) from registrostarjetas
delete registrostarjetas where id > 32288
32288
42245

INSERT INTO REGISTROSTARJETAS VALUES('BROU CESAR','2017/07/10','16','MC DONALD'S           MONTEVID','170 - Aut�matas Bancarios','',87.99,0.0,0)

--Fecha		Descripción	Número Documento	Num. Dep.	Asunto		Débito	Crédito	
	0		1			2					3			4			5		6

id	auto
cardholder cesar
Fecha	fecha	
Descripción	detalle
Número Documento	referencia
Num. Dep.	aux1
Asunto		 aux2
Débito	debito
Crédito	credito
--moneda 0


INSERT INTO REGISTROSTARJETAS VALUES('BROU CESAR','2017/04/28','0','PAGO DE SUELDO','168 - Transf. otros  Bancos - Plaza','',,64608.00,0)