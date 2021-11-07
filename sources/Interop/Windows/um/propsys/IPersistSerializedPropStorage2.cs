// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77EFFA68-4F98-4366-BA72-573B3D880571")]
    [NativeTypeName("struct IPersistSerializedPropStorage2 : IPersistSerializedPropStorage")]
    [NativeInheritance("IPersistSerializedPropStorage")]
    public unsafe partial struct IPersistSerializedPropStorage2 : IPersistSerializedPropStorage2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, Guid*, void**, int>)(lpVtbl[0]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, uint>)(lpVtbl[1]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, uint>)(lpVtbl[2]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, int, int>)(lpVtbl[3]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPropertyStorage(PCUSERIALIZEDPROPSTORAGE psps, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, PCUSERIALIZEDPROPSTORAGE, uint, int>)(lpVtbl[4]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), psps, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPropertyStorage([NativeTypeName("SERIALIZEDPROPSTORAGE **")] PCUSERIALIZEDPROPSTORAGE* ppsps, [NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, PCUSERIALIZEDPROPSTORAGE*, uint*, int>)(lpVtbl[5]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), ppsps, pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPropertyStorageSize([NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, uint*, int>)(lpVtbl[6]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPropertyStorageBuffer(PCUSERIALIZEDPROPSTORAGE psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, PCUSERIALIZEDPROPSTORAGE, uint, uint*, int>)(lpVtbl[7]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), psps, cb, pcbWritten);
        }

        public interface Interface : IPersistSerializedPropStorage.Interface
        {
            [VtblIndex(6)]
            HRESULT GetPropertyStorageSize([NativeTypeName("DWORD *")] uint* pcb);

            [VtblIndex(7)]
            HRESULT GetPropertyStorageBuffer(PCUSERIALIZEDPROPSTORAGE psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcbWritten);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, uint> Release;

            [NativeTypeName("HRESULT (PERSIST_SPROPSTORE_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, int, int> SetFlags;

            [NativeTypeName("HRESULT (PCUSERIALIZEDPROPSTORAGE, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, PCUSERIALIZEDPROPSTORAGE, uint, int> SetPropertyStorage;

            [NativeTypeName("HRESULT (SERIALIZEDPROPSTORAGE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, PCUSERIALIZEDPROPSTORAGE*, uint*, int> GetPropertyStorage;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, uint*, int> GetPropertyStorageSize;

            [NativeTypeName("HRESULT (SERIALIZEDPROPSTORAGE *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistSerializedPropStorage2*, PCUSERIALIZEDPROPSTORAGE, uint, uint*, int> GetPropertyStorageBuffer;
        }
    }
}
