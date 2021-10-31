// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("60ECCBC1-378D-4DF1-894C-F8AC5CE4D7DD")]
    [NativeTypeName("struct ID3D12DebugDevice2 : ID3D12DebugDevice")]
    [NativeInheritance("ID3D12DebugDevice")]
    public unsafe partial struct ID3D12DebugDevice2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, uint>)(lpVtbl[1]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, uint>)(lpVtbl[2]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, D3D12_DEBUG_FEATURE, int>)(lpVtbl[3]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, D3D12_DEBUG_FEATURE>)(lpVtbl[4]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, D3D12_RLDO_FLAGS, int>)(lpVtbl[5]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugDevice2*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }
    }
}
