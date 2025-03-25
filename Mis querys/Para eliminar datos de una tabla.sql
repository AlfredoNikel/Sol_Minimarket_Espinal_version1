select * from TB_TIPOS_DOCUMENTOS_PV_CL

delete from TB_TIPOS_DOCUMENTOS_PV_CL where codigo_tdpc = 1 --Borrar datos--

delete from TB_TIPOS_DOCUMENTOS_PV_CL where codigo_tdpc in (1,2,3); --Borrar varios datos--