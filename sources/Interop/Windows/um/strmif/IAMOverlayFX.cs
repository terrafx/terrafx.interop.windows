// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62FAE250-7E65-4460-BFC9-6398B322073C")]
    [NativeTypeName("struct IAMOverlayFX : IUnknown")]
    public unsafe partial struct IAMOverlayFX
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMOverlayFX*, Guid*, void**, int>)(lpVtbl[0]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMOverlayFX*, uint>)(lpVtbl[1]))((IAMOverlayFX*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMOverlayFX*, uint>)(lpVtbl[2]))((IAMOverlayFX*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryOverlayFXCaps([NativeTypeName("DWORD *")] uint* lpdwOverlayFXCaps)
        {
            return ((delegate* stdcall<IAMOverlayFX*, uint*, int>)(lpVtbl[3]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), lpdwOverlayFXCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayFX([NativeTypeName("DWORD")] uint dwOverlayFX)
        {
            return ((delegate* stdcall<IAMOverlayFX*, uint, int>)(lpVtbl[4]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), dwOverlayFX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayFX([NativeTypeName("DWORD *")] uint* lpdwOverlayFX)
        {
            return ((delegate* stdcall<IAMOverlayFX*, uint*, int>)(lpVtbl[5]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), lpdwOverlayFX);
        }
    }
}
