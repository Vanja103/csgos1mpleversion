using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TerroristClicker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bullets_count_ui_text;
    [SerializeField] TextMeshProUGUI money_count_ui_text;
    static int bullets_count = 30;
    static int bullets_used = 0;
    static int money_count = 0;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    static GameObject[] bullets_images = new GameObject[5];
 


    // Start is called before the first frame update
    void Start()
    {
        bullets_images[0] = image1;
        bullets_images[1] = image2;
        bullets_images[2] = image3;
        bullets_images[3] = image4;
        bullets_images[4] = image5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        bullets_count--;
        bullets_count_ui_text.text = bullets_count + "";
        money_count += 300;
        money_count_ui_text.text = "$" + money_count;
        Destroy(gameObject);
        Destroy(bullets_images[bullets_used]);
        bullets_used++;
    }
}
