// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("540BE5BE-A6C9-40EE-83F6-D2B8B40A7798")]
    [NativeTypeName("struct IMLOperatorShapeInferrer : IUnknown")]
    public unsafe partial struct IMLOperatorShapeInferrer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorShapeInferrer*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorShapeInferrer*, uint>)(lpVtbl[1]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorShapeInferrer*, uint>)(lpVtbl[2]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InferOutputShapes([NativeTypeName("IMLOperatorShapeInferenceContext *")] IMLOperatorShapeInferenceContext* context)
        {
            return ((delegate* unmanaged[Stdcall]<IMLOperatorShapeInferrer*, IMLOperatorShapeInferenceContext*, int>)(lpVtbl[3]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this), context);
        }
    }
}
