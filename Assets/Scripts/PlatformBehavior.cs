using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    private Vector3 direction;
    public float velocity;
    private int hor;
    public GameObject objToChild;
    public GameObject top;
    public GameObject bot;

    private MovementBehavior _movement;
    private TurnIntoChild _turnIntoChild;
    // Start is called before the first frame update
    void Start()
    {
        _movement = gameObject.GetComponent<MovementBehavior>();
        _turnIntoChild = gameObject.GetComponent<TurnIntoChild>();
        hor = -1;
    }

    // Update is called once per frame
    void Update()
    {
        _movement.Move(new Vector3(hor, 0, 0), velocity);
    }

    public void TurnRight()
    {
        hor = 1;
        _movement.MoveTo(top.transform.position.x,top.transform.position.y);
    }

    public void TurnLeft()
    {
        hor = -1;
        _movement.MoveTo(bot.transform.position.x, bot.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision == objToChild.GetComponent<Collider2D>())
        { 
            _turnIntoChild.ChangeParent();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == objToChild.GetComponent<Collider2D>())
        {
            _turnIntoChild.RevertParent();
        }
    }
}
