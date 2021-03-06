/*
	Cambiar 'XMALMORTHEN-SRV' en @server_name ubicado en el código [ EXEC msdb.dbo.sp_add_jobserver @job_name=N'Job_Bd_Expedientes_Digitales', @server_name = N'XMALMORTHEN-SRV' ]
	por el nombre del servidor donde se encuentra la bd
*/

USE [msdb]
GO
DECLARE @jobId BINARY(16)
EXEC  msdb.dbo.sp_add_job @job_name=N'Job_Bd_Expedientes_Digitales', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=2, 
		@notify_level_netsend=2, 
		@notify_level_page=2, 
		@delete_level=0, 
		@description=N'Trabajos para la base de datos Bd_Expedientes_Digitales', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'digitaldocs', @job_id = @jobId OUTPUT
select @jobId
GO
EXEC msdb.dbo.sp_add_jobserver @job_name=N'Job_Bd_Expedientes_Digitales', @server_name = N'XMALMORTHEN-SRV'
GO
USE [msdb]
GO
EXEC msdb.dbo.sp_add_jobstep @job_name=N'Job_Bd_Expedientes_Digitales', @step_name=N'Bloquear_Tramites', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_fail_action=3, 
		@retry_attempts=2, 
		@retry_interval=1, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'UPDATE 
	MA_DIGITAL
SET
	ID_ESTATUS = 4
WHERE     
	(ID_ESTATUS = 5) 
  AND 
	(DATEDIFF(MINUTE, FECHA_HORA_BLOQUEO, FECHA_HORA_CREACION) >= 0)', 
		@database_name=N'Bd_Expedientes_Digitales', 
		@flags=0
GO
USE [msdb]
GO
EXEC msdb.dbo.sp_update_job @job_name=N'Job_Bd_Expedientes_Digitales', 
		@enabled=1, 
		@start_step_id=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=2, 
		@notify_level_netsend=2, 
		@notify_level_page=2, 
		@delete_level=0, 
		@description=N'Trabajos para la base de datos Bd_Expedientes_Digitales', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'digitaldocs', 
		@notify_email_operator_name=N'', 
		@notify_netsend_operator_name=N'', 
		@notify_page_operator_name=N''
GO
USE [msdb]
GO
DECLARE @schedule_id int
EXEC msdb.dbo.sp_add_jobschedule @job_name=N'Job_Bd_Expedientes_Digitales', @name=N'Diario a cada 5 minutos', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=4, 
		@freq_subday_interval=5, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=20140204, 
		@active_end_date=99991231, 
		@active_start_time=0, 
		@active_end_time=235959, @schedule_id = @schedule_id OUTPUT
select @schedule_id
GO
