## Azure Function Verbose Logging Issue

Sample repo reproducing issue with "verbose" logging setting.

### Sample `appsettings.json`
```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "function_STORAGE": "UseDevelopmentStorage=true"
  },
  "ConnectionStrings": {}
}
```