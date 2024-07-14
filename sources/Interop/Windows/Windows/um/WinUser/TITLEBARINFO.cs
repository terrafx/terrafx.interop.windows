// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO"]/*' />
public partial struct TITLEBARINFO
{
    /// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO.rcTitleBar"]/*' />
    public RECT rcTitleBar;

    /// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO.rgstate"]/*' />
    [NativeTypeName("DWORD[6]")]
    public _rgstate_e__FixedBuffer rgstate;

    /// <include file='_rgstate_e__FixedBuffer.xml' path='doc/member[@name="_rgstate_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _rgstate_e__FixedBuffer
    {
        public uint e0;
    }
}
