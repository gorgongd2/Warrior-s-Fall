using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBar : MonoBehaviour
{
    public Sprite fire5;
    public Sprite fire4;
    public Sprite fire3;
    public Sprite fire2;
    public Sprite fire1;
    public Sprite fire0;
    private SpriteRenderer renderer;
    private GameObject player;
    private shootMagicblastWF shoot;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        shoot = player.GetComponent<shootMagicblastWF>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot.MP > 4)
        {
            renderer.sprite = fire5;
        }

        if (shoot.MP == 4)
        {
            renderer.sprite = fire4;
        }

        if (shoot.MP == 3)
        {
            renderer.sprite = fire3;
        }

        if (shoot.MP == 2)
        {
            renderer.sprite = fire2;
        }

        if (shoot.MP == 1)
        {
            renderer.sprite = fire1;
        }

        if (shoot.MP == 0)
        {
            renderer.sprite = fire0;
        }
    }
}
