// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAccountClientViewType.xml' path='doc/member[@name="WebAccountClientViewType"]/*' />
public enum WebAccountClientViewType
{
    /// <include file='WebAccountClientViewType.xml' path='doc/member[@name="WebAccountClientViewType.WebAccountClientViewType_IdOnly"]/*' />
    WebAccountClientViewType_IdOnly = 0,

    /// <include file='WebAccountClientViewType.xml' path='doc/member[@name="WebAccountClientViewType.WebAccountClientViewType_IdAndProperties"]/*' />
    WebAccountClientViewType_IdAndProperties = 1,
}
