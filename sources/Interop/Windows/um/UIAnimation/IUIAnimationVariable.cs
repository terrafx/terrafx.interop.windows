// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8CEEB155-2849-4CE5-9448-91FF70E1E4D9")]
    [NativeTypeName("struct IUIAnimationVariable : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationVariable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, uint>)(lpVtbl[1]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, uint>)(lpVtbl[2]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetValue(double* value)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, double*, int>)(lpVtbl[3]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFinalValue(double* finalValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, double*, int>)(lpVtbl[4]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPreviousValue(double* previousValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, double*, int>)(lpVtbl[5]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetIntegerValue([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, int*, int>)(lpVtbl[6]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, int*, int>)(lpVtbl[7]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), finalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, int*, int>)(lpVtbl[8]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), previousValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetCurrentStoryboard(IUIAnimationStoryboard** storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, IUIAnimationStoryboard**, int>)(lpVtbl[9]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLowerBound(double bound)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, double, int>)(lpVtbl[10]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetUpperBound(double bound)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, double, int>)(lpVtbl[11]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), bound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, UI_ANIMATION_ROUNDING_MODE, int>)(lpVtbl[12]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, IUnknown*, uint, int>)(lpVtbl[13]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, IUnknown**, uint*, int>)(lpVtbl[14]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetVariableChangeHandler(IUIAnimationVariableChangeHandler* handler)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, IUIAnimationVariableChangeHandler*, int>)(lpVtbl[15]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetVariableIntegerChangeHandler(IUIAnimationVariableIntegerChangeHandler* handler)
        {
            return ((delegate* unmanaged<IUIAnimationVariable*, IUIAnimationVariableIntegerChangeHandler*, int>)(lpVtbl[16]))((IUIAnimationVariable*)Unsafe.AsPointer(ref this), handler);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, uint> Release;

            [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, double*, int> GetValue;

            [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, double*, int> GetFinalValue;

            [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, double*, int> GetPreviousValue;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, int*, int> GetIntegerValue;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, int*, int> GetFinalIntegerValue;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, int*, int> GetPreviousIntegerValue;

            [NativeTypeName("HRESULT (IUIAnimationStoryboard **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, IUIAnimationStoryboard**, int> GetCurrentStoryboard;

            [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, double, int> SetLowerBound;

            [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, double, int> SetUpperBound;

            [NativeTypeName("HRESULT (UI_ANIMATION_ROUNDING_MODE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, UI_ANIMATION_ROUNDING_MODE, int> SetRoundingMode;

            [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, IUnknown*, uint, int> SetTag;

            [NativeTypeName("HRESULT (IUnknown **, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, IUnknown**, uint*, int> GetTag;

            [NativeTypeName("HRESULT (IUIAnimationVariableChangeHandler *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, IUIAnimationVariableChangeHandler*, int> SetVariableChangeHandler;

            [NativeTypeName("HRESULT (IUIAnimationVariableIntegerChangeHandler *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariable*, IUIAnimationVariableIntegerChangeHandler*, int> SetVariableIntegerChangeHandler;
        }
    }
}
