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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetAppInfo([NativeTypeName("PAPPINFODATA")] _AppInfoData* pai)
        {
            return ((delegate* unmanaged<IPublishedApp*, _AppInfoData*, int>)(lpVtbl[3]))((IPublishedApp*)Unsafe.AsPointer(ref this), pai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
        {
            return ((delegate* unmanaged<IPublishedApp*, uint*, int>)(lpVtbl[4]))((IPublishedApp*)Unsafe.AsPointer(ref this), pdwActions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] _tagSlowAppInfo* psaid)
        {
            return ((delegate* unmanaged<IPublishedApp*, _tagSlowAppInfo*, int>)(lpVtbl[5]))((IPublishedApp*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] _tagSlowAppInfo* psaid)
        {
            return ((delegate* unmanaged<IPublishedApp*, _tagSlowAppInfo*, int>)(lpVtbl[6]))((IPublishedApp*)Unsafe.AsPointer(ref this), psaid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsInstalled()
        {
            return ((delegate* unmanaged<IPublishedApp*, int>)(lpVtbl[7]))((IPublishedApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall)
        {
            return ((delegate* unmanaged<IPublishedApp*, SYSTEMTIME*, int>)(lpVtbl[8]))((IPublishedApp*)Unsafe.AsPointer(ref this), pstInstall);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] _PubAppInfo* ppai)
        {
            return ((delegate* unmanaged<IPublishedApp*, _PubAppInfo*, int>)(lpVtbl[9]))((IPublishedApp*)Unsafe.AsPointer(ref this), ppai);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Unschedule()
        {
            return ((delegate* unmanaged<IPublishedApp*, int>)(lpVtbl[10]))((IPublishedApp*)Unsafe.AsPointer(ref this));
        }
    }
}
