// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC893BB1-F938-427B-8488-C8DCF775F138")]
    [NativeTypeName("struct IMLOperatorTypeInferenceContext : IMLOperatorAttributes")]
    public unsafe partial struct IMLOperatorTypeInferenceContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint>)(lpVtbl[1]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint>)(lpVtbl[2]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, sbyte*, MLOperatorAttributeType, uint*, int>)(lpVtbl[3]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, [NativeTypeName("void *")] void* value)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int>)(lpVtbl[4]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, sbyte*, uint, uint*, int>)(lpVtbl[5]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, sbyte*, uint, uint, sbyte*, int>)(lpVtbl[6]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint>)(lpVtbl[7]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("uint32_t")]
        public uint GetOutputCount()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint>)(lpVtbl[8]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint, byte>)(lpVtbl[9]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint, byte>)(lpVtbl[10]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, [NativeTypeName("MLOperatorEdgeDescription *")] MLOperatorEdgeDescription* edgeDescription)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint, MLOperatorEdgeDescription*, int>)(lpVtbl[11]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, edgeDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputEdgeDescription([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("const MLOperatorEdgeDescription *")] MLOperatorEdgeDescription* edgeDescription)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorTypeInferenceContext*, uint, MLOperatorEdgeDescription*, int>)(lpVtbl[12]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex, edgeDescription);
        }
    }
}
