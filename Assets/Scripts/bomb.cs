using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bomb : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tm = collision.gameObject.GetComponent<TagManager>();
        if (tm == null) return;

        Tag tag = tm.myTag;
        if (tag.Equals(Tag.WALL))
        {
            Destroy(gameObject);
        }
        if (tag.Equals(Tag.BALL))
        {
            Destroy(gameObject);
        }
    }
}
