// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON"]/*' />
public partial struct THUMBBUTTON
{
    /// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON.dwMask"]/*' />
    public THUMBBUTTONMASK dwMask;

    /// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON.iId"]/*' />
    public uint iId;

    /// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON.iBitmap"]/*' />
    public uint iBitmap;

    /// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON.szTip"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szTip_e__FixedBuffer szTip;

    /// <include file='THUMBBUTTON.xml' path='doc/member[@name="THUMBBUTTON.dwFlags"]/*' />
    public THUMBBUTTONFLAGS dwFlags;

    /// <include file='_szTip_e__FixedBuffer.xml' path='doc/member[@name="_szTip_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szTip_e__FixedBuffer
    {
        public char e0;
    }
}
