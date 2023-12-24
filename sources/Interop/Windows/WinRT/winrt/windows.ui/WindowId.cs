// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WindowId.xml' path='doc/member[@name="WindowId"]/*' />
public partial struct WindowId
{
    /// <include file='WindowId.xml' path='doc/member[@name="WindowId.Value"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Value;
}
