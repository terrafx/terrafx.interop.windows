// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_BUFFER_SRV
    {
        [NativeTypeName("D3D11_BUFFER_SRV::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:3293:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public ref uint FirstElement => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.FirstElement, 1));

        public ref uint ElementOffset => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.ElementOffset, 1));

        [NativeTypeName("D3D11_BUFFER_SRV::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:3298:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref uint NumElements => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.NumElements, 1));

        public ref uint ElementWidth => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.ElementWidth, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint FirstElement;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint ElementOffset;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint NumElements;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint ElementWidth;
        }
    }
}
