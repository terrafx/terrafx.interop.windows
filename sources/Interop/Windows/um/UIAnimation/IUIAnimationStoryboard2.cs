// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE289CD2-12D4-4945-9419-9E41BE034DF2")]
    [NativeTypeName("struct IUIAnimationStoryboard2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationStoryboard2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, uint>)(lpVtbl[1]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, uint>)(lpVtbl[2]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddTransition(IUIAnimationVariable2* variable, IUIAnimationTransition2* transition)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUIAnimationVariable2*, IUIAnimationTransition2*, int>)(lpVtbl[3]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddKeyframeAtOffset([NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* existingKeyframe, [NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("UI_ANIMATION_KEYFRAME *")] UI_ANIMATION_KEYFRAME** keyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, UI_ANIMATION_KEYFRAME*, double, UI_ANIMATION_KEYFRAME**, int>)(lpVtbl[4]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), existingKeyframe, offset, keyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddKeyframeAfterTransition(IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME *")] UI_ANIMATION_KEYFRAME** keyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUIAnimationTransition2*, UI_ANIMATION_KEYFRAME**, int>)(lpVtbl[5]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), transition, keyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddTransitionAtKeyframe(IUIAnimationVariable2* variable, IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUIAnimationVariable2*, IUIAnimationTransition2*, UI_ANIMATION_KEYFRAME*, int>)(lpVtbl[6]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddTransitionBetweenKeyframes(IUIAnimationVariable2* variable, IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* endKeyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUIAnimationVariable2*, IUIAnimationTransition2*, UI_ANIMATION_KEYFRAME*, UI_ANIMATION_KEYFRAME*, int>)(lpVtbl[7]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe, endKeyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RepeatBetweenKeyframes([NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* endKeyframe, [NativeTypeName("DOUBLE")] double cRepetition, UI_ANIMATION_REPEAT_MODE repeatMode, [Optional] IUIAnimationLoopIterationChangeHandler2* pIterationChangeHandler, [NativeTypeName("UINT_PTR")] [Optional] nuint id, [Optional] BOOL fRegisterForNextAnimationEvent)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, UI_ANIMATION_KEYFRAME*, UI_ANIMATION_KEYFRAME*, double, UI_ANIMATION_REPEAT_MODE, IUIAnimationLoopIterationChangeHandler2*, nuint, BOOL, int>)(lpVtbl[8]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), startKeyframe, endKeyframe, cRepetition, repeatMode, pIterationChangeHandler, id, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT HoldVariable(IUIAnimationVariable2* variable)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUIAnimationVariable2*, int>)(lpVtbl[9]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, double, int>)(lpVtbl[10]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetSkipDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double secondsDuration)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, double, int>)(lpVtbl[11]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), secondsDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Schedule([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, double, UI_ANIMATION_SCHEDULING_RESULT*, int>)(lpVtbl[12]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), timeNow, schedulingResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Conclude()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, int>)(lpVtbl[13]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, double, int>)(lpVtbl[14]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), completionDeadline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT Abandon()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, int>)(lpVtbl[15]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUnknown*, uint, int>)(lpVtbl[16]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUnknown**, uint*, int>)(lpVtbl[17]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetStatus(UI_ANIMATION_STORYBOARD_STATUS* status)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, UI_ANIMATION_STORYBOARD_STATUS*, int>)(lpVtbl[18]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, double*, int>)(lpVtbl[19]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), elapsedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetStoryboardEventHandler(IUIAnimationStoryboardEventHandler2* handler, [Optional] BOOL fRegisterStatusChangeForNextAnimationEvent, [Optional] BOOL fRegisterUpdateForNextAnimationEvent)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard2*, IUIAnimationStoryboardEventHandler2*, BOOL, BOOL, int>)(lpVtbl[20]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), handler, fRegisterStatusChangeForNextAnimationEvent, fRegisterUpdateForNextAnimationEvent);
        }
    }
}
