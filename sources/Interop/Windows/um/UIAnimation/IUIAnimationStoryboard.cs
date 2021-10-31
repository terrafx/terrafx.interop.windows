// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A8FF128F-9BF9-4AF1-9E67-E5E410DEFB84")]
    [NativeTypeName("struct IUIAnimationStoryboard : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationStoryboard
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, uint>)(lpVtbl[1]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, uint>)(lpVtbl[2]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddTransition(IUIAnimationVariable* variable, IUIAnimationTransition* transition)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, IUIAnimationTransition*, int>)(lpVtbl[3]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable, transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddKeyframeAtOffset([NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* existingKeyframe, [NativeTypeName("UI_ANIMATION_SECONDS")] double offset, [NativeTypeName("UI_ANIMATION_KEYFRAME *")] UI_ANIMATION_KEYFRAME** keyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, UI_ANIMATION_KEYFRAME*, double, UI_ANIMATION_KEYFRAME**, int>)(lpVtbl[4]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), existingKeyframe, offset, keyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddKeyframeAfterTransition(IUIAnimationTransition* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME *")] UI_ANIMATION_KEYFRAME** keyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME**, int>)(lpVtbl[5]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), transition, keyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddTransitionAtKeyframe(IUIAnimationVariable* variable, IUIAnimationTransition* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME*, int>)(lpVtbl[6]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddTransitionBetweenKeyframes(IUIAnimationVariable* variable, IUIAnimationTransition* transition, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* endKeyframe)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, IUIAnimationTransition*, UI_ANIMATION_KEYFRAME*, UI_ANIMATION_KEYFRAME*, int>)(lpVtbl[7]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable, transition, startKeyframe, endKeyframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RepeatBetweenKeyframes([NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* startKeyframe, [NativeTypeName("UI_ANIMATION_KEYFRAME")] UI_ANIMATION_KEYFRAME* endKeyframe, [NativeTypeName("INT32")] int repetitionCount)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, UI_ANIMATION_KEYFRAME*, UI_ANIMATION_KEYFRAME*, int, int>)(lpVtbl[8]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), startKeyframe, endKeyframe, repetitionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT HoldVariable(IUIAnimationVariable* variable)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationVariable*, int>)(lpVtbl[9]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, double, int>)(lpVtbl[10]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Schedule([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, UI_ANIMATION_SCHEDULING_RESULT* schedulingResult = null)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, double, UI_ANIMATION_SCHEDULING_RESULT*, int>)(lpVtbl[11]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), timeNow, schedulingResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Conclude()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, int>)(lpVtbl[12]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Finish([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, double, int>)(lpVtbl[13]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), completionDeadline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Abandon()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, int>)(lpVtbl[14]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUnknown*, uint, int>)(lpVtbl[15]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetTag(IUnknown** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUnknown**, uint*, int>)(lpVtbl[16]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetStatus(UI_ANIMATION_STORYBOARD_STATUS* status)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, UI_ANIMATION_STORYBOARD_STATUS*, int>)(lpVtbl[17]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetElapsedTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* elapsedTime)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, double*, int>)(lpVtbl[18]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), elapsedTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetStoryboardEventHandler(IUIAnimationStoryboardEventHandler* handler)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboard*, IUIAnimationStoryboardEventHandler*, int>)(lpVtbl[19]))((IUIAnimationStoryboard*)Unsafe.AsPointer(ref this), handler);
        }
    }
}
