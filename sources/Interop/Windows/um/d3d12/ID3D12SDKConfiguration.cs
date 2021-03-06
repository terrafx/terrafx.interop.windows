// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9EB5314-33AA-42B2-A718-D77F58B1F1C7")]
    [NativeTypeName("struct ID3D12SDKConfiguration : IUnknown")]
    public unsafe partial struct ID3D12SDKConfiguration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint>)(lpVtbl[1]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint>)(lpVtbl[2]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSDKVersion([NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("LPCSTR")] sbyte* SDKPath)
        {
            return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint, sbyte*, int>)(lpVtbl[3]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
        }
    }
}
