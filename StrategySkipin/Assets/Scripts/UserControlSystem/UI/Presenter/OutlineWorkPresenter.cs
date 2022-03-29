using System.Linq;
using Abstractions;
using UnityEngine;
using UnityEngine.EventSystems;
using UserControlSystem;

public sealed class OutlineWorkPresenter : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private WorkWithOutline curentWorkWithOutline;

    private void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit, 100))
            {

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
      
    }
}