// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDirectDrawSurface3
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint>)(lpVtbl[1]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint>)(lpVtbl[2]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDrawSurface3*, int>)(lpVtbl[3]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, uint, IDirectDrawSurface3*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, IDirectDrawSurface3*, int>)(lpVtbl[8]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int> param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, void*, delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int>, int>)(lpVtbl[9]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int> param2)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, void*, delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int>, int>)(lpVtbl[10]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flip([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDrawSurface3*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttachedSurface([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3 *")] IDirectDrawSurface3** param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, DDSCAPS*, IDirectDrawSurface3**, int>)(lpVtbl[12]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBltStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, DDSCAPS*, int>)(lpVtbl[14]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("HDC *")] IntPtr* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IntPtr*, int>)(lpVtbl[17]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlipStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, DDSURFACEDESC*, int>)(lpVtbl[22]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[23]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsLost()
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, int>)(lpVtbl[24]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] IntPtr param3)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, RECT*, DDSURFACEDESC*, uint, IntPtr, int>)(lpVtbl[25]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IntPtr, int>)(lpVtbl[26]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Restore()
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, int>)(lpVtbl[27]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unlock([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, void*, int>)(lpVtbl[32]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, IDirectDrawSurface3*, int>)(lpVtbl[35]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int PageLock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int PageUnlock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface3*, DDSURFACEDESC*, uint, int>)(lpVtbl[39]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
