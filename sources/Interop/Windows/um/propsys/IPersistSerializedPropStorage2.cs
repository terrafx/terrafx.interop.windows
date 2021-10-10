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
    public unsafe partial struct IPersistSerializedPropStorage2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, int, int>)(lpVtbl[3]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, IntPtr, uint, int>)(lpVtbl[4]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), psps, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorage([NativeTypeName("SERIALIZEDPROPSTORAGE **")] IntPtr* ppsps, [NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, IntPtr*, uint*, int>)(lpVtbl[5]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), ppsps, pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorageSize([NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, uint*, int>)(lpVtbl[6]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorageBuffer([NativeTypeName("SERIALIZEDPROPSTORAGE *")] IntPtr psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IPersistSerializedPropStorage2*, IntPtr, uint, uint*, int>)(lpVtbl[7]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), psps, cb, pcbWritten);
        }
    }
}
