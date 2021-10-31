// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6295DF42-35EE-11D1-8707-00C04FD93327")]
    [NativeTypeName("struct ISyncMgrRegister : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrRegister
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrRegister*, uint>)(lpVtbl[1]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrRegister*, uint>)(lpVtbl[2]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterSyncMgrHandler([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("LPCWSTR")] ushort* pwszDescription, [NativeTypeName("DWORD")] uint dwSyncMgrRegisterFlags)
        {
            return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, ushort*, uint, int>)(lpVtbl[3]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), clsidHandler, pwszDescription, dwSyncMgrRegisterFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnregisterSyncMgrHandler([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, uint, int>)(lpVtbl[4]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), clsidHandler, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetHandlerRegistrationInfo([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("LPDWORD")] uint* pdwSyncMgrRegisterFlags)
        {
            return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, uint*, int>)(lpVtbl[5]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), clsidHandler, pdwSyncMgrRegisterFlags);
        }
    }
}
