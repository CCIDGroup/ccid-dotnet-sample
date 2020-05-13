FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine3.11 
WORKDIR /app

COPY {{.HostCodePath}}/pkg/ /app
ENTRYPOINT ["dotnet", "/app/demo"]