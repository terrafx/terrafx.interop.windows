// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDraw4 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDraw4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDraw4*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint>)(lpVtbl[1]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint>)(lpVtbl[2]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Compact()
        {
            return ((delegate* unmanaged<IDirectDraw4*, int>)(lpVtbl[3]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw4*, DDSURFACEDESC2*, IDirectDrawSurface4**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, IDirectDrawSurface4*, IDirectDrawSurface4**, int>)(lpVtbl[7]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK2")] delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT> param3)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[8]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, HRESULT> param3)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT FlipToGDISurface()
        {
            return ((delegate* unmanaged<IDirectDraw4*, int>)(lpVtbl[10]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
        {
            return ((delegate* unmanaged<IDirectDraw4*, DDSURFACEDESC2*, int>)(lpVtbl[12]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param0)
        {
            return ((delegate* unmanaged<IDirectDraw4*, IDirectDrawSurface4**, int>)(lpVtbl[14]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint*, int>)(lpVtbl[15]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint*, int>)(lpVtbl[16]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0)
        {
            return ((delegate* unmanaged<IDirectDraw4*, BOOL*, int>)(lpVtbl[17]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Initialize(Guid* param0)
        {
            return ((delegate* unmanaged<IDirectDraw4*, Guid*, int>)(lpVtbl[18]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT RestoreDisplayMode()
        {
            return ((delegate* unmanaged<IDirectDraw4*, int>)(lpVtbl[19]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, HWND, uint, int>)(lpVtbl[20]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint, uint, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, HANDLE param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, uint, HANDLE, int>)(lpVtbl[22]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged<IDirectDraw4*, DDSCAPS2*, uint*, uint*, int>)(lpVtbl[23]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetSurfaceFromDC(HDC param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, HDC, IDirectDrawSurface4**, int>)(lpVtbl[24]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT RestoreAllSurfaces()
        {
            return ((delegate* unmanaged<IDirectDraw4*, int>)(lpVtbl[25]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT TestCooperativeLevel()
        {
            return ((delegate* unmanaged<IDirectDraw4*, int>)(lpVtbl[26]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER")] DDDEVICEIDENTIFIER* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDraw4*, DDDEVICEIDENTIFIER*, uint, int>)(lpVtbl[27]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
