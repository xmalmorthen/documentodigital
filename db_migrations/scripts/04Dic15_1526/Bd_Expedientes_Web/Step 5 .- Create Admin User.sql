USE [Bd_Expedientes_Web]
GO
INSERT INTO 
	ca_usuarios
		(
			usuario, 
			contrasenia, 
			curp, 
			nombres, 
			apellido1, 
			cargo, 
			activo, 
			es_administrador
		)
VALUES        
		(
			'admin', 
			'21232f297a57a5a743894a0e4a801fc3', 
			'000000000000000000', 
			'Administrador', 
			'del Sistema',
			'Administrador General del Sistema', 
			1,
			1)