﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class EmptyInventorySlotDrop : EmptySlotDrop
{
    
    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData); // 부모 클래스의 OnDrop 실행
        //character.changeWeapon(dropObject, Null,  );
        isOccupied = true; // 무기가 슬롯을 차지하니 isOccupied가 true

    }
}
    
        