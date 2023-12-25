// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerMenuItemStatics2.xml' path='doc/member[@name="IRadialControllerMenuItemStatics2"]/*' />
[Guid("0CBB70BE-7E3E-48BD-BE04-2C7FCAA9C1FF")]
[NativeTypeName("struct IRadialControllerMenuItemStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerMenuItemStatics2 : IRadialControllerMenuItemStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerMenuItemStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, uint>)(lpVtbl[1]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, uint>)(lpVtbl[2]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerMenuItemStatics2.xml' path='doc/member[@name="IRadialControllerMenuItemStatics2.CreateFromFontGlyph"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromFontGlyph(HSTRING displayText, HSTRING glyph, HSTRING fontFamily, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, HSTRING, HSTRING, HSTRING, IRadialControllerMenuItem**, int>)(lpVtbl[6]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), displayText, glyph, fontFamily, result);
    }

    /// <include file='IRadialControllerMenuItemStatics2.xml' path='doc/member[@name="IRadialControllerMenuItemStatics2.CreateFromFontGlyphWithUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromFontGlyphWithUri(HSTRING displayText, HSTRING glyph, HSTRING fontFamily, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* fontUri, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenuItemStatics2*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, IRadialControllerMenuItem**, int>)(lpVtbl[7]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), displayText, glyph, fontFamily, fontUri, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromFontGlyph(HSTRING displayText, HSTRING glyph, HSTRING fontFamily, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result);

        [VtblIndex(7)]
        HRESULT CreateFromFontGlyphWithUri(HSTRING displayText, HSTRING glyph, HSTRING fontFamily, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* fontUri, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IRadialControllerMenuItem**, int> CreateFromFontGlyph;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, IRadialControllerMenuItem**, int> CreateFromFontGlyphWithUri;
    }
}
