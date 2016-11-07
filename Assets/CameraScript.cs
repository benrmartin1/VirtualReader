using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    // Use this for initialization


    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }

    public GameObject ObjectLookingAt()
    {
        Camera camera = GetComponent<Camera>();
        RaycastHit hit;
        Vector3 cameraCenter = camera.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, camera.nearClipPlane));
        if (Physics.Raycast(cameraCenter, this.transform.forward, out hit, 1000))
        {
            return hit.transform.gameObject;
        }
        return null;
    }
}
