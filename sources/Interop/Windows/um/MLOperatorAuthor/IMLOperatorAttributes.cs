// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B1B1759-EC40-466C-AAB4-BEB5347FD24C")]
    [NativeTypeName("struct IMLOperatorAttributes : IUnknown")]
    public unsafe partial struct IMLOperatorAttributes
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, uint>)(lpVtbl[1]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, uint>)(lpVtbl[2]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, MLOperatorAttributeType, uint*, int>)(lpVtbl[3]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, type, elementCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, void* value)
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int>)(lpVtbl[4]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, uint, uint*, int>)(lpVtbl[5]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
        {
            return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, uint, uint, sbyte*, int>)(lpVtbl[6]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
        }
    }
}
