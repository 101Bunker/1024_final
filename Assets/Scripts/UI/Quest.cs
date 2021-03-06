using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Quest
{
    public string title;
    public string clearTitle;
    public Sprite image;
    public GameObject locationObj;
    public  List<GameObject> couponCharactors = new List<GameObject>();
    public List<Toggle> toggles = new List<Toggle>();
    public Quest(string title, string clearTitle, Sprite image, GameObject locationObj, List<GameObject> couponCharactors, List<Toggle> toggles)
    {
        this.title = title;
        this.clearTitle = clearTitle;
        this.image = image;
        this.locationObj = locationObj;
        this.couponCharactors = couponCharactors;
        this.toggles = toggles;
    }
}
