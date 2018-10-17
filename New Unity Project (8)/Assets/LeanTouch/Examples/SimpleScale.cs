using UnityEngine;

// This script will rotate and scale the GameObject based on finger gestures
public class SimpleScale : MonoBehaviour
{
	protected virtual void LateUpdate()
	{
		// This will rotate the current transform based on a multi finger twist gesture
	//	Lean.LeanTouch.RotateObject(transform, Lean.LeanTouch.TwistDegrees);
		
		// This will scale the current transform based on a multi finger pinch gesture
		Lean.LeanTouch.ScaleObject(transform, Lean.LeanTouch.PinchScale);
	//	GetComponent.<Collider>().bounds.size
		//GetComponent<Renderer> ().bounds.size ();
		///myWidth.text = GetComponent<Renderer>().bounds.x
	}
}