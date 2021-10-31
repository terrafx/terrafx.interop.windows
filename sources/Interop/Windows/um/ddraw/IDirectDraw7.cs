// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDraw7 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDraw7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDraw7*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint>)(lpVtbl[1]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint>)(lpVtbl[2]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Compact()
        {
            return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[3]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw7*, DDSURFACEDESC2*, IDirectDrawSurface7**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, IDirectDrawSurface7*, IDirectDrawSurface7**, int>)(lpVtbl[7]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK2")] delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT> param3)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[8]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT> param3)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT FlipToGDISurface()
        {
            return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[10]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
        {
            return ((delegate* unmanaged<IDirectDraw7*, DDSURFACEDESC2*, int>)(lpVtbl[12]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param0)
        {
            return ((delegate* unmanaged<IDirectDraw7*, IDirectDrawSurface7**, int>)(lpVtbl[14]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint*, int>)(lpVtbl[15]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint*, int>)(lpVtbl[16]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0)
        {
            return ((delegate* unmanaged<IDirectDraw7*, BOOL*, int>)(lpVtbl[17]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Initialize(Guid* param0)
        {
            return ((delegate* unmanaged<IDirectDraw7*, Guid*, int>)(lpVtbl[18]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT RestoreDisplayMode()
        {
            return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[19]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, HWND, uint, int>)(lpVtbl[20]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, uint, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, HANDLE param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, HANDLE, int>)(lpVtbl[22]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged<IDirectDraw7*, DDSCAPS2*, uint*, uint*, int>)(lpVtbl[23]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetSurfaceFromDC(HDC param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, HDC, IDirectDrawSurface7**, int>)(lpVtbl[24]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT RestoreAllSurfaces()
        {
            return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[25]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT TestCooperativeLevel()
        {
            return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[26]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER2")] DDDEVICEIDENTIFIER2* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, DDDEVICEIDENTIFIER2*, uint, int>)(lpVtbl[27]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT StartModeTest([NativeTypeName("LPSIZE")] SIZE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged<IDirectDraw7*, SIZE*, uint, uint, int>)(lpVtbl[28]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT EvaluateMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD *")] uint* param1)
        {
            return ((delegate* unmanaged<IDirectDraw7*, uint, uint*, int>)(lpVtbl[29]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
