// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat"]/*' />
[Guid("5ADEF3DB-05FB-442D-8065-642AFEA02CED")]
[NativeTypeName("struct ITextCharacterFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextCharacterFormat : ITextCharacterFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextCharacterFormat));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, Guid*, void**, int>)(lpVtbl[0]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, uint>)(lpVtbl[1]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, uint>)(lpVtbl[2]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, uint*, Guid**, int>)(lpVtbl[3]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, HSTRING*, int>)(lpVtbl[4]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, TrustLevel*, int>)(lpVtbl[5]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_AllCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[6]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_AllCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[7]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, Color*, int>)(lpVtbl[8]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, Color, int>)(lpVtbl[9]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Bold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Bold([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[10]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Bold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Bold([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[11]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_FontStretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FontStretch([NativeTypeName("ABI::Windows::UI::Text::FontStretch *")] FontStretch* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FontStretch*, int>)(lpVtbl[12]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_FontStretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FontStretch([NativeTypeName("ABI::Windows::UI::Text::FontStretch")] FontStretch value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FontStretch, int>)(lpVtbl[13]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_FontStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FontStyle([NativeTypeName("ABI::Windows::UI::Text::FontStyle *")] FontStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FontStyle*, int>)(lpVtbl[14]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_FontStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_FontStyle([NativeTypeName("ABI::Windows::UI::Text::FontStyle")] FontStyle value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FontStyle, int>)(lpVtbl[15]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, Color*, int>)(lpVtbl[16]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, Color, int>)(lpVtbl[17]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Hidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Hidden([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[18]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Hidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Hidden([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[19]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Italic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Italic([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[20]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Italic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Italic([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[21]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Kerning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Kerning(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float*, int>)(lpVtbl[22]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Kerning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Kerning(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float, int>)(lpVtbl[23]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_LanguageTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_LanguageTag(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, HSTRING*, int>)(lpVtbl[24]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_LanguageTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_LanguageTag(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, HSTRING, int>)(lpVtbl[25]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_LinkType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_LinkType([NativeTypeName("ABI::Windows::UI::Text::LinkType *")] LinkType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, LinkType*, int>)(lpVtbl[26]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, HSTRING*, int>)(lpVtbl[27]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, HSTRING, int>)(lpVtbl[28]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Outline([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[29]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Outline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Outline([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[30]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Position(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float*, int>)(lpVtbl[31]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_Position(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float, int>)(lpVtbl[32]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_ProtectedText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_ProtectedText([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[33]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_ProtectedText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_ProtectedText([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[34]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Size(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float*, int>)(lpVtbl[35]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_Size(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float, int>)(lpVtbl[36]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_SmallCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_SmallCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[37]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_SmallCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_SmallCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[38]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Spacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Spacing(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float*, int>)(lpVtbl[39]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Spacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_Spacing(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, float, int>)(lpVtbl[40]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Strikethrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_Strikethrough([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[41]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Strikethrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_Strikethrough([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[42]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Subscript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_Subscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[43]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Subscript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_Subscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[44]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Superscript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_Superscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect*, int>)(lpVtbl[45]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Superscript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_Superscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, FormatEffect, int>)(lpVtbl[46]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_TextScript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_TextScript([NativeTypeName("ABI::Windows::UI::Text::TextScript *")] TextScript* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, TextScript*, int>)(lpVtbl[47]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_TextScript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_TextScript([NativeTypeName("ABI::Windows::UI::Text::TextScript")] TextScript value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, TextScript, int>)(lpVtbl[48]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Underline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_Underline([NativeTypeName("ABI::Windows::UI::Text::UnderlineType *")] UnderlineType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, UnderlineType*, int>)(lpVtbl[49]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Underline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_Underline([NativeTypeName("ABI::Windows::UI::Text::UnderlineType")] UnderlineType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, UnderlineType, int>)(lpVtbl[50]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.get_Weight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_Weight([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, int*, int>)(lpVtbl[51]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.put_Weight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT put_Weight([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, int, int>)(lpVtbl[52]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.SetClone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SetClone([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, ITextCharacterFormat*, int>)(lpVtbl[53]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.GetClone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetClone([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")] ITextCharacterFormat** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, ITextCharacterFormat**, int>)(lpVtbl[54]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextCharacterFormat.xml' path='doc/member[@name="ITextCharacterFormat.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT IsEqual([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* format, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextCharacterFormat*, ITextCharacterFormat*, byte*, int>)(lpVtbl[55]))((ITextCharacterFormat*)Unsafe.AsPointer(ref this), format, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(7)]
        HRESULT put_AllCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(8)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT get_Bold([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(11)]
        HRESULT put_Bold([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(12)]
        HRESULT get_FontStretch([NativeTypeName("ABI::Windows::UI::Text::FontStretch *")] FontStretch* value);

        [VtblIndex(13)]
        HRESULT put_FontStretch([NativeTypeName("ABI::Windows::UI::Text::FontStretch")] FontStretch value);

        [VtblIndex(14)]
        HRESULT get_FontStyle([NativeTypeName("ABI::Windows::UI::Text::FontStyle *")] FontStyle* value);

        [VtblIndex(15)]
        HRESULT put_FontStyle([NativeTypeName("ABI::Windows::UI::Text::FontStyle")] FontStyle value);

        [VtblIndex(16)]
        HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(18)]
        HRESULT get_Hidden([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(19)]
        HRESULT put_Hidden([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(20)]
        HRESULT get_Italic([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(21)]
        HRESULT put_Italic([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(22)]
        HRESULT get_Kerning(float* value);

        [VtblIndex(23)]
        HRESULT put_Kerning(float value);

        [VtblIndex(24)]
        HRESULT get_LanguageTag(HSTRING* value);

        [VtblIndex(25)]
        HRESULT put_LanguageTag(HSTRING value);

        [VtblIndex(26)]
        HRESULT get_LinkType([NativeTypeName("ABI::Windows::UI::Text::LinkType *")] LinkType* value);

        [VtblIndex(27)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(28)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(29)]
        HRESULT get_Outline([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(30)]
        HRESULT put_Outline([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(31)]
        HRESULT get_Position(float* value);

        [VtblIndex(32)]
        HRESULT put_Position(float value);

        [VtblIndex(33)]
        HRESULT get_ProtectedText([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(34)]
        HRESULT put_ProtectedText([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(35)]
        HRESULT get_Size(float* value);

        [VtblIndex(36)]
        HRESULT put_Size(float value);

        [VtblIndex(37)]
        HRESULT get_SmallCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(38)]
        HRESULT put_SmallCaps([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(39)]
        HRESULT get_Spacing(float* value);

        [VtblIndex(40)]
        HRESULT put_Spacing(float value);

        [VtblIndex(41)]
        HRESULT get_Strikethrough([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(42)]
        HRESULT put_Strikethrough([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(43)]
        HRESULT get_Subscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(44)]
        HRESULT put_Subscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(45)]
        HRESULT get_Superscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(46)]
        HRESULT put_Superscript([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(47)]
        HRESULT get_TextScript([NativeTypeName("ABI::Windows::UI::Text::TextScript *")] TextScript* value);

        [VtblIndex(48)]
        HRESULT put_TextScript([NativeTypeName("ABI::Windows::UI::Text::TextScript")] TextScript value);

        [VtblIndex(49)]
        HRESULT get_Underline([NativeTypeName("ABI::Windows::UI::Text::UnderlineType *")] UnderlineType* value);

        [VtblIndex(50)]
        HRESULT put_Underline([NativeTypeName("ABI::Windows::UI::Text::UnderlineType")] UnderlineType value);

        [VtblIndex(51)]
        HRESULT get_Weight([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(52)]
        HRESULT put_Weight([NativeTypeName("INT32")] int value);

        [VtblIndex(53)]
        HRESULT SetClone([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* value);

        [VtblIndex(54)]
        HRESULT GetClone([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")] ITextCharacterFormat** result);

        [VtblIndex(55)]
        HRESULT IsEqual([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* format, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_AllCaps;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_AllCaps;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Bold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Bold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStretch *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontStretch*, int> get_FontStretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStretch) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontStretch, int> put_FontStretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontStyle*, int> get_FontStyle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStyle) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontStyle, int> put_FontStyle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Hidden;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Hidden;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Italic;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Italic;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Kerning;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Kerning;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LanguageTag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LanguageTag;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::LinkType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LinkType*, int> get_LinkType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Outline;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Outline;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Position;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Position;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_ProtectedText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_ProtectedText;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Size;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Size;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_SmallCaps;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_SmallCaps;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Spacing;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Spacing;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Strikethrough;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Strikethrough;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Subscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Subscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_Superscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_Superscript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextScript *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextScript*, int> get_TextScript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextScript) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextScript, int> put_TextScript;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::UnderlineType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UnderlineType*, int> get_Underline;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::UnderlineType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UnderlineType, int> put_Underline;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Weight;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_Weight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat*, int> SetClone;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat**, int> GetClone;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat*, byte*, int> IsEqual;
    }
}
