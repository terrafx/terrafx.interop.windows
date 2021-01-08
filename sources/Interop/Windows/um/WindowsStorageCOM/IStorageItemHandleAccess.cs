// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CA296B2-2C25-4D22-B785-B885C8201E6A")]
    [NativeTypeName("struct IStorageItemHandleAccess : IUnknown")]
    public unsafe partial struct IStorageItemHandleAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageItemHandleAccess*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemHandleAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageItemHandleAccess*, uint>)(lpVtbl[1]))((IStorageItemHandleAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageItemHandleAccess*, uint>)(lpVtbl[2]))((IStorageItemHandleAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create(HANDLE_ACCESS_OPTIONS accessOptions, HANDLE_SHARING_OPTIONS sharingOptions, HANDLE_OPTIONS options, [NativeTypeName("IOplockBreakingHandler *")] IOplockBreakingHandler* oplockBreakingHandler, [NativeTypeName("HANDLE *")] IntPtr* interopHandle)
        {
            return ((delegate* unmanaged<IStorageItemHandleAccess*, HANDLE_ACCESS_OPTIONS, HANDLE_SHARING_OPTIONS, HANDLE_OPTIONS, IOplockBreakingHandler*, IntPtr*, int>)(lpVtbl[3]))((IStorageItemHandleAccess*)Unsafe.AsPointer(ref this), accessOptions, sharingOptions, options, oplockBreakingHandler, interopHandle);
        }
    }
}
