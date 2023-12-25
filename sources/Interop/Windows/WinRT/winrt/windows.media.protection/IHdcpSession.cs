// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHdcpSession.xml' path='doc/member[@name="IHdcpSession"]/*' />
[Guid("718845E9-64D7-426D-809B-1BE461941A2A")]
[NativeTypeName("struct IHdcpSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHdcpSession : IHdcpSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHdcpSession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, Guid*, void**, int>)(lpVtbl[0]))((IHdcpSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, uint>)(lpVtbl[1]))((IHdcpSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, uint>)(lpVtbl[2]))((IHdcpSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, uint*, Guid**, int>)(lpVtbl[3]))((IHdcpSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, HSTRING*, int>)(lpVtbl[4]))((IHdcpSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, TrustLevel*, int>)(lpVtbl[5]))((IHdcpSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHdcpSession.xml' path='doc/member[@name="IHdcpSession.IsEffectiveProtectionAtLeast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsEffectiveProtectionAtLeast([NativeTypeName("ABI::Windows::Media::Protection::HdcpProtection")] HdcpProtection protection, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, HdcpProtection, byte*, int>)(lpVtbl[6]))((IHdcpSession*)Unsafe.AsPointer(ref this), protection, value);
    }

    /// <include file='IHdcpSession.xml' path='doc/member[@name="IHdcpSession.GetEffectiveProtection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEffectiveProtection([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CProtection__CHdcpProtection_t **")] IReference<HdcpProtection>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, IReference<HdcpProtection>**, int>)(lpVtbl[7]))((IHdcpSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdcpSession.xml' path='doc/member[@name="IHdcpSession.SetDesiredMinProtectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDesiredMinProtectionAsync([NativeTypeName("ABI::Windows::Media::Protection::HdcpProtection")] HdcpProtection protection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CProtection__CHdcpSetProtectionResult_t **")] IAsyncOperation<HdcpSetProtectionResult>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, HdcpProtection, IAsyncOperation<HdcpSetProtectionResult>**, int>)(lpVtbl[8]))((IHdcpSession*)Unsafe.AsPointer(ref this), protection, value);
    }

    /// <include file='IHdcpSession.xml' path='doc/member[@name="IHdcpSession.add_ProtectionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_ProtectionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CProtection__CHdcpSession_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IHdcpSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IHdcpSession.xml' path='doc/member[@name="IHdcpSession.remove_ProtectionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_ProtectionChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdcpSession*, EventRegistrationToken, int>)(lpVtbl[10]))((IHdcpSession*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsEffectiveProtectionAtLeast([NativeTypeName("ABI::Windows::Media::Protection::HdcpProtection")] HdcpProtection protection, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT GetEffectiveProtection([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CProtection__CHdcpProtection_t **")] IReference<HdcpProtection>** value);

        [VtblIndex(8)]
        HRESULT SetDesiredMinProtectionAsync([NativeTypeName("ABI::Windows::Media::Protection::HdcpProtection")] HdcpProtection protection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CProtection__CHdcpSetProtectionResult_t **")] IAsyncOperation<HdcpSetProtectionResult>** value);

        [VtblIndex(9)]
        HRESULT add_ProtectionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CProtection__CHdcpSession_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_ProtectionChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::HdcpProtection, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HdcpProtection, byte*, int> IsEffectiveProtectionAtLeast;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CProtection__CHdcpProtection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<HdcpProtection>**, int> GetEffectiveProtection;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::HdcpProtection, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CProtection__CHdcpSetProtectionResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HdcpProtection, IAsyncOperation<HdcpSetProtectionResult>**, int> SetDesiredMinProtectionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CProtection__CHdcpSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ProtectionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ProtectionChanged;
    }
}
