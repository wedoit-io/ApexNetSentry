ApexNetSentry
===
ApexNetSentry è una libreria distribuita attraverso nuget che consente di centralizzare la gestione delle eccezzioni su sentry.apexnet.it


Usare ApexNetSentry
---
In questo breve tutorial vediamo un esempio su come utilizzare la libreria

1. Creare una nuova solution in Visual studio

2. Installare con nuget la libreria
```
  PM> Install-Package ApexNetSentry
```

3. Aggiungere lo using in cima progetto
```c#
using ApexNetSentry;
```

4. Impostare la chiave per l'autorizzazione all'invio delle eccezzioni.
```c#
// Chiavi
string ApiKey = "http://1cff7fad696c346e8966d0b0c82439df8:79df31b6aa9642a3bef837f21f4132f1@sentry.apexnet.it/12";
```

5. Chiamare il metodo per la cattura di un messaggio
```c#
Logger.CaptureMessage(ApiKey, "Messaggio 1");

Logger.CaptureMessage(ApiKey, "Messaggio 2", SentryError.Warning);

Dictionary<string, string> tags = new Dictionary<string, string>();
tags["TAG"] = "TAG1";
Logger.CaptureMessage(ApiKey, "Messaggio 3", SentryError.Info, tags);
```

6. Usare CaptureException per catturare le eccezzioni
```c#
Logger.CaptureException(ApiKey, ex);
```
Esempio in Powershell
---
Mettere nella stessa cartella dello script le dll:

* ApexNetSentry.sll
* SharpRaven.dll
* Newtonsoft.Json.dll

Creare un file con estensione ps1 (es: SentryTest.ps1) e incollarci il seguente testo.

``` c#
# Loading Assembly
Add-Type -Path "C:\Work2\PSHSentry\ApexNetSentry.dll"

# Setting ApiKey
$ApiKey = "http://1cff7fad696c346e8966d0b0c82439df8:79df31b6aa9642a3bef837f21f4132f1@sentry.apexnet.it/12"

# Send a Capture Message mode 1
[ApexNetSentry.Logger]::CaptureMessage($ApiKey, "Test from powershell")

# Send a Capture Message mode 2 (with type)
[ApexNetSentry.Logger]::CaptureMessage($ApiKey, "Test fatal from powershell", [ApexNetSentry.SentryError]::Fatal)


# Send exception - mode 1
Try
{
    $junk = 1/0
}
Catch
{
    [ApexNetSentry.Logger]::CaptureException($ApiKey, $_.Exception, "Exception from powershell", [ApexNetSentry.SentryError]::Fatal)
}
```

Le eccezioni verranno mandate nel progetto Sandbox di sentry.apexnet.it

Dipendenze
---

* SharpRaven
* Newtonsoft  >= 4.5

Segnalazioni
---
Potete segnalare errori o imprecisioni della documentazione a questo link:

* https://github.com/Apex-net/ApexNetSentry/issues
