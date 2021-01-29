// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4EF89150-0807-11D3-8DF0-00105A2799B5")]
    [NativeTypeName("struct ITfPersistentPropertyLoaderACP : IUnknown")]
    public unsafe partial struct ITfPersistentPropertyLoaderACP
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, Guid*, void**, int>)(lpVtbl[0]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, uint>)(lpVtbl[1]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, uint>)(lpVtbl[2]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadProperty([NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")] TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, [NativeTypeName("IStream **")] IStream** ppStream)
        {
            return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream**, int>)(lpVtbl[3]))((ITfPersistentPropertyLoaderACP*)Unsafe.AsPointer(ref this), pHdr, ppStream);
        }
    }
}
