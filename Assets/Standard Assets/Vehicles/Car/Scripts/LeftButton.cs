using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Vehicles.Car;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


    public static LeftButton instance = null;

    CarUserControl car;


    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    public void SetPlayer(GameObject player)
    {
        car = player.GetComponent<CarUserControl>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        car.Left();
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        car.PointerUp2();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
