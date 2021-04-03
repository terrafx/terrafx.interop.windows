// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E9B31A1-662E-4AE0-AF67-F63BB337E634")]
    [NativeTypeName("struct ILearningModelDeviceFactoryNative : IUnknown")]
    public unsafe partial struct ILearningModelDeviceFactoryNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, Guid*, void**, int>)(lpVtbl[0]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, uint>)(lpVtbl[1]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, uint>)(lpVtbl[2]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromD3D12CommandQueue(ID3D12CommandQueue* value, IUnknown** result)
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, ID3D12CommandQueue*, IUnknown**, int>)(lpVtbl[3]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this), value, result);
        }
    }
}
