// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJsonArrayStatics.xml' path='doc/member[@name="IJsonArrayStatics"]/*' />
[Guid("DB1434A9-E164-499F-93E2-8A8F49BB90BA")]
[NativeTypeName("struct IJsonArrayStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonArrayStatics : IJsonArrayStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonArrayStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, Guid*, void**, int>)(lpVtbl[0]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, uint>)(lpVtbl[1]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, uint>)(lpVtbl[2]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, HSTRING*, int>)(lpVtbl[4]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, TrustLevel*, int>)(lpVtbl[5]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJsonArrayStatics.xml' path='doc/member[@name="IJsonArrayStatics.Parse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** jsonArray)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, HSTRING, IJsonArray**, int>)(lpVtbl[6]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this), input, jsonArray);
    }

    /// <include file='IJsonArrayStatics.xml' path='doc/member[@name="IJsonArrayStatics.TryParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** result, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArrayStatics*, HSTRING, IJsonArray**, byte*, int>)(lpVtbl[7]))((IJsonArrayStatics*)Unsafe.AsPointer(ref this), input, result, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** jsonArray);

        [VtblIndex(7)]
        HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** result, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonArray**, int> Parse;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonArray **, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonArray**, byte*, int> TryParse;
    }
}
