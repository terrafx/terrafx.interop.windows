// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("63ACC8D2-6EAE-4BB0-B879-586DD8CFBE42")]
    [NativeTypeName("struct IUIAnimationVariableChangeHandler2 : IUnknown")]
    public unsafe partial struct IUIAnimationVariableChangeHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnValueChanged([NativeTypeName("IUIAnimationStoryboard2 *")] IUIAnimationStoryboard2* storyboard, [NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable, [NativeTypeName("DOUBLE *")] double* newValue, [NativeTypeName("DOUBLE *")] double* previousValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, double*, double*, uint, int>)(lpVtbl[3]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue, cDimension);
        }
    }
}
