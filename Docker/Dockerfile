FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=YourStrong@Passw0rd

EXPOSE 1433

ENTRYPOINT [ "/bin/bash", "-c" ]

CMD [ "/opt/mssql/bin/sqlservr" ]