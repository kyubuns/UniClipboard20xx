using System.Runtime.InteropServices;

namespace UniClipboard.Clipboards
{
#if UNITY_IOS
	public class iOS : IClipboard
	{
		[DllImport("__Internal")]
		private static extern void _SetClipboard(string value);

		[DllImport("__Internal")]
		private static extern string _GetClipboard();

		public string GetText()
		{
			return _GetClipboard();
		}

		public void SetText(string text)
		{
			_SetClipboard(text);
		}
	}
#endif
}
