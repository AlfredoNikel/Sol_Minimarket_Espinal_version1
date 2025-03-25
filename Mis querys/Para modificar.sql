
select * from TB_TIPOS_DOCUMENTOS_PV_CL

delete from TB_CATEGORIAS where codigo_ca = 13 --Borrar datos--

dbcc checkident (TB_TIPOS_DOCUMENTOS_PV_CL,reseed,-1) --Para resetar el contador--
