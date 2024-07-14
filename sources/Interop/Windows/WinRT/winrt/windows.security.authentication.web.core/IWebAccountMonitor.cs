// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor"]/*' />
[Guid("7445F5FD-AA9D-4619-8D5D-C138A4EDE3E5")]
[NativeTypeName("struct IWebAccountMonitor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountMonitor : IWebAccountMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountMonitor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, uint>)(lpVtbl[1]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, uint>)(lpVtbl[2]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor.add_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountEventArgs_t *")] ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor.remove_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Updated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, EventRegistrationToken, int>)(lpVtbl[7]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountEventArgs_t *")] ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, EventRegistrationToken, int>)(lpVtbl[9]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor.add_DefaultSignInAccountChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_DefaultSignInAccountChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_IInspectable_t *")] ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IWebAccountMonitor.xml' path='doc/member[@name="IWebAccountMonitor.remove_DefaultSignInAccountChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_DefaultSignInAccountChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMonitor*, EventRegistrationToken, int>)(lpVtbl[11]))((IWebAccountMonitor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountEventArgs_t *")] ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Updated(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountEventArgs_t *")] ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_DefaultSignInAccountChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_IInspectable_t *")] ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_DefaultSignInAccountChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>*, EventRegistrationToken*, int> add_Updated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Updated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IWebAccountEventArgs>>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAccountMonitor_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IWebAccountMonitor>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DefaultSignInAccountChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DefaultSignInAccountChanged;
    }
}
