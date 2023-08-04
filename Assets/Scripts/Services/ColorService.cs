using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorService
{
    public static void SetRandomColor(Renderer renderer)
    {
        Color randomColor = new(Random.value, Random.value, Random.value);
        renderer.material.color = randomColor;
    }
}
