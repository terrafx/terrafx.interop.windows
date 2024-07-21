// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2"]/*' />
[Guid("998681FB-1AB6-4B7F-BE4A-9A0645224C04")]
[NativeTypeName("struct ICoreApplication2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplication2 : ICoreApplication2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplication2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplication2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, uint>)(lpVtbl[1]))((ICoreApplication2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, uint>)(lpVtbl[2]))((ICoreApplication2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplication2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, HSTRING*, int>)(lpVtbl[4]))((ICoreApplication2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplication2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.add_BackgroundActivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_BackgroundActivated([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *")] IEventHandler<Pointer<IBackgroundActivatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, IEventHandler<Pointer<IBackgroundActivatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreApplication2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.remove_BackgroundActivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_BackgroundActivated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreApplication2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.add_LeavingBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_LeavingBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *")] IEventHandler<Pointer<ILeavingBackgroundEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, IEventHandler<Pointer<ILeavingBackgroundEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreApplication2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.remove_LeavingBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_LeavingBackground(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreApplication2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.add_EnteredBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_EnteredBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *")] IEventHandler<Pointer<IEnteredBackgroundEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, IEventHandler<Pointer<IEnteredBackgroundEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICoreApplication2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.remove_EnteredBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_EnteredBackground(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, EventRegistrationToken, int>)(lpVtbl[11]))((ICoreApplication2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplication2.xml' path='doc/member[@name="ICoreApplication2.EnablePrelaunch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnablePrelaunch([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication2*, byte, int>)(lpVtbl[12]))((ICoreApplication2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_BackgroundActivated([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *")] IEventHandler<Pointer<IBackgroundActivatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_BackgroundActivated(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_LeavingBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *")] IEventHandler<Pointer<ILeavingBackgroundEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_LeavingBackground(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_EnteredBackground([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *")] IEventHandler<Pointer<IEnteredBackgroundEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_EnteredBackground(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT EnablePrelaunch([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IBackgroundActivatedEventArgs>>*, EventRegistrationToken*, int> add_BackgroundActivated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BackgroundActivated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<ILeavingBackgroundEventArgs>>*, EventRegistrationToken*, int> add_LeavingBackground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LeavingBackground;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IEnteredBackgroundEventArgs>>*, EventRegistrationToken*, int> add_EnteredBackground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnteredBackground;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> EnablePrelaunch;
    }
}
