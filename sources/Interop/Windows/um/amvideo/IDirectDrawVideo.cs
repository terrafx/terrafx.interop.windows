// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawVideo : IUnknown")]
    public unsafe partial struct IDirectDrawVideo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectDrawVideo*, uint>)(lpVtbl[1]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectDrawVideo*, uint>)(lpVtbl[2]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSwitches([NativeTypeName("DWORD *")] uint* pSwitches)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, uint*, int>)(lpVtbl[3]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pSwitches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwitches([NativeTypeName("DWORD")] uint Switches)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, uint, int>)(lpVtbl[4]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), Switches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, DDCAPS_DX7*, int>)(lpVtbl[5]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEmulatedCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, DDCAPS_DX7*, int>)(lpVtbl[6]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceDesc([NativeTypeName("DDSURFACEDESC *")] DDSURFACEDESC* pSurfaceDesc)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, DDSURFACEDESC*, int>)(lpVtbl[7]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pSurfaceDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFourCCCodes([NativeTypeName("DWORD *")] uint* pCount, [NativeTypeName("DWORD *")] uint* pCodes)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, uint*, uint*, int>)(lpVtbl[8]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pCount, pCodes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDirectDraw([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* pDirectDraw)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, IDirectDraw*, int>)(lpVtbl[9]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pDirectDraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDirectDraw([NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** ppDirectDraw)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, IDirectDraw**, int>)(lpVtbl[10]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), ppDirectDraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceType([NativeTypeName("DWORD *")] uint* pSurfaceType)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, uint*, int>)(lpVtbl[11]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pSurfaceType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefault()
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int>)(lpVtbl[12]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UseScanLine([NativeTypeName("long")] int UseScanLine)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int, int>)(lpVtbl[13]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseScanLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanUseScanLine([NativeTypeName("long *")] int* UseScanLine)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int*, int>)(lpVtbl[14]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseScanLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UseOverlayStretch([NativeTypeName("long")] int UseOverlayStretch)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int, int>)(lpVtbl[15]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseOverlayStretch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanUseOverlayStretch([NativeTypeName("long *")] int* UseOverlayStretch)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int*, int>)(lpVtbl[16]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseOverlayStretch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UseWhenFullScreen([NativeTypeName("long")] int UseWhenFullScreen)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int, int>)(lpVtbl[17]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseWhenFullScreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WillUseFullScreen([NativeTypeName("long *")] int* UseWhenFullScreen)
        {
            return ((delegate* stdcall<IDirectDrawVideo*, int*, int>)(lpVtbl[18]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseWhenFullScreen);
        }
    }
}
