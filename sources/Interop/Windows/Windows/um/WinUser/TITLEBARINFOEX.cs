// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX"]/*' />
public partial struct TITLEBARINFOEX
{
    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.rcTitleBar"]/*' />
    public RECT rcTitleBar;

    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.rgstate"]/*' />
    [NativeTypeName("DWORD[6]")]
    public _rgstate_e__FixedBuffer rgstate;

    /// <include file='TITLEBARINFOEX.xml' path='doc/member[@name="TITLEBARINFOEX.rgrect"]/*' />
    [NativeTypeName("RECT[6]")]
    public _rgrect_e__FixedBuffer rgrect;

    /// <include file='_rgstate_e__FixedBuffer.xml' path='doc/member[@name="_rgstate_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _rgstate_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_rgrect_e__FixedBuffer.xml' path='doc/member[@name="_rgrect_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _rgrect_e__FixedBuffer
    {
        public RECT e0;
    }
}
