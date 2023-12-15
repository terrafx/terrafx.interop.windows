// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO"]/*' />
public partial struct FS_BPIO_INFO
{
    /// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO.ActiveBypassIoCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ActiveBypassIoCount;

    /// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO.StorageDriverNameLen"]/*' />
    [NativeTypeName("WORD")]
    public ushort StorageDriverNameLen;

    /// <include file='FS_BPIO_INFO.xml' path='doc/member[@name="FS_BPIO_INFO.StorageDriverName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _StorageDriverName_e__FixedBuffer StorageDriverName;

    /// <include file='_StorageDriverName_e__FixedBuffer.xml' path='doc/member[@name="_StorageDriverName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _StorageDriverName_e__FixedBuffer
    {
        public char e0;
    }
}
