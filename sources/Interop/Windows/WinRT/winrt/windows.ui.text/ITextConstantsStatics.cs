// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics"]/*' />
[Guid("779E7C33-189D-4BFA-97C8-10DB135D976E")]
[NativeTypeName("struct ITextConstantsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextConstantsStatics : ITextConstantsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITextConstantsStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, uint>)(lpVtbl[1]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, uint>)(lpVtbl[2]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, HSTRING*, int>)(lpVtbl[4]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_AutoColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, Color*, int>)(lpVtbl[6]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_MinUnitCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinUnitCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, int*, int>)(lpVtbl[7]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_MaxUnitCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxUnitCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, int*, int>)(lpVtbl[8]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_UndefinedColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UndefinedColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, Color*, int>)(lpVtbl[9]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_UndefinedFloatValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UndefinedFloatValue(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, float*, int>)(lpVtbl[10]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_UndefinedInt32Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UndefinedInt32Value([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, int*, int>)(lpVtbl[11]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_UndefinedFontStretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UndefinedFontStretch([NativeTypeName("ABI::Windows::UI::Text::FontStretch *")] FontStretch* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, FontStretch*, int>)(lpVtbl[12]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConstantsStatics.xml' path='doc/member[@name="ITextConstantsStatics.get_UndefinedFontStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UndefinedFontStyle([NativeTypeName("ABI::Windows::UI::Text::FontStyle *")] FontStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConstantsStatics*, FontStyle*, int>)(lpVtbl[13]))((ITextConstantsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT get_MinUnitCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MaxUnitCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_UndefinedColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(10)]
        HRESULT get_UndefinedFloatValue(float* value);

        [VtblIndex(11)]
        HRESULT get_UndefinedInt32Value([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_UndefinedFontStretch([NativeTypeName("ABI::Windows::UI::Text::FontStretch *")] FontStretch* value);

        [VtblIndex(13)]
        HRESULT get_UndefinedFontStyle([NativeTypeName("ABI::Windows::UI::Text::FontStyle *")] FontStyle* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_AutoColor;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MinUnitCount;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxUnitCount;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_UndefinedColor;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_UndefinedFloatValue;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_UndefinedInt32Value;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStretch *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontStretch*, int> get_UndefinedFontStretch;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontStyle*, int> get_UndefinedFontStyle;
    }
}
