// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMacAlgorithmProvider.xml' path='doc/member[@name="IMacAlgorithmProvider"]/*' />
[Guid("4A3FC5C3-1CBD-41CE-A092-AA0BC5D2D2F5")]
[NativeTypeName("struct IMacAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMacAlgorithmProvider : IMacAlgorithmProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMacAlgorithmProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, uint>)(lpVtbl[1]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, uint>)(lpVtbl[2]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, HSTRING*, int>)(lpVtbl[4]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, TrustLevel*, int>)(lpVtbl[5]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMacAlgorithmProvider.xml' path='doc/member[@name="IMacAlgorithmProvider.get_AlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, HSTRING*, int>)(lpVtbl[6]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMacAlgorithmProvider.xml' path='doc/member[@name="IMacAlgorithmProvider.get_MacLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MacLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, uint*, int>)(lpVtbl[7]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMacAlgorithmProvider.xml' path='doc/member[@name="IMacAlgorithmProvider.CreateKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** macKey)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProvider*, IBuffer*, ICryptographicKey**, int>)(lpVtbl[8]))((IMacAlgorithmProvider*)Unsafe.AsPointer(ref this), keyMaterial, macKey);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MacLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT CreateKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** macKey);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MacLength;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICryptographicKey**, int> CreateKey;
    }
}
