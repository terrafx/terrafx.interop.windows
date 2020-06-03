// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6857A76-2E3E-4FDD-BFF4-5D2BA10FB453")]
    public unsafe partial struct IDMLCommandRecorder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, Guid*, void**, int>)(lpVtbl[0]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, uint>)(lpVtbl[1]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, uint>)(lpVtbl[2]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, ushort*, int>)(lpVtbl[6]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLCommandRecorder*, Guid*, void**, int>)(lpVtbl[7]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public void RecordDispatch([NativeTypeName("ID3D12CommandList *")] ID3D12CommandList* commandList, [NativeTypeName("IDMLDispatchable *")] IDMLDispatchable* dispatchable, [NativeTypeName("IDMLBindingTable *")] IDMLBindingTable* bindings)
        {
            ((delegate* stdcall<IDMLCommandRecorder*, ID3D12CommandList*, IDMLDispatchable*, IDMLBindingTable*, void>)(lpVtbl[8]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), commandList, dispatchable, bindings);
        }
    }
}
