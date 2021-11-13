// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ks.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct KSDATAFORMAT
    {
        [FieldOffset(0)]
        [NativeTypeName("KSDATAFORMAT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ks.h:1096:5)")]
        internal _Anonymous_e__Struct Anonymous;

        public ref uint FormatSize => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FormatSize, 1));

        public ref uint Flags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));

        public ref uint SampleSize => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SampleSize, 1));

        public ref uint Reserved => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Reserved, 1));

        public ref Guid MajorFormat => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.MajorFormat, 1));

        public ref Guid SubFormat => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SubFormat, 1));

        public ref Guid Specifier => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Specifier, 1));

        [FieldOffset(0)]
        [NativeTypeName("LONGLONG")]
        public long Alignment;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint FormatSize;

            [NativeTypeName("ULONG")]
            public uint Flags;

            [NativeTypeName("ULONG")]
            public uint SampleSize;

            [NativeTypeName("ULONG")]
            public uint Reserved;

            public Guid MajorFormat;

            public Guid SubFormat;

            public Guid Specifier;
        }
    }
}
