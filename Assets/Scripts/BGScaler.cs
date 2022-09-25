using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var worldHeight = Camera.main.orthographicSize/4;
        Debug.Log(worldHeight);
        var worldWidth = worldHeight * Screen.width / Screen.height;
        Debug.Log(worldWidth);
        transform.localScale = new Vector3(worldWidth, worldHeight, 0f);
    }
}
