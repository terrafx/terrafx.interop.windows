// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4EF89150-0807-11D3-8DF0-00105A2799B5")]
    [NativeTypeName("struct ITfPersistentPropertyLoaderACP : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfPersistentPropertyLoaderACP
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, Guid*, void**, int>)(lpVtbl[0]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, uint>)(lpVtbl[1]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, uint>)(lpVtbl[2]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int LoadProperty([NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")] TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, IStream** ppStream)
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream**, int>)(lpVtbl[3]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this), pHdr, ppStream);
        }
    }
}
