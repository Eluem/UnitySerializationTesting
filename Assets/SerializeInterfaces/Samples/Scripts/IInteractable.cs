using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples
{
    public interface IInteractable
    {
        public InterfaceReference<IInteractable> IInteractableReference { get; }
        void Interact();
    }
}