// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("025D1823-6C7D-447B-BBDB-A3CBC3DFA2FC")]
    [NativeTypeName("struct IImageBytes : IUnknown")]
    public unsafe partial struct IImageBytes
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IImageBytes*, Guid*, void**, int>)(lpVtbl[0]))((IImageBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageBytes*, uint>)(lpVtbl[1]))((IImageBytes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageBytes*, uint>)(lpVtbl[2]))((IImageBytes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CountBytes([NativeTypeName("UINT *")] uint* pcb)
        {
            return ((delegate* unmanaged<IImageBytes*, uint*, int>)(lpVtbl[3]))((IImageBytes*)Unsafe.AsPointer(ref this), pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockBytes([NativeTypeName("UINT")] uint cb, [NativeTypeName("ULONG")] uint ulOffset, [NativeTypeName("const void **")] void** ppvBytes)
        {
            return ((delegate* unmanaged<IImageBytes*, uint, uint, void**, int>)(lpVtbl[4]))((IImageBytes*)Unsafe.AsPointer(ref this), cb, ulOffset, ppvBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockBytes([NativeTypeName("const void *")] void* pvBytes, [NativeTypeName("UINT")] uint cb, [NativeTypeName("ULONG")] uint ulOffset)
        {
            return ((delegate* unmanaged<IImageBytes*, void*, uint, uint, int>)(lpVtbl[5]))((IImageBytes*)Unsafe.AsPointer(ref this), pvBytes, cb, ulOffset);
        }
    }
}
