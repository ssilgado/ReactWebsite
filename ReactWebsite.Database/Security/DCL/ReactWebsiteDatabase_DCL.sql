IF NOT EXISTS (
    SELECT  [name]
    FROM    sys.database_principals
    WHERE   [name] = 'SilgadoReactWebsite'
)
BEGIN
    CREATE USER [SilgadoReactWebsite] FROM EXTERNAL PROVIDER;
    ALTER ROLE db_datareader ADD MEMBER [SilgadoReactWebsite];
    ALTER ROLE db_datawriter ADD MEMBER [SilgadoReactWebsite];
END