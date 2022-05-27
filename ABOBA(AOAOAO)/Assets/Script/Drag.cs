using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public HeroInventory heroInventory;
    public Item item;
    public string ownerItem;
    public int countItem;

    public Image image;
    public Sprite defaultSprite;
    public Text count;

    public Text descriptionCell;

    public void OnPointerEnter(PointerEventData evenData)
    {

    }

    public void OnPointerExit(PointerEventData evenData)
    {

    }

    public void OnPointerClick(PointerEventData evenData)
    {
        if(evenData.button == PointerEventData.InputButton.Right)
        {
            heroInventory.RemoveItem(this);
        }
        else if(evenData.button == PointerEventData.InputButton.Left)
        {
            heroInventory.UseItem(this);
        }
    }

    public void RemoveCell()
    {
        item = null;
        image.sprite = null;
        //descriptionCell.text = "";
        //count.text = "";
        ownerItem = "";
    }
}
