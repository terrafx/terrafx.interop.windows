// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebProviderTokenRequest3.xml' path='doc/member[@name="IWebProviderTokenRequest3"]/*' />
[Guid("1B2716AA-4289-446E-9256-DAFB6F66A51E")]
[NativeTypeName("struct IWebProviderTokenRequest3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebProviderTokenRequest3 : IWebProviderTokenRequest3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebProviderTokenRequest3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, Guid*, void**, int>)(lpVtbl[0]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, uint>)(lpVtbl[1]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, uint>)(lpVtbl[2]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, uint*, Guid**, int>)(lpVtbl[3]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, HSTRING*, int>)(lpVtbl[4]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, TrustLevel*, int>)(lpVtbl[5]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebProviderTokenRequest3.xml' path='doc/member[@name="IWebProviderTokenRequest3.get_ApplicationPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ApplicationPackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, HSTRING*, int>)(lpVtbl[6]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebProviderTokenRequest3.xml' path='doc/member[@name="IWebProviderTokenRequest3.get_ApplicationProcessName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ApplicationProcessName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, HSTRING*, int>)(lpVtbl[7]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebProviderTokenRequest3.xml' path='doc/member[@name="IWebProviderTokenRequest3.CheckApplicationForCapabilityAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CheckApplicationForCapabilityAsync(HSTRING capabilityName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest3*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IWebProviderTokenRequest3*)Unsafe.AsPointer(ref this), capabilityName, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ApplicationPackageFamilyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ApplicationProcessName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT CheckApplicationForCapabilityAsync(HSTRING capabilityName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ApplicationPackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ApplicationProcessName;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> CheckApplicationForCapabilityAsync;
    }
}
