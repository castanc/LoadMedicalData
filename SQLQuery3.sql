
CONVERSION DE MONEDA   -68,65 


27/05/2018 90454431 C2C a RODRIGUEZ JUAN 9818 -1.000,00

select * from registrostarjetas
where CardHolder = 'GALES'

select * from registrostarjetas
where CardHolder = 'MDLOCAL'

select * from registrostarjetas
where detalle like 'c2c a%'
and cardholder <> 'MDLOCAL'
ORDER BY FECHA


select * from registrostarjetas
where CardHolder in ('GALES','MDLOCAL','VARLIX')
order by fecha

select sum(debito) from registrostarjetas
where detalle like 'c2c a%'
and cardholder <> 'MDLOCAL'



select * from registrostarjetas
where CardHolder = 'VARLIX'

select * from registrostarjetas
WHERE DETALLE LIKE '%RECARGA%'

select distinct detalle from RegistrosTarjetas
where CardHolder in ('GALES','MDLOCAL','VARLIX')
order by 1


DELETE registrostarjetas WHERE CARDHOLDER IN ('GALES','MDLOCAL','VARLIX')




SELECT  MAX(ID) FROM REGISTROSTARJETAS
43836

insert into registrostarjetas(cardholder,fecha,detalle,debito,credito, moneda) 
values ('XX','2019/1/1','',0,0,0)



insert into registrostarjetas(cardholder, fecha, referencia,detalle, debito, credito, moneda)values('GALES', '2018/03/03', '82943308','RETIRO PESOS LOCAL REDPAGOS',100000,0,0)
DELETE REGISTROSTARJETAS WHERE ID > 43836
