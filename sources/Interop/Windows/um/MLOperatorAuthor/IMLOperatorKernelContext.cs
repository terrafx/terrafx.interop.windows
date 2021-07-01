// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("82536A28-F022-4769-9D3F-8B278F84C0C3")]
    [NativeTypeName("struct IMLOperatorKernelContext : IUnknown")]
    public unsafe partial struct IMLOperatorKernelContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, uint>)(lpVtbl[1]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, uint>)(lpVtbl[2]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTensor([NativeTypeName("uint32_t")] uint inputIndex, IMLOperatorTensor** tensor)
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, uint, IMLOperatorTensor**, int>)(lpVtbl[3]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), inputIndex, tensor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputTensor([NativeTypeName("uint32_t")] uint outputIndex, IMLOperatorTensor** tensor)
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, uint, IMLOperatorTensor**, int>)(lpVtbl[5]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), outputIndex, tensor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputTensor([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("const uint32_t *")] uint* dimensionSizes, IMLOperatorTensor** tensor)
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, uint, uint, uint*, IMLOperatorTensor**, int>)(lpVtbl[4]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount, dimensionSizes, tensor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AllocateTemporaryData([NativeTypeName("size_t")] nuint size, IUnknown** data)
        {
            return ((delegate* unmanaged<IMLOperatorKernelContext*, nuint, IUnknown**, int>)(lpVtbl[6]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), size, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetExecutionInterface(IUnknown** executionObject)
        {
            ((delegate* unmanaged<IMLOperatorKernelContext*, IUnknown**, void>)(lpVtbl[7]))((IMLOperatorKernelContext*)Unsafe.AsPointer(ref this), executionObject);
        }
    }
}
