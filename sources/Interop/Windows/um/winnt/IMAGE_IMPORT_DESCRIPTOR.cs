// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_IMPORT_DESCRIPTOR
    {
        [NativeTypeName("_IMAGE_IMPORT_DESCRIPTOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18247:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Characteristics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Characteristics, 1));
            }
        }

        public ref uint OriginalFirstThunk
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.OriginalFirstThunk, 1));
            }
        }

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint ForwarderChain;

        [NativeTypeName("DWORD")]
        public uint Name;

        [NativeTypeName("DWORD")]
        public uint FirstThunk;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Characteristics;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint OriginalFirstThunk;
        }
    }
}
