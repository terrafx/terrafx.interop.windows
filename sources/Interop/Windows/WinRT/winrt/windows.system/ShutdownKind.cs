// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ShutdownKind.xml' path='doc/member[@name="ShutdownKind"]/*' />
public enum ShutdownKind
{
    /// <include file='ShutdownKind.xml' path='doc/member[@name="ShutdownKind.ShutdownKind_Shutdown"]/*' />
    ShutdownKind_Shutdown = 0,

    /// <include file='ShutdownKind.xml' path='doc/member[@name="ShutdownKind.ShutdownKind_Restart"]/*' />
    ShutdownKind_Restart = 1,
}
