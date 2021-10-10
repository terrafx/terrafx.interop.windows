// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E673275-0257-40AA-AF20-7C608D4A0428")]
    [NativeTypeName("struct IVMRMixerBitmap : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRMixerBitmap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRMixerBitmap*, Guid*, void**, int>)(lpVtbl[0]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRMixerBitmap*, uint>)(lpVtbl[1]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRMixerBitmap*, uint>)(lpVtbl[2]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaBitmap([NativeTypeName("const VMRALPHABITMAP *")] VMRALPHABITMAP* pBmpParms)
        {
            return ((delegate* unmanaged<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[3]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms)
        {
            return ((delegate* unmanaged<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[4]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms)
        {
            return ((delegate* unmanaged<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[5]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
        }
    }
}
