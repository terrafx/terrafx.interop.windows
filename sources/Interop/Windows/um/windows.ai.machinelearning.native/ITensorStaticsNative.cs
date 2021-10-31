// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("39D055A4-66F6-4EBC-95D9-7A29EBE7690A")]
    [NativeTypeName("struct ITensorStaticsNative : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITensorStaticsNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITensorStaticsNative*, Guid*, void**, int>)(lpVtbl[0]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITensorStaticsNative*, uint>)(lpVtbl[1]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITensorStaticsNative*, uint>)(lpVtbl[2]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateFromD3D12Resource(ID3D12Resource* value, [NativeTypeName("long long *")] long* shape, int shapeCount, IUnknown** result)
        {
            return ((delegate* unmanaged<ITensorStaticsNative*, ID3D12Resource*, long*, int, IUnknown**, int>)(lpVtbl[3]))((ITensorStaticsNative*)Unsafe.AsPointer(ref this), value, shape, shapeCount, result);
        }
    }
}
