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

Write-Host "Files unzipped, could you like to delete the zip files? (Y/N)"
$response = Read-Host

$response = $response.ToUpper()

if ($response -eq "Y") {
    Remove-Item "*.zip"
}

