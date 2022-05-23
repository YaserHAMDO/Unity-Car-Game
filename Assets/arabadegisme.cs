using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arabadegisme : MonoBehaviour
{
    
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;
    
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    public GameObject scene5;

    public GameObject Panel;

    private Vector3 sensePosition; 
    private Quaternion senseRotation; 

    private int selectedCar = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(false);
        car5.SetActive(false);
        Panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {


        
    }


    public void car1button()
    {

        selectedCar = 1;

    } 
    
    public void car2button()
    {

        selectedCar = 2;

    }

    public void car3button()
    {

        selectedCar = 3;

    }

    public void car4button()
    {

        selectedCar = 4;

    }

    public void car5button()
    {

        selectedCar = 5;

    }


    public void scene1button()
    {
        sensePosition = new Vector3(244, 0, 221);
        senseRotation = Quaternion.Euler(-4, 370, -0);
        scene1.SetActive(true);
        selectAndEditCar();
     
    }

    public void scene2button()
    {
        sensePosition = new Vector3(244, 0, 221);
        senseRotation = Quaternion.Euler(-4, 370, -0);
        scene2.SetActive(true);
        selectAndEditCar();
       
    }

    public void scene3button()
    {
        sensePosition = new Vector3(276, 1, 457);
        senseRotation = Quaternion.Euler(0, 453, -4);
        scene3.SetActive(true);
        selectAndEditCar();
        
    }


    public void scene4button()
    {
        sensePosition = new Vector3(271, 1, 327);
        senseRotation = Quaternion.Euler(-1, 321, 1);
        scene4.SetActive(true);
        selectAndEditCar();

    }


    public void scene5button()
    {
        sensePosition = new Vector3(466, 0, 272);
        senseRotation = Quaternion.Euler(-1, 361, 1);
        scene5.SetActive(true);
        selectAndEditCar();

    }

    private void selectAndEditCar()
    {
        switch (selectedCar)
        {
            case 1:
                car1.transform.position = sensePosition;
                car1.transform.rotation = senseRotation;
                car1.SetActive(true);
                break;
            case 2:
                car2.transform.position = sensePosition;
                car2.transform.rotation = senseRotation;
                car2.SetActive(true);
                break;
            case 3:
                car3.transform.position = sensePosition;
                car3.transform.rotation = senseRotation;
                car3.SetActive(true);
                break;
            case 4:
                car4.transform.position = sensePosition;
                car4.transform.rotation = senseRotation;
                car4.SetActive(true);
                break;
            case 5:
                car5.transform.position = sensePosition;
                car5.transform.rotation = senseRotation;
                car5.SetActive(true);
                break;
        }

        Panel.SetActive(false);
    }
}
