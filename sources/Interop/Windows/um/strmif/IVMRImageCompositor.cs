// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A4FB5AF-479F-4074-BB40-CE6722E43C82")]
    [NativeTypeName("struct IVMRImageCompositor : IUnknown")]
    public unsafe partial struct IVMRImageCompositor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, uint>)(lpVtbl[1]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, uint>)(lpVtbl[2]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitCompositionTarget([NativeTypeName("IUnknown *")] IUnknown* pD3DDevice, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* pddsRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, IUnknown*, IDirectDrawSurface7*, int>)(lpVtbl[3]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this), pD3DDevice, pddsRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TermCompositionTarget([NativeTypeName("IUnknown *")] IUnknown* pD3DDevice, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* pddsRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, IUnknown*, IDirectDrawSurface7*, int>)(lpVtbl[4]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this), pD3DDevice, pddsRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamMediaType([NativeTypeName("DWORD")] uint dwStrmID, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt, [NativeTypeName("BOOL")] int fTexture)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, uint, AM_MEDIA_TYPE*, int, int>)(lpVtbl[5]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this), dwStrmID, pmt, fTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompositeImage([NativeTypeName("IUnknown *")] IUnknown* pD3DDevice, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* pddsRenderTarget, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtRenderTarget, [NativeTypeName("REFERENCE_TIME")] long rtStart, [NativeTypeName("REFERENCE_TIME")] long rtEnd, [NativeTypeName("DWORD")] uint dwClrBkGnd, [NativeTypeName("VMRVIDEOSTREAMINFO *")] VMRVIDEOSTREAMINFO* pVideoStreamInfo, [NativeTypeName("UINT")] uint cStreams)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImageCompositor*, IUnknown*, IDirectDrawSurface7*, AM_MEDIA_TYPE*, long, long, uint, VMRVIDEOSTREAMINFO*, uint, int>)(lpVtbl[6]))((IVMRImageCompositor*)Unsafe.AsPointer(ref this), pD3DDevice, pddsRenderTarget, pmtRenderTarget, rtStart, rtEnd, dwClrBkGnd, pVideoStreamInfo, cStreams);
        }
    }
}
