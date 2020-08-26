// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29C687DC-DE74-4E3B-AB00-1168F2FC3CFC")]
    [NativeTypeName("struct IDMLBindingTable : IDMLDeviceChild")]
    public unsafe partial struct IDMLBindingTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDMLBindingTable*, Guid*, void**, int>)(lpVtbl[0]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDMLBindingTable*, uint>)(lpVtbl[1]))((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDMLBindingTable*, uint>)(lpVtbl[2]))((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* stdcall<IDMLBindingTable*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* stdcall<IDMLBindingTable*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* stdcall<IDMLBindingTable*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<IDMLBindingTable*, ushort*, int>)(lpVtbl[6]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLBindingTable*, Guid*, void**, int>)(lpVtbl[7]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BindInputs([NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            ((delegate* stdcall<IDMLBindingTable*, uint, DML_BINDING_DESC*, void>)(lpVtbl[8]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BindOutputs([NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            ((delegate* stdcall<IDMLBindingTable*, uint, DML_BINDING_DESC*, void>)(lpVtbl[9]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            ((delegate* stdcall<IDMLBindingTable*, DML_BINDING_DESC*, void>)(lpVtbl[10]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            ((delegate* stdcall<IDMLBindingTable*, DML_BINDING_DESC*, void>)(lpVtbl[11]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc)
        {
            return ((delegate* stdcall<IDMLBindingTable*, DML_BINDING_TABLE_DESC*, int>)(lpVtbl[12]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), desc);
        }
    }
}
