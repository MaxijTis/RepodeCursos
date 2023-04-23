select  A.Id, Codigo, Nombre, A.Descripcion, M.Id, C.Id,IdMarca, IdCategoria, M.Descripcion Marca, C.Descripcion Tipo, ImagenUrl, Precio 
from Articulos A, Marcas M, Categorias C 
where m.Descripcion like '%motorola%' and C.Descripcion like '%celulares%' and
Nombre like 'Play 4' 
