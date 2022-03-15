all:
	make javascript
	make net

javascript:
	cd js; npm i; npm run build

net:
	cd dotnet; dotnet restore; dotnet build
