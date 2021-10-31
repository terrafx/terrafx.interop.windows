// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9169896C-AC8D-4E7D-94E5-67FA4DC2F2E8")]
    [NativeTypeName("struct IUIAnimationManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationManager*, uint>)(lpVtbl[1]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationManager*, uint>)(lpVtbl[2]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateAnimationVariable([NativeTypeName("DOUBLE")] double initialValue, IUIAnimationVariable** variable)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, double, IUIAnimationVariable**, int>)(lpVtbl[3]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), initialValue, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ScheduleTransition(IUIAnimationVariable* variable, IUIAnimationTransition* transition, [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationVariable*, IUIAnimationTransition*, double, int>)(lpVtbl[4]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), variable, transition, timeNow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateStoryboard(IUIAnimationStoryboard** storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationStoryboard**, int>)(lpVtbl[5]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT FinishAllStoryboards([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, double, int>)(lpVtbl[6]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), completionDeadline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AbandonAllStoryboards()
        {
            return ((delegate* unmanaged<IUIAnimationManager*, int>)(lpVtbl[7]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Update([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_UPDATE_RESULT* updateResult = null)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, double, UI_ANIMATION_UPDATE_RESULT*, int>)(lpVtbl[8]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), timeNow, updateResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetVariableFromTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id, IUIAnimationVariable** variable)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUnknown*, uint, IUIAnimationVariable**, int>)(lpVtbl[9]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), @object, id, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetStoryboardFromTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id, IUIAnimationStoryboard** storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUnknown*, uint, IUIAnimationStoryboard**, int>)(lpVtbl[10]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), @object, id, storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStatus(UI_ANIMATION_MANAGER_STATUS* status)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, UI_ANIMATION_MANAGER_STATUS*, int>)(lpVtbl[11]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetAnimationMode(UI_ANIMATION_MODE mode)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, UI_ANIMATION_MODE, int>)(lpVtbl[12]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<IUIAnimationManager*, int>)(lpVtbl[13]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<IUIAnimationManager*, int>)(lpVtbl[14]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetManagerEventHandler(IUIAnimationManagerEventHandler* handler)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationManagerEventHandler*, int>)(lpVtbl[15]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetCancelPriorityComparison(IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[16]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTrimPriorityComparison(IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[17]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetCompressPriorityComparison(IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[18]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetConcludePriorityComparison(IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[19]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetDefaultLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
        {
            return ((delegate* unmanaged<IUIAnimationManager*, double, int>)(lpVtbl[20]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IUIAnimationManager*, int>)(lpVtbl[21]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }
    }
}
