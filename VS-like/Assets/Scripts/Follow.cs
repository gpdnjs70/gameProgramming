using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    RectTransform rect;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void LateUpdate()
    {
        Vector3 screenPos =
            Camera.main.WorldToScreenPoint(GameManager.Instance.player.transform.position);

        rect.position = screenPos;

        rect.anchoredPosition += new Vector2(-1f, -18f);
    }
}
