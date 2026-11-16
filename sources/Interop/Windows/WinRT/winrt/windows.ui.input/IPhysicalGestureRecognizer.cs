// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer"]/*' />
[Guid("79A29F4D-32A6-5AA5-A999-42B0B420C66D")]
[NativeTypeName("struct IPhysicalGestureRecognizer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhysicalGestureRecognizer : IPhysicalGestureRecognizer.Interface, INativeGuid
{
    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhysicalGestureRecognizer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint>)(lpVtbl[1]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint>)(lpVtbl[2]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, Guid**, int>)(lpVtbl[3]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, HSTRING*, int>)(lpVtbl[4]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, TrustLevel*, int>)(lpVtbl[5]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_IsActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, byte*, int>)(lpVtbl[6]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_GestureSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings *")] GestureSettings* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, GestureSettings*, int>)(lpVtbl[7]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_GestureSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings")] GestureSettings value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, GestureSettings, int>)(lpVtbl[8]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_TapMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TapMinContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, int>)(lpVtbl[9]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_TapMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_TapMinContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint, int>)(lpVtbl[10]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_TapMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_TapMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, int>)(lpVtbl[11]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_TapMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_TapMaxContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint, int>)(lpVtbl[12]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_HoldMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_HoldMinContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, int>)(lpVtbl[13]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_HoldMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_HoldMinContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint, int>)(lpVtbl[14]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_HoldMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_HoldMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, int>)(lpVtbl[15]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_HoldMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_HoldMaxContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint, int>)(lpVtbl[16]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_HoldRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_HoldRadius(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, float*, int>)(lpVtbl[17]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_HoldRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_HoldRadius(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, float, int>)(lpVtbl[18]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_HoldStartDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, TimeSpan*, int>)(lpVtbl[19]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_HoldStartDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, TimeSpan, int>)(lpVtbl[20]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_TranslationMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_TranslationMinContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, int>)(lpVtbl[21]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_TranslationMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_TranslationMinContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint, int>)(lpVtbl[22]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.get_TranslationMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_TranslationMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint*, int>)(lpVtbl[23]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.put_TranslationMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_TranslationMaxContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, uint, int>)(lpVtbl[24]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.ProcessDownEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ProcessDownEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, IPointerPoint*, int>)(lpVtbl[25]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.ProcessMoveEvents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ProcessMoveEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *")] IVector<Pointer<IPointerPoint>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, IVector<Pointer<IPointerPoint>>*, int>)(lpVtbl[26]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.ProcessUpEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ProcessUpEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, IPointerPoint*, int>)(lpVtbl[27]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.CompleteGesture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CompleteGesture()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, int>)(lpVtbl[28]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.add_ManipulationStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_ManipulationStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[29]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.remove_ManipulationStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_ManipulationStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[30]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.add_ManipulationUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT add_ManipulationUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[31]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.remove_ManipulationUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT remove_ManipulationUpdated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[32]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.add_ManipulationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT add_ManipulationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[33]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.remove_ManipulationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT remove_ManipulationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[34]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.add_Tapped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT add_Tapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<ITappedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<ITappedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[35]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.remove_Tapped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT remove_Tapped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[36]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.add_Holding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT add_Holding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IHoldingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IHoldingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[37]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhysicalGestureRecognizer.xml' path='doc/member[@name="IPhysicalGestureRecognizer.remove_Holding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT remove_Holding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhysicalGestureRecognizer*, EventRegistrationToken, int>)(lpVtbl[38]))((IPhysicalGestureRecognizer*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings *")] GestureSettings* value);

        [VtblIndex(8)]
        HRESULT put_GestureSettings([NativeTypeName("ABI::Windows::UI::Input::GestureSettings")] GestureSettings value);

        [VtblIndex(9)]
        HRESULT get_TapMinContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_TapMinContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_TapMaxContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_TapMaxContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_HoldMinContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_HoldMinContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_HoldMaxContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_HoldMaxContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_HoldRadius(float* value);

        [VtblIndex(18)]
        HRESULT put_HoldRadius(float value);

        [VtblIndex(19)]
        HRESULT get_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(20)]
        HRESULT put_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(21)]
        HRESULT get_TranslationMinContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(22)]
        HRESULT put_TranslationMinContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(23)]
        HRESULT get_TranslationMaxContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(24)]
        HRESULT put_TranslationMaxContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(25)]
        HRESULT ProcessDownEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value);

        [VtblIndex(26)]
        HRESULT ProcessMoveEvents([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *")] IVector<Pointer<IPointerPoint>>* value);

        [VtblIndex(27)]
        HRESULT ProcessUpEvent([NativeTypeName("ABI::Windows::UI::Input::IPointerPoint *")] IPointerPoint* value);

        [VtblIndex(28)]
        HRESULT CompleteGesture();

        [VtblIndex(29)]
        HRESULT add_ManipulationStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(30)]
        HRESULT remove_ManipulationStarted(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT add_ManipulationUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(32)]
        HRESULT remove_ManipulationUpdated(EventRegistrationToken token);

        [VtblIndex(33)]
        HRESULT add_ManipulationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(34)]
        HRESULT remove_ManipulationCompleted(EventRegistrationToken token);

        [VtblIndex(35)]
        HRESULT add_Tapped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<ITappedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(36)]
        HRESULT remove_Tapped(EventRegistrationToken token);

        [VtblIndex(37)]
        HRESULT add_Holding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *")] ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IHoldingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(38)]
        HRESULT remove_Holding(EventRegistrationToken token);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsActive;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::GestureSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GestureSettings*, int> get_GestureSettings;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::GestureSettings) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GestureSettings, int> put_GestureSettings;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TapMinContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TapMinContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TapMaxContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TapMaxContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HoldMinContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_HoldMinContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HoldMaxContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_HoldMaxContactCount;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_HoldRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_HoldRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_HoldStartDelay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_HoldStartDelay;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TranslationMinContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TranslationMinContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TranslationMaxContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TranslationMaxContactCount;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint*, int> ProcessDownEvent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IPointerPoint>>*, int> ProcessMoveEvents;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IPointerPoint *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPointerPoint*, int> ProcessUpEvent;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CompleteGesture;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationStartedEventArgs>>*, EventRegistrationToken*, int> add_ManipulationStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationUpdatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationUpdatedEventArgs>>*, EventRegistrationToken*, int> add_ManipulationUpdated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationUpdated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CManipulationCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IManipulationCompletedEventArgs>>*, EventRegistrationToken*, int> add_ManipulationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ManipulationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CTappedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<ITappedEventArgs>>*, EventRegistrationToken*, int> add_Tapped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Tapped;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CPhysicalGestureRecognizer_Windows__CUI__CInput__CHoldingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhysicalGestureRecognizer>, Pointer<IHoldingEventArgs>>*, EventRegistrationToken*, int> add_Holding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Holding;
    }
}
