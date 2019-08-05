using System;
using UnityEngine;
using UnityEngine.UI;

public class BugFixedDropDown : Dropdown {
    protected override GameObject CreateDropdownList(GameObject template) {
        var ret = base.CreateDropdownList(template);
        ret.GetComponent<Canvas>().sortingLayerName = SortingLayer;
        return ret;
    }

    [SortingLayerSetting]
    public string SortingLayer;
}
