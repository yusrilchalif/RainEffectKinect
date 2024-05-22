using UnityEngine;

public class MultiDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Display.displays.Length > 1)
        {
            Display.displays[1].Activate(Display.displays[1].systemWidth, Display.displays[1].systemHeight, 60);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
