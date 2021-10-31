// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29C687DC-DE74-4E3B-AB00-1168F2FC3CFC")]
    [NativeTypeName("struct IDMLBindingTable : IDMLDeviceChild")]
    [NativeInheritance("IDMLDeviceChild")]
    public unsafe partial struct IDMLBindingTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, Guid*, void**, int>)(lpVtbl[0]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLBindingTable*, uint>)(lpVtbl[1]))((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLBindingTable*, uint>)(lpVtbl[2]))((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, ushort*, int>)(lpVtbl[6]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, Guid*, void**, int>)(lpVtbl[7]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void BindInputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            ((delegate* unmanaged<IDMLBindingTable*, uint, DML_BINDING_DESC*, void>)(lpVtbl[8]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void BindOutputs(uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            ((delegate* unmanaged<IDMLBindingTable*, uint, DML_BINDING_DESC*, void>)(lpVtbl[9]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            ((delegate* unmanaged<IDMLBindingTable*, DML_BINDING_DESC*, void>)(lpVtbl[10]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            ((delegate* unmanaged<IDMLBindingTable*, DML_BINDING_DESC*, void>)(lpVtbl[11]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc)
        {
            return ((delegate* unmanaged<IDMLBindingTable*, DML_BINDING_TABLE_DESC*, int>)(lpVtbl[12]))((IDMLBindingTable*)Unsafe.AsPointer(ref this), desc);
        }
    }
}
