// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B47A37BF-3D6B-4F88-83E8-6DCB4012FFB0")]
    [NativeTypeName("struct IGestureRecognizer : IInspectable")]
    public unsafe partial struct IGestureRecognizer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGestureRecognizer*, uint>)(lpVtbl[1]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGestureRecognizer*, uint>)(lpVtbl[2]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, uint*, Guid**, int>)(lpVtbl[3]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IntPtr*, int>)(lpVtbl[4]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, TrustLevel*, int>)(lpVtbl[5]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings *")] GestureSettings* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, GestureSettings*, int>)(lpVtbl[6]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings")] GestureSettings value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, GestureSettings, int>)(lpVtbl[7]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsInertial([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[8]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsActive([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[9]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ShowGestureFeedback([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[10]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ShowGestureFeedback([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte, int>)(lpVtbl[11]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PivotCenter([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, Point*, int>)(lpVtbl[12]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PivotCenter([NativeTypeName("ABI::Windows::Foundation::Point")] Point value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, Point, int>)(lpVtbl[13]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PivotRadius([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[14]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PivotRadius([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[15]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InertiaTranslationDeceleration([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[16]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InertiaTranslationDeceleration([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[17]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InertiaRotationDeceleration([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[18]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InertiaRotationDeceleration([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[19]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InertiaExpansionDeceleration([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[20]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InertiaExpansionDeceleration([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[21]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InertiaTranslationDisplacement([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[22]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InertiaTranslationDisplacement([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[23]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InertiaRotationAngle([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[24]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InertiaRotationAngle([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[25]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InertiaExpansion([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float*, int>)(lpVtbl[26]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InertiaExpansion([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, float, int>)(lpVtbl[27]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ManipulationExact([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[28]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ManipulationExact([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte, int>)(lpVtbl[29]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CrossSlideThresholds([NativeTypeName("ABI::Windows::UI::Input::CrossSlideThresholds *")] CrossSlideThresholds* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, CrossSlideThresholds*, int>)(lpVtbl[30]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CrossSlideThresholds([NativeTypeName("ABI::Windows::UI::Input::CrossSlideThresholds")] CrossSlideThresholds value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, CrossSlideThresholds, int>)(lpVtbl[31]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CrossSlideHorizontally([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[32]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CrossSlideHorizontally([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte, int>)(lpVtbl[33]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CrossSlideExact([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[34]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CrossSlideExact([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte, int>)(lpVtbl[35]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AutoProcessInertia([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte*, int>)(lpVtbl[36]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AutoProcessInertia([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, byte, int>)(lpVtbl[37]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MouseWheelParameters([NativeTypeName("ABI::Windows::UI::Input::IMouseWheelParameters **")] IMouseWheelParameters** value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IMouseWheelParameters**, int>)(lpVtbl[38]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanBeDoubleTap([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IPointerPoint*, byte*, int>)(lpVtbl[39]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessDownEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IPointerPoint*, int>)(lpVtbl[40]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessMoveEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *")] IVector<IntPtr>* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IVector<IntPtr>*, int>)(lpVtbl[41]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUpEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IPointerPoint*, int>)(lpVtbl[42]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessMouseWheelEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value, [NativeTypeName("boolean")] byte isShiftKeyDown, [NativeTypeName("boolean")] byte isControlKeyDown)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, IPointerPoint*, byte, byte, int>)(lpVtbl[43]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), value, isShiftKeyDown, isControlKeyDown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInertia()
        {
            return ((delegate* unmanaged<IGestureRecognizer*, int>)(lpVtbl[44]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompleteGesture()
        {
            return ((delegate* unmanaged<IGestureRecognizer*, int>)(lpVtbl[45]))((IGestureRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Tapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[46]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Tapped(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[47]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_RightTapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CRightTappedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[48]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_RightTapped(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[49]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Holding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[50]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Holding(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[51]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_Dragging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CDraggingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[52]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_Dragging(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[53]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ManipulationStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[54]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ManipulationStarted(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[55]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ManipulationUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[56]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ManipulationUpdated(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[57]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ManipulationInertiaStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationInertiaStartingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[58]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ManipulationInertiaStarting(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[59]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ManipulationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[60]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ManipulationCompleted(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[61]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_CrossSliding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CGestureRecognizer_Windows__CUI__CInput__CCrossSlidingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[62]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_CrossSliding(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[63]))((IGestureRecognizer*)Unsafe.AsPointer(ref this), token);
        }
    }
}
