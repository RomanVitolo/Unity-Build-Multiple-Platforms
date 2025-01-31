﻿using UnityEngine;

namespace Modules.PlacementAPI.Scripts.Runtime
{
    [CreateAssetMenu(fileName = "New BuildingType", menuName = "Modules/PlacementAPI/BuildingType")]
    public class BuildingTypeSO : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite BuildingSprite { get; private set; }
        [field: SerializeField] public Transform PrefabType { get; private set; }
        [field: SerializeField] public ResourcesGenerateData ResourcesGenerateData { get; private set; }
        [field: SerializeField] public float MinPlacementRadius { get; private set; }
        [field: SerializeField] public ResourceAmount[] ConstructionsResourceCost { get; private set; }
    }
}