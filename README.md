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
    //
	Logger.CaptureMessage(ApiKey, "Messaggio 1");

	Logger.CaptureMessage(ApiKey, "Messaggio 2", SentryError.Warning);

	Dictionary<string, string> tags = new Dictionary<string, string>();
	tags["TAG"] = "TAG1";
	Logger.CaptureMessage(ApiKey, "Messaggio 3", SentryError.Info, tags);
	
  ```

6. Usare CaptureException per catturare le eccezzioni
  ```c#
    // Quali dati contiene il mio AM ?
	
	Logger.CaptureException(ApiKey, ex);
  ```

Dipendenze
---

* SharpRaven
* Newtonsoft  >= 4.5

Segnalazioni
---
Potete segnalare errori o imprecisioni della documentazione a questo link:

* https://github.com/Apex-net/ApexNetSentry/issues
