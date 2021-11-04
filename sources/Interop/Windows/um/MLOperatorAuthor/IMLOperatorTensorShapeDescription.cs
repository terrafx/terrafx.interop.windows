// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F20E8CBE-3B28-4248-BE95-F96FBC6E4643")]
    [NativeTypeName("struct IMLOperatorTensorShapeDescription : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMLOperatorTensorShapeDescription
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint>)(lpVtbl[1]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint>)(lpVtbl[2]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetInputTensorDimensionCount([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount)
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint*, int>)(lpVtbl[3]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetInputTensorShape([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint, uint*, int>)(lpVtbl[4]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount, dimensions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public bool HasOutputShapeDescription()
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, byte>)(lpVtbl[5]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetOutputTensorDimensionCount([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount)
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint*, int>)(lpVtbl[6]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetOutputTensorShape([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint, uint*, int>)(lpVtbl[7]))((IMLOperatorTensorShapeDescription*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount, dimensions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint> Release;

            [NativeTypeName("HRESULT (uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint*, int> GetInputTensorDimensionCount;

            [NativeTypeName("HRESULT (uint32_t, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint, uint*, int> GetInputTensorShape;

            [NativeTypeName("bool () const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, byte> HasOutputShapeDescription;

            [NativeTypeName("HRESULT (uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint*, int> GetOutputTensorDimensionCount;

            [NativeTypeName("HRESULT (uint32_t, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorTensorShapeDescription*, uint, uint, uint*, int> GetOutputTensorShape;
        }
    }
}
