// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPowerManagerStatics2.xml' path='doc/member[@name="IPowerManagerStatics2"]/*' />
[Guid("67A446C3-4F2E-5D56-B2E8-7707C264745B")]
[NativeTypeName("struct IPowerManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPowerManagerStatics2 : IPowerManagerStatics2.Interface, INativeGuid
{
    /// <include file='IPowerManagerStatics2.xml' path='doc/member[@name="IPowerManagerStatics2.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPowerManagerStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, uint>)(lpVtbl[1]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, uint>)(lpVtbl[2]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPowerManagerStatics2.xml' path='doc/member[@name="IPowerManagerStatics2.get_EnergySaverStatus2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EnergySaverStatus2([NativeTypeName("ABI::Windows::System::Power::EnergySaverStatus2 *")] EnergySaverStatus2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, EnergySaverStatus2*, int>)(lpVtbl[6]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics2.xml' path='doc/member[@name="IPowerManagerStatics2.get_IsEnergySaverStatus2Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsEnergySaverStatus2Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, byte*, int>)(lpVtbl[7]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics2.xml' path='doc/member[@name="IPowerManagerStatics2.add_EnergySaverStatus2Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_EnergySaverStatus2Changed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerManagerStatics2.xml' path='doc/member[@name="IPowerManagerStatics2.remove_EnergySaverStatus2Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_EnergySaverStatus2Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics2*, EventRegistrationToken, int>)(lpVtbl[9]))((IPowerManagerStatics2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EnergySaverStatus2([NativeTypeName("ABI::Windows::System::Power::EnergySaverStatus2 *")] EnergySaverStatus2* value);

        [VtblIndex(7)]
        HRESULT get_IsEnergySaverStatus2Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT add_EnergySaverStatus2Changed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_EnergySaverStatus2Changed(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::Power::EnergySaverStatus2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnergySaverStatus2*, int> get_EnergySaverStatus2;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnergySaverStatus2Supported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_EnergySaverStatus2Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnergySaverStatus2Changed;
    }
}
