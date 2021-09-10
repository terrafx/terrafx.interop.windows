// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("829B6CF1-4F3A-4412-AE09-B243EB4C6B58")]
    [NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationVariableIntegerChangeHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnIntegerValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, [NativeTypeName("INT32 *")] int* newValue, [NativeTypeName("INT32 *")] int* previousValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, int*, int*, uint, int>)(lpVtbl[3]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue, cDimension);
        }
    }
}
