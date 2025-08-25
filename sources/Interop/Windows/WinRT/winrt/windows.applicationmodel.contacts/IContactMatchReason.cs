// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactMatchReason.xml' path='doc/member[@name="IContactMatchReason"]/*' />
[Guid("BC922504-E7D8-413E-95F4-B75C54C74077")]
[NativeTypeName("struct IContactMatchReason : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactMatchReason : IContactMatchReason.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactMatchReason);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, Guid*, void**, int>)(lpVtbl[0]))((IContactMatchReason*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, uint>)(lpVtbl[1]))((IContactMatchReason*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, uint>)(lpVtbl[2]))((IContactMatchReason*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, uint*, Guid**, int>)(lpVtbl[3]))((IContactMatchReason*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, HSTRING*, int>)(lpVtbl[4]))((IContactMatchReason*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, TrustLevel*, int>)(lpVtbl[5]))((IContactMatchReason*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactMatchReason.xml' path='doc/member[@name="IContactMatchReason.get_Field"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Field([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactMatchReasonKind *")] ContactMatchReasonKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, ContactMatchReasonKind*, int>)(lpVtbl[6]))((IContactMatchReason*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactMatchReason.xml' path='doc/member[@name="IContactMatchReason.get_Segments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Segments([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CTextSegment_t **")] IVectorView<TextSegment>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, IVectorView<TextSegment>**, int>)(lpVtbl[7]))((IContactMatchReason*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactMatchReason.xml' path='doc/member[@name="IContactMatchReason.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactMatchReason*, HSTRING*, int>)(lpVtbl[8]))((IContactMatchReason*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Field([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactMatchReasonKind *")] ContactMatchReasonKind* value);

        [VtblIndex(7)]
        HRESULT get_Segments([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CTextSegment_t **")] IVectorView<TextSegment>** value);

        [VtblIndex(8)]
        HRESULT get_Text(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactMatchReasonKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactMatchReasonKind*, int> get_Field;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CTextSegment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<TextSegment>**, int> get_Segments;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;
    }
}
