using System;
using UnityEngine;
using UnityEngine.UI;


namespace Electron
{
	public class ViewController<T>: MonoBehaviour where T: UnityEngine.Component{
		public T View;

		void Start(){
			View = gameObject.GetComponents<T>()[0];
			Debug.Log(String.Format("Found View: {0}", View));	
			onStart();
		}

		void Update(){
			onUpdate();
		}

		virtual public void onStart(){}
		virtual public void onUpdate(){}

		public void addChild(Component child, bool worldPositionStays = false){
			child.transform.SetParent(View.transform, worldPositionStays);
		}

	}
}

