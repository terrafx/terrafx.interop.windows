// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyDerivationParametersStatics.xml' path='doc/member[@name="IKeyDerivationParametersStatics"]/*' />
[Guid("EA961FBE-F37F-4146-9DFE-A456F1735F4B")]
[NativeTypeName("struct IKeyDerivationParametersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationParametersStatics : IKeyDerivationParametersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyDerivationParametersStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, uint>)(lpVtbl[1]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, uint>)(lpVtbl[2]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyDerivationParametersStatics.xml' path='doc/member[@name="IKeyDerivationParametersStatics.BuildForPbkdf2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BuildForPbkdf2([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* pbkdf2Salt, [NativeTypeName("UINT32")] uint iterationCount, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, IBuffer*, uint, IKeyDerivationParameters**, int>)(lpVtbl[6]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), pbkdf2Salt, iterationCount, value);
    }

    /// <include file='IKeyDerivationParametersStatics.xml' path='doc/member[@name="IKeyDerivationParametersStatics.BuildForSP800108"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BuildForSP800108([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* label, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* context, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, IBuffer*, IBuffer*, IKeyDerivationParameters**, int>)(lpVtbl[7]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), label, context, value);
    }

    /// <include file='IKeyDerivationParametersStatics.xml' path='doc/member[@name="IKeyDerivationParametersStatics.BuildForSP80056a"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BuildForSP80056a([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* algorithmId, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* partyUInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* partyVInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* suppPubInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* suppPrivInfo, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics*, IBuffer*, IBuffer*, IBuffer*, IBuffer*, IBuffer*, IKeyDerivationParameters**, int>)(lpVtbl[8]))((IKeyDerivationParametersStatics*)Unsafe.AsPointer(ref this), algorithmId, partyUInfo, partyVInfo, suppPubInfo, suppPrivInfo, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BuildForPbkdf2([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* pbkdf2Salt, [NativeTypeName("UINT32")] uint iterationCount, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value);

        [VtblIndex(7)]
        HRESULT BuildForSP800108([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* label, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* context, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value);

        [VtblIndex(8)]
        HRESULT BuildForSP80056a([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* algorithmId, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* partyUInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* partyVInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* suppPubInfo, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* suppPrivInfo, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, uint, IKeyDerivationParameters**, int> BuildForPbkdf2;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IBuffer*, IKeyDerivationParameters**, int> BuildForSP800108;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IBuffer*, IBuffer*, IBuffer*, IBuffer*, IKeyDerivationParameters**, int> BuildForSP80056a;
    }
}
