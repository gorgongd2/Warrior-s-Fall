using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiritBar : MonoBehaviour
{
    public Sprite spirit1;
    public Sprite spirit0;
    private SpriteRenderer renderer;
    private GameObject player;
    private useSpecial special;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        special = player.GetComponent<useSpecial>();
    }

    // Update is called once per frame
    void Update()
    {
        if (special.SP > 0)
        {
            renderer.sprite = spirit1;
        }

        if (special.SP == 0)
        {
            renderer.sprite = spirit0;
        }
    }
}
