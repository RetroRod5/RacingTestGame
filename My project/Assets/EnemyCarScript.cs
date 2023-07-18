using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarScript : MonoBehaviour
{
    //MOVEMENT AND PHYSICS
    Rigidbody2D rig1;
    private float xpos;
    private float yPos;
    public SpriteRenderer spriteRenderer;
    [SerializeField] float EnemySpd = 1.5f;
    [SerializeField] RoadMoving scriptHere;
    RoadMoving roadMoving = new RoadMoving();
    private float roadspeed;

    //SPAWNCOLOR
    private int Color;
    [SerializeField] Sprite Red;
    [SerializeField] Sprite Blue;
    [SerializeField] Sprite Green;
    [SerializeField] Sprite Pink;

    void Awake()
    {
        roadspeed = roadMoving.RoadSpeed;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        rig1 = GetComponent<Rigidbody2D>();
        Color = Random.Range(1, 4);
        if (Color == 1)
        {
            spriteRenderer.sprite = Red;
        }
        else if (Color == 2)
        {
            spriteRenderer.sprite = Blue;
        }
        else if (Color == 3)
        {
            spriteRenderer.sprite = Green;
        }
        else
        {
            spriteRenderer.sprite = Pink;
        }
    }

    void FixedUpdate()
    {
        yPos = transform.position.y - roadspeed * EnemySpd * Time.deltaTime;
        rig1.MovePosition(new Vector2(xpos, yPos));
    }
}
