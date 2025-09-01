// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument"]/*' />
[Guid("BEEE4DDB-90B2-408C-A2F6-0A0AC31E33E4")]
[NativeTypeName("struct ITextDocument : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextDocument : ITextDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITextDocument);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, Guid*, void**, int>)(lpVtbl[0]))((ITextDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, uint>)(lpVtbl[1]))((ITextDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, uint>)(lpVtbl[2]))((ITextDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, uint*, Guid**, int>)(lpVtbl[3]))((ITextDocument*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, HSTRING*, int>)(lpVtbl[4]))((ITextDocument*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, TrustLevel*, int>)(lpVtbl[5]))((ITextDocument*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.get_CaretType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CaretType([NativeTypeName("ABI::Windows::UI::Text::CaretType *")] CaretType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, CaretType*, int>)(lpVtbl[6]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.put_CaretType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CaretType([NativeTypeName("ABI::Windows::UI::Text::CaretType")] CaretType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, CaretType, int>)(lpVtbl[7]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.get_DefaultTabStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DefaultTabStop(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, float*, int>)(lpVtbl[8]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.put_DefaultTabStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DefaultTabStop(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, float, int>)(lpVtbl[9]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.get_Selection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Selection([NativeTypeName("ABI::Windows::UI::Text::ITextSelection **")] ITextSelection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, ITextSelection**, int>)(lpVtbl[10]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.get_UndoLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UndoLimit([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, uint*, int>)(lpVtbl[11]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.put_UndoLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_UndoLimit([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, uint, int>)(lpVtbl[12]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.CanCopy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CanCopy([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, byte*, int>)(lpVtbl[13]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.CanPaste"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CanPaste([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, byte*, int>)(lpVtbl[14]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.CanRedo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CanRedo([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, byte*, int>)(lpVtbl[15]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.CanUndo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CanUndo([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, byte*, int>)(lpVtbl[16]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.ApplyDisplayUpdates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ApplyDisplayUpdates([NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int*, int>)(lpVtbl[17]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.BatchDisplayUpdates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT BatchDisplayUpdates([NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int*, int>)(lpVtbl[18]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.BeginUndoGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT BeginUndoGroup()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int>)(lpVtbl[19]))((ITextDocument*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.EndUndoGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT EndUndoGroup()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int>)(lpVtbl[20]))((ITextDocument*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.GetDefaultCharacterFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDefaultCharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")] ITextCharacterFormat** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, ITextCharacterFormat**, int>)(lpVtbl[21]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.GetDefaultParagraphFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetDefaultParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")] ITextParagraphFormat** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, ITextParagraphFormat**, int>)(lpVtbl[22]))((ITextDocument*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.GetRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetRange([NativeTypeName("INT32")] int startPosition, [NativeTypeName("INT32")] int endPosition, [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int, int, ITextRange**, int>)(lpVtbl[23]))((ITextDocument*)Unsafe.AsPointer(ref this), startPosition, endPosition, result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.GetRangeFromPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetRangeFromPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point point, [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, Point, PointOptions, ITextRange**, int>)(lpVtbl[24]))((ITextDocument*)Unsafe.AsPointer(ref this), point, options, result);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.GetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetText([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, TextGetOptions, HSTRING*, int>)(lpVtbl[25]))((ITextDocument*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.LoadFromStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT LoadFromStream([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, TextSetOptions, IRandomAccessStream*, int>)(lpVtbl[26]))((ITextDocument*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.Redo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Redo()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int>)(lpVtbl[27]))((ITextDocument*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.SaveToStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SaveToStream([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, TextGetOptions, IRandomAccessStream*, int>)(lpVtbl[28]))((ITextDocument*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.SetDefaultCharacterFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetDefaultCharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, ITextCharacterFormat*, int>)(lpVtbl[29]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.SetDefaultParagraphFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetDefaultParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, ITextParagraphFormat*, int>)(lpVtbl[30]))((ITextDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.SetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetText([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, TextSetOptions, HSTRING, int>)(lpVtbl[31]))((ITextDocument*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='ITextDocument.xml' path='doc/member[@name="ITextDocument.Undo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Undo()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument*, int>)(lpVtbl[32]))((ITextDocument*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CaretType([NativeTypeName("ABI::Windows::UI::Text::CaretType *")] CaretType* value);

        [VtblIndex(7)]
        HRESULT put_CaretType([NativeTypeName("ABI::Windows::UI::Text::CaretType")] CaretType value);

        [VtblIndex(8)]
        HRESULT get_DefaultTabStop(float* value);

        [VtblIndex(9)]
        HRESULT put_DefaultTabStop(float value);

        [VtblIndex(10)]
        HRESULT get_Selection([NativeTypeName("ABI::Windows::UI::Text::ITextSelection **")] ITextSelection** value);

        [VtblIndex(11)]
        HRESULT get_UndoLimit([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_UndoLimit([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT CanCopy([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT CanPaste([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(15)]
        HRESULT CanRedo([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(16)]
        HRESULT CanUndo([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(17)]
        HRESULT ApplyDisplayUpdates([NativeTypeName("INT32 *")] int* result);

        [VtblIndex(18)]
        HRESULT BatchDisplayUpdates([NativeTypeName("INT32 *")] int* result);

        [VtblIndex(19)]
        HRESULT BeginUndoGroup();

        [VtblIndex(20)]
        HRESULT EndUndoGroup();

        [VtblIndex(21)]
        HRESULT GetDefaultCharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat **")] ITextCharacterFormat** result);

        [VtblIndex(22)]
        HRESULT GetDefaultParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat **")] ITextParagraphFormat** result);

        [VtblIndex(23)]
        HRESULT GetRange([NativeTypeName("INT32")] int startPosition, [NativeTypeName("INT32")] int endPosition, [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** result);

        [VtblIndex(24)]
        HRESULT GetRangeFromPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point point, [NativeTypeName("ABI::Windows::UI::Text::PointOptions")] PointOptions options, [NativeTypeName("ABI::Windows::UI::Text::ITextRange **")] ITextRange** result);

        [VtblIndex(25)]
        HRESULT GetText([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, HSTRING* value);

        [VtblIndex(26)]
        HRESULT LoadFromStream([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value);

        [VtblIndex(27)]
        HRESULT Redo();

        [VtblIndex(28)]
        HRESULT SaveToStream([NativeTypeName("ABI::Windows::UI::Text::TextGetOptions")] TextGetOptions options, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value);

        [VtblIndex(29)]
        HRESULT SetDefaultCharacterFormat([NativeTypeName("ABI::Windows::UI::Text::ITextCharacterFormat *")] ITextCharacterFormat* value);

        [VtblIndex(30)]
        HRESULT SetDefaultParagraphFormat([NativeTypeName("ABI::Windows::UI::Text::ITextParagraphFormat *")] ITextParagraphFormat* value);

        [VtblIndex(31)]
        HRESULT SetText([NativeTypeName("ABI::Windows::UI::Text::TextSetOptions")] TextSetOptions options, HSTRING value);

        [VtblIndex(32)]
        HRESULT Undo();
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::CaretType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CaretType*, int> get_CaretType;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::CaretType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CaretType, int> put_CaretType;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_DefaultTabStop;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_DefaultTabStop;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextSelection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextSelection**, int> get_Selection;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_UndoLimit;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_UndoLimit;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> CanCopy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> CanPaste;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> CanRedo;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> CanUndo;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> ApplyDisplayUpdates;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> BatchDisplayUpdates;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> BeginUndoGroup;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> EndUndoGroup;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat**, int> GetDefaultCharacterFormat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat**, int> GetDefaultParagraphFormat;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::UI::Text::ITextRange **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, ITextRange**, int> GetRange;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::UI::Text::PointOptions, ABI::Windows::UI::Text::ITextRange **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, PointOptions, ITextRange**, int> GetRangeFromPoint;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextGetOptions, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextGetOptions, HSTRING*, int> GetText;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextSetOptions, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextSetOptions, IRandomAccessStream*, int> LoadFromStream;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Redo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextGetOptions, ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextGetOptions, IRandomAccessStream*, int> SaveToStream;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextCharacterFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextCharacterFormat*, int> SetDefaultCharacterFormat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::ITextParagraphFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITextParagraphFormat*, int> SetDefaultParagraphFormat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextSetOptions, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextSetOptions, HSTRING, int> SetText;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Undo;
    }
}
