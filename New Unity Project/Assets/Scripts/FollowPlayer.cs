
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // 跟随play 每一帧

    public Transform player;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // 指向当前这个脚本指向的无敌
        transform.position = player.position + offset;

    }
}
