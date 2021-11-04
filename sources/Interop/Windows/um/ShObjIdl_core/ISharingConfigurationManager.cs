// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B4CD448A-9C86-4466-9201-2E62105B87AE")]
    [NativeTypeName("struct ISharingConfigurationManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISharingConfigurationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, Guid*, void**, int>)(lpVtbl[0]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, uint>)(lpVtbl[1]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, uint>)(lpVtbl[2]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateShare(DEF_SHARE_ID dsid, SHARE_ROLE role)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE, int>)(lpVtbl[3]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid, role);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT DeleteShare(DEF_SHARE_ID dsid)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int>)(lpVtbl[4]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ShareExists(DEF_SHARE_ID dsid)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int>)(lpVtbl[5]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetSharePermissions(DEF_SHARE_ID dsid, SHARE_ROLE* pRole)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE*, int>)(lpVtbl[6]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid, pRole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SharePrinters()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[7]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT StopSharingPrinters()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[8]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ArePrintersShared()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[9]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, uint> Release;

            [NativeTypeName("HRESULT (DEF_SHARE_ID, SHARE_ROLE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE, int> CreateShare;

            [NativeTypeName("HRESULT (DEF_SHARE_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int> DeleteShare;

            [NativeTypeName("HRESULT (DEF_SHARE_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int> ShareExists;

            [NativeTypeName("HRESULT (DEF_SHARE_ID, SHARE_ROLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE*, int> GetSharePermissions;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, int> SharePrinters;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, int> StopSharingPrinters;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISharingConfigurationManager*, int> ArePrintersShared;
        }
    }
}
