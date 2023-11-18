using System;
using UnityEngine;

namespace Coffee.RotateMe
{
	public class RotateMe : MonoBehaviour
	{
		public float angularVelocity = 10;
		void Update ()
		{
			var rot = Quaternion.AngleAxis (angularVelocity * Time.deltaTime, Vector3.up);
			transform.localRotation = rot * transform.localRotation;
			Debug.Log("hogehogehoge");
			Debug.Log("fugafugas");
			#if !UNITY_EDITOR
			Debug.Log("fix bugs")
			Debug.Log("fix bugs 1")
			#endif
		}
	}
}
