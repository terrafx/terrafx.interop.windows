// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics"]/*' />
[Guid("97909E87-9291-4F91-B6C8-B6E359D7A7FB")]
[NativeTypeName("struct IUnicodeCharactersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUnicodeCharactersStatics : IUnicodeCharactersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUnicodeCharactersStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint>)(lpVtbl[1]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint>)(lpVtbl[2]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, HSTRING*, int>)(lpVtbl[4]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.GetCodepointFromSurrogatePair"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCodepointFromSurrogatePair([NativeTypeName("UINT32")] uint highSurrogate, [NativeTypeName("UINT32")] uint lowSurrogate, [NativeTypeName("UINT32 *")] uint* codepoint)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, uint, uint*, int>)(lpVtbl[6]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), highSurrogate, lowSurrogate, codepoint);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.GetSurrogatePairFromCodepoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSurrogatePairFromCodepoint([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("WCHAR *")] char* highSurrogate, [NativeTypeName("WCHAR *")] char* lowSurrogate)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, char*, char*, int>)(lpVtbl[7]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, highSurrogate, lowSurrogate);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsHighSurrogate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsHighSurrogate([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[8]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsLowSurrogate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsLowSurrogate([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[9]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsSupplementary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsSupplementary([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[10]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsNoncharacter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsNoncharacter([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[11]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsWhitespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsWhitespace([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[12]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsAlphabetic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsAlphabetic([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[13]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsCased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsCased([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[14]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsUppercase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsUppercase([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[15]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsLowercase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsLowercase([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[16]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsIdStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsIdStart([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[17]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsIdContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT IsIdContinue([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[18]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsGraphemeBase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT IsGraphemeBase([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[19]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.IsGraphemeExtend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsGraphemeExtend([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, byte*, int>)(lpVtbl[20]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.GetNumericType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetNumericType([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("ABI::Windows::Data::Text::UnicodeNumericType *")] UnicodeNumericType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, UnicodeNumericType*, int>)(lpVtbl[21]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    /// <include file='IUnicodeCharactersStatics.xml' path='doc/member[@name="IUnicodeCharactersStatics.GetGeneralCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetGeneralCategory([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("ABI::Windows::Data::Text::UnicodeGeneralCategory *")] UnicodeGeneralCategory* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnicodeCharactersStatics*, uint, UnicodeGeneralCategory*, int>)(lpVtbl[22]))((IUnicodeCharactersStatics*)Unsafe.AsPointer(ref this), codepoint, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCodepointFromSurrogatePair([NativeTypeName("UINT32")] uint highSurrogate, [NativeTypeName("UINT32")] uint lowSurrogate, [NativeTypeName("UINT32 *")] uint* codepoint);

        [VtblIndex(7)]
        HRESULT GetSurrogatePairFromCodepoint([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("WCHAR *")] char* highSurrogate, [NativeTypeName("WCHAR *")] char* lowSurrogate);

        [VtblIndex(8)]
        HRESULT IsHighSurrogate([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT IsLowSurrogate([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT IsSupplementary([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT IsNoncharacter([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT IsWhitespace([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT IsAlphabetic([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT IsCased([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT IsUppercase([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT IsLowercase([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT IsIdStart([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT IsIdContinue([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT IsGraphemeBase([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(20)]
        HRESULT IsGraphemeExtend([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT GetNumericType([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("ABI::Windows::Data::Text::UnicodeNumericType *")] UnicodeNumericType* value);

        [VtblIndex(22)]
        HRESULT GetGeneralCategory([NativeTypeName("UINT32")] uint codepoint, [NativeTypeName("ABI::Windows::Data::Text::UnicodeGeneralCategory *")] UnicodeGeneralCategory* value);
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

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, int> GetCodepointFromSurrogatePair;

        [NativeTypeName("HRESULT (UINT32, WCHAR *, WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, int> GetSurrogatePairFromCodepoint;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsHighSurrogate;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsLowSurrogate;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsSupplementary;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsNoncharacter;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsWhitespace;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsAlphabetic;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsCased;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsUppercase;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsLowercase;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsIdStart;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsIdContinue;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsGraphemeBase;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> IsGraphemeExtend;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Data::Text::UnicodeNumericType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, UnicodeNumericType*, int> GetNumericType;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Data::Text::UnicodeGeneralCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, UnicodeGeneralCategory*, int> GetGeneralCategory;
    }
}
