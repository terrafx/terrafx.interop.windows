// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreClosestInteractiveBoundsRequested.xml' path='doc/member[@name="ICoreClosestInteractiveBoundsRequested"]/*' />
[Guid("F303043A-E8BF-4E8E-AE69-C9DADD57A114")]
[NativeTypeName("struct ICoreClosestInteractiveBoundsRequested : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreClosestInteractiveBoundsRequested : ICoreClosestInteractiveBoundsRequested.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreClosestInteractiveBoundsRequested));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, Guid*, void**, int>)(lpVtbl[0]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, uint>)(lpVtbl[1]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, uint>)(lpVtbl[2]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, HSTRING*, int>)(lpVtbl[4]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, TrustLevel*, int>)(lpVtbl[5]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreClosestInteractiveBoundsRequested.xml' path='doc/member[@name="ICoreClosestInteractiveBoundsRequested.add_ClosestInteractiveBoundsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ClosestInteractiveBoundsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreComponentInputSource_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>* handler, EventRegistrationToken* pCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, ITypedEventHandler<IntPtr, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), handler, pCookie);
    }

    /// <include file='ICoreClosestInteractiveBoundsRequested.xml' path='doc/member[@name="ICoreClosestInteractiveBoundsRequested.remove_ClosestInteractiveBoundsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ClosestInteractiveBoundsRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreClosestInteractiveBoundsRequested*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ClosestInteractiveBoundsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreComponentInputSource_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>* handler, EventRegistrationToken* pCookie);

        [VtblIndex(7)]
        HRESULT remove_ClosestInteractiveBoundsRequested(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreComponentInputSource_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, Pointer<IClosestInteractiveBoundsRequestedEventArgs>>*, EventRegistrationToken*, int> add_ClosestInteractiveBoundsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ClosestInteractiveBoundsRequested;
    }
}
