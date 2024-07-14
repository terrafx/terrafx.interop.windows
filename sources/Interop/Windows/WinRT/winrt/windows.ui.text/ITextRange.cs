// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextRange.xml' path='doc/member[@name="ITextRange"]/*' />
[Guid("5B9E4E57-C072-42A0-8945-AF503EE54768")]
[NativeTypeName("struct ITextRange : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextRange : ITextRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextRange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, Guid*, void**, int>)(lpVtbl[0]))((ITextRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, uint>)(lpVtbl[1]))((ITextRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, uint>)(lpVtbl[2]))((ITextRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, uint*, Guid**, int>)(lpVtbl[3]))((ITextRange*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HSTRING*, int>)(lpVtbl[4]))((ITextRange*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TrustLevel*, int>)(lpVtbl[5]))((ITextRange*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_Character"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Character([NativeTypeName("WCHAR *")] char* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, char*, int>)(lpVtbl[6]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_Character"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Character([NativeTypeName("WCHAR")] char value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, char, int>)(lpVtbl[7]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_CharacterFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")] ITextCharacterFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextCharacterFormat**, int>)(lpVtbl[8]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_CharacterFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextCharacterFormat*, int>)(lpVtbl[9]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_FormattedText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FormattedText([NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextRange**, int>)(lpVtbl[10]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_FormattedText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FormattedText([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextRange*, int>)(lpVtbl[11]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_EndPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EndPosition([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int*, int>)(lpVtbl[12]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_EndPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_EndPosition([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int, int>)(lpVtbl[13]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_Gravity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Gravity([NativeTypeName("ABI::Windows::UI::Text::RangeGravity *")] RangeGravity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, RangeGravity*, int>)(lpVtbl[14]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_Gravity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Gravity([NativeTypeName("ABI::Windows::UI::Text::RangeGravity")] RangeGravity value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, RangeGravity, int>)(lpVtbl[15]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Length([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int*, int>)(lpVtbl[16]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_Link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Link(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HSTRING*, int>)(lpVtbl[17]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_Link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_Link(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HSTRING, int>)(lpVtbl[18]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_ParagraphFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")] ITextParagraphFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextParagraphFormat**, int>)(lpVtbl[19]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_ParagraphFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextParagraphFormat*, int>)(lpVtbl[20]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_StartPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_StartPosition([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int*, int>)(lpVtbl[21]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_StartPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_StartPosition([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int, int>)(lpVtbl[22]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_StoryLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_StoryLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int*, int>)(lpVtbl[23]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HSTRING*, int>)(lpVtbl[24]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.put_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HSTRING, int>)(lpVtbl[25]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.CanPaste"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CanPaste([NativeTypeName("INT32")] int format, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int, byte*, int>)(lpVtbl[26]))((ITextRange*)Unsafe.AsPointer(ref this), format, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.ChangeCase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ChangeCase([NativeTypeName("ABI::Windows::UI::Text::LetterCase")] LetterCase value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, LetterCase, int>)(lpVtbl[27]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Collapse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT Collapse([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, byte, int>)(lpVtbl[28]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Copy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT Copy()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int>)(lpVtbl[29]))((ITextRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Cut"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Cut()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int>)(lpVtbl[30]))((ITextRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Delete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT Delete([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int, int*, int>)(lpVtbl[31]))((ITextRange*)Unsafe.AsPointer(ref this), unit, count, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.EndOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT EndOf([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, byte, int*, int>)(lpVtbl[32]))((ITextRange*)Unsafe.AsPointer(ref this), unit, extend, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Expand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT Expand([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int*, int>)(lpVtbl[33]))((ITextRange*)Unsafe.AsPointer(ref this), unit, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.FindTextW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT FindTextW(HSTRING value, [NativeTypeName("INT32")] int scanLength, [NativeTypeName("ABI::Windows::UI::Text::FindOptions")] FindOptions options, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HSTRING, int, FindOptions, int*, int>)(lpVtbl[34]))((ITextRange*)Unsafe.AsPointer(ref this), value, scanLength, options, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetCharacterUtf32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetCharacterUtf32([NativeTypeName("UINT32 *")] uint* value, [NativeTypeName("INT32")] int offset)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, uint*, int, int>)(lpVtbl[35]))((ITextRange*)Unsafe.AsPointer(ref this), value, offset);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetClone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetClone([NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextRange**, int>)(lpVtbl[36]))((ITextRange*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetIndex([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int*, int>)(lpVtbl[37]))((ITextRange*)Unsafe.AsPointer(ref this), unit, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetPoint([NativeTypeName("ABI::Windows::UI::Text::HorizontalCharacterAlignment")] HorizontalCharacterAlignment horizontalAlign, [NativeTypeName("ABI::Windows::UI::Text::VerticalCharacterAlignment")] VerticalCharacterAlignment verticalAlign, [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* point)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, HorizontalCharacterAlignment, VerticalCharacterAlignment, PointOptions, Point*, int>)(lpVtbl[38]))((ITextRange*)Unsafe.AsPointer(ref this), horizontalAlign, verticalAlign, options, point);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetRect([NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* rect, [NativeTypeName("INT32 *")] int* hit)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, PointOptions, Rect*, int*, int>)(lpVtbl[39]))((ITextRange*)Unsafe.AsPointer(ref this), options, rect, hit);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetText([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextGetOptions, HSTRING*, int>)(lpVtbl[40]))((ITextRange*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.GetTextViaStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetTextViaStream([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextGetOptions, IRandomAccessStream*, int>)(lpVtbl[41]))((ITextRange*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.InRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT InRange([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* range, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextRange*, byte*, int>)(lpVtbl[42]))((ITextRange*)Unsafe.AsPointer(ref this), range, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.InsertImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT InsertImage([NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("INT32")] int ascent, [NativeTypeName("ABI::Windows::UI::Text::VerticalCharacterAlignment")] VerticalCharacterAlignment verticalAlign, HSTRING alternateText, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int, int, int, VerticalCharacterAlignment, HSTRING, IRandomAccessStream*, int>)(lpVtbl[43]))((ITextRange*)Unsafe.AsPointer(ref this), width, height, ascent, verticalAlign, alternateText, value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.InStory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT InStory([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* range, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextRange*, byte*, int>)(lpVtbl[44]))((ITextRange*)Unsafe.AsPointer(ref this), range, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT IsEqual([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* range, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, ITextRange*, byte*, int>)(lpVtbl[45]))((ITextRange*)Unsafe.AsPointer(ref this), range, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Move"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT Move([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int, int*, int>)(lpVtbl[46]))((ITextRange*)Unsafe.AsPointer(ref this), unit, count, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.MoveEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT MoveEnd([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int, int*, int>)(lpVtbl[47]))((ITextRange*)Unsafe.AsPointer(ref this), unit, count, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.MoveStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT MoveStart([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int, int*, int>)(lpVtbl[48]))((ITextRange*)Unsafe.AsPointer(ref this), unit, count, result);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.Paste"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT Paste([NativeTypeName("INT32")] int format)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int, int>)(lpVtbl[49]))((ITextRange*)Unsafe.AsPointer(ref this), format);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.ScrollIntoView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT ScrollIntoView([NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, PointOptions, int>)(lpVtbl[50]))((ITextRange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.MatchSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT MatchSelection()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int>)(lpVtbl[51]))((ITextRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.SetIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT SetIndex([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int index, [NativeTypeName("boolean")] byte extend)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, int, byte, int>)(lpVtbl[52]))((ITextRange*)Unsafe.AsPointer(ref this), unit, index, extend);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.SetPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SetPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point point, [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("boolean")] byte extend)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, Point, PointOptions, byte, int>)(lpVtbl[53]))((ITextRange*)Unsafe.AsPointer(ref this), point, options, extend);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.SetRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT SetRange([NativeTypeName("INT32")] int startPosition, [NativeTypeName("INT32")] int endPosition)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, int, int, int>)(lpVtbl[54]))((ITextRange*)Unsafe.AsPointer(ref this), startPosition, endPosition);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.SetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT SetText([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextSetOptions, HSTRING, int>)(lpVtbl[55]))((ITextRange*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.SetTextViaStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT SetTextViaStream([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextSetOptions, IRandomAccessStream*, int>)(lpVtbl[56]))((ITextRange*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextRange.xml' path='doc/member[@name="ITextRange.StartOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT StartOf([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextRange*, TextRangeUnit, byte, int*, int>)(lpVtbl[57]))((ITextRange*)Unsafe.AsPointer(ref this), unit, extend, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Character([NativeTypeName("WCHAR *")] char* value);

        [VtblIndex(7)]
        HRESULT put_Character([NativeTypeName("WCHAR")] char value);

        [VtblIndex(8)]
        HRESULT get_CharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")] ITextCharacterFormat** value);

        [VtblIndex(9)]
        HRESULT put_CharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* value);

        [VtblIndex(10)]
        HRESULT get_FormattedText([NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** value);

        [VtblIndex(11)]
        HRESULT put_FormattedText([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* value);

        [VtblIndex(12)]
        HRESULT get_EndPosition([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_EndPosition([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_Gravity([NativeTypeName("ABI::Windows::UI::Text::RangeGravity *")] RangeGravity* value);

        [VtblIndex(15)]
        HRESULT put_Gravity([NativeTypeName("ABI::Windows::UI::Text::RangeGravity")] RangeGravity value);

        [VtblIndex(16)]
        HRESULT get_Length([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT get_Link(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_Link(HSTRING value);

        [VtblIndex(19)]
        HRESULT get_ParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")] ITextParagraphFormat** value);

        [VtblIndex(20)]
        HRESULT put_ParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* value);

        [VtblIndex(21)]
        HRESULT get_StartPosition([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(22)]
        HRESULT put_StartPosition([NativeTypeName("INT32")] int value);

        [VtblIndex(23)]
        HRESULT get_StoryLength([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(24)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(25)]
        HRESULT put_Text(HSTRING value);

        [VtblIndex(26)]
        HRESULT CanPaste([NativeTypeName("INT32")] int format, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(27)]
        HRESULT ChangeCase([NativeTypeName("ABI::Windows::UI::Text::LetterCase")] LetterCase value);

        [VtblIndex(28)]
        HRESULT Collapse([NativeTypeName("boolean")] byte value);

        [VtblIndex(29)]
        HRESULT Copy();

        [VtblIndex(30)]
        HRESULT Cut();

        [VtblIndex(31)]
        HRESULT Delete([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(32)]
        HRESULT EndOf([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(33)]
        HRESULT Expand([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(34)]
        HRESULT FindTextW(HSTRING value, [NativeTypeName("INT32")] int scanLength, [NativeTypeName("ABI::Windows::UI::Text::FindOptions")] FindOptions options, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(35)]
        HRESULT GetCharacterUtf32([NativeTypeName("UINT32 *")] uint* value, [NativeTypeName("INT32")] int offset);

        [VtblIndex(36)]
        HRESULT GetClone([NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** result);

        [VtblIndex(37)]
        HRESULT GetIndex([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(38)]
        HRESULT GetPoint([NativeTypeName("ABI::Windows::UI::Text::HorizontalCharacterAlignment")] HorizontalCharacterAlignment horizontalAlign, [NativeTypeName("ABI::Windows::UI::Text::VerticalCharacterAlignment")] VerticalCharacterAlignment verticalAlign, [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* point);

        [VtblIndex(39)]
        HRESULT GetRect([NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* rect, [NativeTypeName("INT32 *")] int* hit);

        [VtblIndex(40)]
        HRESULT GetText([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, HSTRING* value);

        [VtblIndex(41)]
        HRESULT GetTextViaStream([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value);

        [VtblIndex(42)]
        HRESULT InRange([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* range, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(43)]
        HRESULT InsertImage([NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("INT32")] int ascent, [NativeTypeName("ABI::Windows::UI::Text::VerticalCharacterAlignment")] VerticalCharacterAlignment verticalAlign, HSTRING alternateText, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value);

        [VtblIndex(44)]
        HRESULT InStory([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* range, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(45)]
        HRESULT IsEqual([NativeTypeName("ABI::Windows::UI::Text::ITextRange *")] ITextRange* range, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(46)]
        HRESULT Move([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(47)]
        HRESULT MoveEnd([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(48)]
        HRESULT MoveStart([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(49)]
        HRESULT Paste([NativeTypeName("INT32")] int format);

        [VtblIndex(50)]
        HRESULT ScrollIntoView([NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions value);

        [VtblIndex(51)]
        HRESULT MatchSelection();

        [VtblIndex(52)]
        HRESULT SetIndex([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int index, [NativeTypeName("boolean")] byte extend);

        [VtblIndex(53)]
        HRESULT SetPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point point, [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("boolean")] byte extend);

        [VtblIndex(54)]
        HRESULT SetRange([NativeTypeName("INT32")] int startPosition, [NativeTypeName("INT32")] int endPosition);

        [VtblIndex(55)]
        HRESULT SetText([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, HSTRING value);

        [VtblIndex(56)]
        HRESULT SetTextViaStream([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value);

        [VtblIndex(57)]
        HRESULT StartOf([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);
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

        [NativeTypeName("HRESULT (WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> get_Character;

        [NativeTypeName("HRESULT (WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char, int> put_Character;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat**, int> get_CharacterFormat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat*, int> put_CharacterFormat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextRange **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextRange**, int> get_FormattedText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextRange*, int> put_FormattedText;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_EndPosition;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_EndPosition;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::RangeGravity *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RangeGravity*, int> get_Gravity;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::RangeGravity) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RangeGravity, int> put_Gravity;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Length;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Link;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Link;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat**, int> get_ParagraphFormat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat*, int> put_ParagraphFormat;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_StartPosition;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_StartPosition;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_StoryLength;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Text;

        [NativeTypeName("HRESULT (INT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, byte*, int> CanPaste;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::LetterCase) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LetterCase, int> ChangeCase;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> Collapse;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Copy;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Cut;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, int*, int> Delete;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, byte, int*, int> EndOf;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int*, int> Expand;

        [NativeTypeName("HRESULT (HSTRING, INT32, ABI::Windows::UI::Text::FindOptions, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int, FindOptions, int*, int> FindTextW;

        [NativeTypeName("HRESULT (UINT32 *, INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int, int> GetCharacterUtf32;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextRange **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextRange**, int> GetClone;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int*, int> GetIndex;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::HorizontalCharacterAlignment, ABI::Windows::UI::Text::VerticalCharacterAlignment, ABI::Windows::UI::Text::PointOptions, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HorizontalCharacterAlignment, VerticalCharacterAlignment, PointOptions, Point*, int> GetPoint;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::PointOptions, ABI::Windows::Foundation::Rect *, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointOptions, Rect*, int*, int> GetRect;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextGetOptions, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextGetOptions, HSTRING*, int> GetText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextGetOptions, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextGetOptions, IRandomAccessStream*, int> GetTextViaStream;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextRange *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextRange*, byte*, int> InRange;

        [NativeTypeName("HRESULT (INT32, INT32, INT32, ABI::Windows::UI::Text::VerticalCharacterAlignment, HSTRING, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int, VerticalCharacterAlignment, HSTRING, IRandomAccessStream*, int> InsertImage;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextRange *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextRange*, byte*, int> InStory;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextRange *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextRange*, byte*, int> IsEqual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, int*, int> Move;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, int*, int> MoveEnd;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, int*, int> MoveStart;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> Paste;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::PointOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointOptions, int> ScrollIntoView;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> MatchSelection;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, byte, int> SetIndex;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::UI::Text::PointOptions, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, PointOptions, byte, int> SetPoint;

        [NativeTypeName("HRESULT (INT32, INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int> SetRange;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextSetOptions, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextSetOptions, HSTRING, int> SetText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextSetOptions, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextSetOptions, IRandomAccessStream*, int> SetTextViaStream;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, byte, int*, int> StartOf;
    }
}
