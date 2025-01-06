set PGUSER=postgres
set PGPASSWORD=postgres123
pg_restore.exe --host localhost --port 5432 --username "postgres" --dbname "cobra" --no-password  --verbose "cobra.backup"