using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

      public void Move(Vector2Int direction){
            transform.position += new Vector3(direction.x, direction.y,0);

        
    }
}
