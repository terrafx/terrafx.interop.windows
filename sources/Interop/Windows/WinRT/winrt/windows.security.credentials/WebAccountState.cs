// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAccountState.xml' path='doc/member[@name="WebAccountState"]/*' />
public enum WebAccountState
{
    /// <include file='WebAccountState.xml' path='doc/member[@name="WebAccountState.WebAccountState_None"]/*' />
    WebAccountState_None = 0,

    /// <include file='WebAccountState.xml' path='doc/member[@name="WebAccountState.WebAccountState_Connected"]/*' />
    WebAccountState_Connected = 1,

    /// <include file='WebAccountState.xml' path='doc/member[@name="WebAccountState.WebAccountState_Error"]/*' />
    WebAccountState_Error = 2,
}
