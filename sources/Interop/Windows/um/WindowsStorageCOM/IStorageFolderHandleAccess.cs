// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF19938F-5462-48A0-BE65-D2A3271A08D6")]
    [NativeTypeName("struct IStorageFolderHandleAccess : IUnknown")]
    public unsafe partial struct IStorageFolderHandleAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFolderHandleAccess*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFolderHandleAccess*, uint>)(lpVtbl[1]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFolderHandleAccess*, uint>)(lpVtbl[2]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("LPCWSTR")] ushort* fileName, HANDLE_CREATION_OPTIONS creationOptions, HANDLE_ACCESS_OPTIONS accessOptions, HANDLE_SHARING_OPTIONS sharingOptions, HANDLE_OPTIONS options, IOplockBreakingHandler* oplockBreakingHandler, [NativeTypeName("HANDLE *")] IntPtr* interopHandle)
        {
            return ((delegate* unmanaged<IStorageFolderHandleAccess*, ushort*, HANDLE_CREATION_OPTIONS, HANDLE_ACCESS_OPTIONS, HANDLE_SHARING_OPTIONS, HANDLE_OPTIONS, IOplockBreakingHandler*, IntPtr*, int>)(lpVtbl[3]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this), fileName, creationOptions, accessOptions, sharingOptions, options, oplockBreakingHandler, interopHandle);
        }
    }
}
