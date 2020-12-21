// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AADA05A8-5A4E-4729-AF0B-CEA27AED51E2")]
    [NativeTypeName("struct IVMRSurfaceAllocatorNotify : IUnknown")]
    public unsafe partial struct IVMRSurfaceAllocatorNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, uint>)(lpVtbl[1]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, uint>)(lpVtbl[2]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseSurfaceAllocator([NativeTypeName("DWORD_PTR")] nuint dwUserID, [NativeTypeName("IVMRSurfaceAllocator *")] IVMRSurfaceAllocator* lpIVRMSurfaceAllocator)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, nuint, IVMRSurfaceAllocator*, int>)(lpVtbl[3]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), dwUserID, lpIVRMSurfaceAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDDrawDevice([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDrawDevice, [NativeTypeName("HMONITOR")] IntPtr hMonitor)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, IDirectDraw7*, IntPtr, int>)(lpVtbl[4]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), lpDDrawDevice, hMonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChangeDDrawDevice([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDrawDevice, [NativeTypeName("HMONITOR")] IntPtr hMonitor)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, IDirectDraw7*, IntPtr, int>)(lpVtbl[5]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), lpDDrawDevice, hMonitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreDDrawSurfaces()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, int>)(lpVtbl[6]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyEvent([NativeTypeName("LONG")] int EventCode, [NativeTypeName("LONG_PTR")] nint Param1, [NativeTypeName("LONG_PTR")] nint Param2)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, int, nint, nint, int>)(lpVtbl[7]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), EventCode, Param1, Param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("COLORREF")] uint clrBorder)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocatorNotify*, uint, int>)(lpVtbl[8]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), clrBorder);
        }
    }
}
