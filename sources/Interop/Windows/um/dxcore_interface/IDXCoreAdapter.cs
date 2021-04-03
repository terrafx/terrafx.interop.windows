// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0DB4C7F-FE5A-42A2-BD62-F2A6CF6FC83E")]
    [NativeTypeName("struct IDXCoreAdapter : IUnknown")]
    public unsafe partial struct IDXCoreAdapter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, uint>)(lpVtbl[1]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, uint>)(lpVtbl[2]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsValid()
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, byte>)(lpVtbl[3]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, Guid*, byte>)(lpVtbl[4]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), attributeGUID) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsPropertySupported(DXCoreAdapterProperty property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterProperty, byte>)(lpVtbl[5]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterProperty, nuint, void*, int>)(lpVtbl[6]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterProperty, nuint*, int>)(lpVtbl[7]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsQueryStateSupported(DXCoreAdapterState property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterState, byte>)(lpVtbl[8]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterState, nuint, void*, nuint, void*, int>)(lpVtbl[9]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsSetStateSupported(DXCoreAdapterState property)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterState, byte>)(lpVtbl[10]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, DXCoreAdapterState, nuint, void*, nuint, void*, int>)(lpVtbl[11]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
        {
            return ((delegate* unmanaged<IDXCoreAdapter*, Guid*, void**, int>)(lpVtbl[12]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }
    }
}
