// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback"]/*' />
[Guid("6295DF41-35EE-11D1-8707-00C04FD93327")]
[NativeTypeName("struct ISyncMgrSynchronizeCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSynchronizeCallback : ISyncMgrSynchronizeCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSynchronizeCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, uint>)(lpVtbl[1]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, uint>)(lpVtbl[2]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.ShowPropertiesCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowPropertiesCompleted(HRESULT hr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, HRESULT, int>)(lpVtbl[3]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.PrepareForSyncCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PrepareForSyncCompleted(HRESULT hr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, HRESULT, int>)(lpVtbl[4]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.SynchronizeCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SynchronizeCompleted(HRESULT hr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, HRESULT, int>)(lpVtbl[5]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.ShowErrorCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowErrorCompleted(HRESULT hr, [NativeTypeName("ULONG")] uint cItems, [NativeTypeName("const GUID *")] Guid* pItemIDs)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, HRESULT, uint, Guid*, int>)(lpVtbl[6]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr, cItems, pItemIDs);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.EnableModeless"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, BOOL, int>)(lpVtbl[7]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), fEnable);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Progress([NativeTypeName("const GUID &")] Guid* ItemID, [NativeTypeName("const SYNCMGRPROGRESSITEM *")] SYNCMGRPROGRESSITEM* pSyncProgressItem)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, Guid*, SYNCMGRPROGRESSITEM*, int>)(lpVtbl[8]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), ItemID, pSyncProgressItem);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.LogError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LogError([NativeTypeName("DWORD")] uint dwErrorLevel, [NativeTypeName("LPCWSTR")] char* pszErrorText, [NativeTypeName("const SYNCMGRLOGERRORINFO *")] SYNCMGRLOGERRORINFO* pSyncLogError)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, uint, char*, SYNCMGRLOGERRORINFO*, int>)(lpVtbl[9]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), dwErrorLevel, pszErrorText, pSyncLogError);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.DeleteLogError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteLogError([NativeTypeName("const GUID &")] Guid* ErrorID, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, Guid*, uint, int>)(lpVtbl[10]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), ErrorID, dwReserved);
    }

    /// <include file='ISyncMgrSynchronizeCallback.xml' path='doc/member[@name="ISyncMgrSynchronizeCallback.EstablishConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EstablishConnection([NativeTypeName("LPCWSTR")] char* pwszConnection, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSynchronizeCallback*, char*, uint, int>)(lpVtbl[11]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), pwszConnection, dwReserved);
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
        HRESULT LogError([NativeTypeName("DWORD")] uint dwErrorLevel, [NativeTypeName("LPCWSTR")] char* pszErrorText, [NativeTypeName("const SYNCMGRLOGERRORINFO *")] SYNCMGRLOGERRORINFO* pSyncLogError);

        [VtblIndex(10)]
        HRESULT DeleteLogError([NativeTypeName("const GUID &")] Guid* ErrorID, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(11)]
        HRESULT EstablishConnection([NativeTypeName("LPCWSTR")] char* pwszConnection, [NativeTypeName("DWORD")] uint dwReserved);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, int> ShowPropertiesCompleted;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, int> PrepareForSyncCompleted;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, int> SynchronizeCompleted;

        [NativeTypeName("HRESULT (HRESULT, ULONG, const GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, uint, Guid*, int> ShowErrorCompleted;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> EnableModeless;

        [NativeTypeName("HRESULT (const GUID &, const SYNCMGRPROGRESSITEM *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, SYNCMGRPROGRESSITEM*, int> Progress;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, const SYNCMGRLOGERRORINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, SYNCMGRLOGERRORINFO*, int> LogError;

        [NativeTypeName("HRESULT (const GUID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, int> DeleteLogError;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> EstablishConnection;
    }
}
