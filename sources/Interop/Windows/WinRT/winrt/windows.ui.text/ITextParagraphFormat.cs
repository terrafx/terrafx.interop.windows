// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat"]/*' />
[Guid("2CF8CFA6-4676-498A-93F5-BBDBFC0BD883")]
[NativeTypeName("struct ITextParagraphFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextParagraphFormat : ITextParagraphFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextParagraphFormat));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, Guid*, void**, int>)(lpVtbl[0]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, uint>)(lpVtbl[1]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, uint>)(lpVtbl[2]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, uint*, Guid**, int>)(lpVtbl[3]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, HSTRING*, int>)(lpVtbl[4]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, TrustLevel*, int>)(lpVtbl[5]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_Alignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Alignment([NativeTypeName("ABI::Windows::UI::Text::ParagraphAlignment *")] ParagraphAlignment* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ParagraphAlignment*, int>)(lpVtbl[6]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_Alignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Alignment([NativeTypeName("ABI::Windows::UI::Text::ParagraphAlignment")] ParagraphAlignment value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ParagraphAlignment, int>)(lpVtbl[7]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_FirstLineIndent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FirstLineIndent(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[8]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_KeepTogether"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_KeepTogether([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect*, int>)(lpVtbl[9]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_KeepTogether"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_KeepTogether([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect, int>)(lpVtbl[10]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_KeepWithNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_KeepWithNext([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect*, int>)(lpVtbl[11]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_KeepWithNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_KeepWithNext([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect, int>)(lpVtbl[12]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_LeftIndent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LeftIndent(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[13]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_LineSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LineSpacing(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[14]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_LineSpacingRule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LineSpacingRule([NativeTypeName("ABI::Windows::UI::Text::LineSpacingRule *")] LineSpacingRule* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, LineSpacingRule*, int>)(lpVtbl[15]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_ListAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ListAlignment([NativeTypeName("ABI::Windows::UI::Text::MarkerAlignment *")] MarkerAlignment* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, MarkerAlignment*, int>)(lpVtbl[16]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_ListAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ListAlignment([NativeTypeName("ABI::Windows::UI::Text::MarkerAlignment")] MarkerAlignment value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, MarkerAlignment, int>)(lpVtbl[17]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_ListLevelIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ListLevelIndex([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int*, int>)(lpVtbl[18]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_ListLevelIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ListLevelIndex([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int, int>)(lpVtbl[19]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_ListStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ListStart([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int*, int>)(lpVtbl[20]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_ListStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_ListStart([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int, int>)(lpVtbl[21]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_ListStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ListStyle([NativeTypeName("ABI::Windows::UI::Text::MarkerStyle *")] MarkerStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, MarkerStyle*, int>)(lpVtbl[22]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_ListStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ListStyle([NativeTypeName("ABI::Windows::UI::Text::MarkerStyle")] MarkerStyle value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, MarkerStyle, int>)(lpVtbl[23]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_ListTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_ListTab(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[24]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_ListTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_ListTab(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, int>)(lpVtbl[25]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_ListType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ListType([NativeTypeName("ABI::Windows::UI::Text::MarkerType *")] MarkerType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, MarkerType*, int>)(lpVtbl[26]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_ListType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_ListType([NativeTypeName("ABI::Windows::UI::Text::MarkerType")] MarkerType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, MarkerType, int>)(lpVtbl[27]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_NoLineNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_NoLineNumber([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect*, int>)(lpVtbl[28]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_NoLineNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_NoLineNumber([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect, int>)(lpVtbl[29]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_PageBreakBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_PageBreakBefore([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect*, int>)(lpVtbl[30]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_PageBreakBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_PageBreakBefore([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect, int>)(lpVtbl[31]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_RightIndent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_RightIndent(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[32]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_RightIndent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_RightIndent(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, int>)(lpVtbl[33]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_RightToLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_RightToLeft([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect*, int>)(lpVtbl[34]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_RightToLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_RightToLeft([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect, int>)(lpVtbl[35]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_Style"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_Style([NativeTypeName("ABI::Windows::UI::Text::ParagraphStyle *")] ParagraphStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ParagraphStyle*, int>)(lpVtbl[36]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_Style"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_Style([NativeTypeName("ABI::Windows::UI::Text::ParagraphStyle")] ParagraphStyle value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ParagraphStyle, int>)(lpVtbl[37]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_SpaceAfter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_SpaceAfter(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[38]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_SpaceAfter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_SpaceAfter(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, int>)(lpVtbl[39]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_SpaceBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_SpaceBefore(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float*, int>)(lpVtbl[40]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_SpaceBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_SpaceBefore(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, int>)(lpVtbl[41]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_WidowControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_WidowControl([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect*, int>)(lpVtbl[42]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.put_WidowControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_WidowControl([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, FormatEffect, int>)(lpVtbl[43]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.get_TabCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_TabCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int*, int>)(lpVtbl[44]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.AddTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT AddTab(float position, [NativeTypeName("ABI::Windows::UI::Text::TabAlignment")] TabAlignment align, [NativeTypeName("ABI::Windows::UI::Text::TabLeader")] TabLeader leader)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, TabAlignment, TabLeader, int>)(lpVtbl[45]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), position, align, leader);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.ClearAllTabs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT ClearAllTabs()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int>)(lpVtbl[46]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.DeleteTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT DeleteTab(float position)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, int>)(lpVtbl[47]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), position);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.GetClone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetClone([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")] ITextParagraphFormat** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ITextParagraphFormat**, int>)(lpVtbl[48]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.GetTab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetTab([NativeTypeName("INT32")] int index, float* position, [NativeTypeName("ABI::Windows::UI::Text::TabAlignment *")] TabAlignment* align, [NativeTypeName("ABI::Windows::UI::Text::TabLeader *")] TabLeader* leader)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, int, float*, TabAlignment*, TabLeader*, int>)(lpVtbl[49]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), index, position, align, leader);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT IsEqual([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* format, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ITextParagraphFormat*, byte*, int>)(lpVtbl[50]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), format, result);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.SetClone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT SetClone([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* format)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, ITextParagraphFormat*, int>)(lpVtbl[51]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), format);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.SetIndents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT SetIndents(float start, float left, float right)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, float, float, float, int>)(lpVtbl[52]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), start, left, right);
    }

    /// <include file='ITextParagraphFormat.xml' path='doc/member[@name="ITextParagraphFormat.SetLineSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SetLineSpacing([NativeTypeName("ABI::Windows::UI::Text::LineSpacingRule")] LineSpacingRule rule, float spacing)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextParagraphFormat*, LineSpacingRule, float, int>)(lpVtbl[53]))((ITextParagraphFormat*)Unsafe.AsPointer(ref this), rule, spacing);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Alignment([NativeTypeName("ABI::Windows::UI::Text::ParagraphAlignment *")] ParagraphAlignment* value);

        [VtblIndex(7)]
        HRESULT put_Alignment([NativeTypeName("ABI::Windows::UI::Text::ParagraphAlignment")] ParagraphAlignment value);

        [VtblIndex(8)]
        HRESULT get_FirstLineIndent(float* value);

        [VtblIndex(9)]
        HRESULT get_KeepTogether([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(10)]
        HRESULT put_KeepTogether([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(11)]
        HRESULT get_KeepWithNext([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(12)]
        HRESULT put_KeepWithNext([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(13)]
        HRESULT get_LeftIndent(float* value);

        [VtblIndex(14)]
        HRESULT get_LineSpacing(float* value);

        [VtblIndex(15)]
        HRESULT get_LineSpacingRule([NativeTypeName("ABI::Windows::UI::Text::LineSpacingRule *")] LineSpacingRule* value);

        [VtblIndex(16)]
        HRESULT get_ListAlignment([NativeTypeName("ABI::Windows::UI::Text::MarkerAlignment *")] MarkerAlignment* value);

        [VtblIndex(17)]
        HRESULT put_ListAlignment([NativeTypeName("ABI::Windows::UI::Text::MarkerAlignment")] MarkerAlignment value);

        [VtblIndex(18)]
        HRESULT get_ListLevelIndex([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT put_ListLevelIndex([NativeTypeName("INT32")] int value);

        [VtblIndex(20)]
        HRESULT get_ListStart([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT put_ListStart([NativeTypeName("INT32")] int value);

        [VtblIndex(22)]
        HRESULT get_ListStyle([NativeTypeName("ABI::Windows::UI::Text::MarkerStyle *")] MarkerStyle* value);

        [VtblIndex(23)]
        HRESULT put_ListStyle([NativeTypeName("ABI::Windows::UI::Text::MarkerStyle")] MarkerStyle value);

        [VtblIndex(24)]
        HRESULT get_ListTab(float* value);

        [VtblIndex(25)]
        HRESULT put_ListTab(float value);

        [VtblIndex(26)]
        HRESULT get_ListType([NativeTypeName("ABI::Windows::UI::Text::MarkerType *")] MarkerType* value);

        [VtblIndex(27)]
        HRESULT put_ListType([NativeTypeName("ABI::Windows::UI::Text::MarkerType")] MarkerType value);

        [VtblIndex(28)]
        HRESULT get_NoLineNumber([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(29)]
        HRESULT put_NoLineNumber([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(30)]
        HRESULT get_PageBreakBefore([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(31)]
        HRESULT put_PageBreakBefore([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(32)]
        HRESULT get_RightIndent(float* value);

        [VtblIndex(33)]
        HRESULT put_RightIndent(float value);

        [VtblIndex(34)]
        HRESULT get_RightToLeft([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(35)]
        HRESULT put_RightToLeft([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(36)]
        HRESULT get_Style([NativeTypeName("ABI::Windows::UI::Text::ParagraphStyle *")] ParagraphStyle* value);

        [VtblIndex(37)]
        HRESULT put_Style([NativeTypeName("ABI::Windows::UI::Text::ParagraphStyle")] ParagraphStyle value);

        [VtblIndex(38)]
        HRESULT get_SpaceAfter(float* value);

        [VtblIndex(39)]
        HRESULT put_SpaceAfter(float value);

        [VtblIndex(40)]
        HRESULT get_SpaceBefore(float* value);

        [VtblIndex(41)]
        HRESULT put_SpaceBefore(float value);

        [VtblIndex(42)]
        HRESULT get_WidowControl([NativeTypeName("ABI::Windows::UI::Text::FormatEffect *")] FormatEffect* value);

        [VtblIndex(43)]
        HRESULT put_WidowControl([NativeTypeName("ABI::Windows::UI::Text::FormatEffect")] FormatEffect value);

        [VtblIndex(44)]
        HRESULT get_TabCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(45)]
        HRESULT AddTab(float position, [NativeTypeName("ABI::Windows::UI::Text::TabAlignment")] TabAlignment align, [NativeTypeName("ABI::Windows::UI::Text::TabLeader")] TabLeader leader);

        [VtblIndex(46)]
        HRESULT ClearAllTabs();

        [VtblIndex(47)]
        HRESULT DeleteTab(float position);

        [VtblIndex(48)]
        HRESULT GetClone([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")] ITextParagraphFormat** result);

        [VtblIndex(49)]
        HRESULT GetTab([NativeTypeName("INT32")] int index, float* position, [NativeTypeName("ABI::Windows::UI::Text::TabAlignment *")] TabAlignment* align, [NativeTypeName("ABI::Windows::UI::Text::TabLeader *")] TabLeader* leader);

        [VtblIndex(50)]
        HRESULT IsEqual([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* format, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(51)]
        HRESULT SetClone([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* format);

        [VtblIndex(52)]
        HRESULT SetIndents(float start, float left, float right);

        [VtblIndex(53)]
        HRESULT SetLineSpacing([NativeTypeName("ABI::Windows::UI::Text::LineSpacingRule")] LineSpacingRule rule, float spacing);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ParagraphAlignment *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ParagraphAlignment*, int> get_Alignment;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ParagraphAlignment) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ParagraphAlignment, int> put_Alignment;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_FirstLineIndent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_KeepTogether;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_KeepTogether;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_KeepWithNext;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_KeepWithNext;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LeftIndent;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LineSpacing;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::LineSpacingRule *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LineSpacingRule*, int> get_LineSpacingRule;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::MarkerAlignment *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MarkerAlignment*, int> get_ListAlignment;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::MarkerAlignment) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MarkerAlignment, int> put_ListAlignment;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ListLevelIndex;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ListLevelIndex;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ListStart;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ListStart;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::MarkerStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MarkerStyle*, int> get_ListStyle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::MarkerStyle) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MarkerStyle, int> put_ListStyle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_ListTab;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_ListTab;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::MarkerType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MarkerType*, int> get_ListType;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::MarkerType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MarkerType, int> put_ListType;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_NoLineNumber;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_NoLineNumber;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_PageBreakBefore;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_PageBreakBefore;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RightIndent;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RightIndent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_RightToLeft;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_RightToLeft;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ParagraphStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ParagraphStyle*, int> get_Style;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ParagraphStyle) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ParagraphStyle, int> put_Style;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_SpaceAfter;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_SpaceAfter;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_SpaceBefore;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_SpaceBefore;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect*, int> get_WidowControl;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FormatEffect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FormatEffect, int> put_WidowControl;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_TabCount;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::UI::Text::TabAlignment, ABI::Windows::UI::Text::TabLeader) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, TabAlignment, TabLeader, int> AddTab;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAllTabs;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> DeleteTab;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat**, int> GetClone;

        [NativeTypeName("HRESULT (INT32, FLOAT *, ABI::Windows::UI::Text::TabAlignment *, ABI::Windows::UI::Text::TabLeader *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, float*, TabAlignment*, TabLeader*, int> GetTab;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat*, byte*, int> IsEqual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat*, int> SetClone;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, int> SetIndents;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::LineSpacingRule, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LineSpacingRule, float, int> SetLineSpacing;
    }
}
