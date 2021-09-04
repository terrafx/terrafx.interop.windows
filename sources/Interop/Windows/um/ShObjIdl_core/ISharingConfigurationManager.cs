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
    public unsafe partial struct ISharingConfigurationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, Guid*, void**, int>)(lpVtbl[0]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, uint>)(lpVtbl[1]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, uint>)(lpVtbl[2]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShare(DEF_SHARE_ID dsid, SHARE_ROLE role)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE, int>)(lpVtbl[3]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid, role);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteShare(DEF_SHARE_ID dsid)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int>)(lpVtbl[4]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShareExists(DEF_SHARE_ID dsid)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int>)(lpVtbl[5]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSharePermissions(DEF_SHARE_ID dsid, SHARE_ROLE* pRole)
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE*, int>)(lpVtbl[6]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid, pRole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SharePrinters()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[7]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopSharingPrinters()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[8]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ArePrintersShared()
        {
            return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[9]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
        }
    }
}
