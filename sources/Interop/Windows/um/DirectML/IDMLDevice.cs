// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DBD6437-96FD-423F-A98C-AE5E7C2A573F")]
    [NativeTypeName("struct IDMLDevice : IDMLObject")]
    [NativeInheritance("IDMLObject")]
    public unsafe partial struct IDMLDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDevice*, uint>)(lpVtbl[1]))((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLDevice*, uint>)(lpVtbl[2]))((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLDevice*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLDevice*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLDevice*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDevice*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLDevice*, ushort*, int>)(lpVtbl[6]))((IDMLDevice*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DML_FEATURE feature, [NativeTypeName("UINT")] uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, [NativeTypeName("UINT")] uint featureSupportDataSize, void* featureSupportData)
        {
            return ((delegate* unmanaged<IDMLDevice*, DML_FEATURE, uint, void*, uint, void*, int>)(lpVtbl[7]))((IDMLDevice*)Unsafe.AsPointer(ref this), feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DML_OPERATOR_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice*, DML_OPERATOR_DESC*, Guid*, void**, int>)(lpVtbl[8]))((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CompileOperator(IDMLOperator* op, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice*, IDMLOperator*, DML_EXECUTION_FLAGS, Guid*, void**, int>)(lpVtbl[9]))((IDMLDevice*)Unsafe.AsPointer(ref this), op, flags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOperatorInitializer([NativeTypeName("UINT")] uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice*, uint, IDMLCompiledOperator**, Guid*, void**, int>)(lpVtbl[10]))((IDMLDevice*)Unsafe.AsPointer(ref this), operatorCount, operators, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice*, Guid*, void**, int>)(lpVtbl[11]))((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice*, DML_BINDING_TABLE_DESC*, Guid*, void**, int>)(lpVtbl[12]))((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return ((delegate* unmanaged<IDMLDevice*, uint, IDMLPageable**, int>)(lpVtbl[13]))((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return ((delegate* unmanaged<IDMLDevice*, uint, IDMLPageable**, int>)(lpVtbl[14]))((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<IDMLDevice*, int>)(lpVtbl[15]))((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetParentDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDevice*, Guid*, void**, int>)(lpVtbl[16]))((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
