// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawSurface7 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDrawSurface7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint>)(lpVtbl[1]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint>)(lpVtbl[2]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawSurface7*, int>)(lpVtbl[3]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, IDirectDrawSurface7*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, uint, IDirectDrawSurface7*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, IDirectDrawSurface7*, int>)(lpVtbl[8]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, int> param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[9]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, int> param2)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[10]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Flip([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawSurface7*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, DDSCAPS2*, IDirectDrawSurface7**, int>)(lpVtbl[12]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetBltStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, DDSCAPS2*, int>)(lpVtbl[14]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("HDC *")] IntPtr* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IntPtr*, int>)(lpVtbl[17]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlipStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, int>)(lpVtbl[22]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDraw*, DDSURFACEDESC2*, int>)(lpVtbl[23]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int IsLost()
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, int>)(lpVtbl[24]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] IntPtr param3)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, DDSURFACEDESC2*, uint, IntPtr, int>)(lpVtbl[25]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[26]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int Restore()
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, int>)(lpVtbl[27]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, int>)(lpVtbl[32]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, IDirectDrawSurface7*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, IDirectDrawSurface7*, int>)(lpVtbl[35]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int PageLock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int PageUnlock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, uint, int>)(lpVtbl[39]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, void*, uint, uint, int>)(lpVtbl[40]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, void*, uint*, int>)(lpVtbl[41]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, int>)(lpVtbl[42]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint*, int>)(lpVtbl[43]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int ChangeUniquenessValue()
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, int>)(lpVtbl[44]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[45]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint*, int>)(lpVtbl[46]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int SetLOD([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[47]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int GetLOD([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface7*, uint*, int>)(lpVtbl[48]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }
    }
}
