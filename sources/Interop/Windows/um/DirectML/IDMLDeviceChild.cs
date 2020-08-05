// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27E83142-8165-49E3-974E-2FD66E4CB69D")]
    [NativeTypeName("struct IDMLDeviceChild : IDMLObject")]
    public unsafe partial struct IDMLDeviceChild
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDMLDeviceChild*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDMLDeviceChild*, uint>)(lpVtbl[1]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDMLDeviceChild*, uint>)(lpVtbl[2]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* stdcall<IDMLDeviceChild*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* stdcall<IDMLDeviceChild*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* stdcall<IDMLDeviceChild*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<IDMLDeviceChild*, ushort*, int>)(lpVtbl[6]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDeviceChild*, Guid*, void**, int>)(lpVtbl[7]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
