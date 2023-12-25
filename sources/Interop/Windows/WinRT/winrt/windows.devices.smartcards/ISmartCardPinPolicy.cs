// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy"]/*' />
[Guid("183CE184-4DB6-4841-AC9E-2AC1F39B7304")]
[NativeTypeName("struct ISmartCardPinPolicy : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardPinPolicy : ISmartCardPinPolicy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardPinPolicy));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint>)(lpVtbl[1]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint>)(lpVtbl[2]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.get_MinLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint*, int>)(lpVtbl[6]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.put_MinLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MinLength([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint, int>)(lpVtbl[7]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.get_MaxLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint*, int>)(lpVtbl[8]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.put_MaxLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxLength([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, uint, int>)(lpVtbl[9]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.get_UppercaseLetters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UppercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption*, int>)(lpVtbl[10]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.put_UppercaseLetters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_UppercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption, int>)(lpVtbl[11]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.get_LowercaseLetters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LowercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption*, int>)(lpVtbl[12]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.put_LowercaseLetters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_LowercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption, int>)(lpVtbl[13]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.get_Digits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Digits([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption*, int>)(lpVtbl[14]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.put_Digits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Digits([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption, int>)(lpVtbl[15]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.get_SpecialCharacters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SpecialCharacters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption*, int>)(lpVtbl[16]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardPinPolicy.xml' path='doc/member[@name="ISmartCardPinPolicy.put_SpecialCharacters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SpecialCharacters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardPinPolicy*, SmartCardPinCharacterPolicyOption, int>)(lpVtbl[17]))((ISmartCardPinPolicy*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MinLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_MinLength([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_MaxLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_MaxLength([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_UppercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value);

        [VtblIndex(11)]
        HRESULT put_UppercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value);

        [VtblIndex(12)]
        HRESULT get_LowercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value);

        [VtblIndex(13)]
        HRESULT put_LowercaseLetters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value);

        [VtblIndex(14)]
        HRESULT get_Digits([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value);

        [VtblIndex(15)]
        HRESULT put_Digits([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value);

        [VtblIndex(16)]
        HRESULT get_SpecialCharacters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")] SmartCardPinCharacterPolicyOption* value);

        [VtblIndex(17)]
        HRESULT put_SpecialCharacters([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")] SmartCardPinCharacterPolicyOption value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinLength;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_MinLength;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxLength;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_MaxLength;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption*, int> get_UppercaseLetters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption, int> put_UppercaseLetters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption*, int> get_LowercaseLetters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption, int> put_LowercaseLetters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption*, int> get_Digits;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption, int> put_Digits;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption*, int> get_SpecialCharacters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardPinCharacterPolicyOption, int> put_SpecialCharacters;
    }
}
