# MAUI.AndroidBinding.QYWX
调用企业微信登录


``` C#
var api = WWAPIFactory.CreateWWAPI(Android.App.Application.Context);
api.RegisterApp(Schema);

WWAuthMessage.Req req = new WWAuthMessage.Req()
{
    Sch = this.Schema,
    AppId = AppId,
    AgentId = AgentId,
    State = ""
};

WWAPIEventHandler wWAPIEventHandler = new WWAPIEventHandler(func);
api.SendMessage(req, wWAPIEventHandler);
```
