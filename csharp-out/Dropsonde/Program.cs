using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CloudFoundry.Dropsonde;
using CloudFoundry.Dropsonde.Events;
using System.Net;
using System.Globalization;

namespace Dropsonde
{


	class MainClass
	{
		static string authToken = System.Environment.GetEnvironmentVariable ("CF_ACCESS_TOKEN");
		static string appGuid = System.Environment.GetEnvironmentVariable ("APP_GUID");
		static string dopplerAddr = System.Environment.GetEnvironmentVariable ("DOPPLER_ADDR");


		private static void ChatWithDoppler ()
		{
			using (var ws = new ClientWebSocket ()) {
				
				ws.Options.SetRequestHeader ("AUTHORIZATION", authToken.Trim ());
				Uri serverUri = new Uri (dopplerAddr);

				var streamUriBuilder = new UriBuilder (serverUri);
				streamUriBuilder.Path = String.Format (CultureInfo.InvariantCulture, "/apps/{0}/stream", appGuid);

				var streamUri = streamUriBuilder.Uri;

				MemoryStream ms = new MemoryStream ();

				ws.Options.SetBuffer (1024 * 1024 , 1024);
				ws.ConnectAsync (streamUri, CancellationToken.None).Wait();
				Console.WriteLine ("Connected. SubProtocol: {0}", ws.SubProtocol);

				while (true) {
					var bytesReceived = new ArraySegment<byte> (new byte[1024*1024]);

					WebSocketReceiveResult result = ws.ReceiveAsync (bytesReceived, CancellationToken.None).Result;

					ms.Write (bytesReceived.Array, 0, result.Count);

					if (result.EndOfMessage) {
						ms.Seek (0, SeekOrigin.Begin);

						try {
							
							var envelope = Envelope.ParseFrom (ms);
							Console.WriteLine (envelope.ToString ());

						} catch (Exception ex) {
							Console.WriteLine (ex.ToString ());
						}

						ms = new MemoryStream ();
					}

					if (ws.State != WebSocketState.Open) {
						Console.WriteLine (ws.State);
						Console.WriteLine (ws.CloseStatusDescription);
						break;
					}
				}
			}

		}

		public static void Main (string[] args)
		{
			ServicePointManager.ServerCertificateValidationCallback += delegate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) {
				return true;
			};


			try {

				ChatWithDoppler ();

			} catch (Exception ex) {
				Console.WriteLine (ex.ToString ());
			}


			Console.WriteLine ("End of process.");
		}
	}
}
