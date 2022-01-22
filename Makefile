run:
	 dotnet run 

createapp:
	 dotnet new classlib -n $(app)
	 dotnet sln ./*.sln add **/*.csproj
