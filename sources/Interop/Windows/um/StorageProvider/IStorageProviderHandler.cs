// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("162C6FB5-44D3-435B-903D-E613FA093FB5")]
    [NativeTypeName("struct IStorageProviderHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IStorageProviderHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageProviderHandler*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageProviderHandler*, uint>)(lpVtbl[1]))((IStorageProviderHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageProviderHandler*, uint>)(lpVtbl[2]))((IStorageProviderHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPropertyHandlerFromPath([NativeTypeName("LPCWSTR")] ushort* path, IStorageProviderPropertyHandler** propertyHandler)
        {
            return ((delegate* unmanaged<IStorageProviderHandler*, ushort*, IStorageProviderPropertyHandler**, int>)(lpVtbl[3]))((IStorageProviderHandler*)Unsafe.AsPointer(ref this), path, propertyHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPropertyHandlerFromUri([NativeTypeName("LPCWSTR")] ushort* uri, IStorageProviderPropertyHandler** propertyHandler)
        {
            return ((delegate* unmanaged<IStorageProviderHandler*, ushort*, IStorageProviderPropertyHandler**, int>)(lpVtbl[4]))((IStorageProviderHandler*)Unsafe.AsPointer(ref this), uri, propertyHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPropertyHandlerFromFileId([NativeTypeName("LPCWSTR")] ushort* fileId, IStorageProviderPropertyHandler** propertyHandler)
        {
            return ((delegate* unmanaged<IStorageProviderHandler*, ushort*, IStorageProviderPropertyHandler**, int>)(lpVtbl[5]))((IStorageProviderHandler*)Unsafe.AsPointer(ref this), fileId, propertyHandler);
        }
    }
}
