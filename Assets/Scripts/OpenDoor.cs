using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    //[SerializeField] private GameObject doorToOpen;
    [SerializeField] private Sprite crankUp;
    [SerializeField] private Sprite crankDown;
    [SerializeField] private List<GameObject> doors = new List<GameObject>();

    private bool doorIsOpen = false;    

    //Hit the crank and either open or close all doors in the list of doors.
    public void Crank()
    {
        if(doorIsOpen == false)
        {
            GetComponent<SpriteRenderer>().sprite = crankDown;
            for(int numberInList = 0; numberInList < doors.Count; numberInList++)
            {
                doors[numberInList].SetActive(false);
            }
            //doorToOpen.SetActive(false);
            doorIsOpen = true;
        }
        else if(doorIsOpen == true)
        {
            GetComponent<SpriteRenderer>().sprite = crankUp;
            for (int numberInList = 0; numberInList < doors.Count; numberInList++)
            {
                doors[numberInList].SetActive(true);
            }
            //doorToOpen.SetActive(true);
            doorIsOpen = false;
        }
    }
}
