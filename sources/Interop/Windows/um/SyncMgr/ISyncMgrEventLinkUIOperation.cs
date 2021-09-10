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
    public unsafe partial struct ISyncMgrEventLinkUIOperation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, IntPtr, int>)(lpVtbl[3]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent* pEvent)
        {
            return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, ISyncMgrEvent*, int>)(lpVtbl[4]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), rguidEventID, pEvent);
        }
    }
}
