// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct TXFS_READ_BACKUP_INFORMATION_OUT
    {
        [NativeTypeName("_TXFS_READ_BACKUP_INFORMATION_OUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:13536:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint BufferLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.BufferLength, 1));
            }
        }

        public Span<byte> Buffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.Buffer[0], 1);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint BufferLength;

            [FieldOffset(0)]
            [NativeTypeName("BYTE [1]")]
            public fixed byte Buffer[1];
        }
    }
}
