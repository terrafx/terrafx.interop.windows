// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C204249-C443-4BA4-85ED-C972681DB137")]
    [NativeTypeName("struct ISyncMgrConflict : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrConflict
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, uint>)(lpVtbl[1]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, uint>)(lpVtbl[2]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetProperty([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[3]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this), propkey, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetConflictIdInfo(SYNCMGR_CONFLICT_ID_INFO* pConflictIdInfo)
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, SYNCMGR_CONFLICT_ID_INFO*, int>)(lpVtbl[4]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this), pConflictIdInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetItemsArray(ISyncMgrConflictItems** ppArray)
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, ISyncMgrConflictItems**, int>)(lpVtbl[5]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this), ppArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Resolve(ISyncMgrConflictResolveInfo* pResolveInfo)
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, ISyncMgrConflictResolveInfo*, int>)(lpVtbl[6]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this), pResolveInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetResolutionHandler([NativeTypeName("const IID &")] Guid* riid, void** ppvResolutionHandler)
        {
            return ((delegate* unmanaged<ISyncMgrConflict*, Guid*, void**, int>)(lpVtbl[7]))((ISyncMgrConflict*)Unsafe.AsPointer(ref this), riid, ppvResolutionHandler);
        }
    }
}
