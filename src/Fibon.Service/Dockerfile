FROM microsoft/dotnet:runtime
WORKDIR ./dotnetapp
COPY ./bin/Docker .

ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT dotnet Fibon.Services.dll --urls="http://*:5050"