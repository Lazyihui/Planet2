using UnityEngine;
public static class HomeDomain {

    public static HomeEntity Spawn(GamaContext ctx,int typeID,Vector2 pos) {
    
        HomeEntity prafab = ctx.assetsContext.homeEntity;
        HomeEntity homeEntity = GameObject.Instantiate(prafab);
        homeEntity.SetPos(pos);
        return homeEntity;
    }
}