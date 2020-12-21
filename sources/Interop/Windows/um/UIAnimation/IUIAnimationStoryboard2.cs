// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE289CD2-12D4-4945-9419-9E41BE034DF2")]
    [NativeTypeName("struct IUIAnimationStoryboard2 : IUnknown")]
    public unsafe partial struct IUIAnimationStoryboard2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, uint>)(lpVtbl[1]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, uint>)(lpVtbl[2]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTransition([NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable, [NativeTypeName("IUIAnimationTransition2 *")] IUIAnimationTransition2* transition)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUIAnimationVariable2*, IUIAnimationTransition2*, int>)(lpVtbl[3]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddKeyframeAtOffset([NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* existingKeyframe, [NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("UI_ANIMATION_KEYFRAME *")] UI_ANIMATION_KEYFRAME** keyframe)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, UI_ANIMATION_KEYFRAME*, double, UI_ANIMATION_KEYFRAME**, int>)(lpVtbl[4]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), existingKeyframe, offset, keyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddKeyframeAfterTransition([NativeTypeName("IUIAnimationTransition2 *")] IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME *")] UI_ANIMATION_KEYFRAME** keyframe)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUIAnimationTransition2*, UI_ANIMATION_KEYFRAME**, int>)(lpVtbl[5]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), transition, keyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTransitionAtKeyframe([NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable, [NativeTypeName("IUIAnimationTransition2 *")] IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUIAnimationVariable2*, IUIAnimationTransition2*, UI_ANIMATION_KEYFRAME*, int>)(lpVtbl[6]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTransitionBetweenKeyframes([NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable, [NativeTypeName("IUIAnimationTransition2 *")] IUIAnimationTransition2* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* endKeyframe)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUIAnimationVariable2*, IUIAnimationTransition2*, UI_ANIMATION_KEYFRAME*, UI_ANIMATION_KEYFRAME*, int>)(lpVtbl[7]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe, endKeyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RepeatBetweenKeyframes([NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* endKeyframe, [NativeTypeName("DOUBLE")] double cRepetition, UI_ANIMATION_REPEAT_MODE repeatMode, [NativeTypeName("IUIAnimationLoopIterationChangeHandler2 *")] IUIAnimationLoopIterationChangeHandler2* pIterationChangeHandler = null, [NativeTypeName("UINT_PTR")] nuint id = 0, [NativeTypeName("BOOL")] int fRegisterForNextAnimationEvent = 0)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, UI_ANIMATION_KEYFRAME*, UI_ANIMATION_KEYFRAME*, double, UI_ANIMATION_REPEAT_MODE, IUIAnimationLoopIterationChangeHandler2*, nuint, int, int>)(lpVtbl[8]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), startKeyframe, endKeyframe, cRepetition, repeatMode, pIterationChangeHandler, id, fRegisterForNextAnimationEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HoldVariable([NativeTypeName("IUIAnimationVariable2 *")] IUIAnimationVariable2* variable)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUIAnimationVariable2*, int>)(lpVtbl[9]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, double, int>)(lpVtbl[10]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSkipDuration([NativeTypeName("UI_ANIMATION_SECONDS")] double secondsDuration)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, double, int>)(lpVtbl[11]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), secondsDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Schedule([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, [NativeTypeName("UI_ANIMATION_SCHEDULING_RESULT *")] UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, double, UI_ANIMATION_SCHEDULING_RESULT*, int>)(lpVtbl[12]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), timeNow, schedulingResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Conclude()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, int>)(lpVtbl[13]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, double, int>)(lpVtbl[14]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), completionDeadline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abandon()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, int>)(lpVtbl[15]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUnknown*, uint, int>)(lpVtbl[16]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTag([NativeTypeName("IUnknown **")] IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUnknown**, uint*, int>)(lpVtbl[17]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("UI_ANIMATION_STORYBOARD_STATUS *")] UI_ANIMATION_STORYBOARD_STATUS* status)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, UI_ANIMATION_STORYBOARD_STATUS*, int>)(lpVtbl[18]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, double*, int>)(lpVtbl[19]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), elapsedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStoryboardEventHandler([NativeTypeName("IUIAnimationStoryboardEventHandler2 *")] IUIAnimationStoryboardEventHandler2* handler, [NativeTypeName("BOOL")] int fRegisterStatusChangeForNextAnimationEvent = 0, [NativeTypeName("BOOL")] int fRegisterUpdateForNextAnimationEvent = 0)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationStoryboard2*, IUIAnimationStoryboardEventHandler2*, int, int, int>)(lpVtbl[20]))((IUIAnimationStoryboard2*)Unsafe.AsPointer(ref this), handler, fRegisterStatusChangeForNextAnimationEvent, fRegisterUpdateForNextAnimationEvent);
        }
    }
}
