-- Migracion ROLES_X_USUARIOS

begin

insert into OLA_K_ASE.ROLES_USUARIOS(USUARIO_ID, ROLES_ID)
select USUARIO_ID, 2 from OLA_K_ASE.CLIENTES
union
select usuario_id, 3 from OLA_K_ASE.CHOFERES
union
select ID_USUARIO, 1 from OLA_K_ASE.USUARIOS where nombre = 'admin'
end;