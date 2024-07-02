@echo off 

IF NOT EXIST "C:\Backup\" MKDIR C:\Backup

IF EXIST "C:\Backup\*Alarms*" DEL /Q /F "C:\Backup\*Alarms*"
IF EXIST "C:\Backup\*Logs*" DEL /Q /F "C:\Backup\*Logs*"
IF EXIST "C:\Backup\*Orders*" DEL /Q /F "C:\Backup\*Orders*"
IF EXIST "C:\Backup\*Recipes*" DEL /Q /F "C:\Backup\*Recipes*"

sqlcmd -S 227799-EOT\MSSQLE -U sa -P 2555 -i "C:\Users\Public\Documents\VisiWin 7\7.2\Projects\227799-EOT\Resources\SQL\Backup.sql"
sqlcmd -S 227799-EOT\MSSQLE -U sa -P 2555 -i "C:\Users\Public\Documents\VisiWin 7\7.2\Projects\227799-EOT\Resources\SQL\ClearAlarms.sql"
sqlcmd -S 227799-EOT\MSSQLE -U sa -P 2555 -i "C:\Users\Public\Documents\VisiWin 7\7.2\Projects\227799-EOT\Resources\SQL\ClearLogs.sql"
sqlcmd -S 227799-EOT\MSSQLE -U sa -P 2555 -i "C:\Users\Public\Documents\VisiWin 7\7.2\Projects\227799-EOT\Resources\SQL\ClearProtocol.sql"
