using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveUp : MonoBehaviour
{
    public GameObject PltfrmObj;
    public float Y_Speed;
    public float Z_Speed;
    public float limit_Y;
    public float limit_Z;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PltfrmObj.transform.position.y <= limit_Y)
        {
            PltfrmObj.transform.position += new Vector3(0, Y_Speed * Time.deltaTime, 0);
        }
        else
        {
            if (PltfrmObj.transform.position.z <= limit_Z)
            {
                PltfrmObj.transform.position += new Vector3(0, 1 * Time.deltaTime, Z_Speed * Time.deltaTime);
            }
            else
            {
                Destroy(PltfrmObj);
            }
        }
    }
}
