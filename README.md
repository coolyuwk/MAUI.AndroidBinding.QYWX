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
# MAUI.IOSBinding.QYWX

Info.plise
```
	<key>CFBundleURLTypes</key>
	<array>
		<dict>
			<key>CFBundleTypeRole</key>
			<string>Editor</string>
			<key>CFBundleURLName</key>
			<string>main</string>
			<key>CFBundleURLSchemes</key>
			<array>
				<string>schema</string>
			</array>
		</dict>
		<dict>
			<key>CFBundleTypeRole</key>
			<string>Editor</string>
			<key>CFBundleURLName</key>
			<string>main</string>
			<key>CFBundleURLSchemes</key>
			<array>
				<string>Bundle ID</string>
			</array>
		</dict>
	</array>
```