// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl"]/*' />
[Guid("9B63616C-36B2-46BC-959F-C1593952D19B")]
[NativeTypeName("struct ISyncMgrControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrControl : ISyncMgrControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISyncMgrControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, uint>)(lpVtbl[1]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, uint>)(lpVtbl[2]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.StartHandlerSync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartHandlerSync([NativeTypeName("LPCWSTR")] char* pszHandlerID, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int>)(lpVtbl[3]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, hwndOwner, punk, nSyncControlFlags, pResult);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.StartItemSync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT StartItemSync([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR *")] char** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, char**, uint, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int>)(lpVtbl[4]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems, hwndOwner, punk, nSyncControlFlags, pResult);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.StartSyncAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT StartSyncAll(HWND hwndOwner)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, HWND, int>)(lpVtbl[5]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.StopHandlerSync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StopHandlerSync([NativeTypeName("LPCWSTR")] char* pszHandlerID)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, int>)(lpVtbl[6]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.StopItemSync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StopItemSync([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR *")] char** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, char**, uint, int>)(lpVtbl[7]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.StopSyncAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StopSyncAll()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, int>)(lpVtbl[8]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.UpdateHandlerCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UpdateHandlerCollection([NativeTypeName("const IID &")] Guid* rclsidCollectionID, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, Guid*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[9]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), rclsidCollectionID, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.UpdateHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UpdateHandler([NativeTypeName("LPCWSTR")] char* pszHandlerID, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[10]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.UpdateItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UpdateItem([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, char*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[11]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.UpdateEvents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UpdateEvents([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, char*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[12]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.UpdateConflict"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UpdateConflict([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, ISyncMgrConflict* pConflict, SYNCMGR_UPDATE_REASON nReason)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, char*, ISyncMgrConflict*, SYNCMGR_UPDATE_REASON, int>)(lpVtbl[13]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, pConflict, nReason);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.UpdateConflicts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UpdateConflicts([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, char*, char*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[14]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.ActivateHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ActivateHandler(BOOL fActivate, [NativeTypeName("LPCWSTR")] char* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, BOOL, char*, HWND, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[15]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fActivate, pszHandlerID, hwndOwner, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.EnableHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnableHandler(BOOL fEnable, [NativeTypeName("LPCWSTR")] char* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, BOOL, char*, HWND, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[16]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fEnable, pszHandlerID, hwndOwner, nControlFlags);
    }

    /// <include file='ISyncMgrControl.xml' path='doc/member[@name="ISyncMgrControl.EnableItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnableItem(BOOL fEnable, [NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrControl*, BOOL, char*, char*, HWND, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[17]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fEnable, pszHandlerID, pszItemID, hwndOwner, nControlFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartHandlerSync([NativeTypeName("LPCWSTR")] char* pszHandlerID, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult);

        [VtblIndex(4)]
        HRESULT StartItemSync([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR *")] char** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult);

        [VtblIndex(5)]
        HRESULT StartSyncAll(HWND hwndOwner);

        [VtblIndex(6)]
        HRESULT StopHandlerSync([NativeTypeName("LPCWSTR")] char* pszHandlerID);

        [VtblIndex(7)]
        HRESULT StopItemSync([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR *")] char** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems);

        [VtblIndex(8)]
        HRESULT StopSyncAll();

        [VtblIndex(9)]
        HRESULT UpdateHandlerCollection([NativeTypeName("const IID &")] Guid* rclsidCollectionID, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(10)]
        HRESULT UpdateHandler([NativeTypeName("LPCWSTR")] char* pszHandlerID, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(11)]
        HRESULT UpdateItem([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(12)]
        HRESULT UpdateEvents([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(13)]
        HRESULT UpdateConflict([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, ISyncMgrConflict* pConflict, SYNCMGR_UPDATE_REASON nReason);

        [VtblIndex(14)]
        HRESULT UpdateConflicts([NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(15)]
        HRESULT ActivateHandler(BOOL fActivate, [NativeTypeName("LPCWSTR")] char* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(16)]
        HRESULT EnableHandler(BOOL fEnable, [NativeTypeName("LPCWSTR")] char* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);

        [VtblIndex(17)]
        HRESULT EnableItem(BOOL fEnable, [NativeTypeName("LPCWSTR")] char* pszHandlerID, [NativeTypeName("LPCWSTR")] char* pszItemID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);
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

        [NativeTypeName("HRESULT (LPCWSTR, HWND, IUnknown *, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int> StartHandlerSync;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR *, ULONG, HWND, IUnknown *, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, uint, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int> StartItemSync;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int> StartSyncAll;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> StopHandlerSync;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, uint, int> StopItemSync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopSyncAll;

        [NativeTypeName("HRESULT (const IID &, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, SYNCMGR_CONTROL_FLAGS, int> UpdateHandlerCollection;

        [NativeTypeName("HRESULT (LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, SYNCMGR_CONTROL_FLAGS, int> UpdateHandler;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, SYNCMGR_CONTROL_FLAGS, int> UpdateItem;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, SYNCMGR_CONTROL_FLAGS, int> UpdateEvents;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ISyncMgrConflict *, SYNCMGR_UPDATE_REASON) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, ISyncMgrConflict*, SYNCMGR_UPDATE_REASON, int> UpdateConflict;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, SYNCMGR_CONTROL_FLAGS, int> UpdateConflicts;

        [NativeTypeName("HRESULT (BOOL, LPCWSTR, HWND, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, char*, HWND, SYNCMGR_CONTROL_FLAGS, int> ActivateHandler;

        [NativeTypeName("HRESULT (BOOL, LPCWSTR, HWND, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, char*, HWND, SYNCMGR_CONTROL_FLAGS, int> EnableHandler;

        [NativeTypeName("HRESULT (BOOL, LPCWSTR, LPCWSTR, HWND, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, char*, char*, HWND, SYNCMGR_CONTROL_FLAGS, int> EnableItem;
    }
}
