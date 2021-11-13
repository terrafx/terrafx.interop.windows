// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("E6857A76-2E3E-4FDD-BFF4-5D2BA10FB453")]
    [NativeTypeName("struct IDMLCommandRecorder : IDMLDeviceChild")]
    [NativeInheritance("IDMLDeviceChild")]
    public unsafe partial struct IDMLCommandRecorder : IDMLCommandRecorder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, Guid*, void**, int>)(lpVtbl[0]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, uint>)(lpVtbl[1]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, uint>)(lpVtbl[2]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, ushort*, int>)(lpVtbl[6]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLCommandRecorder*, Guid*, void**, int>)(lpVtbl[7]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void RecordDispatch(ID3D12CommandList* commandList, IDMLDispatchable* dispatchable, IDMLBindingTable* bindings)
        {
            ((delegate* unmanaged<IDMLCommandRecorder*, ID3D12CommandList*, IDMLDispatchable*, IDMLBindingTable*, void>)(lpVtbl[8]))((IDMLCommandRecorder*)Unsafe.AsPointer(ref this), commandList, dispatchable, bindings);
        }

        public interface Interface : IDMLDeviceChild.Interface
        {
            [VtblIndex(8)]
            void RecordDispatch(ID3D12CommandList* commandList, IDMLDispatchable* dispatchable, IDMLBindingTable* bindings);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, Guid*, void**, int> GetDevice;

            [NativeTypeName("void (ID3D12CommandList *, IDMLDispatchable *, IDMLBindingTable *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLCommandRecorder*, ID3D12CommandList*, IDMLDispatchable*, IDMLBindingTable*, void> RecordDispatch;
        }
    }
}
