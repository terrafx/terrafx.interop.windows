// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBufferProtectUnprotectResult.xml' path='doc/member[@name="IBufferProtectUnprotectResult"]/*' />
[Guid("47995EDC-6CEC-4E3A-B251-9E7485D79E7A")]
[NativeTypeName("struct IBufferProtectUnprotectResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBufferProtectUnprotectResult : IBufferProtectUnprotectResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBufferProtectUnprotectResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, Guid*, void**, int>)(lpVtbl[0]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, uint>)(lpVtbl[1]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, uint>)(lpVtbl[2]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, uint*, Guid**, int>)(lpVtbl[3]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, HSTRING*, int>)(lpVtbl[4]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, TrustLevel*, int>)(lpVtbl[5]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBufferProtectUnprotectResult.xml' path='doc/member[@name="IBufferProtectUnprotectResult.get_Buffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Buffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, IBuffer**, int>)(lpVtbl[6]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBufferProtectUnprotectResult.xml' path='doc/member[@name="IBufferProtectUnprotectResult.get_ProtectionInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProtectionInfo([NativeTypeName("ABI::Windows::Security::EnterpriseData::IDataProtectionInfo **")] IDataProtectionInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferProtectUnprotectResult*, IDataProtectionInfo**, int>)(lpVtbl[7]))((IBufferProtectUnprotectResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Buffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT get_ProtectionInfo([NativeTypeName("ABI::Windows::Security::EnterpriseData::IDataProtectionInfo **")] IDataProtectionInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Buffer;

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::IDataProtectionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataProtectionInfo**, int> get_ProtectionInfo;
    }
}
