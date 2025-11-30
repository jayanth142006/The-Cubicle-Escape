using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    public Renderer[] cubeRenderers;   // drag your cubes' Renderers here

    public void ChangeColors()
    {
        foreach (var rend in cubeRenderers)
        {
            if (rend != null)
            {
                Color newColor = new Color(Random.value, Random.value, Random.value);
                rend.material.color = newColor;
            }
        }
    }
}
