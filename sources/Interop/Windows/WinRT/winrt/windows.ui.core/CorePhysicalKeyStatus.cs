// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus"]/*' />
public partial struct CorePhysicalKeyStatus
{
    /// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus.RepeatCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint RepeatCount;

    /// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus.ScanCode"]/*' />
    [NativeTypeName("UINT32")]
    public uint ScanCode;

    /// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus.IsExtendedKey"]/*' />
    [NativeTypeName("boolean")]
    public byte IsExtendedKey;

    /// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus.IsMenuKeyDown"]/*' />
    [NativeTypeName("boolean")]
    public byte IsMenuKeyDown;

    /// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus.WasKeyDown"]/*' />
    [NativeTypeName("boolean")]
    public byte WasKeyDown;

    /// <include file='CorePhysicalKeyStatus.xml' path='doc/member[@name="CorePhysicalKeyStatus.IsKeyReleased"]/*' />
    [NativeTypeName("boolean")]
    public byte IsKeyReleased;
}
