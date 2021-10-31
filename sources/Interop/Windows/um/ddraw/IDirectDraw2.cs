// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDraw2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDraw2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDraw2*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint>)(lpVtbl[1]))((IDirectDraw2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint>)(lpVtbl[2]))((IDirectDraw2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Compact()
        {
            return ((delegate* unmanaged<IDirectDraw2*, int>)(lpVtbl[3]))((IDirectDraw2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw2*, DDSURFACEDESC*, IDirectDrawSurface**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1)
        {
            return ((delegate* unmanaged<IDirectDraw2*, IDirectDrawSurface*, IDirectDrawSurface**, int>)(lpVtbl[7]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK")] delegate* unmanaged<DDSURFACEDESC*, void*, int> param3)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<DDSURFACEDESC*, void*, int>, int>)(lpVtbl[8]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, int> param3)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, int>, int>)(lpVtbl[9]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int FlipToGDISurface()
        {
            return ((delegate* unmanaged<IDirectDraw2*, int>)(lpVtbl[10]))((IDirectDraw2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
        {
            return ((delegate* unmanaged<IDirectDraw2*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
        {
            return ((delegate* unmanaged<IDirectDraw2*, DDSURFACEDESC*, int>)(lpVtbl[12]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param0)
        {
            return ((delegate* unmanaged<IDirectDraw2*, IDirectDrawSurface**, int>)(lpVtbl[14]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint*, int>)(lpVtbl[15]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint*, int>)(lpVtbl[16]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0)
        {
            return ((delegate* unmanaged<IDirectDraw2*, BOOL*, int>)(lpVtbl[17]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("GUID *")] Guid* param0)
        {
            return ((delegate* unmanaged<IDirectDraw2*, Guid*, int>)(lpVtbl[18]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreDisplayMode()
        {
            return ((delegate* unmanaged<IDirectDraw2*, int>)(lpVtbl[19]))((IDirectDraw2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetCooperativeLevel([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDraw2*, IntPtr, uint, int>)(lpVtbl[20]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint, uint, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HANDLE")] IntPtr param1)
        {
            return ((delegate* unmanaged<IDirectDraw2*, uint, IntPtr, int>)(lpVtbl[22]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableVidMem([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged<IDirectDraw2*, DDSCAPS*, uint*, uint*, int>)(lpVtbl[23]))((IDirectDraw2*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }
    }
}
