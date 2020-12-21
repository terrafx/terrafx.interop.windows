// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72895E91-0145-4C21-9192-5AAB40EDDF80")]
    [NativeTypeName("struct IUIAnimationVariableCurveChangeHandler2 : IUnknown")]
    public unsafe partial struct IUIAnimationVariableCurveChangeHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableCurveChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableCurveChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableCurveChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCurveChanged([NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariableCurveChangeHandler2*, IUIAnimationVariable2*, int>)(lpVtbl[3]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this), variable);
        }
    }
}
