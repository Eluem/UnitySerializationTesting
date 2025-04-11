using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples
{
    public class InteractableAsset : ScriptableObject, IInteractable
    {
        public InterfaceReference<IInteractable> IInteractableReference
        {
            get
            {
                //Not implemented for this
                return null;
            }
        }

        public void Interact()
        {
            Debug.Log($"Interacted with asset: {this.name}");
        }
    }
}
