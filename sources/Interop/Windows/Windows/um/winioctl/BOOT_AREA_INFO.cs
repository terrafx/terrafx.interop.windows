// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='BOOT_AREA_INFO.xml' path='doc/member[@name="BOOT_AREA_INFO"]/*' />
public partial struct BOOT_AREA_INFO
{
    /// <include file='BOOT_AREA_INFO.xml' path='doc/member[@name="BOOT_AREA_INFO.BootSectorCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint BootSectorCount;

    /// <include file='BOOT_AREA_INFO.xml' path='doc/member[@name="BOOT_AREA_INFO.BootSectors"]/*' />
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/include/10.0.26100.0/um/winioctl.h:14321:5)[2]")]
    public _BootSectors_e__FixedBuffer BootSectors;

    /// <include file='_BootSectors_e__Struct.xml' path='doc/member[@name="_BootSectors_e__Struct"]/*' />
    public partial struct _BootSectors_e__Struct
    {
        /// <include file='_BootSectors_e__Struct.xml' path='doc/member[@name="_BootSectors_e__Struct.Offset"]/*' />
        public LARGE_INTEGER Offset;
    }

    /// <include file='_BootSectors_e__FixedBuffer.xml' path='doc/member[@name="_BootSectors_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _BootSectors_e__FixedBuffer
    {
        public _BootSectors_e__Struct e0;
    }
}
