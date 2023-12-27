// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextSource.xml' path='doc/member[@name="ITimedTextSource"]/*' />
[Guid("C4ED9BA6-101F-404D-A949-82F33FCD93B7")]
[NativeTypeName("struct ITimedTextSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSource : ITimedTextSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, uint>)(lpVtbl[1]))((ITimedTextSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, uint>)(lpVtbl[2]))((ITimedTextSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextSource.xml' path='doc/member[@name="ITimedTextSource.add_Resolved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Resolved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedTextSource_Windows__CMedia__CCore__CTimedTextSourceResolveResultEventArgs_t *")] ITypedEventHandler<Pointer<ITimedTextSource>, Pointer<ITimedTextSourceResolveResultEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, ITypedEventHandler<Pointer<ITimedTextSource>, Pointer<ITimedTextSourceResolveResultEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ITimedTextSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITimedTextSource.xml' path='doc/member[@name="ITimedTextSource.remove_Resolved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Resolved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSource*, EventRegistrationToken, int>)(lpVtbl[7]))((ITimedTextSource*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Resolved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedTextSource_Windows__CMedia__CCore__CTimedTextSourceResolveResultEventArgs_t *")] ITypedEventHandler<Pointer<ITimedTextSource>, Pointer<ITimedTextSourceResolveResultEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Resolved(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedTextSource_Windows__CMedia__CCore__CTimedTextSourceResolveResultEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITimedTextSource>, Pointer<ITimedTextSourceResolveResultEventArgs>>*, EventRegistrationToken*, int> add_Resolved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Resolved;
    }
}
