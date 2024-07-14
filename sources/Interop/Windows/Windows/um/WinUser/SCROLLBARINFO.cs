// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO"]/*' />
public partial struct SCROLLBARINFO
{
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.rcScrollBar"]/*' />
    public RECT rcScrollBar;

    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.dxyLineButton"]/*' />
    public int dxyLineButton;

    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.xyThumbTop"]/*' />
    public int xyThumbTop;

    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.xyThumbBottom"]/*' />
    public int xyThumbBottom;

    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.reserved"]/*' />
    public int reserved;

    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.rgstate"]/*' />
    [NativeTypeName("DWORD[6]")]
    public _rgstate_e__FixedBuffer rgstate;

    /// <include file='_rgstate_e__FixedBuffer.xml' path='doc/member[@name="_rgstate_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _rgstate_e__FixedBuffer
    {
        public uint e0;
    }
}
