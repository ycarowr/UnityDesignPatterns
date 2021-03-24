using System;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge
{
    public class ResourceClient : MonoBehaviour
    {
        private readonly List<BaseView> _views = new List<BaseView>();

        private void Awake()
        {
            var resourceAlbum = new ResourceAlbum();
            var resourceArtist = new ResourceArtist();
            var resourceBook = new ResourceBook();

            _views.Add(new LongFormView(resourceAlbum));
            _views.Add(new ShortFormView(resourceArtist));
            _views.Add(new ShortFormView(resourceBook));
            
            Show();
        }

        [Button]
        private void Show()
        {
            foreach (var i in _views)
                i.Show();
        }

        [Button]
        private void Hide()
        {
            foreach (var i in _views)
                i.Hide();
        }
    }
}