## Unofficial Domene.shop dns library


### Docs
 - https://api.domeneshop.no/docs/

### Create/edit api key
 - https://www.domeneshop.no/admin?view=api



### commands I never remember

// Step 1: Authenticate (if this is the first time)
dotnet nuget add source https://nuget.pkg.github.com/ravndaa/index.json -n github -u ravndaa -p GH_TOKEN
// Step 2: Pack
dotnet pack --configuration Release
// Step 3: Publish
dotnet nuget push bin/Release/Domeneshop.DnsApi.0.0.1-alpha.nupkg --source "github"