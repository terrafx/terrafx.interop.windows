// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DBD6437-96FD-423F-A98C-AE5E7C2A573F")]
    public unsafe partial struct IDMLDevice
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return lpVtbl->GetPrivateData((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return lpVtbl->SetPrivateData((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return lpVtbl->SetPrivateDataInterface((IDMLDevice*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return lpVtbl->SetName((IDMLDevice*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DML_FEATURE feature, [NativeTypeName("UINT")] uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, [NativeTypeName("UINT")] uint featureSupportDataSize, [NativeTypeName("void *")] void* featureSupportData)
        {
            return lpVtbl->CheckFeatureSupport((IDMLDevice*)Unsafe.AsPointer(ref this), feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DML_OPERATOR_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->CreateOperator((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompileOperator([NativeTypeName("IDMLOperator *")] IDMLOperator* op, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->CompileOperator((IDMLDevice*)Unsafe.AsPointer(ref this), op, flags, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOperatorInitializer([NativeTypeName("UINT")] uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->CreateOperatorInitializer((IDMLDevice*)Unsafe.AsPointer(ref this), operatorCount, operators, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->CreateCommandRecorder((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->CreateBindingTable((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return lpVtbl->Evict((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return lpVtbl->MakeResident((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return lpVtbl->GetDeviceRemovedReason((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParentDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->GetParentDevice((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (DML_FEATURE, UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, DML_FEATURE, uint, void*, uint, void*, int> CheckFeatureSupport;

            [NativeTypeName("HRESULT (const DML_OPERATOR_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, DML_OPERATOR_DESC*, Guid*, void**, int> CreateOperator;

            [NativeTypeName("HRESULT (IDMLOperator *, DML_EXECUTION_FLAGS, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, IDMLOperator*, DML_EXECUTION_FLAGS, Guid*, void**, int> CompileOperator;

            [NativeTypeName("HRESULT (UINT, IDMLCompiledOperator *const *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, uint, IDMLCompiledOperator**, Guid*, void**, int> CreateOperatorInitializer;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, Guid*, void**, int> CreateCommandRecorder;

            [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, DML_BINDING_TABLE_DESC*, Guid*, void**, int> CreateBindingTable;

            [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, uint, IDMLPageable**, int> Evict;

            [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, uint, IDMLPageable**, int> MakeResident;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, int> GetDeviceRemovedReason;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDMLDevice*, Guid*, void**, int> GetParentDevice;
        }
    }
}
