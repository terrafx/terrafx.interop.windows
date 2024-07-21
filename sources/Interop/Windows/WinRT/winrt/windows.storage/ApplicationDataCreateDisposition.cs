// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationDataCreateDisposition.xml' path='doc/member[@name="ApplicationDataCreateDisposition"]/*' />
public enum ApplicationDataCreateDisposition
{
    /// <include file='ApplicationDataCreateDisposition.xml' path='doc/member[@name="ApplicationDataCreateDisposition.ApplicationDataCreateDisposition_Always"]/*' />
    ApplicationDataCreateDisposition_Always = 0,

    /// <include file='ApplicationDataCreateDisposition.xml' path='doc/member[@name="ApplicationDataCreateDisposition.ApplicationDataCreateDisposition_Existing"]/*' />
    ApplicationDataCreateDisposition_Existing = 1,
}
