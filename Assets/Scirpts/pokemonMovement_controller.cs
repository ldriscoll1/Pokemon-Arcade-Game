using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemonMovement_controller : MonoBehaviour
{
    private float Timer = 0f;
    public float movementMax = 1f;
    public float movementDir = 0.01f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Timer < movementMax)
        {
            transform.position = new Vector2(transform.position.x,
                transform.position.y + (Time.fixedDeltaTime * movementDir));
            Timer += Time.fixedDeltaTime;

        }
        else
        {
            movementDir *= -1;
            Timer = 0f;
        }
    }
}
