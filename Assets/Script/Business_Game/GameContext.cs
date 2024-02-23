public class GameContext {

    public PlayerEntity playerEntity;
    public AssetsContext assetsContext;

    public HomeRepository homeRepository;

    public BaseRepository baseRepository;

    public MstRepository mstRepository;
    public UIcontext uiContext;

    public TemplateContext templateContext;
    public int MstID;

    public int homeID;
    public int baseID;
    public GameContext() {
        playerEntity = new PlayerEntity();
        homeRepository = new HomeRepository();
        baseRepository = new BaseRepository();
        mstRepository = new MstRepository();
        uiContext = new UIcontext();
        templateContext = new TemplateContext();

        baseID = 0;
        homeID = 0;
        MstID = 0;
    }

    public void Inject(AssetsContext assetsContext, UIcontext uiContext, TemplateContext templateContext) {
        this.assetsContext = assetsContext;
        this.uiContext = uiContext;
        this.templateContext = templateContext;
    }

}