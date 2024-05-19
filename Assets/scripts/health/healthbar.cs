using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField] private health playerHealth;
    [SerializeField]private Image totalhealthBar;
    [SerializeField]private Image currenthealthBar;
    // Start is called before the first frame update
    void Start()
    {
        totalhealthBar.fillAmount = playerHealth.CurrentHealth / 10;
    }

    // Update is called once per frame
    void Update()
    {
        currenthealthBar.fillAmount = playerHealth.CurrentHealth / 10;
     //   Debug.Log(playerHealth.CurrentHealth);

    }
}
