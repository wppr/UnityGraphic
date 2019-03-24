using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render : MonoBehaviour
{
    public RenderTexture rt;
    // Start is called before the first frame update
    void Start()
    {
        rt = new RenderTexture(Screen.width, Screen.height, 24);
    }

    // Update is called once per frame
    void Update()
    {
        GL.Clear(true, true, Color.grey);
    }
    private void OnPostRender()
    {
        
        Camera cam = Camera.current;
        Graphics.SetRenderTarget(rt);
        GL.Clear(true, true, Color.grey);
        Graphics.Blit(rt, cam.targetTexture);
        //GetComponent<Camera>().targetTexture = null;
        //print("post");
        //Graphics.Blit(rt, null as RenderTexture);
    }
}
