// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0DB4C7F-FE5A-42A2-BD62-F2A6CF6FC83E")]
    public unsafe partial struct IDXCoreAdapter
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXCoreAdapter* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXCoreAdapter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXCoreAdapter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsValid(IDXCoreAdapter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsAttributeSupported(IDXCoreAdapter* pThis, [NativeTypeName("const GUID &")] Guid* attributeGUID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsPropertySupported(IDXCoreAdapter* pThis, DXCoreAdapterProperty property);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProperty(IDXCoreAdapter* pThis, DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, [NativeTypeName("void *")] void* propertyData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertySize(IDXCoreAdapter* pThis, DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsQueryStateSupported(IDXCoreAdapter* pThis, DXCoreAdapterState property);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryState(IDXCoreAdapter* pThis, DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, [NativeTypeName("void *")] void* outputBuffer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsSetStateSupported(IDXCoreAdapter* pThis, DXCoreAdapterState property);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetState(IDXCoreAdapter* pThis, DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFactory(IDXCoreAdapter* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
        }

        public bool IsValid()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsValid>(lpVtbl->IsValid)((IDXCoreAdapter*)Unsafe.AsPointer(ref this)) != 0;
        }

        public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsAttributeSupported>(lpVtbl->IsAttributeSupported)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), attributeGUID) != 0;
        }

        public bool IsPropertySupported(DXCoreAdapterProperty property)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsPropertySupported>(lpVtbl->IsPropertySupported)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, [NativeTypeName("void *")] void* propertyData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProperty>(lpVtbl->GetProperty)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertySize>(lpVtbl->GetPropertySize)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize);
        }

        public bool IsQueryStateSupported(DXCoreAdapterState property)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsQueryStateSupported>(lpVtbl->IsQueryStateSupported)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, [NativeTypeName("void *")] void* outputBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryState>(lpVtbl->QueryState)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
        }

        public bool IsSetStateSupported(DXCoreAdapterState property)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsSetStateSupported>(lpVtbl->IsSetStateSupported)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetState>(lpVtbl->SetState)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("bool () __attribute__((stdcall))")]
            public IntPtr IsValid;

            [NativeTypeName("bool (const GUID &) __attribute__((stdcall))")]
            public IntPtr IsAttributeSupported;

            [NativeTypeName("bool (DXCoreAdapterProperty) __attribute__((stdcall))")]
            public IntPtr IsPropertySupported;

            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, void *) __attribute__((stdcall))")]
            public IntPtr GetProperty;

            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t *) __attribute__((stdcall))")]
            public IntPtr GetPropertySize;

            [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
            public IntPtr IsQueryStateSupported;

            [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
            public IntPtr QueryState;

            [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
            public IntPtr IsSetStateSupported;

            [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, const void *) __attribute__((stdcall))")]
            public IntPtr SetState;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetFactory;
        }
    }
}
