// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationDataLocality.xml' path='doc/member[@name="ApplicationDataLocality"]/*' />
public enum ApplicationDataLocality
{
    /// <include file='ApplicationDataLocality.xml' path='doc/member[@name="ApplicationDataLocality.ApplicationDataLocality_Local"]/*' />
    ApplicationDataLocality_Local = 0,

    /// <include file='ApplicationDataLocality.xml' path='doc/member[@name="ApplicationDataLocality.ApplicationDataLocality_Roaming"]/*' />
    ApplicationDataLocality_Roaming = 1,

    /// <include file='ApplicationDataLocality.xml' path='doc/member[@name="ApplicationDataLocality.ApplicationDataLocality_Temporary"]/*' />
    ApplicationDataLocality_Temporary = 2,

    /// <include file='ApplicationDataLocality.xml' path='doc/member[@name="ApplicationDataLocality.ApplicationDataLocality_LocalCache"]/*' />
    ApplicationDataLocality_LocalCache = 3,

    /// <include file='ApplicationDataLocality.xml' path='doc/member[@name="ApplicationDataLocality.ApplicationDataLocality_SharedLocal"]/*' />
    ApplicationDataLocality_SharedLocal = 4,
}
