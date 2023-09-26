FROM alpine
RUN apk update && apk upgrade
RUN apk add nano && apk add micro
RUN apk add gcc && apk add build-base
RUN apk add dotnet7-sdk
RUN apk add aspnetcore7-runtime
