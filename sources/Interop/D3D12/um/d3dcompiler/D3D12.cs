// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcompiler.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3DCompiler;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D12
    {
        public static int D3D12ReflectLibrary(void* pSrcData, UIntPtr SrcDataSize, ID3D12LibraryReflection** ppReflector)
        {
            var iid = IID_ID3D12LibraryReflection;
            return D3DReflectLibrary(pSrcData, SrcDataSize, &iid, (void**)ppReflector);
        }
    }
}
