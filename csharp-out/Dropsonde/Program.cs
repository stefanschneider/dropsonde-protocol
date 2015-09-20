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
				ws.Options.SetRequestHeader ("Authorization", authToken.Trim ());
				ws.Options.SetRequestHeader ("Origin", "http://localhost");
				Uri serverUri = new Uri (dopplerAddr);

				var streamUriBuilder = new UriBuilder (serverUri);
				streamUriBuilder.Path = String.Format (CultureInfo.InvariantCulture, "/apps/{0}/stream", appGuid);

				var streamUri = streamUriBuilder.Uri;

				MemoryStream ms = new MemoryStream ();

				// ws.Options.KeepAliveInterval = TimeSpan.FromDays (1);
				// ws.Options.SetBuffer (1024, 1024);
				ws.ConnectAsync (streamUri, CancellationToken.None).Wait ();
				Console.WriteLine ("Connected. SubProtocol: {0}", ws.SubProtocol);


				while (true) {

					var bytesReceived = new ArraySegment<byte> (new byte[128]);


					WebSocketReceiveResult result = ws.ReceiveAsync (bytesReceived, CancellationToken.None).Result;

					ms.Write (bytesReceived.Array, 0, result.Count);

					if (result.EndOfMessage && result.MessageType == WebSocketMessageType.Binary) {
						ms.Seek (0, SeekOrigin.Begin);

						try {
							
							var envelope = Envelope.Parser.ParseFrom (ms);
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

		public static void ChatWithDoppler2(){
			Uri serverUri = new Uri (dopplerAddr);

			var streamUriBuilder = new UriBuilder (serverUri);
			streamUriBuilder.Path = String.Format (CultureInfo.InvariantCulture, "/apps/{0}/stream", appGuid);

			var streamUri = streamUriBuilder.Uri;

			var webSocketClient = new WebSocket4Net.WebSocket(streamUri.ToString(), "", 
				version: WebSocket4Net.WebSocketVersion.Rfc6455, 
				customHeaderItems: new List<KeyValuePair<string, string>>(){ new KeyValuePair<string, string> ( "Authorization", authToken.Trim ()) } );
			webSocketClient.AllowUnstrustedCertificate = true;


			webSocketClient.Opened += (object sender, EventArgs e) => {
				Console.WriteLine ("Websocket connection opened: {0}", e);
				Console.WriteLine ("webSocketClient.AllowUnstrustedCertificate: {0}", webSocketClient.AllowUnstrustedCertificate);
				Console.WriteLine ("webSocketClient.AutoSendPingInterval: {0}", webSocketClient.AutoSendPingInterval);
				Console.WriteLine ("webSocketClient.EnableAutoSendPing: {0}", webSocketClient.EnableAutoSendPing);
				Console.WriteLine ("webSocketClient.NoDelay: {0}", webSocketClient.NoDelay);
				Console.WriteLine ("webSocketClient.Handshaked: {0}", webSocketClient.Proxy);
				Console.WriteLine ("webSocketClient.ReceiveBufferSize: {0}", webSocketClient.ReceiveBufferSize);
				Console.WriteLine ();
				Console.WriteLine ("webSocketClient.Handshaked: {0}", webSocketClient.Handshaked);
				Console.WriteLine ("webSocketClient.LastActiveTime: {0}", webSocketClient.LastActiveTime);
				Console.WriteLine ("webSocketClient.State: {0}", webSocketClient.State);
				Console.WriteLine ("webSocketClient.SupportBinary: {0}", webSocketClient.SupportBinary);
				Console.WriteLine ("webSocketClient.Version: {0}", webSocketClient.Version);

			};

			webSocketClient.Closed += (object sender, EventArgs e) => {
				Console.WriteLine ("Websocket connectino closed: {0}", e);
			};
			webSocketClient.DataReceived += (object sender, WebSocket4Net.DataReceivedEventArgs e) => {
				var envelope = Envelope.Parser.ParseFrom (e.Data);
				Console.WriteLine (envelope.ToString ());
			};
			webSocketClient.Error += (object sender, SuperSocket.ClientEngine.ErrorEventArgs e) => {
				Console.WriteLine ("Websocket error: {0}", e.Exception.ToString());
			};

			webSocketClient.Open ();

			Console.ReadLine ();
			webSocketClient.Close ();
			Thread.Sleep (1000);
		}

		public static void Main (string[] args)
		{
			ServicePointManager.ServerCertificateValidationCallback += delegate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) {
				return true;
			};


			try {

				ChatWithDoppler2 ();

			} catch (Exception ex) {
				Console.WriteLine (ex.ToString ());
			}


			Console.WriteLine ("End of process.");
		}
	}
}
