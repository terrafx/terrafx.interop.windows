// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FILE_ID_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        public FILE_ID_TYPE Type;

        [NativeTypeName("FILE_ID_DESCRIPTOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:9164:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref LARGE_INTEGER FileId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FileId, 1));
            }
        }

        public ref Guid ObjectId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ObjectId, 1));
            }
        }

        public ref FILE_ID_128 ExtendedFileId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ExtendedFileId, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public LARGE_INTEGER FileId;

            [FieldOffset(0)]
            [NativeTypeName("GUID")]
            public Guid ObjectId;

            [FieldOffset(0)]
            public FILE_ID_128 ExtendedFileId;
        }
    }
}
