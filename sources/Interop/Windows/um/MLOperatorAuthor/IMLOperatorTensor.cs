// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7FE41F41-F430-440E-AECE-54416DC8B9DB")]
    [NativeTypeName("struct IMLOperatorTensor : IUnknown")]
    public unsafe partial struct IMLOperatorTensor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, uint>)(lpVtbl[1]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, uint>)(lpVtbl[2]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetDimensionCount()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, uint>)(lpVtbl[3]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShape([NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, uint, uint*, int>)(lpVtbl[4]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this), dimensionCount, dimensions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MLOperatorTensorDataType GetTensorDataType()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, MLOperatorTensorDataType>)(lpVtbl[5]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsCpuData()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, byte>)(lpVtbl[6]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsDataInterface()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, byte>)(lpVtbl[7]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void* GetData()
        {
            return ((delegate* unmanaged<IMLOperatorTensor*, void*>)(lpVtbl[8]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDataInterface(IUnknown** dataInterface)
        {
            ((delegate* unmanaged<IMLOperatorTensor*, IUnknown**, void>)(lpVtbl[9]))((IMLOperatorTensor*)Unsafe.AsPointer(ref this), dataInterface);
        }
    }
}
