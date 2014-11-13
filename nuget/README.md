Creare un pacchetto Nuget
===

Installare NuGet
---
La prima cosa da fare per creare pacchetti NuGet e' installare Nuget.

1. Scaricare NuGet da questo link http://nuget.codeplex.com/releases/view/58939 (scaricare NuGet bootstrapper).
2. Mettere l'eseguibilie in una cartella 
3. Aggiungere la cartella al path di sistema

Nota: Non mettete, come fanno in molti repo su github, il file nuget.exe nel repository.

Per prima cosa, aggiornare NuGet. C'è sempre una nuova versione !

```
NuGet Update -self
```

Note di rilascio
---
L'elenco completo delle modifiche è disponibile a questo indirizzo:

* https://github.com/Apex-net/AMHelper/releases

Configurare un pacchetto 
---
1. Andare nella cartella in cui e' situalto il file .csproj
2. Creare il manifest

```
nuget spec
```

3. Questo comando crea un file XML con questo formato :

```xml
<?xml version="1.0"?>
<package xmlns="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd">
  <metadata>
    <id>MyPackageId</id>
    <version>1.0</version>
    <authors>philha</authors>
    <owners>philha</owners>
    <licenseUrl>http://LICENSE_URL_HERE_OR_DELETE_THIS_LINE</licenseUrl>
    <projectUrl>http://PROJECT_URL_HERE_OR_DELETE_THIS_LINE</projectUrl>
    <iconUrl>http://ICON_URL_HERE_OR_DELETE_THIS_LINE</iconUrl>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>Package description</description>
    <tags>Tag1 Tag2</tags>
    <dependencies>
      <dependency id="SampleDependency" version="1.0" />
    </dependencies>
  </metadata>
</package>
```

Modificarlo a piacimento.
Ecco il mio.

```xml

<?xml version="1.0"?>
<package >
  <metadata>
    <id>$id$</id>
    <version>$version$</version>
    <title>$title$</title>
    <authors>Stefano Teodorani</authors>
    <owners>Stefano Teodorani</owners>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>Apex-net APPManager helper for iCommerce IOS App</description>
    <releaseNotes></releaseNotes>
    <copyright>Copyright 2014</copyright>
    <tags>iorder icommerce ib igamma</tags>
  </metadata>
</package>

```

Come si vede è possibile sostituire alcune descrizioni con variabili che vengono gestite autonomamente da NuGet (fare riferimento alla documentazione in fondo alla pagina per la lista delle variabili utilizzabili)

Creare il pacchetto
---
Dopo aver creato il manifest, per creare il pacchetto digitare da linea di comando

```
nuget pack AMHelper.csproj
```

L'esecuzione di questo comando crea un file di pacchetto con estensione nupkg

Pubblicare su NuGet
---
Dopo essersi registrati su nuiget.org, nel proprio profilo è presente una chiave. Copiarsi la chiave e da linea di comando digitare

```
nuget setApiKey Your-API-Key
```

Questo comando crea una sorta di associazione fra voi e il vostro account e rende possibile la pubblicazione del pacchetto su nuget.org.

A questo punto, dal proprio profilo del sito andare in upload del pacchetto, caricarlo e il gioco e' fatto

Si puo' anche fare da linea di comando con :

```
NuGet Push AMHelper.nupkg
```

Reference
---
http://docs.nuget.org/docs/creating-packages/creating-and-publishing-a-package#From_a_convention_based_working_directory

sezione from a project
