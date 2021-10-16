// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("12B81347-1B3A-4A04-AA61-3F768B67FD7E")]
    [NativeTypeName("struct IPublishedApp2 : IPublishedApp")]
    [NativeInheritance("IPublishedApp")]
    public unsafe partial struct IPublishedApp2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPublishedApp2*, Guid*, void**, int>)(lpVtbl[0]))((IPublishedApp2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPublishedApp2*, uint>)(lpVtbl[1]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPublishedApp2*, uint>)(lpVtbl[2]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai)
        {
            return ((delegate* unmanaged<IPublishedApp2*, APPINFODATA*, int>)(lpVtbl[3]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
        {
            return ((delegate* unmanaged<IPublishedApp2*, uint*, int>)(lpVtbl[4]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pdwActions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
        {
            return ((delegate* unmanaged<IPublishedApp2*, SLOWAPPINFO*, int>)(lpVtbl[5]))((IPublishedApp2*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
        {
            return ((delegate* unmanaged<IPublishedApp2*, SLOWAPPINFO*, int>)(lpVtbl[6]))((IPublishedApp2*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsInstalled()
        {
            return ((delegate* unmanaged<IPublishedApp2*, int>)(lpVtbl[7]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall)
        {
            return ((delegate* unmanaged<IPublishedApp2*, SYSTEMTIME*, int>)(lpVtbl[8]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pstInstall);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] PUBAPPINFO* ppai)
        {
            return ((delegate* unmanaged<IPublishedApp2*, PUBAPPINFO*, int>)(lpVtbl[9]))((IPublishedApp2*)Unsafe.AsPointer(ref this), ppai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Unschedule()
        {
            return ((delegate* unmanaged<IPublishedApp2*, int>)(lpVtbl[10]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Install2([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall, [NativeTypeName("HWND")] IntPtr hwndParent)
        {
            return ((delegate* unmanaged<IPublishedApp2*, SYSTEMTIME*, IntPtr, int>)(lpVtbl[11]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pstInstall, hwndParent);
        }
    }
}
