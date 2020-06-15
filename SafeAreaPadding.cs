using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class SafeAreaPadding : MonoBehaviour
{
    private DeviceOrientation postOrientation;

    public bool use_debug;
    public Vector4 debug_data;

    void Update()
    {
        if (Input.deviceOrientation != DeviceOrientation.Unknown && postOrientation == Input.deviceOrientation)
            return;

        postOrientation = Input.deviceOrientation;

        var rect = GetComponent<RectTransform>();
        var area = Screen.safeArea;
        var resolition = Screen.currentResolution;

        if(use_debug)
        {
            rect.anchorMax = new Vector2(debug_data.z,debug_data.w);
            rect.anchorMin = new Vector2(debug_data.x,debug_data.y);
        }
        else {
            rect.anchorMax = new Vector2(area.xMax / resolition.width, area.yMax / resolition.height);
            rect.anchorMin = new Vector2(area.xMin / resolition.width, area.yMin / resolition.height);
        }
        rect.sizeDelta = Vector2.zero;

        //Debug.Log(area);
        //Debug.Log(string.Format("area_x({0},{1}) area_y({2},{3}) reso({4},{5})",
        //    area.xMax, area.xMin, area.yMax, area.yMin, resolition.width, resolition.height));
    }

}
