// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3D12_RANGE
    {
        [NativeTypeName("SIZE_T")]
        public UIntPtr Begin;

        [NativeTypeName("SIZE_T")]
        public UIntPtr End;

        public D3D12_RANGE(UIntPtr begin, UIntPtr end)
        {
            Begin = begin;
            End = end;
        }
    }
}
