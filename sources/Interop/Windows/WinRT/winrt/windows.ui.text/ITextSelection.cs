// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection"]/*' />
[Guid("A6D36724-F28F-430A-B2CF-C343671EC0E9")]
[NativeTypeName("struct ITextSelection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextSelection : ITextSelection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextSelection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, Guid*, void**, int>)(lpVtbl[0]))((ITextSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, uint>)(lpVtbl[1]))((ITextSelection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, uint>)(lpVtbl[2]))((ITextSelection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, uint*, Guid**, int>)(lpVtbl[3]))((ITextSelection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, HSTRING*, int>)(lpVtbl[4]))((ITextSelection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TrustLevel*, int>)(lpVtbl[5]))((ITextSelection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.get_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Options([NativeTypeName("ABI::Windows::UI::Text::SelectionOptions *")] SelectionOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, SelectionOptions*, int>)(lpVtbl[6]))((ITextSelection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.put_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Options([NativeTypeName("ABI::Windows::UI::Text::SelectionOptions")] SelectionOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, SelectionOptions, int>)(lpVtbl[7]))((ITextSelection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::UI::Text::SelectionType *")] SelectionType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, SelectionType*, int>)(lpVtbl[8]))((ITextSelection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.EndKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EndKey([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TextRangeUnit, byte, int*, int>)(lpVtbl[9]))((ITextSelection*)Unsafe.AsPointer(ref this), unit, extend, result);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.HomeKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT HomeKey([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TextRangeUnit, byte, int*, int>)(lpVtbl[10]))((ITextSelection*)Unsafe.AsPointer(ref this), unit, extend, result);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.MoveDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT MoveDown([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TextRangeUnit, int, byte, int*, int>)(lpVtbl[11]))((ITextSelection*)Unsafe.AsPointer(ref this), unit, count, extend, result);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.MoveLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MoveLeft([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TextRangeUnit, int, byte, int*, int>)(lpVtbl[12]))((ITextSelection*)Unsafe.AsPointer(ref this), unit, count, extend, result);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.MoveRight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT MoveRight([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TextRangeUnit, int, byte, int*, int>)(lpVtbl[13]))((ITextSelection*)Unsafe.AsPointer(ref this), unit, count, extend, result);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.MoveUp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveUp([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, TextRangeUnit, int, byte, int*, int>)(lpVtbl[14]))((ITextSelection*)Unsafe.AsPointer(ref this), unit, count, extend, result);
    }

    /// <include file='ITextSelection.xml' path='doc/member[@name="ITextSelection.TypeText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TypeText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextSelection*, HSTRING, int>)(lpVtbl[15]))((ITextSelection*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Options([NativeTypeName("ABI::Windows::UI::Text::SelectionOptions *")] SelectionOptions* value);

        [VtblIndex(7)]
        HRESULT put_Options([NativeTypeName("ABI::Windows::UI::Text::SelectionOptions")] SelectionOptions value);

        [VtblIndex(8)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::UI::Text::SelectionType *")] SelectionType* value);

        [VtblIndex(9)]
        HRESULT EndKey([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(10)]
        HRESULT HomeKey([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(11)]
        HRESULT MoveDown([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(12)]
        HRESULT MoveLeft([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(13)]
        HRESULT MoveRight([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(14)]
        HRESULT MoveUp([NativeTypeName("ABI::Windows::UI::Text::TextRangeUnit")] TextRangeUnit unit, [NativeTypeName("INT32")] int count, [NativeTypeName("boolean")] byte extend, [NativeTypeName("INT32 *")] int* result);

        [VtblIndex(15)]
        HRESULT TypeText(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::SelectionOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SelectionOptions*, int> get_Options;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::SelectionOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SelectionOptions, int> put_Options;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::SelectionType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SelectionType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, byte, int*, int> EndKey;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, byte, int*, int> HomeKey;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, byte, int*, int> MoveDown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, byte, int*, int> MoveLeft;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, byte, int*, int> MoveRight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::TextRangeUnit, INT32, boolean, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextRangeUnit, int, byte, int*, int> MoveUp;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> TypeText;
    }
}
