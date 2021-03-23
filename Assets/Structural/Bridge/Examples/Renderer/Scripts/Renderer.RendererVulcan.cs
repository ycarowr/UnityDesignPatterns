using UnityEngine;

namespace Bridge
{

    public partial class Renderer
    {
        private class RendererVulcan: IRendererImpl
        {
            public RendererType Type => RendererType.Vulcan;

            public void Render(Sprite sprite)
            {
                Debug.Log("Rendered with Vulcan");
            }
        }
    }
}