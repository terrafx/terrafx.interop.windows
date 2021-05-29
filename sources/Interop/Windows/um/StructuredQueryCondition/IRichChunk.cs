// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4FDEF69C-DBC9-454E-9910-B34F3C64B510")]
    [NativeTypeName("struct IRichChunk : IUnknown")]
    public unsafe partial struct IRichChunk
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRichChunk*, Guid*, void**, int>)(lpVtbl[0]))((IRichChunk*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRichChunk*, uint>)(lpVtbl[1]))((IRichChunk*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRichChunk*, uint>)(lpVtbl[2]))((IRichChunk*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("ULONG *")] uint* pFirstPos, [NativeTypeName("ULONG *")] uint* pLength, [NativeTypeName("LPWSTR *")] ushort** ppsz, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IRichChunk*, uint*, uint*, ushort**, PROPVARIANT*, int>)(lpVtbl[3]))((IRichChunk*)Unsafe.AsPointer(ref this), pFirstPos, pLength, ppsz, pValue);
        }
    }
}
