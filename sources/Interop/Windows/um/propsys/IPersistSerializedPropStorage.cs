// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E318AD57-0AA0-450F-ACA5-6FAB7103D917")]
    public unsafe partial struct IPersistSerializedPropStorage
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage*, uint>)(lpVtbl[1]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage*, uint>)(lpVtbl[2]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage*, int, int>)(lpVtbl[3]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage*, IntPtr, uint, int>)(lpVtbl[4]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), psps, cb);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStorage([NativeTypeName("SERIALIZEDPROPSTORAGE **")] IntPtr* ppsps, [NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* stdcall<IPersistSerializedPropStorage*, IntPtr*, uint*, int>)(lpVtbl[5]))((IPersistSerializedPropStorage*)Unsafe.AsPointer(ref this), ppsps, pcb);
        }
    }
}
