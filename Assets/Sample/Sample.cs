using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniClipboard.Sample
{
	public class Sample : MonoBehaviour
	{
		public void OnClick()
		{
			Debug.Log($"コピーされていた文字列は{Clipboard.Text}でした。");

			var text = Random.Range(0, 10000).ToString();
			Debug.Log($"{text}をコピーします。");
			Clipboard.Text = text;
		}
	}
}
