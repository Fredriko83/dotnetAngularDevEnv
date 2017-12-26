# dotnetAngularDevEnv

## Add migrations  
docker exec -i -t dotnetang_app_1 /bin/bash  
dotnet ef migrations add InitialModel --msbuildprojeectextensionspath ../obj  
