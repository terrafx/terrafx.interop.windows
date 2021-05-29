// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E318AD57-0AA0-450F-ACA5-6FAB7103D917")]
    [NativeTypeName("struct IPersistSerializedPropStorage : IUnknown")]
    public unsafe partial struct IPersistSerializedPropStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage*, uint>)(lpVtbl[1]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage*, uint>)(lpVtbl[2]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage*, int, int>)(lpVtbl[3]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage*, IntPtr, uint, int>)(lpVtbl[4]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), psps, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorage([NativeTypeName("SERIALIZEDPROPSTORAGE **")] IntPtr* ppsps, [NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage*, IntPtr*, uint*, int>)(lpVtbl[5]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), ppsps, pcb);
        }
    }
}
