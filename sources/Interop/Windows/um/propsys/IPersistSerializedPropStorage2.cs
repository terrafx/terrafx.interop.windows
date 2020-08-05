// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77EFFA68-4F98-4366-BA72-573B3D880571")]
    [NativeTypeName("struct IPersistSerializedPropStorage2 : IPersistSerializedPropStorage")]
    public unsafe partial struct IPersistSerializedPropStorage2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, Guid*, void**, int>)(lpVtbl[0]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, uint>)(lpVtbl[1]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, uint>)(lpVtbl[2]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, int, int>)(lpVtbl[3]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, IntPtr, uint, int>)(lpVtbl[4]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), psps, cb);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorage([NativeTypeName("SERIALIZEDPROPSTORAGE **")] IntPtr* ppsps, [NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, IntPtr*, uint*, int>)(lpVtbl[5]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), ppsps, pcb);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorageSize([NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, uint*, int>)(lpVtbl[6]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), pcb);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorageBuffer([NativeTypeName("SERIALIZEDPROPSTORAGE *")] IntPtr psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage2*, IntPtr, uint, uint*, int>)(lpVtbl[7]))((IPersistSerializedPropStorage2*)Unsafe.AsPointer(ref this), psps, cb, pcbWritten);
        }
    }
}
