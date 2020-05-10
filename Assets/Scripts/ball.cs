using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2;
    public float Speed = 10;
    AudioSource audioSource;
    public player player;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        rb2.velocity = new Vector2(1, 0)* Speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        TagManager tm = collision.gameObject.GetComponent<TagManager>();
        if (tm == null) return;

        Tag tag = tm.myTag;
        if (tag.Equals(Tag.BOMB))
        {
            player.MakeScore();
        }
    }


}
