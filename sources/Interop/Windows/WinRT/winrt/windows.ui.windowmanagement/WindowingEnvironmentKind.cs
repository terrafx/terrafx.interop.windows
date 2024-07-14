// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WindowingEnvironmentKind.xml' path='doc/member[@name="WindowingEnvironmentKind"]/*' />
public enum WindowingEnvironmentKind
{
    /// <include file='WindowingEnvironmentKind.xml' path='doc/member[@name="WindowingEnvironmentKind.WindowingEnvironmentKind_Unknown"]/*' />
    WindowingEnvironmentKind_Unknown = 0,

    /// <include file='WindowingEnvironmentKind.xml' path='doc/member[@name="WindowingEnvironmentKind.WindowingEnvironmentKind_Overlapped"]/*' />
    WindowingEnvironmentKind_Overlapped = 1,

    /// <include file='WindowingEnvironmentKind.xml' path='doc/member[@name="WindowingEnvironmentKind.WindowingEnvironmentKind_Tiled"]/*' />
    WindowingEnvironmentKind_Tiled = 2,
}
