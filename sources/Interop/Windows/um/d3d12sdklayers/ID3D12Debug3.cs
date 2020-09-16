// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CF4E58F-F671-4FF1-A542-3686E3D153D1")]
    [NativeTypeName("struct ID3D12Debug3 : ID3D12Debug")]
    public unsafe partial struct ID3D12Debug3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Debug3*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Debug3*, uint>)(lpVtbl[1]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Debug3*, uint>)(lpVtbl[2]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnableDebugLayer()
        {
            ((delegate* unmanaged<ID3D12Debug3*, void>)(lpVtbl[3]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* unmanaged<ID3D12Debug3*, int, void>)(lpVtbl[4]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* unmanaged<ID3D12Debug3*, int, void>)(lpVtbl[5]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
        {
            ((delegate* unmanaged<ID3D12Debug3*, D3D12_GPU_BASED_VALIDATION_FLAGS, void>)(lpVtbl[6]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Flags);
        }
    }
}
