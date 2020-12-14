// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISK_CACHE_INFORMATION
    {
        [NativeTypeName("BOOLEAN")]
        public byte ParametersSavable;

        [NativeTypeName("BOOLEAN")]
        public byte ReadCacheEnabled;

        [NativeTypeName("BOOLEAN")]
        public byte WriteCacheEnabled;

        public DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority;

        public DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority;

        [NativeTypeName("WORD")]
        public ushort DisablePrefetchTransferLength;

        [NativeTypeName("BOOLEAN")]
        public byte PrefetchScalar;

        [NativeTypeName("_DISK_CACHE_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8796:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._ScalarPrefetch_e__Struct ScalarPrefetch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ScalarPrefetch, 1));
            }
        }

        public ref _Anonymous_e__Union._BlockPrefetch_e__Struct BlockPrefetch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.BlockPrefetch, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8797:9)")]
            public _ScalarPrefetch_e__Struct ScalarPrefetch;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8809:9)")]
            public _BlockPrefetch_e__Struct BlockPrefetch;

            public partial struct _ScalarPrefetch_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort Minimum;

                [NativeTypeName("WORD")]
                public ushort Maximum;

                [NativeTypeName("WORD")]
                public ushort MaximumBlocks;
            }

            public partial struct _BlockPrefetch_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort Minimum;

                [NativeTypeName("WORD")]
                public ushort Maximum;
            }
        }
    }
}
