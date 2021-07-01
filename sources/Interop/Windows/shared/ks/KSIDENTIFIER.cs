// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ks.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct KSIDENTIFIER
    {
        [NativeTypeName("KSIDENTIFIER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ks.h:107:5)")]
        internal _Anonymous_e__Union Anonymous;

        public ref Guid Set => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Set, 1));

        public ref uint Id => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Id, 1));

        public ref uint Flags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Flags, 1));

        public ref long Alignment => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Alignment, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("KSIDENTIFIER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ks.h:111:9)")]
            internal _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("LONGLONG")]
            public long Alignment;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("GUID")]
                public Guid Set;

                [NativeTypeName("ULONG")]
                public uint Id;

                [NativeTypeName("ULONG")]
                public uint Flags;
            }
        }
    }
}
