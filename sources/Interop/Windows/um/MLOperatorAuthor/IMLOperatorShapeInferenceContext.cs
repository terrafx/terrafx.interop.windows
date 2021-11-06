// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("105B6B29-5408-4A68-9959-09B5955A3492")]
    [NativeTypeName("struct IMLOperatorShapeInferenceContext : IMLOperatorAttributes")]
    [NativeInheritance("IMLOperatorAttributes")]
    public unsafe partial struct IMLOperatorShapeInferenceContext : IMLOperatorShapeInferenceContext.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[1]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[2]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, MLOperatorAttributeType, uint*, int>)(lpVtbl[3]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, void* value)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int>)(lpVtbl[4]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, uint, uint*, int>)(lpVtbl[5]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, uint, uint, sbyte*, int>)(lpVtbl[6]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("uint32_t")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[7]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("uint32_t")]
        public uint GetOutputCount()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[8]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, byte>)(lpVtbl[9]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, byte>)(lpVtbl[10]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, MLOperatorEdgeDescription* edgeDescription)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, MLOperatorEdgeDescription*, int>)(lpVtbl[11]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, edgeDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetInputTensorDimensionCount([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint*, int>)(lpVtbl[12]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetInputTensorShape([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint, uint*, int>)(lpVtbl[13]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount, dimensions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetOutputTensorShape([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("const uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint, uint*, int>)(lpVtbl[14]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount, dimensions);
        }

        public interface Interface : IMLOperatorAttributes.Interface
        {
            [VtblIndex(7)]
            [return: NativeTypeName("uint32_t")]
            uint GetInputCount();

            [VtblIndex(8)]
            [return: NativeTypeName("uint32_t")]
            uint GetOutputCount();

            [VtblIndex(9)]
            bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex);

            [VtblIndex(10)]
            bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex);

            [VtblIndex(11)]
            HRESULT GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, MLOperatorEdgeDescription* edgeDescription);

            [VtblIndex(12)]
            HRESULT GetInputTensorDimensionCount([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount);

            [VtblIndex(13)]
            HRESULT GetInputTensorShape([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions);

            [VtblIndex(14)]
            HRESULT SetOutputTensorShape([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("const uint32_t *")] uint* dimensions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint> Release;

            [NativeTypeName("HRESULT (const char *, MLOperatorAttributeType, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, MLOperatorAttributeType, uint*, int> GetAttributeElementCount;

            [NativeTypeName("HRESULT (const char *, MLOperatorAttributeType, uint32_t, size_t, void *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int> GetAttribute;

            [NativeTypeName("HRESULT (const char *, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, uint, uint*, int> GetStringAttributeElementLength;

            [NativeTypeName("HRESULT (const char *, uint32_t, uint32_t, char *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, uint, uint, sbyte*, int> GetStringAttributeElement;

            [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint> GetInputCount;

            [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint> GetOutputCount;

            [NativeTypeName("bool (uint32_t) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, byte> IsInputValid;

            [NativeTypeName("bool (uint32_t) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, byte> IsOutputValid;

            [NativeTypeName("HRESULT (uint32_t, MLOperatorEdgeDescription *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, MLOperatorEdgeDescription*, int> GetInputEdgeDescription;

            [NativeTypeName("HRESULT (uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint*, int> GetInputTensorDimensionCount;

            [NativeTypeName("HRESULT (uint32_t, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint, uint*, int> GetInputTensorShape;

            [NativeTypeName("HRESULT (uint32_t, uint32_t, const uint32_t *) noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint, uint*, int> SetOutputTensorShape;
        }
    }
}
