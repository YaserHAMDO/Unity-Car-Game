using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Vehicles.Car;

public class BackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static BackButton instance = null;
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
        car.Backward();
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        car.PointerUp();
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
