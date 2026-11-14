// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class URLACTION
{
    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_MIN"]/*' />
    [NativeTypeName("#define URLACTION_MIN 0x00001000")]
    public const int URLACTION_MIN = 0x00001000;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_DOWNLOAD_MIN"]/*' />
    [NativeTypeName("#define URLACTION_DOWNLOAD_MIN 0x00001000")]
    public const int URLACTION_DOWNLOAD_MIN = 0x00001000;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_DOWNLOAD_SIGNED_ACTIVEX"]/*' />
    [NativeTypeName("#define URLACTION_DOWNLOAD_SIGNED_ACTIVEX 0x00001001")]
    public const int URLACTION_DOWNLOAD_SIGNED_ACTIVEX = 0x00001001;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX"]/*' />
    [NativeTypeName("#define URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX 0x00001004")]
    public const int URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX = 0x00001004;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_DOWNLOAD_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_DOWNLOAD_CURR_MAX 0x00001004")]
    public const int URLACTION_DOWNLOAD_CURR_MAX = 0x00001004;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_DOWNLOAD_MAX"]/*' />
    [NativeTypeName("#define URLACTION_DOWNLOAD_MAX 0x000011FF")]
    public const int URLACTION_DOWNLOAD_MAX = 0x000011FF;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_MIN"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_MIN 0x00001200")]
    public const int URLACTION_ACTIVEX_MIN = 0x00001200;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_RUN"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_RUN 0x00001200")]
    public const int URLACTION_ACTIVEX_RUN = 0x00001200;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY 0x00001201")]
    public const int URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY = 0x00001201;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY 0x00001202")]
    public const int URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY = 0x00001202;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY 0x00001203")]
    public const int URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY = 0x00001203;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_OVERRIDE_SAFETY"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_OVERRIDE_SAFETY 0x00001401")]
    public const int URLACTION_SCRIPT_OVERRIDE_SAFETY = 0x00001401;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY 0x00001204")]
    public const int URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY = 0x00001204;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_TREATASUNTRUSTED"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_TREATASUNTRUSTED 0x00001205")]
    public const int URLACTION_ACTIVEX_TREATASUNTRUSTED = 0x00001205;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_NO_WEBOC_SCRIPT"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_NO_WEBOC_SCRIPT 0x00001206")]
    public const int URLACTION_ACTIVEX_NO_WEBOC_SCRIPT = 0x00001206;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION 0x00001207")]
    public const int URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION = 0x00001207;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_OVERRIDE_OPTIN"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OPTIN 0x00001208")]
    public const int URLACTION_ACTIVEX_OVERRIDE_OPTIN = 0x00001208;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_SCRIPTLET_RUN"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_SCRIPTLET_RUN 0x00001209")]
    public const int URLACTION_ACTIVEX_SCRIPTLET_RUN = 0x00001209;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION 0x0000120A")]
    public const int URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION = 0x0000120A;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST 0x0000120B")]
    public const int URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST = 0x0000120B;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_ALLOW_TDC"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_ALLOW_TDC 0x0000120C")]
    public const int URLACTION_ACTIVEX_ALLOW_TDC = 0x0000120C;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_CURR_MAX 0x0000120C")]
    public const int URLACTION_ACTIVEX_CURR_MAX = 0x0000120C;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ACTIVEX_MAX"]/*' />
    [NativeTypeName("#define URLACTION_ACTIVEX_MAX 0x000013ff")]
    public const int URLACTION_ACTIVEX_MAX = 0x000013ff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_MIN"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_MIN 0x00001400")]
    public const int URLACTION_SCRIPT_MIN = 0x00001400;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_RUN"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_RUN 0x00001400")]
    public const int URLACTION_SCRIPT_RUN = 0x00001400;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_JAVA_USE"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_JAVA_USE 0x00001402")]
    public const int URLACTION_SCRIPT_JAVA_USE = 0x00001402;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_SAFE_ACTIVEX"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_SAFE_ACTIVEX 0x00001405")]
    public const int URLACTION_SCRIPT_SAFE_ACTIVEX = 0x00001405;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_CROSS_DOMAIN_DATA"]/*' />
    [NativeTypeName("#define URLACTION_CROSS_DOMAIN_DATA 0x00001406")]
    public const int URLACTION_CROSS_DOMAIN_DATA = 0x00001406;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_PASTE"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_PASTE 0x00001407")]
    public const int URLACTION_SCRIPT_PASTE = 0x00001407;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE 0x00001408")]
    public const int URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE = 0x00001408;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_XSSFILTER"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_XSSFILTER 0x00001409")]
    public const int URLACTION_SCRIPT_XSSFILTER = 0x00001409;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_NAVIGATE"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_NAVIGATE 0x0000140A")]
    public const int URLACTION_SCRIPT_NAVIGATE = 0x0000140A;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_PLUGGABLE_PROTOCOL_XHR"]/*' />
    [NativeTypeName("#define URLACTION_PLUGGABLE_PROTOCOL_XHR 0x0000140B")]
    public const int URLACTION_PLUGGABLE_PROTOCOL_XHR = 0x0000140B;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_VBSCRIPT_IE"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_VBSCRIPT_IE 0x0000140C")]
    public const int URLACTION_ALLOW_VBSCRIPT_IE = 0x0000140C;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_JSCRIPT_IE"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_JSCRIPT_IE 0x0000140D")]
    public const int URLACTION_ALLOW_JSCRIPT_IE = 0x0000140D;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_CURR_MAX 0x0000140D")]
    public const int URLACTION_SCRIPT_CURR_MAX = 0x0000140D;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SCRIPT_MAX"]/*' />
    [NativeTypeName("#define URLACTION_SCRIPT_MAX 0x000015ff")]
    public const int URLACTION_SCRIPT_MAX = 0x000015ff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_MIN"]/*' />
    [NativeTypeName("#define URLACTION_HTML_MIN 0x00001600")]
    public const int URLACTION_HTML_MIN = 0x00001600;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_SUBMIT_FORMS"]/*' />
    [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS 0x00001601")]
    public const int URLACTION_HTML_SUBMIT_FORMS = 0x00001601;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_SUBMIT_FORMS_FROM"]/*' />
    [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_FROM 0x00001602")]
    public const int URLACTION_HTML_SUBMIT_FORMS_FROM = 0x00001602;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_SUBMIT_FORMS_TO"]/*' />
    [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_TO 0x00001603")]
    public const int URLACTION_HTML_SUBMIT_FORMS_TO = 0x00001603;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_FONT_DOWNLOAD"]/*' />
    [NativeTypeName("#define URLACTION_HTML_FONT_DOWNLOAD 0x00001604")]
    public const int URLACTION_HTML_FONT_DOWNLOAD = 0x00001604;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_JAVA_RUN"]/*' />
    [NativeTypeName("#define URLACTION_HTML_JAVA_RUN 0x00001605")]
    public const int URLACTION_HTML_JAVA_RUN = 0x00001605;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_USERDATA_SAVE"]/*' />
    [NativeTypeName("#define URLACTION_HTML_USERDATA_SAVE 0x00001606")]
    public const int URLACTION_HTML_USERDATA_SAVE = 0x00001606;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_SUBFRAME_NAVIGATE"]/*' />
    [NativeTypeName("#define URLACTION_HTML_SUBFRAME_NAVIGATE 0x00001607")]
    public const int URLACTION_HTML_SUBFRAME_NAVIGATE = 0x00001607;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_META_REFRESH"]/*' />
    [NativeTypeName("#define URLACTION_HTML_META_REFRESH 0x00001608")]
    public const int URLACTION_HTML_META_REFRESH = 0x00001608;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_MIXED_CONTENT"]/*' />
    [NativeTypeName("#define URLACTION_HTML_MIXED_CONTENT 0x00001609")]
    public const int URLACTION_HTML_MIXED_CONTENT = 0x00001609;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_INCLUDE_FILE_PATH"]/*' />
    [NativeTypeName("#define URLACTION_HTML_INCLUDE_FILE_PATH 0x0000160A")]
    public const int URLACTION_HTML_INCLUDE_FILE_PATH = 0x0000160A;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML"]/*' />
    [NativeTypeName("#define URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML 0x0000160B")]
    public const int URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML = 0x0000160B;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE"]/*' />
    [NativeTypeName("#define URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE 0x0000160C")]
    public const int URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE = 0x0000160C;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS"]/*' />
    [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS 0x0000160D")]
    public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS = 0x0000160D;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_ALLOW_WINDOW_CLOSE"]/*' />
    [NativeTypeName("#define URLACTION_HTML_ALLOW_WINDOW_CLOSE 0x0000160E")]
    public const int URLACTION_HTML_ALLOW_WINDOW_CLOSE = 0x0000160E;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER"]/*' />
    [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER 0x0000160F")]
    public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER = 0x0000160F;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK"]/*' />
    [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK 0x00001610")]
    public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK = 0x00001610;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_ALLOW_INDEXEDDB"]/*' />
    [NativeTypeName("#define URLACTION_HTML_ALLOW_INDEXEDDB 0x00001611")]
    public const int URLACTION_HTML_ALLOW_INDEXEDDB = 0x00001611;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_HTML_MAX"]/*' />
    [NativeTypeName("#define URLACTION_HTML_MAX 0x000017ff")]
    public const int URLACTION_HTML_MAX = 0x000017ff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_MIN"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_MIN 0x00001800")]
    public const int URLACTION_SHELL_MIN = 0x00001800;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_INSTALL_DTITEMS"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_INSTALL_DTITEMS 0x00001800")]
    public const int URLACTION_SHELL_INSTALL_DTITEMS = 0x00001800;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_MOVE_OR_COPY"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_MOVE_OR_COPY 0x00001802")]
    public const int URLACTION_SHELL_MOVE_OR_COPY = 0x00001802;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_FILE_DOWNLOAD"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_FILE_DOWNLOAD 0x00001803")]
    public const int URLACTION_SHELL_FILE_DOWNLOAD = 0x00001803;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_VERB"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_VERB 0x00001804")]
    public const int URLACTION_SHELL_VERB = 0x00001804;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_WEBVIEW_VERB"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_WEBVIEW_VERB 0x00001805")]
    public const int URLACTION_SHELL_WEBVIEW_VERB = 0x00001805;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_SHELLEXECUTE"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_SHELLEXECUTE 0x00001806")]
    public const int URLACTION_SHELL_SHELLEXECUTE = 0x00001806;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_EXECUTE_HIGHRISK"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_EXECUTE_HIGHRISK 0x00001806")]
    public const int URLACTION_SHELL_EXECUTE_HIGHRISK = 0x00001806;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_EXECUTE_MODRISK"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_EXECUTE_MODRISK 0x00001807")]
    public const int URLACTION_SHELL_EXECUTE_MODRISK = 0x00001807;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_EXECUTE_LOWRISK"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_EXECUTE_LOWRISK 0x00001808")]
    public const int URLACTION_SHELL_EXECUTE_LOWRISK = 0x00001808;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_POPUPMGR"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_POPUPMGR 0x00001809")]
    public const int URLACTION_SHELL_POPUPMGR = 0x00001809;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_RTF_OBJECTS_LOAD"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_RTF_OBJECTS_LOAD 0x0000180A")]
    public const int URLACTION_SHELL_RTF_OBJECTS_LOAD = 0x0000180A;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY 0x0000180B")]
    public const int URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY = 0x0000180B;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_EXTENSIONSECURITY"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_EXTENSIONSECURITY 0x0000180C")]
    public const int URLACTION_SHELL_EXTENSIONSECURITY = 0x0000180C;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_SECURE_DRAGSOURCE"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_SECURE_DRAGSOURCE 0x0000180D")]
    public const int URLACTION_SHELL_SECURE_DRAGSOURCE = 0x0000180D;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_REMOTEQUERY"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_REMOTEQUERY 0x0000180E")]
    public const int URLACTION_SHELL_REMOTEQUERY = 0x0000180E;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_PREVIEW"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_PREVIEW 0x0000180F")]
    public const int URLACTION_SHELL_PREVIEW = 0x0000180F;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_SHARE"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_SHARE 0x00001810")]
    public const int URLACTION_SHELL_SHARE = 0x00001810;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE 0x00001811")]
    public const int URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE = 0x00001811;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_TOCTOU_RISK"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_TOCTOU_RISK 0x00001812")]
    public const int URLACTION_SHELL_TOCTOU_RISK = 0x00001812;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_CURR_MAX 0x00001812")]
    public const int URLACTION_SHELL_CURR_MAX = 0x00001812;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_SHELL_MAX"]/*' />
    [NativeTypeName("#define URLACTION_SHELL_MAX 0x000019ff")]
    public const int URLACTION_SHELL_MAX = 0x000019ff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_NETWORK_MIN"]/*' />
    [NativeTypeName("#define URLACTION_NETWORK_MIN 0x00001A00")]
    public const int URLACTION_NETWORK_MIN = 0x00001A00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_CREDENTIALS_USE"]/*' />
    [NativeTypeName("#define URLACTION_CREDENTIALS_USE 0x00001A00")]
    public const int URLACTION_CREDENTIALS_USE = 0x00001A00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_AUTHENTICATE_CLIENT"]/*' />
    [NativeTypeName("#define URLACTION_AUTHENTICATE_CLIENT 0x00001A01")]
    public const int URLACTION_AUTHENTICATE_CLIENT = 0x00001A01;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_COOKIES"]/*' />
    [NativeTypeName("#define URLACTION_COOKIES 0x00001A02")]
    public const int URLACTION_COOKIES = 0x00001A02;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_COOKIES_SESSION"]/*' />
    [NativeTypeName("#define URLACTION_COOKIES_SESSION 0x00001A03")]
    public const int URLACTION_COOKIES_SESSION = 0x00001A03;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_CLIENT_CERT_PROMPT"]/*' />
    [NativeTypeName("#define URLACTION_CLIENT_CERT_PROMPT 0x00001A04")]
    public const int URLACTION_CLIENT_CERT_PROMPT = 0x00001A04;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_COOKIES_THIRD_PARTY"]/*' />
    [NativeTypeName("#define URLACTION_COOKIES_THIRD_PARTY 0x00001A05")]
    public const int URLACTION_COOKIES_THIRD_PARTY = 0x00001A05;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_COOKIES_SESSION_THIRD_PARTY"]/*' />
    [NativeTypeName("#define URLACTION_COOKIES_SESSION_THIRD_PARTY 0x00001A06")]
    public const int URLACTION_COOKIES_SESSION_THIRD_PARTY = 0x00001A06;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_COOKIES_ENABLED"]/*' />
    [NativeTypeName("#define URLACTION_COOKIES_ENABLED 0x00001A10")]
    public const int URLACTION_COOKIES_ENABLED = 0x00001A10;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_NETWORK_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_NETWORK_CURR_MAX 0x00001A10")]
    public const int URLACTION_NETWORK_CURR_MAX = 0x00001A10;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_NETWORK_MAX"]/*' />
    [NativeTypeName("#define URLACTION_NETWORK_MAX 0x00001Bff")]
    public const int URLACTION_NETWORK_MAX = 0x00001Bff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_JAVA_MIN"]/*' />
    [NativeTypeName("#define URLACTION_JAVA_MIN 0x00001C00")]
    public const int URLACTION_JAVA_MIN = 0x00001C00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_JAVA_PERMISSIONS"]/*' />
    [NativeTypeName("#define URLACTION_JAVA_PERMISSIONS 0x00001C00")]
    public const int URLACTION_JAVA_PERMISSIONS = 0x00001C00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_JAVA_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_JAVA_CURR_MAX 0x00001C00")]
    public const int URLACTION_JAVA_CURR_MAX = 0x00001C00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_JAVA_MAX"]/*' />
    [NativeTypeName("#define URLACTION_JAVA_MAX 0x00001Cff")]
    public const int URLACTION_JAVA_MAX = 0x00001Cff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_MIN"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_MIN 0x00001D00")]
    public const int URLACTION_INFODELIVERY_MIN = 0x00001D00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_ADDING_CHANNELS"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_CHANNELS 0x00001D00")]
    public const int URLACTION_INFODELIVERY_NO_ADDING_CHANNELS = 0x00001D00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_EDITING_CHANNELS"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_CHANNELS 0x00001D01")]
    public const int URLACTION_INFODELIVERY_NO_EDITING_CHANNELS = 0x00001D01;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS 0x00001D02")]
    public const int URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS = 0x00001D02;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS 0x00001D03")]
    public const int URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS = 0x00001D03;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS 0x00001D04")]
    public const int URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS = 0x00001D04;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS 0x00001D05")]
    public const int URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS = 0x00001D05;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING 0x00001D06")]
    public const int URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING = 0x00001D06;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_CURR_MAX"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_CURR_MAX 0x00001D06")]
    public const int URLACTION_INFODELIVERY_CURR_MAX = 0x00001D06;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INFODELIVERY_MAX"]/*' />
    [NativeTypeName("#define URLACTION_INFODELIVERY_MAX 0x00001Dff")]
    public const int URLACTION_INFODELIVERY_MAX = 0x00001Dff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_CHANNEL_SOFTDIST_MIN"]/*' />
    [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MIN 0x00001E00")]
    public const int URLACTION_CHANNEL_SOFTDIST_MIN = 0x00001E00;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_CHANNEL_SOFTDIST_PERMISSIONS"]/*' />
    [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_PERMISSIONS 0x00001E05")]
    public const int URLACTION_CHANNEL_SOFTDIST_PERMISSIONS = 0x00001E05;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_CHANNEL_SOFTDIST_MAX"]/*' />
    [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MAX 0x00001Eff")]
    public const int URLACTION_CHANNEL_SOFTDIST_MAX = 0x00001Eff;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_DOTNET_USERCONTROLS"]/*' />
    [NativeTypeName("#define URLACTION_DOTNET_USERCONTROLS 0x00002005")]
    public const int URLACTION_DOTNET_USERCONTROLS = 0x00002005;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_BEHAVIOR_MIN"]/*' />
    [NativeTypeName("#define URLACTION_BEHAVIOR_MIN 0x00002000")]
    public const int URLACTION_BEHAVIOR_MIN = 0x00002000;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_BEHAVIOR_RUN"]/*' />
    [NativeTypeName("#define URLACTION_BEHAVIOR_RUN 0x00002000")]
    public const int URLACTION_BEHAVIOR_RUN = 0x00002000;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_MIN"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_MIN 0x00002100")]
    public const int URLACTION_FEATURE_MIN = 0x00002100;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_MIME_SNIFFING"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_MIME_SNIFFING 0x00002100")]
    public const int URLACTION_FEATURE_MIME_SNIFFING = 0x00002100;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_ZONE_ELEVATION"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_ZONE_ELEVATION 0x00002101")]
    public const int URLACTION_FEATURE_ZONE_ELEVATION = 0x00002101;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_WINDOW_RESTRICTIONS"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_WINDOW_RESTRICTIONS 0x00002102")]
    public const int URLACTION_FEATURE_WINDOW_RESTRICTIONS = 0x00002102;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_SCRIPT_STATUS_BAR"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_SCRIPT_STATUS_BAR 0x00002103")]
    public const int URLACTION_FEATURE_SCRIPT_STATUS_BAR = 0x00002103;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_FORCE_ADDR_AND_STATUS"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_FORCE_ADDR_AND_STATUS 0x00002104")]
    public const int URLACTION_FEATURE_FORCE_ADDR_AND_STATUS = 0x00002104;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_BLOCK_INPUT_PROMPTS"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_BLOCK_INPUT_PROMPTS 0x00002105")]
    public const int URLACTION_FEATURE_BLOCK_INPUT_PROMPTS = 0x00002105;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_DATA_BINDING"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_DATA_BINDING 0x00002106")]
    public const int URLACTION_FEATURE_DATA_BINDING = 0x00002106;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE"]/*' />
    [NativeTypeName("#define URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE 0x00002107")]
    public const int URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE = 0x00002107;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN"]/*' />
    [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN 0x00002200")]
    public const int URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN = 0x00002200;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_AUTOMATIC_DOWNLOAD_UI"]/*' />
    [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI 0x00002200")]
    public const int URLACTION_AUTOMATIC_DOWNLOAD_UI = 0x00002200;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_AUTOMATIC_ACTIVEX_UI"]/*' />
    [NativeTypeName("#define URLACTION_AUTOMATIC_ACTIVEX_UI 0x00002201")]
    public const int URLACTION_AUTOMATIC_ACTIVEX_UI = 0x00002201;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_RESTRICTEDPROTOCOLS"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_RESTRICTEDPROTOCOLS 0x00002300")]
    public const int URLACTION_ALLOW_RESTRICTEDPROTOCOLS = 0x00002300;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_APEVALUATION"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_APEVALUATION 0x00002301")]
    public const int URLACTION_ALLOW_APEVALUATION = 0x00002301;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_XHR_EVALUATION"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_XHR_EVALUATION 0x00002302")]
    public const int URLACTION_ALLOW_XHR_EVALUATION = 0x00002302;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_WINDOWS_BROWSER_APPLICATIONS"]/*' />
    [NativeTypeName("#define URLACTION_WINDOWS_BROWSER_APPLICATIONS 0x00002400")]
    public const int URLACTION_WINDOWS_BROWSER_APPLICATIONS = 0x00002400;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_XPS_DOCUMENTS"]/*' />
    [NativeTypeName("#define URLACTION_XPS_DOCUMENTS 0x00002401")]
    public const int URLACTION_XPS_DOCUMENTS = 0x00002401;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_LOOSE_XAML"]/*' />
    [NativeTypeName("#define URLACTION_LOOSE_XAML 0x00002402")]
    public const int URLACTION_LOOSE_XAML = 0x00002402;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_LOWRIGHTS"]/*' />
    [NativeTypeName("#define URLACTION_LOWRIGHTS 0x00002500")]
    public const int URLACTION_LOWRIGHTS = 0x00002500;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_WINFX_SETUP"]/*' />
    [NativeTypeName("#define URLACTION_WINFX_SETUP 0x00002600")]
    public const int URLACTION_WINFX_SETUP = 0x00002600;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_INPRIVATE_BLOCKING"]/*' />
    [NativeTypeName("#define URLACTION_INPRIVATE_BLOCKING 0x00002700")]
    public const int URLACTION_INPRIVATE_BLOCKING = 0x00002700;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_AUDIO_VIDEO"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO 0x00002701")]
    public const int URLACTION_ALLOW_AUDIO_VIDEO = 0x00002701;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_ACTIVEX_FILTERING"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_ACTIVEX_FILTERING 0x00002702")]
    public const int URLACTION_ALLOW_ACTIVEX_FILTERING = 0x00002702;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING 0x00002703")]
    public const int URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING = 0x00002703;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS 0x00002704")]
    public const int URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS = 0x00002704;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT 0x00002705")]
    public const int URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT = 0x00002705;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION 0x00002706")]
    public const int URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION = 0x00002706;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW 0x00002708")]
    public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW = 0x00002708;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS 0x00002709")]
    public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS = 0x00002709;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST 0x0000270A")]
    public const int URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST = 0x0000270A;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS 0x0000270B")]
    public const int URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS = 0x0000270B;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX 0x0000270C")]
    public const int URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX = 0x0000270C;

    /// <include file='URLACTION.xml' path='doc/member[@name="URLACTION.URLACTION_ALLOW_CSS_EXPRESSIONS"]/*' />
    [NativeTypeName("#define URLACTION_ALLOW_CSS_EXPRESSIONS 0x0000270D")]
    public const int URLACTION_ALLOW_CSS_EXPRESSIONS = 0x0000270D;
}
