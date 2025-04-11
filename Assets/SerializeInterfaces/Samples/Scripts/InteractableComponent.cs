using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples
{
    public class InteractableComponent : MonoBehaviour, IInteractable
    {
        public InteractableTest test;
        InterfaceReference<IInteractable> _IInteractableReference;
        public string DebugText;

        public InterfaceReference<IInteractable> IInteractableReference
        {
            get
            {
                if(_IInteractableReference == null)
                {
                    _IInteractableReference = new InterfaceReference<IInteractable>();
                    _IInteractableReference.Value = this;
                }
                Debug.Log((_IInteractableReference.Value as InteractableComponent).name);
                Debug.Log(_IInteractableReference.UnderlyingValue.name);
                return _IInteractableReference;
            }
        }

        public void Interact()
        {

            Debug.Log($"Interacted with component: {this.name}");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (test != null)
                {
                    Debug.Log(name + " T pressed");
                    test.AddToReferenceList(this);
                }
            }
        }
    }
}
