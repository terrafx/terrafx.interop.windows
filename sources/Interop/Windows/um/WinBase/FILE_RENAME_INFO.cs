// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct FILE_RENAME_INFO
    {
        [NativeTypeName("_FILE_RENAME_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinBase.h:8853:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("HANDLE")]
        public IntPtr RootDirectory;

        [NativeTypeName("DWORD")]
        public uint FileNameLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];

        public ref byte ReplaceIfExists
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ReplaceIfExists, 1));
            }
        }

        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("BOOLEAN")]
            public byte ReplaceIfExists;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;
        }
    }
}
