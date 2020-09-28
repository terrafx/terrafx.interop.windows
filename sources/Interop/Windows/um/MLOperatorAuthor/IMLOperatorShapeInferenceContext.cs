// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("105B6B29-5408-4A68-9959-09B5955A3492")]
    [NativeTypeName("struct IMLOperatorShapeInferenceContext : IMLOperatorAttributes")]
    public unsafe partial struct IMLOperatorShapeInferenceContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[1]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[2]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, MLOperatorAttributeType, uint*, int>)(lpVtbl[3]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, [NativeTypeName("void *")] void* value)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int>)(lpVtbl[4]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, uint, uint*, int>)(lpVtbl[5]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, sbyte*, uint, uint, sbyte*, int>)(lpVtbl[6]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[7]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetOutputCount()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint>)(lpVtbl[8]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, byte>)(lpVtbl[9]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, byte>)(lpVtbl[10]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("MLOperatorEdgeDescription *")] MLOperatorEdgeDescription* edgeDescription)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, MLOperatorEdgeDescription*, int>)(lpVtbl[11]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, edgeDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTensorDimensionCount([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t *")] uint* dimensionCount)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint*, int>)(lpVtbl[12]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTensorShape([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint, uint*, int>)(lpVtbl[13]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, dimensionCount, dimensions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputTensorShape([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("uint32_t")] uint dimensionCount, [NativeTypeName("const uint32_t *")] uint* dimensions)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferenceContext*, uint, uint, uint*, int>)(lpVtbl[14]))((IMLOperatorShapeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex, dimensionCount, dimensions);
        }
    }
}
