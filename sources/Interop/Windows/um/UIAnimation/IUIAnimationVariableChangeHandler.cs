// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6358B7BA-87D2-42D5-BF71-82E919DD5862")]
    [NativeTypeName("struct IUIAnimationVariableChangeHandler : IUnknown")]
    public unsafe partial struct IUIAnimationVariableChangeHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, uint>)(lpVtbl[1]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, uint>)(lpVtbl[2]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnValueChanged([NativeTypeName("IUIAnimationStoryboard *")] IUIAnimationStoryboard* storyboard, [NativeTypeName("IUIAnimationVariable *")] IUIAnimationVariable* variable, [NativeTypeName("DOUBLE")] double newValue, [NativeTypeName("DOUBLE")] double previousValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, IUIAnimationStoryboard*, IUIAnimationVariable*, double, double, int>)(lpVtbl[3]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue);
        }
    }
}
