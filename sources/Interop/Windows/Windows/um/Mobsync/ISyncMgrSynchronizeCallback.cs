// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("6295DF41-35EE-11D1-8707-00C04FD93327")]
    [NativeTypeName("struct ISyncMgrSynchronizeCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrSynchronizeCallback : ISyncMgrSynchronizeCallback.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint>)(lpVtbl[1]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint>)(lpVtbl[2]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ShowPropertiesCompleted(HRESULT hr)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, int>)(lpVtbl[3]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT PrepareForSyncCompleted(HRESULT hr)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, int>)(lpVtbl[4]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SynchronizeCompleted(HRESULT hr)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, int>)(lpVtbl[5]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ShowErrorCompleted(HRESULT hr, [NativeTypeName("ULONG")] uint cItems, [NativeTypeName("const GUID *")] Guid* pItemIDs)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, uint, Guid*, int>)(lpVtbl[6]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr, cItems, pItemIDs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EnableModeless(BOOL fEnable)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, BOOL, int>)(lpVtbl[7]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Progress([NativeTypeName("const GUID &")] Guid* ItemID, [NativeTypeName("const SYNCMGRPROGRESSITEM *")] SYNCMGRPROGRESSITEM* pSyncProgressItem)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, SYNCMGRPROGRESSITEM*, int>)(lpVtbl[8]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), ItemID, pSyncProgressItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT LogError([NativeTypeName("DWORD")] uint dwErrorLevel, [NativeTypeName("LPCWSTR")] ushort* pszErrorText, [NativeTypeName("const SYNCMGRLOGERRORINFO *")] SYNCMGRLOGERRORINFO* pSyncLogError)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint, ushort*, SYNCMGRLOGERRORINFO*, int>)(lpVtbl[9]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), dwErrorLevel, pszErrorText, pSyncLogError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT DeleteLogError([NativeTypeName("const GUID &")] Guid* ErrorID, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, uint, int>)(lpVtbl[10]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), ErrorID, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT EstablishConnection([NativeTypeName("LPCWSTR")] ushort* pwszConnection, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, ushort*, uint, int>)(lpVtbl[11]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), pwszConnection, dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT ShowPropertiesCompleted(HRESULT hr);

            [VtblIndex(4)]
            HRESULT PrepareForSyncCompleted(HRESULT hr);

            [VtblIndex(5)]
            HRESULT SynchronizeCompleted(HRESULT hr);

            [VtblIndex(6)]
            HRESULT ShowErrorCompleted(HRESULT hr, [NativeTypeName("ULONG")] uint cItems, [NativeTypeName("const GUID *")] Guid* pItemIDs);

            [VtblIndex(7)]
            HRESULT EnableModeless(BOOL fEnable);

            [VtblIndex(8)]
            HRESULT Progress([NativeTypeName("const GUID &")] Guid* ItemID, [NativeTypeName("const SYNCMGRPROGRESSITEM *")] SYNCMGRPROGRESSITEM* pSyncProgressItem);

            [VtblIndex(9)]
            HRESULT LogError([NativeTypeName("DWORD")] uint dwErrorLevel, [NativeTypeName("LPCWSTR")] ushort* pszErrorText, [NativeTypeName("const SYNCMGRLOGERRORINFO *")] SYNCMGRLOGERRORINFO* pSyncLogError);

            [VtblIndex(10)]
            HRESULT DeleteLogError([NativeTypeName("const GUID &")] Guid* ErrorID, [NativeTypeName("DWORD")] uint dwReserved);

            [VtblIndex(11)]
            HRESULT EstablishConnection([NativeTypeName("LPCWSTR")] ushort* pwszConnection, [NativeTypeName("DWORD")] uint dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint> Release;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, int> ShowPropertiesCompleted;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, int> PrepareForSyncCompleted;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, int> SynchronizeCompleted;

            [NativeTypeName("HRESULT (HRESULT, ULONG, const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, HRESULT, uint, Guid*, int> ShowErrorCompleted;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, BOOL, int> EnableModeless;

            [NativeTypeName("HRESULT (const GUID &, const SYNCMGRPROGRESSITEM *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, SYNCMGRPROGRESSITEM*, int> Progress;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, const SYNCMGRLOGERRORINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint, ushort*, SYNCMGRLOGERRORINFO*, int> LogError;

            [NativeTypeName("HRESULT (const GUID &, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, uint, int> DeleteLogError;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrSynchronizeCallback*, ushort*, uint, int> EstablishConnection;
        }
    }
}
