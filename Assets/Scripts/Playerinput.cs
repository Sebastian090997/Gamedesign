using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space pressed");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<movementController>().Move(new Vector2Int(0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<movementController>().Move3(new Vector2Int(0, 0));
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<movementController>().Move2(new Vector2Int(0, 0));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<movementController>().Move4(new Vector2Int(0, 0));
        }

    }
}
