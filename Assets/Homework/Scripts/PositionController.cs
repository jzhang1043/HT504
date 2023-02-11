using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PositionController : MonoBehaviour {
    public Slider XPos;
    public Slider YPos;
    public Slider ZPos;
    //public Transform ControlledObject;
    public void UpdateObjectPosition(Transform ControlledObject) {
        // To-Do:        
        Vector3 newPos = new Vector3(XPos.value, YPos.value, ZPos.value);
        ControlledObject.localPosition = newPos;
    }
}
