// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FSCTL_QUERY_FAT_BPB_BUFFER.xml' path='doc/member[@name="FSCTL_QUERY_FAT_BPB_BUFFER"]/*' />
public partial struct FSCTL_QUERY_FAT_BPB_BUFFER
{
    /// <include file='FSCTL_QUERY_FAT_BPB_BUFFER.xml' path='doc/member[@name="FSCTL_QUERY_FAT_BPB_BUFFER.First0x24BytesOfBootSector"]/*' />
    [NativeTypeName("BYTE[36]")]
    public _First0x24BytesOfBootSector_e__FixedBuffer First0x24BytesOfBootSector;

    /// <include file='_First0x24BytesOfBootSector_e__FixedBuffer.xml' path='doc/member[@name="_First0x24BytesOfBootSector_e__FixedBuffer"]/*' />
    [InlineArray(36)]
    public partial struct _First0x24BytesOfBootSector_e__FixedBuffer
    {
        public byte e0;
    }
}
