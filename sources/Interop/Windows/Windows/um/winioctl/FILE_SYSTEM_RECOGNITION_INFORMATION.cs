// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_SYSTEM_RECOGNITION_INFORMATION.xml' path='doc/member[@name="FILE_SYSTEM_RECOGNITION_INFORMATION"]/*' />
public partial struct FILE_SYSTEM_RECOGNITION_INFORMATION
{
    /// <include file='FILE_SYSTEM_RECOGNITION_INFORMATION.xml' path='doc/member[@name="FILE_SYSTEM_RECOGNITION_INFORMATION.FileSystem"]/*' />
    [NativeTypeName("CHAR[9]")]
    public _FileSystem_e__FixedBuffer FileSystem;

    /// <include file='_FileSystem_e__FixedBuffer.xml' path='doc/member[@name="_FileSystem_e__FixedBuffer"]/*' />
    [InlineArray(9)]
    public partial struct _FileSystem_e__FixedBuffer
    {
        public sbyte e0;
    }
}
