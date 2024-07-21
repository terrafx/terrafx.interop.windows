// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMacAlgorithmProvider2.xml' path='doc/member[@name="IMacAlgorithmProvider2"]/*' />
[Guid("6DA32A15-D931-42ED-8E7E-C301CAEE119C")]
[NativeTypeName("struct IMacAlgorithmProvider2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMacAlgorithmProvider2 : IMacAlgorithmProvider2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMacAlgorithmProvider2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, Guid*, void**, int>)(lpVtbl[0]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, uint>)(lpVtbl[1]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, uint>)(lpVtbl[2]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, uint*, Guid**, int>)(lpVtbl[3]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, HSTRING*, int>)(lpVtbl[4]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, TrustLevel*, int>)(lpVtbl[5]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMacAlgorithmProvider2.xml' path='doc/member[@name="IMacAlgorithmProvider2.CreateHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateHash([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IHashComputation **")] IHashComputation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider2*, IBuffer*, IHashComputation**, int>)(lpVtbl[6]))((IMacAlgorithmProvider2*)Unsafe.AsPointer(ref this), keyMaterial, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateHash([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IHashComputation **")] IHashComputation** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IHashComputation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IHashComputation**, int> CreateHash;
    }
}
