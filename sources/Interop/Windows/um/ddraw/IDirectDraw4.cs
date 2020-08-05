// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDraw4 : IUnknown")]
    public unsafe partial struct IDirectDraw4
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectDraw4*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectDraw4*, uint>)(lpVtbl[1]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectDraw4*, uint>)(lpVtbl[2]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Compact()
        {
            return ((delegate* stdcall<IDirectDraw4*, int>)(lpVtbl[3]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, [NativeTypeName("IUnknown *")] IUnknown* param2)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, [NativeTypeName("IUnknown *")] IUnknown* param3)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1, [NativeTypeName("IUnknown *")] IUnknown* param2)
        {
            return ((delegate* stdcall<IDirectDraw4*, DDSURFACEDESC2*, IDirectDrawSurface4**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, IDirectDrawSurface4*, IDirectDrawSurface4**, int>)(lpVtbl[7]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK2")] delegate* stdcall<DDSURFACEDESC2*, void*, int> param3)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint, DDSURFACEDESC2*, void*, delegate* stdcall<DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[8]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* stdcall<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int> param3)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint, DDSURFACEDESC2*, void*, delegate* stdcall<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[9]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int FlipToGDISurface()
        {
            return ((delegate* stdcall<IDirectDraw4*, int>)(lpVtbl[10]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
        {
            return ((delegate* stdcall<IDirectDraw4*, DDSURFACEDESC2*, int>)(lpVtbl[12]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param0)
        {
            return ((delegate* stdcall<IDirectDraw4*, IDirectDrawSurface4**, int>)(lpVtbl[14]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint*, int>)(lpVtbl[15]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint*, int>)(lpVtbl[16]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalBlankStatus([NativeTypeName("LPBOOL")] int* param0)
        {
            return ((delegate* stdcall<IDirectDraw4*, int*, int>)(lpVtbl[17]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("GUID *")] Guid* param0)
        {
            return ((delegate* stdcall<IDirectDraw4*, Guid*, int>)(lpVtbl[18]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int RestoreDisplayMode()
        {
            return ((delegate* stdcall<IDirectDraw4*, int>)(lpVtbl[19]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCooperativeLevel([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, IntPtr, uint, int>)(lpVtbl[20]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint, uint, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HANDLE")] IntPtr param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, uint, IntPtr, int>)(lpVtbl[22]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* stdcall<IDirectDraw4*, DDSCAPS2*, uint*, uint*, int>)(lpVtbl[23]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceFromDC([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, IntPtr, IDirectDrawSurface4**, int>)(lpVtbl[24]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int RestoreAllSurfaces()
        {
            return ((delegate* stdcall<IDirectDraw4*, int>)(lpVtbl[25]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TestCooperativeLevel()
        {
            return ((delegate* stdcall<IDirectDraw4*, int>)(lpVtbl[26]))((IDirectDraw4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER")] DDDEVICEIDENTIFIER* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* stdcall<IDirectDraw4*, DDDEVICEIDENTIFIER*, uint, int>)(lpVtbl[27]))((IDirectDraw4*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
