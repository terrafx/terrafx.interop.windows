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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
        }

        public bool IsValid()
        {
            return lpVtbl->IsValid((IDXCoreAdapter*)Unsafe.AsPointer(ref this)) != 0;
        }

        public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
        {
            return lpVtbl->IsAttributeSupported((IDXCoreAdapter*)Unsafe.AsPointer(ref this), attributeGUID) != 0;
        }

        public bool IsPropertySupported(DXCoreAdapterProperty property)
        {
            return lpVtbl->IsPropertySupported((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, [NativeTypeName("void *")] void* propertyData)
        {
            return lpVtbl->GetProperty((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
        {
            return lpVtbl->GetPropertySize((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize);
        }

        public bool IsQueryStateSupported(DXCoreAdapterState property)
        {
            return lpVtbl->IsQueryStateSupported((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, [NativeTypeName("void *")] void* outputBuffer)
        {
            return lpVtbl->QueryState((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
        }

        public bool IsSetStateSupported(DXCoreAdapterState property)
        {
            return lpVtbl->IsSetStateSupported((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
        {
            return lpVtbl->SetState((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory)
        {
            return lpVtbl->GetFactory((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, uint> Release;

            [NativeTypeName("bool () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, byte> IsValid;

            [NativeTypeName("bool (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, Guid*, byte> IsAttributeSupported;

            [NativeTypeName("bool (DXCoreAdapterProperty) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterProperty, byte> IsPropertySupported;

            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterProperty, nuint, void*, int> GetProperty;

            [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterProperty, nuint*, int> GetPropertySize;

            [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterState, byte> IsQueryStateSupported;

            [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterState, nuint, void*, nuint, void*, int> QueryState;

            [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterState, byte> IsSetStateSupported;

            [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, DXCoreAdapterState, nuint, void*, nuint, void*, int> SetState;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapter*, Guid*, void**, int> GetFactory;
        }
    }
}
