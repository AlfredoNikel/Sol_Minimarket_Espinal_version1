
Create Procedure USP_Listado_um   
@cTexto varchar(20) = ''    
    
as    
    
select codigo_um,abreviatura_um,descripcion_um     
from TB_UNIDADES_MEDIDAS     
where estado=1 and     
upper(TRIM(cast(codigo_um as char))+
trim(abreviatura_um)+
trim(descripcion_um)) like '%'+upper (trim(@cTexto))+'%'; 