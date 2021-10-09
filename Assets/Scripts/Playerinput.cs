using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (Input.GetKeyDown(KeyCode.Space))
        { Debug.Log("spacja wciœniêta"); 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<MovementController>().Move(new Vector2Int(0, 1));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<MovementController>().Move(new Vector2Int(0, -1));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<MovementController>().Move(new Vector2Int(1, 0));


        }

            




        
    }
}
