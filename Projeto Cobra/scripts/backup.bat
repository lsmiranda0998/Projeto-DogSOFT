set PGUSER=postgres
set PGPASSWORD=postgres123
cd scripts
pg_dump.exe --host localhost --port 5432 --username "postgres" --no-password  --format custom --blobs --verbose --file "cobra.backup" "cobra"