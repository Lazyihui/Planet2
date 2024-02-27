using System;
using UnityEngine;

public static class PlantDomain {
    public static PlantEntity Spawn(GameContext ctx, int typeID, Vector2 pos) {

        bool has = ctx.templateContext.plants.TryGetValue(typeID, out PlantTM tm);

        if (!has) {
            Debug.LogError("没找到" + typeID);
        }
        ctx.assetsContext.Entity_TryGetPrefab("Entity_Plant", out GameObject prefab);
        PlantEntity plantEntity = GameObject.Instantiate(prefab).GetComponent<PlantEntity>();

        plantEntity.Ctor();
        plantEntity.SetPos(tm.plantPos);
        plantEntity.id = ctx.plantID++;
        plantEntity.isPlanted = false;
        plantEntity.isLive = false;


        plantEntity.typeID = tm.typeID;

        plantEntity.Init(tm.typeID, tm.sprite, tm.plantName, tm.plantPrice, tm.shapeSize, tm.cd, tm.cd, tm.maintain, tm.interval);

        ctx.plantRepository.Add(plantEntity);
        return plantEntity;
    }
}