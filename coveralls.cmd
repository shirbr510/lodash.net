nuget install NUnit.Runners -Version 3.5.0 -OutputDirectory tools
nuget install OpenCover -Version 4.6.519 -OutputDirectory tools
nuget install coveralls.net -Version 0.7.0 -OutputDirectory tools
 
.\tools\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:.\tools\NUnit.Runners.3.5.0\tools\nunit3-console.exe -targetargs:"/nologo /noshadow .\test\Lodash.Net.Tests\bin\Debug\Lodash.Net.Tests.dll" -filter:"+[*]* -[*.Tests]*" -register:user
 
.\tools\coveralls.net.0.7\tools\csmacnz.Coveralls.exe --opencover -i .\results.xml 