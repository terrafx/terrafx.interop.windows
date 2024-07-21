// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceDiagnostics.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnostics"]/*' />
[Guid("9B24EE68-962E-448C-AEBF-B29B56098E23")]
[NativeTypeName("struct IAdaptiveMediaSourceDiagnostics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDiagnostics : IAdaptiveMediaSourceDiagnostics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDiagnostics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceDiagnostics.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnostics.add_DiagnosticAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_DiagnosticAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDiagnostics_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDiagnosticAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IAdaptiveMediaSourceDiagnostics>, Pointer<IAdaptiveMediaSourceDiagnosticAvailableEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, ITypedEventHandler<Pointer<IAdaptiveMediaSourceDiagnostics>, Pointer<IAdaptiveMediaSourceDiagnosticAvailableEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdaptiveMediaSourceDiagnostics.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnostics.remove_DiagnosticAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_DiagnosticAvailable(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnostics*, EventRegistrationToken, int>)(lpVtbl[7]))((IAdaptiveMediaSourceDiagnostics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_DiagnosticAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDiagnostics_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDiagnosticAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IAdaptiveMediaSourceDiagnostics>, Pointer<IAdaptiveMediaSourceDiagnosticAvailableEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_DiagnosticAvailable(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDiagnostics_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDiagnosticAvailableEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAdaptiveMediaSourceDiagnostics>, Pointer<IAdaptiveMediaSourceDiagnosticAvailableEventArgs>>*, EventRegistrationToken*, int> add_DiagnosticAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DiagnosticAvailable;
    }
}
