// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRIVERSTATUS
{
    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.bDriverError"]/*' />
    public byte bDriverError;

    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.bIDEError"]/*' />
    public byte bIDEError;

    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.bReserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _bReserved_e__FixedBuffer bReserved;

    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.dwReserved"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _dwReserved_e__FixedBuffer dwReserved;

    /// <include file='_bReserved_e__FixedBuffer.xml' path='doc/member[@name="_bReserved_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(2)]
    public partial struct _bReserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_dwReserved_e__FixedBuffer.xml' path='doc/member[@name="_dwReserved_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(2)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public uint e0;
    }
}
