using System;
using System.Collections;
using System.Collections.Generic;
using Chipmunk.Library.PoolEditor;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] BuildingSO so;
    private void Start()
    {
        // GameObject gameObject = PoolManager.Instance.Pop("ww");
        // PoolManager.Instance.Pop("ww");
        // gameObject.name = "ming";
        // PoolManager.Instance.Push(gameObject);
        StartCoroutine(enumerator());
    }
    IEnumerator enumerator()
    {
        yield return null;
        BuildingManager.Instance.eventContainer.Subscribe(EnumBuildingEvent.CreateBuilding, CreateBuildingHandler);
        BuildingManager.Instance.CreateBuilding(Vector2Int.RoundToInt(transform.position), new BaseBuilding(so));
    }
    private void CreateBuildingHandler(BaseEvent @event)
    {
        @event.onAfterExcute += OnAfterExecute;
        CreateBuildingEvent createBuildingEvent = @event as CreateBuildingEvent;
    }

    private void OnAfterExecute(EnumEventResult result)
    {
    }
}
