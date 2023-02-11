using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotationController : MonoBehaviour {

    public Slider XRot;
    public Slider YRot;
    public Slider ZRot;

    public void UpdateObjectPosition(Transform ControlledObject)
    {
        // To-Do:
        Vector3 newRot = new Vector3(XRot.value, YRot.value, ZRot.value);
        ControlledObject.rotation = Quaternion.Euler(newRot);
    }
}
