// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallVideoCapabilitiesManagerStatics.xml' path='doc/member[@name="IPhoneCallVideoCapabilitiesManagerStatics"]/*' />
[Guid("F3C64B56-F00B-4A1C-A0C6-EE1910749CE7")]
[NativeTypeName("struct IPhoneCallVideoCapabilitiesManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallVideoCapabilitiesManagerStatics : IPhoneCallVideoCapabilitiesManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallVideoCapabilitiesManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, uint>)(lpVtbl[1]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, uint>)(lpVtbl[2]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallVideoCapabilitiesManagerStatics.xml' path='doc/member[@name="IPhoneCallVideoCapabilitiesManagerStatics.GetCapabilitiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCapabilitiesAsync(HSTRING phoneNumber, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallVideoCapabilities_t **")] IAsyncOperation<Pointer<IPhoneCallVideoCapabilities>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallVideoCapabilitiesManagerStatics*, HSTRING, IAsyncOperation<Pointer<IPhoneCallVideoCapabilities>>**, int>)(lpVtbl[6]))((IPhoneCallVideoCapabilitiesManagerStatics*)Unsafe.AsPointer(ref this), phoneNumber, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCapabilitiesAsync(HSTRING phoneNumber, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallVideoCapabilities_t **")] IAsyncOperation<Pointer<IPhoneCallVideoCapabilities>>** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallVideoCapabilities_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IPhoneCallVideoCapabilities>>**, int> GetCapabilitiesAsync;
    }
}
