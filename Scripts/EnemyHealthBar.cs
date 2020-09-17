using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    
    public Slider slider;
    private float maxHealth=1f;
    public bool canTakeDamage;
    [SerializeField]
    private GeneralSpeed spawner;
    public bool canFireCannon;
    

    private void Awake()
    {
        spawner = FindObjectOfType<GeneralSpeed>();
    }
    // Start is called before the first frame update
    void Start()
    {
        canTakeDamage = true;
        canFireCannon = true;
        SetMaxHealt();
    }
    private void Update()
    {
        if (slider.value <= 0f)
        {
            canTakeDamage = false;
            canFireCannon = false;
            slider.value = 0f;
            spawner.gameObject.GetComponent<GeneralSpeed>().Score += 100;
            spawner.gameObject.GetComponent<GeneralSpeed>().ScoreText.text = "SURVIVAL TIME : " + spawner.gameObject.GetComponent<GeneralSpeed>().Score;
        }
        if (!canTakeDamage &&slider.value!=1f)
        {
            
            slider.value += 0.002f;
            if (slider.value == 1f)
            {
                canTakeDamage = true;
                canFireCannon = true;
            }
        }
    }


    void SetMaxHealt()
    {
        slider.value = maxHealth;
    }

}
