// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Web_IUriToStreamResolver"]/*' />
    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Web_IUriToStreamResolver = "Windows.Web.IUriToStreamResolver";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_Web_IWebErrorStatics"]/*' />
    [NativeTypeName("const WCHAR[29]")]
    public const string InterfaceName_Windows_Web_IWebErrorStatics = "Windows.Web.IWebErrorStatics";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_Web_WebError"]/*' />
    [NativeTypeName("const WCHAR[21]")]
    public const string RuntimeClass_Windows_Web_WebError = "Windows.Web.WebError";
}
