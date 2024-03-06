using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Panel_Select : MonoBehaviour{

    [SerializeField] Panel_SelectElement elePrefab;

    [SerializeField] Transform selectGroup;

    public void Ctor() {
    }

    public void Init() {
    }

    public void Show() {
        gameObject.SetActive(true);
    }

    public void Close(){
        gameObject.SetActive(false);
    }

    public void AddElement(Sprite sprite, UIcontext ctx) {
        Panel_SelectElement ele = GameObject.Instantiate(elePrefab, selectGroup);
     
        ele.Ctor();
        ele.OnSelectClickHandle = () => {
            ctx.events.SelectElement_Select();
        };
        ele.Init(sprite);
    }

}