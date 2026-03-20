using UnityEngine;

public class ForceColliderOnDetach : MonoBehaviour
{
    private BoxCollider _col;
    private RCC_DetachablePart _detachableScript;

    void Start()
    {
        _col = GetComponent<BoxCollider>();
        _detachableScript = GetComponent<RCC_DetachablePart>();
    }

    void Update()
    {
        if (_detachableScript.broken && _col != null && !_col.enabled)
        {
            _col.enabled = true;
            Destroy(this);
        }
    }
}