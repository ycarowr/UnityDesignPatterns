using UnityEngine;

namespace Bridge
{
    public class RendererClient : MonoBehaviour
    {
        private Renderer DirectX;
        private Renderer Vulcan;

        private void Awake()
        {
            DirectX = new Renderer(RendererType.DirectX);
            Vulcan = new Renderer(RendererType.Vulcan);
        }

        private void Update()
        {
            DirectX.Render(null);
            Vulcan.Render(null);
        }
    }
}