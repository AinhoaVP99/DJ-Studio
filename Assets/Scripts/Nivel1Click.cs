using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel1Click : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        ChangeSprite();
        SceneManager.LoadScene(sceneName);
        
    }

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    //private void OnMouseOver()
    //{
        //ChangeSprite(newSprite);
    //}
    // Update is called once per frame
    //void Update()
    //{
       // if (Input.GetMouseButtonDown(0))
        //{
            //ChangeSprite();
        //}
    //}
}
