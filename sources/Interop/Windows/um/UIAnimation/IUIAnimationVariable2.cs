// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4914B304-96AB-44D9-9E77-D5109B7E7466")]
    [NativeTypeName("struct IUIAnimationVariable2 : IUnknown")]
    public unsafe partial struct IUIAnimationVariable2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, uint>)(lpVtbl[1]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, uint>)(lpVtbl[2]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDimension([NativeTypeName("UINT *")] uint* dimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, uint*, int>)(lpVtbl[3]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, int>)(lpVtbl[4]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVectorValue([NativeTypeName("DOUBLE *")] double* value, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[5]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurve([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVectorCurve([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IDCompositionAnimation**, uint, int>)(lpVtbl[7]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), animation, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalValue([NativeTypeName("DOUBLE *")] double* finalValue)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, int>)(lpVtbl[8]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalVectorValue([NativeTypeName("DOUBLE *")] double* finalValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[9]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousValue([NativeTypeName("DOUBLE *")] double* previousValue)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, int>)(lpVtbl[10]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousVectorValue([NativeTypeName("DOUBLE *")] double* previousValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[11]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntegerValue([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, int*, int>)(lpVtbl[12]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIntegerVectorValue([NativeTypeName("INT32 *")] int* value, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, int*, uint, int>)(lpVtbl[13]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, int*, int>)(lpVtbl[14]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFinalIntegerVectorValue([NativeTypeName("INT32 *")] int* finalValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, int*, uint, int>)(lpVtbl[15]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, int*, int>)(lpVtbl[16]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousIntegerVectorValue([NativeTypeName("INT32 *")] int* previousValue, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, int*, uint, int>)(lpVtbl[17]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentStoryboard([NativeTypeName("IUIAnimationStoryboard2 **")] IUIAnimationStoryboard2** storyboard)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IUIAnimationStoryboard2**, int>)(lpVtbl[18]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLowerBound([NativeTypeName("DOUBLE")] double bound)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double, int>)(lpVtbl[19]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLowerBoundVector([NativeTypeName("const DOUBLE *")] double* bound, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[20]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpperBound([NativeTypeName("DOUBLE")] double bound)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double, int>)(lpVtbl[21]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpperBoundVector([NativeTypeName("const DOUBLE *")] double* bound, [NativeTypeName("UINT")] uint cDimension)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[22]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, UI_ANIMATION_ROUNDING_MODE, int>)(lpVtbl[23]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IUnknown*, uint, int>)(lpVtbl[24]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTag([NativeTypeName("IUnknown **")] IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IUnknown**, uint*, int>)(lpVtbl[25]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVariableChangeHandler([NativeTypeName("IUIAnimationVariableChangeHandler2 *")] IUIAnimationVariableChangeHandler2* handler, [NativeTypeName("BOOL")] int fRegisterForNextAnimationEvent = 0)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IUIAnimationVariableChangeHandler2*, int, int>)(lpVtbl[26]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), handler, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVariableIntegerChangeHandler([NativeTypeName("IUIAnimationVariableIntegerChangeHandler2 *")] IUIAnimationVariableIntegerChangeHandler2* handler, [NativeTypeName("BOOL")] int fRegisterForNextAnimationEvent = 0)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IUIAnimationVariableIntegerChangeHandler2*, int, int>)(lpVtbl[27]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), handler, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVariableCurveChangeHandler([NativeTypeName("IUIAnimationVariableCurveChangeHandler2 *")] IUIAnimationVariableCurveChangeHandler2* handler)
        {
            return ((delegate* stdcall<IUIAnimationVariable2*, IUIAnimationVariableCurveChangeHandler2*, int>)(lpVtbl[28]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), handler);
        }
    }
}
