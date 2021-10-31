// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT CreateInteractionContext([NativeTypeName("HINTERACTIONCONTEXT *")] IntPtr* interactionContext);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT DestroyInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT RegisterOutputCallbackInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("INTERACTION_CONTEXT_OUTPUT_CALLBACK")] delegate* unmanaged<void*, INTERACTION_CONTEXT_OUTPUT*, void> outputCallback, void* clientData);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT RegisterOutputCallbackInteractionContext2([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("INTERACTION_CONTEXT_OUTPUT_CALLBACK2")] delegate* unmanaged<void*, INTERACTION_CONTEXT_OUTPUT2*, void> outputCallback, void* clientData);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetInteractionConfigurationInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint configurationCount, [NativeTypeName("const INTERACTION_CONTEXT_CONFIGURATION *")] INTERACTION_CONTEXT_CONFIGURATION* configuration);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetInteractionConfigurationInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint configurationCount, INTERACTION_CONTEXT_CONFIGURATION* configuration);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetPropertyInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, INTERACTION_CONTEXT_PROPERTY contextProperty, [NativeTypeName("UINT32")] uint value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetPropertyInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, INTERACTION_CONTEXT_PROPERTY contextProperty, [NativeTypeName("UINT32 *")] uint* value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetInertiaParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, INERTIA_PARAMETER inertiaParameter, float value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetInertiaParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, INERTIA_PARAMETER inertiaParameter, float* value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetCrossSlideParametersInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint parameterCount, CROSS_SLIDE_PARAMETER* crossSlideParameters);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetCrossSlideParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, CROSS_SLIDE_THRESHOLD threshold, float* distance);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetTapParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, TAP_PARAMETER parameter, float value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetTapParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, TAP_PARAMETER parameter, float* value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetHoldParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, HOLD_PARAMETER parameter, float value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetHoldParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, HOLD_PARAMETER parameter, float* value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetTranslationParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, TRANSLATION_PARAMETER parameter, float value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetTranslationParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, TRANSLATION_PARAMETER parameter, float* value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetMouseWheelParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, MOUSE_WHEEL_PARAMETER parameter, float value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetMouseWheelParameterInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, MOUSE_WHEEL_PARAMETER parameter, float* value);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT ResetInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT GetStateInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo, INTERACTION_STATE* state);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT AddPointerInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint pointerId);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT RemovePointerInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint pointerId);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT ProcessPointerFramesInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint entriesCount, [NativeTypeName("UINT32")] uint pointerCount, [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT BufferPointerPacketsInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, [NativeTypeName("UINT32")] uint entriesCount, [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT ProcessBufferedPacketsInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT ProcessInertiaInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT StopInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext);

        [DllImport("ninput", ExactSpelling = true)]
        public static extern HRESULT SetPivotInteractionContext([NativeTypeName("HINTERACTIONCONTEXT")] IntPtr interactionContext, float x, float y, float radius);

        [NativeTypeName("#define CROSS_SLIDE_THRESHOLD_INVALID_VALUE FLT_MAX")]
        public const float CROSS_SLIDE_THRESHOLD_INVALID_VALUE = 3.402823466e+38F;

        [NativeTypeName("#define INERTIA_PARAMETER_INVALID_VALUE FLT_MAX")]
        public const float INERTIA_PARAMETER_INVALID_VALUE = 3.402823466e+38F;
    }
}
