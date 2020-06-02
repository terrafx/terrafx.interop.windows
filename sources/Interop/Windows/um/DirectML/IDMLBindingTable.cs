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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDMLBindingTable* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDMLBindingTable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDMLBindingTable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDMLBindingTable* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDMLBindingTable* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDMLBindingTable* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(IDMLBindingTable* pThis, [NativeTypeName("PCWSTR")] ushort* name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDMLBindingTable* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BindInputs(IDMLBindingTable* pThis, [NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BindOutputs(IDMLBindingTable* pThis, [NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BindTemporaryResource(IDMLBindingTable* pThis, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BindPersistentResource(IDMLBindingTable* pThis, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(IDMLBindingTable* pThis, [NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDMLBindingTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDMLBindingTable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((IDMLBindingTable*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((IDMLBindingTable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public void BindInputs([NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            Marshal.GetDelegateForFunctionPointer<_BindInputs>(lpVtbl->BindInputs)((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        public void BindOutputs([NativeTypeName("UINT")] uint bindingCount, [NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* bindings)
        {
            Marshal.GetDelegateForFunctionPointer<_BindOutputs>(lpVtbl->BindOutputs)((IDMLBindingTable*)Unsafe.AsPointer(ref this), bindingCount, bindings);
        }

        public void BindTemporaryResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            Marshal.GetDelegateForFunctionPointer<_BindTemporaryResource>(lpVtbl->BindTemporaryResource)((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        public void BindPersistentResource([NativeTypeName("const DML_BINDING_DESC *")] DML_BINDING_DESC* binding)
        {
            Marshal.GetDelegateForFunctionPointer<_BindPersistentResource>(lpVtbl->BindPersistentResource)((IDMLBindingTable*)Unsafe.AsPointer(ref this), binding);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("const DML_BINDING_TABLE_DESC *")] DML_BINDING_TABLE_DESC* desc)
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IDMLBindingTable*)Unsafe.AsPointer(ref this), desc);
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

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindInputs;

            [NativeTypeName("void (UINT, const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindOutputs;

            [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindTemporaryResource;

            [NativeTypeName("void (const DML_BINDING_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindPersistentResource;

            [NativeTypeName("HRESULT (const DML_BINDING_TABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Reset;
        }
    }
}
