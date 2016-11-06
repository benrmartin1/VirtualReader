using UnityEngine;
using Leap;
using System.Collections.Generic;

public class LeapControllerScript : MonoBehaviour {

    Controller m_leapController;
    public Transform page;

    // Use this for initialization
    void Start () {
        m_leapController = new Controller();

    }

    // Update is called once per frame
    void Update () {

        Frame frame = m_leapController.Frame();
        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;

            for(int i = 0; i < hands.Count; i++) {
                Hand theHand = hands[i];
                string handName = theHand.IsLeft ? "Left hand" : "Right hand";
                print("hand " + i);
                print(handName);
                print("grab strength " + theHand.GrabStrength);
                print("grab angle " + theHand.GrabAngle);
                print("palm position " + theHand.PalmPosition);
                print("palm veloctiy " + theHand.PalmVelocity);
                print("rotation" + theHand.Rotation);


                float pinchDistance = theHand.PinchDistance;
                float pinchStrength = theHand.PinchStrength;
                print("pinch strength" + pinchStrength);


                page.localScale = page.localScale * pinchDistance;

            }
        }
    }
}
