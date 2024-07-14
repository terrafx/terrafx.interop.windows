// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAuthenticationOptions.xml' path='doc/member[@name="WebAuthenticationOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum WebAuthenticationOptions : uint
{
    /// <include file='WebAuthenticationOptions.xml' path='doc/member[@name="WebAuthenticationOptions.WebAuthenticationOptions_None"]/*' />
    WebAuthenticationOptions_None = 0,

    /// <include file='WebAuthenticationOptions.xml' path='doc/member[@name="WebAuthenticationOptions.WebAuthenticationOptions_SilentMode"]/*' />
    WebAuthenticationOptions_SilentMode = 0x1,

    /// <include file='WebAuthenticationOptions.xml' path='doc/member[@name="WebAuthenticationOptions.WebAuthenticationOptions_UseTitle"]/*' />
    WebAuthenticationOptions_UseTitle = 0x2,

    /// <include file='WebAuthenticationOptions.xml' path='doc/member[@name="WebAuthenticationOptions.WebAuthenticationOptions_UseHttpPost"]/*' />
    WebAuthenticationOptions_UseHttpPost = 0x4,

    /// <include file='WebAuthenticationOptions.xml' path='doc/member[@name="WebAuthenticationOptions.WebAuthenticationOptions_UseCorporateNetwork"]/*' />
    WebAuthenticationOptions_UseCorporateNetwork = 0x8,
}
