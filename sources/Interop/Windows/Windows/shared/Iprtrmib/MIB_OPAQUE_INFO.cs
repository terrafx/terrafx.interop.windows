// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MIB_OPAQUE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwId;

        [NativeTypeName("_MIB_OPAQUE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/Iprtrmib.h:306:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref ulong ullAlign
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ullAlign, 1));
            }
        }

        public Span<byte> rgbyData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.rgbyData[0], 1);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong ullAlign;

            [FieldOffset(0)]
            [NativeTypeName("BYTE [1]")]
            public fixed byte rgbyData[1];
        }
    }
}
