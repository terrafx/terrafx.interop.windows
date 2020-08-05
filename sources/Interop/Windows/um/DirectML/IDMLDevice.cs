// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DBD6437-96FD-423F-A98C-AE5E7C2A573F")]
    [NativeTypeName("struct IDMLDevice : IDMLObject")]
    public unsafe partial struct IDMLDevice
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDMLDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDMLDevice*, uint>)(lpVtbl[1]))((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDMLDevice*, uint>)(lpVtbl[2]))((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* stdcall<IDMLDevice*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* stdcall<IDMLDevice*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* stdcall<IDMLDevice*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDevice*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<IDMLDevice*, ushort*, int>)(lpVtbl[6]))((IDMLDevice*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DML_FEATURE feature, [NativeTypeName("UINT")] uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, [NativeTypeName("UINT")] uint featureSupportDataSize, [NativeTypeName("void *")] void* featureSupportData)
        {
            return ((delegate* stdcall<IDMLDevice*, DML_FEATURE, uint, void*, uint, void*, int>)(lpVtbl[7]))((IDMLDevice*)Unsafe.AsPointer(ref this), feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DML_OPERATOR_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDevice*, DML_OPERATOR_DESC*, Guid*, void**, int>)(lpVtbl[8]))((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompileOperator([NativeTypeName("IDMLOperator *")] IDMLOperator* op, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDevice*, IDMLOperator*, DML_EXECUTION_FLAGS, Guid*, void**, int>)(lpVtbl[9]))((IDMLDevice*)Unsafe.AsPointer(ref this), op, flags, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOperatorInitializer([NativeTypeName("UINT")] uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDevice*, uint, IDMLCompiledOperator**, Guid*, void**, int>)(lpVtbl[10]))((IDMLDevice*)Unsafe.AsPointer(ref this), operatorCount, operators, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDevice*, Guid*, void**, int>)(lpVtbl[11]))((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDevice*, DML_BINDING_TABLE_DESC*, Guid*, void**, int>)(lpVtbl[12]))((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return ((delegate* stdcall<IDMLDevice*, uint, IDMLPageable**, int>)(lpVtbl[13]))((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return ((delegate* stdcall<IDMLDevice*, uint, IDMLPageable**, int>)(lpVtbl[14]))((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* stdcall<IDMLDevice*, int>)(lpVtbl[15]))((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParentDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDevice*, Guid*, void**, int>)(lpVtbl[16]))((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
