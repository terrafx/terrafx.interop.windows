// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PlaySpeed.xml' path='doc/member[@name="PlaySpeed"]/*' />
public partial struct PlaySpeed
{
    /// <include file='PlaySpeed.xml' path='doc/member[@name="PlaySpeed.Numerator"]/*' />
    [NativeTypeName("INT32")]
    public int Numerator;

    /// <include file='PlaySpeed.xml' path='doc/member[@name="PlaySpeed.Denominator"]/*' />
    [NativeTypeName("UINT32")]
    public uint Denominator;
}
