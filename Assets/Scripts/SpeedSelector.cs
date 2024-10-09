using StarterAssets;
using UnityEngine;

public class SpeedSelector : MonoBehaviour
{
    [SerializeField] private ThirdPersonController _thirdPersonController;

    private float _normalSpeed;
    private float _turboSpeed;
    
    void Start()
    {
        _normalSpeed = _thirdPersonController.MoveSpeed;
        _turboSpeed = _thirdPersonController.MoveSpeed * 2;
    }

    public void SetSpeedModeToNormal()
    {
        _thirdPersonController.MoveSpeed = _normalSpeed;
        Debug.Log("CAMBIO A VELOCIDAD NORMAL");
    }

    public void SetSpeedModeToTurbo()
    {
        _thirdPersonController.MoveSpeed = _turboSpeed;
        Debug.Log("CAMBIO A VELOCIDAD TURBO");
    }
}
