// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64522E52-848B-4015-89CE-5A36F00B94FF")]
    [NativeTypeName("struct ISyncMgrEventLinkUIOperation : ISyncMgrUIOperation")]
    [NativeInheritance("ISyncMgrUIOperation")]
    public unsafe partial struct ISyncMgrEventLinkUIOperation : ISyncMgrEventLinkUIOperation.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, uint>)(lpVtbl[1]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, uint>)(lpVtbl[2]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Run(HWND hwndOwner)
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, HWND, int>)(lpVtbl[3]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent* pEvent)
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, ISyncMgrEvent*, int>)(lpVtbl[4]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), rguidEventID, pEvent);
        }

        public interface Interface : ISyncMgrUIOperation.Interface
        {
            [VtblIndex(4)]
            HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent* pEvent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrEventLinkUIOperation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrEventLinkUIOperation*, uint> Release;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrEventLinkUIOperation*, HWND, int> Run;

            [NativeTypeName("HRESULT (const GUID &, ISyncMgrEvent *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, ISyncMgrEvent*, int> Init;
        }
    }
}
