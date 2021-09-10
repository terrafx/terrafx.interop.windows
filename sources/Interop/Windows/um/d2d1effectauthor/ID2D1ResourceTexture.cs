// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("688D15C3-02B0-438D-B13A-D1B44C32C39A")]
    [NativeTypeName("struct ID2D1ResourceTexture : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID2D1ResourceTexture
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1ResourceTexture*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1ResourceTexture*, uint>)(lpVtbl[1]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1ResourceTexture*, uint>)(lpVtbl[2]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const UINT32 *")] uint* minimumExtents, [NativeTypeName("const UINT32 *")] uint* maximimumExtents, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dimensions, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount)
        {
            return ((delegate* unmanaged<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)(lpVtbl[3]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
        }
    }
}
