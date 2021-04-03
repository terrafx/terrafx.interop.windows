// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("058D1F11-2A54-4BEF-BD54-DF706626B727")]
    [NativeTypeName("struct IVMRVideoStreamControl : IUnknown")]
    public unsafe partial struct IVMRVideoStreamControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, uint>)(lpVtbl[1]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, uint>)(lpVtbl[2]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* lpClrKey)
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, DDCOLORKEY*, int>)(lpVtbl[3]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), lpClrKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* lpClrKey)
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, DDCOLORKEY*, int>)(lpVtbl[4]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), lpClrKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamActiveState([NativeTypeName("BOOL")] int fActive)
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, int, int>)(lpVtbl[5]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), fActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamActiveState([NativeTypeName("BOOL *")] int* lpfActive)
        {
            return ((delegate* unmanaged<IVMRVideoStreamControl*, int*, int>)(lpVtbl[6]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), lpfActive);
        }
    }
}
