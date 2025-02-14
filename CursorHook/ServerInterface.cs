using System;


namespace Magpie.CursorHook {
	// IPC 服务器接口
	public class ServerInterface : MarshalByRefObject {
		public void ReportMessages(string[] messages) {
			if (messages == null) {
				return;
			}

			foreach (string msg in messages) {
				ReportMessage(msg);
			}
		}

		public void ReportMessage(string message) {
			Console.WriteLine("##CursorHook##: " + message);
		}


		// 客户端调用此函数确定服务器的响应性
		public void Ping() {
		}
	}
}
