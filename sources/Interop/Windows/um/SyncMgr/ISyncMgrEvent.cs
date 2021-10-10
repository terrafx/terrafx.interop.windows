// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEE0EF8B-46BD-4DB4-B7E6-FF2C687313BC")]
    [NativeTypeName("struct ISyncMgrEvent : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, uint>)(lpVtbl[1]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, uint>)(lpVtbl[2]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetEventID([NativeTypeName("GUID *")] Guid* pguidEventID)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, Guid*, int>)(lpVtbl[3]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pguidEventID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetHandlerID([NativeTypeName("LPWSTR *")] ushort** ppszHandlerID)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[4]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszHandlerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[5]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszItemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevel(SYNCMGR_EVENT_LEVEL* pnLevel)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, SYNCMGR_EVENT_LEVEL*, int>)(lpVtbl[6]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pnLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags(SYNCMGR_EVENT_FLAGS* pnFlags)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, SYNCMGR_EVENT_FLAGS*, int>)(lpVtbl[7]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pnFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetTime(FILETIME* pfCreationTime)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, FILETIME*, int>)(lpVtbl[8]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pfCreationTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[9]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[10]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetLinkText([NativeTypeName("LPWSTR *")] ushort** ppszLinkText)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[11]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszLinkText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetLinkReference([NativeTypeName("LPWSTR *")] ushort** ppszLinkReference)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[12]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszLinkReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetContext([NativeTypeName("LPWSTR *")] ushort** ppszContext)
        {
            return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int>)(lpVtbl[13]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszContext);
        }
    }
}
