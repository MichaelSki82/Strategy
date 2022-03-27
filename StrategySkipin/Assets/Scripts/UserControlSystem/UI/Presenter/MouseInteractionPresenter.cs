using System.Linq;
using Abstractions;
using UnityEngine;
using UserControlSystem;

public sealed class MouseInteractionPresenter : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SelectableValue _selectedObject;
    private WorkWithOutline curentWorkWithOutline;

    private void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.collider.gameObject);
                var workWithOutline = hit.collider.GetComponent<WorkWithOutline>();
                if (workWithOutline != null)
                {
                    
                    curentWorkWithOutline?.OutlineDeactivation();
                    curentWorkWithOutline = workWithOutline;
                    curentWorkWithOutline.OutlineActivation();

                }
                else
                {
                    curentWorkWithOutline?.OutlineDeactivation();
                    curentWorkWithOutline = workWithOutline;
                }

            }
        }


        if (!Input.GetMouseButtonUp(0))
        {
            return;
        }
        var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));
        if (hits.Length == 0)
        {
            return;
        }
        var selectable = hits
            .Select(hit => hit.collider.GetComponentInParent<ISelectable>())
            .FirstOrDefault(c => c != null);
        _selectedObject.SetValue(selectable);
    }
}