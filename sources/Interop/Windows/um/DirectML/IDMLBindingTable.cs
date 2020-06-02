// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29C687DC-DE74-4E3B-AB00-1168F2FC3CFC")]
    public unsafe partial struct IDMLBindingTable
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return lpVtbl->GetPrivateData((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return lpVtbl->SetPrivateData((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return lpVtbl->SetPrivateDataInterface((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return lpVtbl->SetName((IDMLBindingTable*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->GetDevice((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public void BindInputs([NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            lpVtbl->BindInputs((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        public void BindOutputs([NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            lpVtbl->BindOutputs((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            lpVtbl->BindTemporaryResource((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            lpVtbl->BindPersistentResource((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc)
        {
            return lpVtbl->Reset((IDMLBindingTable*)Unsafe.AsPointer(ref this), desc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, Guid*, void**, int> GetDevice;

            [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, uint, DML_BINDING_DESC*, void> BindInputs;

            [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, uint, DML_BINDING_DESC*, void> BindOutputs;

            [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, DML_BINDING_DESC*, void> BindTemporaryResource;

            [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, DML_BINDING_DESC*, void> BindPersistentResource;

            [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLBindingTable*, DML_BINDING_TABLE_DESC*, int> Reset;
        }
    }
}
