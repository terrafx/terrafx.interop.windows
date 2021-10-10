// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6295DF2C-35EE-11D1-8707-00C04FD93327")]
    [NativeTypeName("struct ISyncMgrSynchronizeInvoke : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrSynchronizeInvoke
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, uint>)(lpVtbl[1]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, uint>)(lpVtbl[2]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateItems([NativeTypeName("DWORD")] uint dwInvokeFlags, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("DWORD")] uint cbCookie, [NativeTypeName("const BYTE *")] byte* pCookie)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, uint, Guid*, uint, byte*, int>)(lpVtbl[3]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this), dwInvokeFlags, clsid, cbCookie, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateAll()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, int>)(lpVtbl[4]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this));
        }
    }
}
