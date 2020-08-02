// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDirectDraw
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectDraw*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectDraw*, uint>)(lpVtbl[1]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectDraw*, uint>)(lpVtbl[2]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Compact()
        {
            return ((delegate* stdcall<IDirectDraw*, int>)(lpVtbl[3]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, [NativeTypeName("IUnknown *")] IUnknown* param2)
        {
            return ((delegate* stdcall<IDirectDraw*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, [NativeTypeName("IUnknown *")] IUnknown* param3)
        {
            return ((delegate* stdcall<IDirectDraw*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1, [NativeTypeName("IUnknown *")] IUnknown* param2)
        {
            return ((delegate* stdcall<IDirectDraw*, DDSURFACEDESC*, IDirectDrawSurface**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1)
        {
            return ((delegate* stdcall<IDirectDraw*, IDirectDrawSurface*, IDirectDrawSurface**, int>)(lpVtbl[7]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK")] delegate* stdcall<DDSURFACEDESC*, void*, int> param3)
        {
            return ((delegate* stdcall<IDirectDraw*, uint, DDSURFACEDESC*, void*, delegate* stdcall<DDSURFACEDESC*, void*, int>, int>)(lpVtbl[8]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int> param3)
        {
            return ((delegate* stdcall<IDirectDraw*, uint, DDSURFACEDESC*, void*, delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int>, int>)(lpVtbl[9]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int FlipToGDISurface()
        {
            return ((delegate* stdcall<IDirectDraw*, int>)(lpVtbl[10]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
        {
            return ((delegate* stdcall<IDirectDraw*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
        {
            return ((delegate* stdcall<IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[12]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* stdcall<IDirectDraw*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param0)
        {
            return ((delegate* stdcall<IDirectDraw*, IDirectDrawSurface**, int>)(lpVtbl[14]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* stdcall<IDirectDraw*, uint*, int>)(lpVtbl[15]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* stdcall<IDirectDraw*, uint*, int>)(lpVtbl[16]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalBlankStatus([NativeTypeName("LPBOOL")] int* param0)
        {
            return ((delegate* stdcall<IDirectDraw*, int*, int>)(lpVtbl[17]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("GUID *")] Guid* param0)
        {
            return ((delegate* stdcall<IDirectDraw*, Guid*, int>)(lpVtbl[18]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int RestoreDisplayMode()
        {
            return ((delegate* stdcall<IDirectDraw*, int>)(lpVtbl[19]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCooperativeLevel([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* stdcall<IDirectDraw*, IntPtr, uint, int>)(lpVtbl[20]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* stdcall<IDirectDraw*, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HANDLE")] IntPtr param1)
        {
            return ((delegate* stdcall<IDirectDraw*, uint, IntPtr, int>)(lpVtbl[22]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
