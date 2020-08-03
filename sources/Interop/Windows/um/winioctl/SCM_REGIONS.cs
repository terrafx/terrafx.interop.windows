// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCM_REGIONS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint RegionCount;

        [NativeTypeName("SCM_REGION [1]")]
        public _Regions_e__FixedBuffer Regions;

        public partial struct _Regions_e__FixedBuffer
        {
            public SCM_REGION e0;

            public ref SCM_REGION this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<SCM_REGION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
