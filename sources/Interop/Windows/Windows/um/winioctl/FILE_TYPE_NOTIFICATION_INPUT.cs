// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_TYPE_NOTIFICATION_INPUT.xml' path='doc/member[@name="FILE_TYPE_NOTIFICATION_INPUT"]/*' />
public partial struct FILE_TYPE_NOTIFICATION_INPUT
{
    /// <include file='FILE_TYPE_NOTIFICATION_INPUT.xml' path='doc/member[@name="FILE_TYPE_NOTIFICATION_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FILE_TYPE_NOTIFICATION_INPUT.xml' path='doc/member[@name="FILE_TYPE_NOTIFICATION_INPUT.NumFileTypeIDs"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumFileTypeIDs;

    /// <include file='FILE_TYPE_NOTIFICATION_INPUT.xml' path='doc/member[@name="FILE_TYPE_NOTIFICATION_INPUT.FileTypeID"]/*' />
    [NativeTypeName("GUID[1]")]
    public _FileTypeID_e__FixedBuffer FileTypeID;

    /// <include file='_FileTypeID_e__FixedBuffer.xml' path='doc/member[@name="_FileTypeID_e__FixedBuffer"]/*' />
    public partial struct _FileTypeID_e__FixedBuffer
    {
        public Guid e0;

        public ref Guid this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
