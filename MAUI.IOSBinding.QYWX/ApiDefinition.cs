using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace QyWxBinding
{
    // @protocol WWKApiSerializable <NSObject>
    /*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface IWWKApiSerializable
    {
        // @required -(BOOL)deserializeWithDictionary:(NSDictionary * _Nonnull)dict;
        [Abstract]
        [Export("deserializeWithDictionary:")]
        bool DeserializeWithDictionary(NSDictionary dict);
    }

    // @interface WWKBaseObject : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKBaseObject
    {
        // @property (copy, nonatomic) NSString * _Nonnull bundleID;
        [Export("bundleID")]
        string BundleID { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull bundleName;
        [Export("bundleName")]
        string BundleName { get; set; }

        // @property (assign, nonatomic) NSUInteger sequence;
        [Export("sequence")]
        nuint Sequence { get; set; }

        // @property (readonly, nonatomic) NSData * _Nullable serializedData;
        [NullAllowed, Export("serializedData")]
        NSData SerializedData { get; }

        // @property (readonly, nonatomic) NSMutableDictionary * _Nullable serializedDict;
        [NullAllowed, Export("serializedDict")]
        NSMutableDictionary SerializedDict { get; }

        // +(instancetype _Nonnull)deserializeWithData:(NSData * _Nonnull)data appid:(NSString * _Nonnull)appid;
        [Static]
        [Export("deserializeWithData:appid:")]
        WWKBaseObject DeserializeWithData(NSData data, string appid);
    }

    // @interface WWKBaseReq : WWKBaseObject
    [BaseType(typeof(WWKBaseObject))]
    interface WWKBaseReq
    {
        // -(WWKBaseResp * _Nonnull)respObj;
        [Export("respObj")]
        WWKBaseResp RespObj { get; }
    }

    [Static]
    partial interface Constants
    {
        // extern const int WWKBaseRespErrCodeOK;
        [Field("WWKBaseRespErrCodeOK", "__Internal")]
        int WWKBaseRespErrCodeOK { get; }

        // extern const int WWKBaseRespErrCodeCancelled;
        [Field("WWKBaseRespErrCodeCancelled", "__Internal")]
        int WWKBaseRespErrCodeCancelled { get; }

        // extern const int WWKBaseRespErrCodeFailed;
        [Field("WWKBaseRespErrCodeFailed", "__Internal")]
        int WWKBaseRespErrCodeFailed { get; }

        // extern const int WWKBaseRespErrCodeNotSupported;
        [Field("WWKBaseRespErrCodeNotSupported", "__Internal")]
        int WWKBaseRespErrCodeNotSupported { get; }

        // extern const int WWKBaseRespErrCodeLowAppVer;
        [Field("WWKBaseRespErrCodeLowAppVer", "__Internal")]
        int WWKBaseRespErrCodeLowAppVer { get; }

        // extern const int WWKBaseRespErrCodeNoPrivileges;
        [Field("WWKBaseRespErrCodeNoPrivileges", "__Internal")]
        int WWKBaseRespErrCodeNoPrivileges { get; }

        // extern const int WWKBaseRespErrCodeInvalidCall;
        [Field("WWKBaseRespErrCodeInvalidCall", "__Internal")]
        int WWKBaseRespErrCodeInvalidCall { get; }

        // extern const int WWKBaseRespErrCodeNetWork;
        [Field("WWKBaseRespErrCodeNetWork", "__Internal")]
        int WWKBaseRespErrCodeNetWork { get; }

        // extern const int WWKBaseRespErrCodeSessonKeyTimeOut;
        [Field("WWKBaseRespErrCodeSessonKeyTimeOut", "__Internal")]
        int WWKBaseRespErrCodeSessonKeyTimeOut { get; }
    }

    // @interface WWKBaseResp : WWKBaseObject
    [BaseType(typeof(WWKBaseObject))]
    interface WWKBaseResp
    {
        // @property (assign, nonatomic) int errCode;
        [Export("errCode")]
        int ErrCode { get; set; }

        // @property (retain, nonatomic) NSString * _Nullable errStr;
        [NullAllowed, Export("errStr", ArgumentSemantic.Retain)]
        string ErrStr { get; set; }
    }

    // @interface WWKMessageAttachment : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKMessageAttachment
    {
    }

    // @interface WWKMessageTextAttachment : WWKMessageAttachment
    [BaseType(typeof(WWKMessageAttachment))]
    interface WWKMessageTextAttachment
    {
        // @property (copy, nonatomic) NSString * _Nonnull text;
        [Export("text")]
        string Text { get; set; }
    }

    // @interface WWKMessageFileAttachment : WWKMessageAttachment
    [BaseType(typeof(WWKMessageAttachment))]
    interface WWKMessageFileAttachment
    {
        // @property (copy, nonatomic) NSString * _Nonnull filename;
        [Export("filename")]
        string Filename { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable path;
        [NullAllowed, Export("path")]
        string Path { get; set; }

        // @property (retain, nonatomic) NSData * _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Retain)]
        NSData Data { get; set; }
    }

    // @interface WWKMessageImageAttachment : WWKMessageFileAttachment
    [BaseType(typeof(WWKMessageFileAttachment))]
    interface WWKMessageImageAttachment
    {
    }

    // @interface WWKMessageVideoAttachment : WWKMessageFileAttachment
    [BaseType(typeof(WWKMessageFileAttachment))]
    interface WWKMessageVideoAttachment
    {
    }

    // @interface WWKMessageLinkAttachment : WWKMessageAttachment
    [BaseType(typeof(WWKMessageAttachment))]
    interface WWKMessageLinkAttachment
    {
        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable summary;
        [NullAllowed, Export("summary")]
        string Summary { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable url;
        [NullAllowed, Export("url")]
        string Url { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable iconurl;
        [NullAllowed, Export("iconurl")]
        string Iconurl { get; set; }

        // @property (retain, nonatomic) NSData * _Nullable icon;
        [NullAllowed, Export("icon", ArgumentSemantic.Retain)]
        NSData Icon { get; set; }

        // @property (assign, nonatomic) BOOL withShareTicket;
        [Export("withShareTicket")]
        bool WithShareTicket { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable shareTicketState;
        [NullAllowed, Export("shareTicketState")]
        string ShareTicketState { get; set; }
    }

    // @interface WWKMessageMiniAppAttachment : WWKMessageAttachment
    [BaseType(typeof(WWKMessageAttachment))]
    interface WWKMessageMiniAppAttachment
    {
        // @property (copy, nonatomic) NSString * _Nonnull userName;
        [Export("userName")]
        string UserName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable path;
        [NullAllowed, Export("path")]
        string Path { get; set; }

        // @property (nonatomic, strong) NSData * _Nullable hdImageData;
        [NullAllowed, Export("hdImageData", ArgumentSemantic.Strong)]
        NSData HdImageData { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }
    }

    // @interface WWKMessageLocationAttachment : WWKMessageAttachment
    [BaseType(typeof(WWKMessageAttachment))]
    interface WWKMessageLocationAttachment
    {
        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable address;
        [NullAllowed, Export("address")]
        string Address { get; set; }

        // @property (assign, nonatomic) double lat;
        [Export("lat")]
        double Lat { get; set; }

        // @property (assign, nonatomic) double lng;
        [Export("lng")]
        double Lng { get; set; }

        // @property (assign, nonatomic) double zoom;
        [Export("zoom")]
        double Zoom { get; set; }
    }

    // @interface WWKMessageAttachmentWrapper : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKMessageAttachmentWrapper
    {
        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull date;
        [Export("date", ArgumentSemantic.Copy)]
        NSDate Date { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable avatarUrl;
        [NullAllowed, Export("avatarUrl")]
        string AvatarUrl { get; set; }

        // @property (copy, nonatomic) NSData * _Nullable avatarData;
        [NullAllowed, Export("avatarData", ArgumentSemantic.Copy)]
        NSData AvatarData { get; set; }

        // @property (retain, nonatomic) WWKMessageAttachment * _Nonnull attachment;
        [Export("attachment", ArgumentSemantic.Retain)]
        WWKMessageAttachment Attachment { get; set; }
    }

    // @interface WWKMessageGroupAttachment : WWKMessageAttachment
    [BaseType(typeof(WWKMessageAttachment))]
    interface WWKMessageGroupAttachment
    {
        // @property (copy, nonatomic) NSArray<WWKMessageAttachmentWrapper *> * _Nonnull contents;
        [Export("contents", ArgumentSemantic.Copy)]
        WWKMessageAttachmentWrapper[] Contents { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; set; }
    }

    // @interface WWKOpenIdInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKOpenIdInfo
    {
        // @property (copy, nonatomic) NSString * _Nullable openid;
        [NullAllowed, Export("openid")]
        string Openid { get; set; }

        // @property (assign, nonatomic) WWKOpenIdType idType;
        [Export("idType", ArgumentSemantic.Assign)]
        WWKOpenIdType IdType { get; set; }
    }

    // @interface WWKSendMessageReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKSendMessageReq : IWWKApiSerializable
    {
        // @property (retain, nonatomic) WWKMessageAttachment * _Nullable attachment;
        [NullAllowed, Export("attachment", ArgumentSemantic.Retain)]
        WWKMessageAttachment Attachment { get; set; }
    }

    // @interface WWKSendMessageResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKSendMessageResp : IWWKApiSerializable
    {
    }

    // @interface WWKPickContactReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKPickContactReq : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; set; }
    }

    // @interface WWKContactInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKContactInfo
    {
        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }
    }

    // @interface WWKPickContactResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKPickContactResp : IWWKApiSerializable
    {
        // @property (retain, nonatomic) NSArray<WWKContactInfo *> * _Nullable contacts;
        [NullAllowed, Export("contacts", ArgumentSemantic.Retain)]
        WWKContactInfo[] Contacts { get; set; }
    }

    // @interface WWKOpenConversationReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKOpenConversationReq : IWWKApiSerializable
    {
        // @property (assign, nonatomic) uint64_t conversationType;
        [Export("conversationType")]
        ulong ConversationType { get; set; }

        // @property (assign, nonatomic) uint64_t conversationId;
        [Export("conversationId")]
        ulong ConversationId { get; set; }
    }

    // @interface WWKOpenConversationResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKOpenConversationResp : IWWKApiSerializable
    {
    }

    // @interface WWKSSOReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKSSOReq : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSString * _Nonnull state;
        [Export("state")]
        string State { get; set; }
    }

    // @interface WWKSSOResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKSSOResp : IWWKApiSerializable
    {
        // @property (retain, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state", ArgumentSemantic.Retain)]
        string State { get; set; }

        // @property (retain, nonatomic) NSString * _Nullable code;
        [NullAllowed, Export("code", ArgumentSemantic.Retain)]
        string Code { get; set; }
    }

    // @interface WWKOpenChatWithMessageReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKOpenChatWithMessageReq : IWWKApiSerializable
    {
        // @property (retain, nonatomic) WWKMessageAttachment * _Nullable attachment;
        [NullAllowed, Export("attachment", ArgumentSemantic.Retain)]
        WWKMessageAttachment Attachment { get; set; }

        // @property (retain, nonatomic) NSArray<NSString *> * _Nullable userOpenidList;
        [NullAllowed, Export("userOpenidList", ArgumentSemantic.Retain)]
        string[] UserOpenidList { get; set; }

        // @property (retain, nonatomic) NSString * _Nullable openUserid;
        [NullAllowed, Export("openUserid", ArgumentSemantic.Retain)]
        string OpenUserid { get; set; }
    }

    // @interface WWKOpenChatWithMessageResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKOpenChatWithMessageResp : IWWKApiSerializable
    {
    }

    // @interface WWKSelectContactReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKSelectContactReq : IWWKApiSerializable
    {
        // @property (retain, nonatomic) NSString * _Nonnull openUserid;
        [Export("openUserid", ArgumentSemantic.Retain)]
        string OpenUserid { get; set; }
    }

    // @interface WWKSelectContactResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKSelectContactResp : IWWKApiSerializable
    {
        // @property (retain, nonatomic) NSArray<WWKOpenIdInfo *> * _Nullable openids;
        [NullAllowed, Export("openids", ArgumentSemantic.Retain)]
        WWKOpenIdInfo[] Openids { get; set; }
    }

    // @interface WWKOpenDataItem : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKOpenDataItem
    {
        // @property (copy, nonatomic) NSString * _Nonnull openid;
        [Export("openid")]
        string Openid { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable data;
        [NullAllowed, Export("data")]
        string Data { get; set; }
    }

    // @interface WWKSelectPrivilegedContactReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKSelectPrivilegedContactReq : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSString * _Nonnull loginOpenUserid;
        [Export("loginOpenUserid")]
        string LoginOpenUserid { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull selectedOpenUserIds;
        [Export("selectedOpenUserIds", ArgumentSemantic.Copy)]
        string[] SelectedOpenUserIds { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull selectedTickets;
        [Export("selectedTickets", ArgumentSemantic.Copy)]
        string[] SelectedTickets { get; set; }
    }

    // @interface WWKSelectPrivilegedContactResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKSelectPrivilegedContactResp : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull openUserIdList;
        [Export("openUserIdList", ArgumentSemantic.Copy)]
        string[] OpenUserIdList { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull selectedTicket;
        [Export("selectedTicket")]
        string SelectedTicket { get; set; }

        // @property (assign, nonatomic) uint32_t expiresIn;
        [Export("expiresIn")]
        uint ExpiresIn { get; set; }

        // @property (assign, nonatomic) uint32_t selectedUserCount;
        [Export("selectedUserCount")]
        uint SelectedUserCount { get; set; }
    }

    // @interface WWKCreateChatWithMsgReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKCreateChatWithMsgReq : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSString * _Nonnull loginOpenUserid;
        [Export("loginOpenUserid")]
        string LoginOpenUserid { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull selectedOpenUserIdList;
        [Export("selectedOpenUserIdList", ArgumentSemantic.Copy)]
        string[] SelectedOpenUserIdList { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull selectedTicketList;
        [Export("selectedTicketList", ArgumentSemantic.Copy)]
        string[] SelectedTicketList { get; set; }

        // @property (retain, nonatomic) WWKMessageAttachment * _Nonnull attachment;
        [Export("attachment", ArgumentSemantic.Retain)]
        WWKMessageAttachment Attachment { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable chatName;
        [NullAllowed, Export("chatName")]
        string ChatName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; set; }
    }

    // @interface WWKCreateChatWithMsgResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKCreateChatWithMsgResp : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSString * _Nullable chatId;
        [NullAllowed, Export("chatId")]
        string ChatId { get; set; }
    }

    // @interface WWKOpenExistedChatWithMsgReq : WWKBaseReq <WWKApiSerializable>
    [BaseType(typeof(WWKBaseReq))]
    interface WWKOpenExistedChatWithMsgReq : IWWKApiSerializable
    {
        // @property (copy, nonatomic) NSString * _Nonnull loginOpenUserid;
        [Export("loginOpenUserid")]
        string LoginOpenUserid { get; set; }

        // @property (retain, nonatomic) WWKMessageAttachment * _Nullable attachment;
        [NullAllowed, Export("attachment", ArgumentSemantic.Retain)]
        WWKMessageAttachment Attachment { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull chatId;
        [Export("chatId")]
        string ChatId { get; set; }
    }

    // @interface WWKOpenExistedChatWithMsgResp : WWKBaseResp <WWKApiSerializable>
    [BaseType(typeof(WWKBaseResp))]
    interface WWKOpenExistedChatWithMsgResp : IWWKApiSerializable
    {
    }

    // @protocol WWKApiDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface WWKApiDelegate
    {
        // @optional -(void)onReq:(WWKBaseReq *)req;
        [Export("onReq:")]
        void OnReq(WWKBaseReq req);

        // @optional -(void)onResp:(WWKBaseResp *)resp;
        [Export("onResp:")]
        void OnResp(WWKBaseResp resp);

        // @optional -(void)onSessionKeyUpdate:(NSString *)newSessionKey;
        [Export("onSessionKeyUpdate:")]
        void OnSessionKeyUpdate(string newSessionKey);
    }

    // @interface WWKApi : NSObject
    [BaseType(typeof(NSObject))]
    interface WWKApi
    {
        // +(BOOL)registerApp:(NSString *)appid;
        [Static]
        [Export("registerApp:")]
        bool RegisterApp(string appid);

        // +(BOOL)registerAppID:(NSString *)appid schema:(NSString *)schema;
        [Static]
        [Export("registerAppID:schema:")]
        bool RegisterAppID(string appid, string schema);

        // +(BOOL)registerApp:(NSString *)appid corpId:(NSString *)corpid agentId:(NSString *)agentid;
        [Static]
        [Export("registerApp:corpId:agentId:")]
        bool RegisterApp(string appid, string corpid, string agentid);

        // +(void)updateSessionKeyIfNeeded:(BOOL)enable;
        [Static]
        [Export("updateSessionKeyIfNeeded:")]
        void UpdateSessionKeyIfNeeded(bool enable);

        // +(BOOL)handleOpenURL:(NSURL *)url delegate:(id<WWKApiDelegate>)delegate;
        [Static]
        [Export("handleOpenURL:delegate:")]
        bool HandleOpenURL(NSUrl url, WWKApiDelegate @delegate);

        // +(BOOL)isAppInstalled;
        [Static]
        [Export("isAppInstalled")]
        bool IsAppInstalled { get; }

        // +(NSString *)getAppInstallUrl;
        [Static]
        [Export("getAppInstallUrl")]
        string AppInstallUrl { get; }

        // +(NSString *)getApiVersion;
        [Static]
        [Export("getApiVersion")]
        string ApiVersion { get; }

        // +(BOOL)openApp;
        [Static]
        [Export("openApp")]
        bool OpenApp { get; }

        // +(void)startSSOLogin:(NSString *)state fromNavigationController:(UINavigationController *)navigationController;
        [Static]
        [Export("startSSOLogin:fromNavigationController:")]
        void StartSSOLogin(string state, UINavigationController navigationController);

        // +(BOOL)sendReq:(WWKBaseReq *)req;
        [Static]
        [Export("sendReq:")]
        bool SendReq(WWKBaseReq req);

        // +(BOOL)sendResp:(WWKBaseResp *)resp;
        [Static]
        [Export("sendResp:")]
        bool SendResp(WWKBaseResp resp);

        // +(WWKDiplayNameType)displayNameType;
        [Static]
        [Export("displayNameType")]
        WWKDiplayNameType DisplayNameType { get; }

        // +(void)setSessionKey:(NSString *)sessionKey;
        [Static]
        [Export("setSessionKey:")]
        void SetSessionKey(string sessionKey);

        // +(void)initOpenData:(void (^)(BOOL))completion;
        [Static]
        [Export("initOpenData:")]
        void InitOpenData(Action<bool> completion);

        // +(void)getOpenData:(NSArray<WWKOpenDataItem *> *)dataList completion:(void (^)(NSError *, NSArray<WWKOpenDataItem *> *))completion;
        //[Static]
        //[Export ("getOpenData:completion:")]
        //void GetOpenData (WWKOpenDataItem[] dataList, Action<NSError, NSArray<WWKOpenDataItem>> completion);
    }
}
