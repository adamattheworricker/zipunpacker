param
    (
    [string]$directory
    )

Set-Location $directory

$zips = Get-ChildItem -Filter *.zip

foreach ($zip in $zips)
    {
       Expand-Archive $zip -Force 
    }
