// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_INF_INFORMATION.xml' path='doc/member[@name="SP_INF_INFORMATION"]/*' />
public partial struct SP_INF_INFORMATION
{
    /// <include file='SP_INF_INFORMATION.xml' path='doc/member[@name="SP_INF_INFORMATION.InfStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint InfStyle;

    /// <include file='SP_INF_INFORMATION.xml' path='doc/member[@name="SP_INF_INFORMATION.InfCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint InfCount;

    /// <include file='SP_INF_INFORMATION.xml' path='doc/member[@name="SP_INF_INFORMATION.VersionData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _VersionData_e__FixedBuffer VersionData;

    /// <include file='_VersionData_e__FixedBuffer.xml' path='doc/member[@name="_VersionData_e__FixedBuffer"]/*' />
    public partial struct _VersionData_e__FixedBuffer
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
