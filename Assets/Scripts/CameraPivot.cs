using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    [SerializeField] private Transform FollowPlayer;
    [SerializeField] private Vector3 Offset;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, FollowPlayer.position + Offset, Time.deltaTime * 3f);
    }
}
