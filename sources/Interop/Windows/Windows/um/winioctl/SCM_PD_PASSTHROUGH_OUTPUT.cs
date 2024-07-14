// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT"]/*' />
public partial struct SCM_PD_PASSTHROUGH_OUTPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.ProtocolGuid"]/*' />
    public Guid ProtocolGuid;

    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.DataSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataSize;

    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.Data"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    public partial struct _Data_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
