// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8B6F7D4-4109-4D3F-ACEE-879926968CB1")]
    [NativeTypeName("struct IUIAnimationManager2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationManager2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, uint>)(lpVtbl[1]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, uint>)(lpVtbl[2]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAnimationVectorVariable([NativeTypeName("const DOUBLE *")] double* initialValue, [NativeTypeName("UINT")] uint cDimension, IUIAnimationVariable2** variable)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, double*, uint, IUIAnimationVariable2**, int>)(lpVtbl[3]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), initialValue, cDimension, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAnimationVariable([NativeTypeName("DOUBLE")] double initialValue, IUIAnimationVariable2** variable)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, double, IUIAnimationVariable2**, int>)(lpVtbl[4]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), initialValue, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ScheduleTransition(IUIAnimationVariable2* variable, IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationVariable2*, IUIAnimationTransition2*, double, int>)(lpVtbl[5]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), variable, transition, timeNow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStoryboard(IUIAnimationStoryboard2** storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationStoryboard2**, int>)(lpVtbl[6]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int FinishAllStoryboards([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, double, int>)(lpVtbl[7]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), completionDeadline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int AbandonAllStoryboards()
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, int>)(lpVtbl[8]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_UPDATE_RESULT* updateResult = null)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, double, UI_ANIMATION_UPDATE_RESULT*, int>)(lpVtbl[9]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), timeNow, updateResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetVariableFromTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id, IUIAnimationVariable2** variable)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUnknown*, uint, IUIAnimationVariable2**, int>)(lpVtbl[10]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), @object, id, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetStoryboardFromTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id, IUIAnimationStoryboard2** storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUnknown*, uint, IUIAnimationStoryboard2**, int>)(lpVtbl[11]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), @object, id, storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int EstimateNextEventTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, double*, int>)(lpVtbl[12]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), seconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(UI_ANIMATION_MANAGER_STATUS* status)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, UI_ANIMATION_MANAGER_STATUS*, int>)(lpVtbl[13]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetAnimationMode(UI_ANIMATION_MODE mode)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, UI_ANIMATION_MODE, int>)(lpVtbl[14]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, int>)(lpVtbl[15]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, int>)(lpVtbl[16]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetManagerEventHandler(IUIAnimationManagerEventHandler2* handler, [NativeTypeName("BOOL")] int fRegisterForNextAnimationEvent = 0)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationManagerEventHandler2*, int, int>)(lpVtbl[17]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), handler, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetCancelPriorityComparison(IUIAnimationPriorityComparison2* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationPriorityComparison2*, int>)(lpVtbl[18]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimPriorityComparison(IUIAnimationPriorityComparison2* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationPriorityComparison2*, int>)(lpVtbl[19]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompressPriorityComparison(IUIAnimationPriorityComparison2* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationPriorityComparison2*, int>)(lpVtbl[20]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SetConcludePriorityComparison(IUIAnimationPriorityComparison2* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, IUIAnimationPriorityComparison2*, int>)(lpVtbl[21]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, double, int>)(lpVtbl[22]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this), delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IUIAnimationManager2*, int>)(lpVtbl[23]))((IUIAnimationManager2*)Unsafe.AsPointer(ref this));
        }
    }
}
