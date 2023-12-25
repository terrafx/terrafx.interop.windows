// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRichEditTextRange.xml' path='doc/member[@name="IRichEditTextRange"]/*' />
[Guid("374E3515-BA8A-4A6E-8C59-0DDE3D0CF5CD")]
[NativeTypeName("struct IRichEditTextRange : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRichEditTextRange : IRichEditTextRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRichEditTextRange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, Guid*, void**, int>)(lpVtbl[0]))((IRichEditTextRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, uint>)(lpVtbl[1]))((IRichEditTextRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, uint>)(lpVtbl[2]))((IRichEditTextRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, uint*, Guid**, int>)(lpVtbl[3]))((IRichEditTextRange*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, HSTRING*, int>)(lpVtbl[4]))((IRichEditTextRange*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, TrustLevel*, int>)(lpVtbl[5]))((IRichEditTextRange*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRichEditTextRange.xml' path='doc/member[@name="IRichEditTextRange.get_ContentLinkInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentLinkInfo([NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo **")] IContentLinkInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, IContentLinkInfo**, int>)(lpVtbl[6]))((IRichEditTextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRichEditTextRange.xml' path='doc/member[@name="IRichEditTextRange.put_ContentLinkInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ContentLinkInfo([NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo *")] IContentLinkInfo* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRichEditTextRange*, IContentLinkInfo*, int>)(lpVtbl[7]))((IRichEditTextRange*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentLinkInfo([NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo **")] IContentLinkInfo** value);

        [VtblIndex(7)]
        HRESULT put_ContentLinkInfo([NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo *")] IContentLinkInfo* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::IContentLinkInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContentLinkInfo**, int> get_ContentLinkInfo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::IContentLinkInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContentLinkInfo*, int> put_ContentLinkInfo;
    }
}
