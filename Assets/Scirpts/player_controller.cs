using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    //Prefabricated Pokemon List
    private Rigidbody2D rb;
    private Vector3 target;
    private Vector3 position;
    public AllyPokemon starter;
    public float speed;
    public GameObject playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCamera.activeSelf)
        {
            Move();
            BounceMovement();
        }
        
    }
    void Move()
    {
        float xPosition = 0;
        float yPosition = 0;

        if (Input.GetKeyDown("up"))
        {
            yPosition += 1;
        }
        else if (Input.GetKeyDown("down"))
        {
            yPosition -= 1;
        }
        else if (Input.GetKeyDown("left"))
        {
            xPosition -= 1;
        }
        else if (Input.GetKeyDown("right"))
        {
            xPosition += 1;
        }
        transform.position += new Vector3(xPosition, yPosition, 0);

    }
    void BounceMovement()
    {
        float dist = (this.transform.position - Camera.main.transform.position).z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
        float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;

        Vector3 playerSize = GetComponent<Renderer>().bounds.size;

        this.transform.position = new Vector3(
        Mathf.Clamp(this.transform.position.x, leftBorder + playerSize.x / 2, rightBorder - playerSize.x / 2),
        Mathf.Clamp(this.transform.position.y, topBorder + playerSize.y / 2, bottomBorder - playerSize.y / 2),
        this.transform.position.z
        );
    }
}
