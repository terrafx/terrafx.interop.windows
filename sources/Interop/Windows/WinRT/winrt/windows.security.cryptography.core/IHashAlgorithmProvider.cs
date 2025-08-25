// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHashAlgorithmProvider.xml' path='doc/member[@name="IHashAlgorithmProvider"]/*' />
[Guid("BE9B3080-B2C3-422B-BCE1-EC90EFB5D7B5")]
[NativeTypeName("struct IHashAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHashAlgorithmProvider : IHashAlgorithmProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHashAlgorithmProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, Guid*, void**, int>)(lpVtbl[0]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, uint>)(lpVtbl[1]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, uint>)(lpVtbl[2]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, HSTRING*, int>)(lpVtbl[4]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, TrustLevel*, int>)(lpVtbl[5]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHashAlgorithmProvider.xml' path='doc/member[@name="IHashAlgorithmProvider.get_AlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, HSTRING*, int>)(lpVtbl[6]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHashAlgorithmProvider.xml' path='doc/member[@name="IHashAlgorithmProvider.get_HashLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HashLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, uint*, int>)(lpVtbl[7]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHashAlgorithmProvider.xml' path='doc/member[@name="IHashAlgorithmProvider.HashData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT HashData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, IBuffer*, IBuffer**, int>)(lpVtbl[8]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), data, value);
    }

    /// <include file='IHashAlgorithmProvider.xml' path='doc/member[@name="IHashAlgorithmProvider.CreateHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateHash([NativeTypeName("ABI::Windows::Security::Cryptography::Core::IHashComputation **")] IHashComputation** Value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmProvider*, IHashComputation**, int>)(lpVtbl[9]))((IHashAlgorithmProvider*)Unsafe.AsPointer(ref this), Value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_HashLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT HashData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT CreateHash([NativeTypeName("ABI::Windows::Security::Cryptography::Core::IHashComputation **")] IHashComputation** Value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlgorithmName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HashLength;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IBuffer**, int> HashData;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::IHashComputation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHashComputation**, int> CreateHash;
    }
}
