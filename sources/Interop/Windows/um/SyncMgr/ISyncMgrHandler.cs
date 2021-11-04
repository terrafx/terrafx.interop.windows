// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04EC2E43-AC77-49F9-9B98-0307EF7A72A2")]
    [NativeTypeName("struct ISyncMgrHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, uint>)(lpVtbl[1]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, uint>)(lpVtbl[2]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, ushort**, int>)(lpVtbl[3]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHandlerInfo(ISyncMgrHandlerInfo** ppHandlerInfo)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, ISyncMgrHandlerInfo**, int>)(lpVtbl[4]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), ppHandlerInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetObjectW([NativeTypeName("const GUID &")] Guid* rguidObjectID, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, Guid*, Guid*, void**, int>)(lpVtbl[5]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), rguidObjectID, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCapabilities(SYNCMGR_HANDLER_CAPABILITIES* pmCapabilities)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, SYNCMGR_HANDLER_CAPABILITIES*, int>)(lpVtbl[6]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), pmCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPolicies(SYNCMGR_HANDLER_POLICIES* pmPolicies)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, SYNCMGR_HANDLER_POLICIES*, int>)(lpVtbl[7]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), pmPolicies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Activate(BOOL fActivate)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, BOOL, int>)(lpVtbl[8]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), fActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Enable(BOOL fEnable)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, BOOL, int>)(lpVtbl[9]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Synchronize([NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, HWND hwndOwner, ISyncMgrSessionCreator* pSessionCreator, IUnknown* punk)
        {
            return ((delegate* unmanaged<ISyncMgrHandler*, ushort**, uint, HWND, ISyncMgrSessionCreator*, IUnknown*, int>)(lpVtbl[10]))((ISyncMgrHandler*)Unsafe.AsPointer(ref this), ppszItemIDs, cItems, hwndOwner, pSessionCreator, punk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, ushort**, int> GetName;

            [NativeTypeName("HRESULT (ISyncMgrHandlerInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, ISyncMgrHandlerInfo**, int> GetHandlerInfo;

            [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, Guid*, Guid*, void**, int> GetObjectW;

            [NativeTypeName("HRESULT (SYNCMGR_HANDLER_CAPABILITIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, SYNCMGR_HANDLER_CAPABILITIES*, int> GetCapabilities;

            [NativeTypeName("HRESULT (SYNCMGR_HANDLER_POLICIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, SYNCMGR_HANDLER_POLICIES*, int> GetPolicies;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, BOOL, int> Activate;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, BOOL, int> Enable;

            [NativeTypeName("HRESULT (LPCWSTR *, ULONG, HWND, ISyncMgrSessionCreator *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrHandler*, ushort**, uint, HWND, ISyncMgrSessionCreator*, IUnknown*, int> Synchronize;
        }
    }
}
