// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1BC752E0-9046-11D1-B8B3-006008059382")]
    [NativeTypeName("struct IPublishedApp : IShellApp")]
    [NativeInheritance("IShellApp")]
    public unsafe partial struct IPublishedApp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPublishedApp*, Guid*, void**, int>)(lpVtbl[0]))((IPublishedApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPublishedApp*, uint>)(lpVtbl[1]))((IPublishedApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPublishedApp*, uint>)(lpVtbl[2]))((IPublishedApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai)
        {
            return ((delegate* unmanaged<IPublishedApp*, APPINFODATA*, int>)(lpVtbl[3]))((IPublishedApp*)Unsafe.AsPointer(ref this), pai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
        {
            return ((delegate* unmanaged<IPublishedApp*, uint*, int>)(lpVtbl[4]))((IPublishedApp*)Unsafe.AsPointer(ref this), pdwActions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
        {
            return ((delegate* unmanaged<IPublishedApp*, SLOWAPPINFO*, int>)(lpVtbl[5]))((IPublishedApp*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
        {
            return ((delegate* unmanaged<IPublishedApp*, SLOWAPPINFO*, int>)(lpVtbl[6]))((IPublishedApp*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsInstalled()
        {
            return ((delegate* unmanaged<IPublishedApp*, int>)(lpVtbl[7]))((IPublishedApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall)
        {
            return ((delegate* unmanaged<IPublishedApp*, SYSTEMTIME*, int>)(lpVtbl[8]))((IPublishedApp*)Unsafe.AsPointer(ref this), pstInstall);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] PUBAPPINFO* ppai)
        {
            return ((delegate* unmanaged<IPublishedApp*, PUBAPPINFO*, int>)(lpVtbl[9]))((IPublishedApp*)Unsafe.AsPointer(ref this), ppai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Unschedule()
        {
            return ((delegate* unmanaged<IPublishedApp*, int>)(lpVtbl[10]))((IPublishedApp*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, uint> Release;

            [NativeTypeName("HRESULT (PAPPINFODATA) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, APPINFODATA*, int> GetAppInfo;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, uint*, int> GetPossibleActions;

            [NativeTypeName("HRESULT (PSLOWAPPINFO) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, SLOWAPPINFO*, int> GetSlowAppInfo;

            [NativeTypeName("HRESULT (PSLOWAPPINFO) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, SLOWAPPINFO*, int> GetCachedSlowAppInfo;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, int> IsInstalled;

            [NativeTypeName("HRESULT (LPSYSTEMTIME) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, SYSTEMTIME*, int> Install;

            [NativeTypeName("HRESULT (PPUBAPPINFO) __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, PUBAPPINFO*, int> GetPublishedAppInfo;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPublishedApp*, int> Unschedule;
        }
    }
}
