dotnet tool restore
dotnet paket install
dotnet paket generate-load-scripts
dotnet fsi script.fsx
