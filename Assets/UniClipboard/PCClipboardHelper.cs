using UnityEngine;

namespace UniClipboard.Clipboards
{
	public class Standalone : IClipboard
	{
		public void SetText(string value)
		{
			GUIUtility.systemCopyBuffer = value;
		}

		public string GetText()
		{
			return GUIUtility.systemCopyBuffer;
		}
	}
}
