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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDMLDevice* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDMLDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDMLDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDMLDevice* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDMLDevice* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDMLDevice* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(IDMLDevice* pThis, [NativeTypeName("PCWSTR")] ushort* name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(IDMLDevice* pThis, DML_FEATURE feature, [NativeTypeName("UINT")] uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, [NativeTypeName("UINT")] uint featureSupportDataSize, [NativeTypeName("void *")] void* featureSupportData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateOperator(IDMLDevice* pThis, [NativeTypeName("const DML_OPERATOR_DESC *")] DML_OPERATOR_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CompileOperator(IDMLDevice* pThis, [NativeTypeName("IDMLOperator *")] IDMLOperator* op, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateOperatorInitializer(IDMLDevice* pThis, [NativeTypeName("UINT")] uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandRecorder(IDMLDevice* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBindingTable(IDMLDevice* pThis, [NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Evict(IDMLDevice* pThis, [NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeResident(IDMLDevice* pThis, [NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceRemovedReason(IDMLDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParentDevice(IDMLDevice* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDMLDevice*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDMLDevice*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((IDMLDevice*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DML_FEATURE feature, [NativeTypeName("UINT")] uint featureQueryDataSize, [NativeTypeName("const void *")] void* featureQueryData, [NativeTypeName("UINT")] uint featureSupportDataSize, [NativeTypeName("void *")] void* featureSupportData)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((IDMLDevice*)Unsafe.AsPointer(ref this), feature, featureQueryDataSize, featureQueryData, featureSupportDataSize, featureSupportData);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOperator([NativeTypeName("const DML_OPERATOR_DESC *")] DML_OPERATOR_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateOperator>(lpVtbl->CreateOperator)((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompileOperator([NativeTypeName("IDMLOperator *")] IDMLOperator* op, DML_EXECUTION_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_CompileOperator>(lpVtbl->CompileOperator)((IDMLDevice*)Unsafe.AsPointer(ref this), op, flags, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOperatorInitializer([NativeTypeName("UINT")] uint operatorCount, [NativeTypeName("IDMLCompiledOperator *const *")] IDMLCompiledOperator** operators, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateOperatorInitializer>(lpVtbl->CreateOperatorInitializer)((IDMLDevice*)Unsafe.AsPointer(ref this), operatorCount, operators, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandRecorder([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateCommandRecorder>(lpVtbl->CreateCommandRecorder)((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBindingTable([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBindingTable>(lpVtbl->CreateBindingTable)((IDMLDevice*)Unsafe.AsPointer(ref this), desc, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int Evict([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return Marshal.GetDelegateForFunctionPointer<_Evict>(lpVtbl->Evict)((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeResident([NativeTypeName("UINT")] uint count, [NativeTypeName("IDMLPageable *const *")] IDMLPageable** ppObjects)
        {
            return Marshal.GetDelegateForFunctionPointer<_MakeResident>(lpVtbl->MakeResident)((IDMLDevice*)Unsafe.AsPointer(ref this), count, ppObjects);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceRemovedReason>(lpVtbl->GetDeviceRemovedReason)((IDMLDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParentDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParentDevice>(lpVtbl->GetParentDevice)((IDMLDevice*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetName;

            [NativeTypeName("HRESULT (DML_FEATURE, UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CheckFeatureSupport;

            [NativeTypeName("HRESULT (const DML_OPERATOR_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateOperator;

            [NativeTypeName("HRESULT (IDMLOperator *, DML_EXECUTION_FLAGS, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CompileOperator;

            [NativeTypeName("HRESULT (UINT, IDMLCompiledOperator *const *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateOperatorInitializer;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateCommandRecorder;

            [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBindingTable;

            [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Evict;

            [NativeTypeName("HRESULT (UINT, IDMLPageable *const *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MakeResident;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDeviceRemovedReason;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetParentDevice;
        }
    }
}
