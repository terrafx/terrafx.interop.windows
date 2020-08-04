// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_DEVICE_FAULT_DOMAIN_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NumberOfFaultDomains;

        [NativeTypeName("GUID [1]")]
        public _FaultDomainIds_e__FixedBuffer FaultDomainIds;

        public partial struct _FaultDomainIds_e__FixedBuffer
        {
            public Guid e0;

            public ref Guid this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
