// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("781AEB48-9BCB-4797-BF77-8BF455217BEB")]
    [NativeTypeName("struct IMLOperatorTypeInferrer : IUnknown")]
    public unsafe partial struct IMLOperatorTypeInferrer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorTypeInferrer*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorTypeInferrer*, uint>)(lpVtbl[1]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorTypeInferrer*, uint>)(lpVtbl[2]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InferOutputTypes([NativeTypeName("IMLOperatorTypeInferenceContext *")] IMLOperatorTypeInferenceContext* context)
        {
            return ((delegate* unmanaged<IMLOperatorTypeInferrer*, IMLOperatorTypeInferenceContext*, int>)(lpVtbl[3]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this), context);
        }
    }
}
