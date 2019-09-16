FROM mcr.microsoft.com/dotnet/core/runtime:2.2-alpine3.9

WORKDIR /opt

RUN mkdir pmcenter \
    && cd pmcenter \
    && wget https://ci.appveyor.com/api/projects/Elepover/pmcenter/artifacts/pmcenter.zip \
    && unzip pmcenter.zip \
    && rm pmcenter.zip \
    && wget https://raw.githubusercontent.com/Elepover/pmcenter/master/locales/pmcenter_locale_zh.meow.json -O /opt/pmcenter/pmcenter_locale.json

CMD ["dotnet","/opt/pmcenter/pmcenter.dll"]
