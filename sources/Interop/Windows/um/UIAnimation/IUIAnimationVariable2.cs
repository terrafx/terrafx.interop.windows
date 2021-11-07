// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4914B304-96AB-44D9-9E77-D5109B7E7466")]
    [NativeTypeName("struct IUIAnimationVariable2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationVariable2 : IUIAnimationVariable2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, uint>)(lpVtbl[1]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, uint>)(lpVtbl[2]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDimension(uint* dimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, uint*, int>)(lpVtbl[3]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), dimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetValue(double* value)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, int>)(lpVtbl[4]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetVectorValue(double* value, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[5]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCurve(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetVectorCurve(IDCompositionAnimation** animation, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IDCompositionAnimation**, uint, int>)(lpVtbl[7]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), animation, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFinalValue(double* finalValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, int>)(lpVtbl[8]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetFinalVectorValue(double* finalValue, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[9]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetPreviousValue(double* previousValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, int>)(lpVtbl[10]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetPreviousVectorValue(double* previousValue, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[11]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetIntegerValue([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, int*, int>)(lpVtbl[12]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetIntegerVectorValue([NativeTypeName("INT32 *")] int* value, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, int*, uint, int>)(lpVtbl[13]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), value, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, int*, int>)(lpVtbl[14]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetFinalIntegerVectorValue([NativeTypeName("INT32 *")] int* finalValue, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, int*, uint, int>)(lpVtbl[15]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), finalValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, int*, int>)(lpVtbl[16]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetPreviousIntegerVectorValue([NativeTypeName("INT32 *")] int* previousValue, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, int*, uint, int>)(lpVtbl[17]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), previousValue, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetCurrentStoryboard(IUIAnimationStoryboard2** storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationStoryboard2**, int>)(lpVtbl[18]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetLowerBound(double bound)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double, int>)(lpVtbl[19]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetLowerBoundVector([NativeTypeName("const DOUBLE *")] double* bound, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[20]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUpperBound(double bound)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double, int>)(lpVtbl[21]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUpperBoundVector([NativeTypeName("const DOUBLE *")] double* bound, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int>)(lpVtbl[22]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), bound, cDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, UI_ANIMATION_ROUNDING_MODE, int>)(lpVtbl[23]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IUnknown*, uint, int>)(lpVtbl[24]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IUnknown**, uint*, int>)(lpVtbl[25]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetVariableChangeHandler(IUIAnimationVariableChangeHandler2* handler, [Optional] BOOL fRegisterForNextAnimationEvent)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationVariableChangeHandler2*, BOOL, int>)(lpVtbl[26]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), handler, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetVariableIntegerChangeHandler(IUIAnimationVariableIntegerChangeHandler2* handler, [Optional] BOOL fRegisterForNextAnimationEvent)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationVariableIntegerChangeHandler2*, BOOL, int>)(lpVtbl[27]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), handler, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetVariableCurveChangeHandler(IUIAnimationVariableCurveChangeHandler2* handler)
        {
            return ((delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationVariableCurveChangeHandler2*, int>)(lpVtbl[28]))((IUIAnimationVariable2*)Unsafe.AsPointer(ref this), handler);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetDimension(uint* dimension);

            [VtblIndex(4)]
            HRESULT GetValue(double* value);

            [VtblIndex(5)]
            HRESULT GetVectorValue(double* value, uint cDimension);

            [VtblIndex(6)]
            HRESULT GetCurve(IDCompositionAnimation* animation);

            [VtblIndex(7)]
            HRESULT GetVectorCurve(IDCompositionAnimation** animation, uint cDimension);

            [VtblIndex(8)]
            HRESULT GetFinalValue(double* finalValue);

            [VtblIndex(9)]
            HRESULT GetFinalVectorValue(double* finalValue, uint cDimension);

            [VtblIndex(10)]
            HRESULT GetPreviousValue(double* previousValue);

            [VtblIndex(11)]
            HRESULT GetPreviousVectorValue(double* previousValue, uint cDimension);

            [VtblIndex(12)]
            HRESULT GetIntegerValue([NativeTypeName("INT32 *")] int* value);

            [VtblIndex(13)]
            HRESULT GetIntegerVectorValue([NativeTypeName("INT32 *")] int* value, uint cDimension);

            [VtblIndex(14)]
            HRESULT GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue);

            [VtblIndex(15)]
            HRESULT GetFinalIntegerVectorValue([NativeTypeName("INT32 *")] int* finalValue, uint cDimension);

            [VtblIndex(16)]
            HRESULT GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue);

            [VtblIndex(17)]
            HRESULT GetPreviousIntegerVectorValue([NativeTypeName("INT32 *")] int* previousValue, uint cDimension);

            [VtblIndex(18)]
            HRESULT GetCurrentStoryboard(IUIAnimationStoryboard2** storyboard);

            [VtblIndex(19)]
            HRESULT SetLowerBound(double bound);

            [VtblIndex(20)]
            HRESULT SetLowerBoundVector([NativeTypeName("const DOUBLE *")] double* bound, uint cDimension);

            [VtblIndex(21)]
            HRESULT SetUpperBound(double bound);

            [VtblIndex(22)]
            HRESULT SetUpperBoundVector([NativeTypeName("const DOUBLE *")] double* bound, uint cDimension);

            [VtblIndex(23)]
            HRESULT SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode);

            [VtblIndex(24)]
            HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id);

            [VtblIndex(25)]
            HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id);

            [VtblIndex(26)]
            HRESULT SetVariableChangeHandler(IUIAnimationVariableChangeHandler2* handler, [Optional] BOOL fRegisterForNextAnimationEvent);

            [VtblIndex(27)]
            HRESULT SetVariableIntegerChangeHandler(IUIAnimationVariableIntegerChangeHandler2* handler, [Optional] BOOL fRegisterForNextAnimationEvent);

            [VtblIndex(28)]
            HRESULT SetVariableCurveChangeHandler(IUIAnimationVariableCurveChangeHandler2* handler);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, uint*, int> GetDimension;

            [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, int> GetValue;

            [NativeTypeName("HRESULT (DOUBLE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int> GetVectorValue;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IDCompositionAnimation*, int> GetCurve;

            [NativeTypeName("HRESULT (IDCompositionAnimation **, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IDCompositionAnimation**, uint, int> GetVectorCurve;

            [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, int> GetFinalValue;

            [NativeTypeName("HRESULT (DOUBLE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int> GetFinalVectorValue;

            [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, int> GetPreviousValue;

            [NativeTypeName("HRESULT (DOUBLE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int> GetPreviousVectorValue;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, int*, int> GetIntegerValue;

            [NativeTypeName("HRESULT (INT32 *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, int*, uint, int> GetIntegerVectorValue;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, int*, int> GetFinalIntegerValue;

            [NativeTypeName("HRESULT (INT32 *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, int*, uint, int> GetFinalIntegerVectorValue;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, int*, int> GetPreviousIntegerValue;

            [NativeTypeName("HRESULT (INT32 *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, int*, uint, int> GetPreviousIntegerVectorValue;

            [NativeTypeName("HRESULT (IUIAnimationStoryboard2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationStoryboard2**, int> GetCurrentStoryboard;

            [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double, int> SetLowerBound;

            [NativeTypeName("HRESULT (const DOUBLE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int> SetLowerBoundVector;

            [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double, int> SetUpperBound;

            [NativeTypeName("HRESULT (const DOUBLE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, double*, uint, int> SetUpperBoundVector;

            [NativeTypeName("HRESULT (UI_ANIMATION_ROUNDING_MODE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, UI_ANIMATION_ROUNDING_MODE, int> SetRoundingMode;

            [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IUnknown*, uint, int> SetTag;

            [NativeTypeName("HRESULT (IUnknown **, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IUnknown**, uint*, int> GetTag;

            [NativeTypeName("HRESULT (IUIAnimationVariableChangeHandler2 *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationVariableChangeHandler2*, BOOL, int> SetVariableChangeHandler;

            [NativeTypeName("HRESULT (IUIAnimationVariableIntegerChangeHandler2 *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationVariableIntegerChangeHandler2*, BOOL, int> SetVariableIntegerChangeHandler;

            [NativeTypeName("HRESULT (IUIAnimationVariableCurveChangeHandler2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable2*, IUIAnimationVariableCurveChangeHandler2*, int> SetVariableCurveChangeHandler;
        }
    }
}
