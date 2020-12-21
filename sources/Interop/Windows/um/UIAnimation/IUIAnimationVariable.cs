// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8CEEB155-2849-4CE5-9448-91FF70E1E4D9")]
    [NativeTypeName("struct IUIAnimationVariable : IUnknown")]
    public unsafe partial struct IUIAnimationVariable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, uint>)(lpVtbl[1]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, uint>)(lpVtbl[2]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, double*, int>)(lpVtbl[3]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalValue([NativeTypeName("DOUBLE *")] double* finalValue)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, double*, int>)(lpVtbl[4]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousValue([NativeTypeName("DOUBLE *")] double* previousValue)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, double*, int>)(lpVtbl[5]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntegerValue([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, int*, int>)(lpVtbl[6]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, int*, int>)(lpVtbl[7]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, int*, int>)(lpVtbl[8]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentStoryboard([NativeTypeName("IUIAnimationStoryboard **")] IUIAnimationStoryboard** storyboard)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, IUIAnimationStoryboard**, int>)(lpVtbl[9]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLowerBound([NativeTypeName("DOUBLE")] double bound)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, double, int>)(lpVtbl[10]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpperBound([NativeTypeName("DOUBLE")] double bound)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, double, int>)(lpVtbl[11]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, UI_ANIMATION_ROUNDING_MODE, int>)(lpVtbl[12]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, IUnknown*, uint, int>)(lpVtbl[13]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTag([NativeTypeName("IUnknown **")] IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, IUnknown**, uint*, int>)(lpVtbl[14]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVariableChangeHandler([NativeTypeName("IUIAnimationVariableChangeHandler *")] IUIAnimationVariableChangeHandler* handler)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, IUIAnimationVariableChangeHandler*, int>)(lpVtbl[15]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVariableIntegerChangeHandler([NativeTypeName("IUIAnimationVariableIntegerChangeHandler *")] IUIAnimationVariableIntegerChangeHandler* handler)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationVariable*, IUIAnimationVariableIntegerChangeHandler*, int>)(lpVtbl[16]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), handler);
        }
    }
}
