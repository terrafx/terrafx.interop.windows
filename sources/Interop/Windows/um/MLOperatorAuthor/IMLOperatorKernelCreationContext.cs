// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5459B53D-A0FC-4665-ADDD-70171EF7E631")]
    [NativeTypeName("struct IMLOperatorKernelCreationContext : IMLOperatorAttributes")]
    public unsafe partial struct IMLOperatorKernelCreationContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint>)(lpVtbl[1]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint>)(lpVtbl[2]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, sbyte*, MLOperatorAttributeType, uint*, int>)(lpVtbl[3]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), name, type, elementCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, void* value)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int>)(lpVtbl[4]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, sbyte*, uint, uint*, int>)(lpVtbl[5]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, sbyte*, uint, uint, sbyte*, int>)(lpVtbl[6]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint>)(lpVtbl[7]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetOutputCount()
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint>)(lpVtbl[8]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint, byte>)(lpVtbl[9]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), inputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint, byte>)(lpVtbl[10]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), outputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, MLOperatorEdgeDescription* edgeDescription)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint, MLOperatorEdgeDescription*, int>)(lpVtbl[11]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), inputIndex, edgeDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputEdgeDescription([NativeTypeName("uint32_t")] uint outputIndex, MLOperatorEdgeDescription* edgeDescription)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, uint, MLOperatorEdgeDescription*, int>)(lpVtbl[12]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), outputIndex, edgeDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool HasTensorShapeDescription()
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, byte>)(lpVtbl[13]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTensorShapeDescription(IMLOperatorTensorShapeDescription** shapeDescription)
        {
            return ((delegate* unmanaged<IMLOperatorKernelCreationContext*, IMLOperatorTensorShapeDescription**, int>)(lpVtbl[14]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), shapeDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetExecutionInterface(IUnknown** executionObject)
        {
            ((delegate* unmanaged<IMLOperatorKernelCreationContext*, IUnknown**, void>)(lpVtbl[15]))((IMLOperatorKernelCreationContext*)Unsafe.AsPointer(ref this), executionObject);
        }
    }
}
