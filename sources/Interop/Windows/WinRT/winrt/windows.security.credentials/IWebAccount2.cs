// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccount2.xml' path='doc/member[@name="IWebAccount2"]/*' />
[Guid("7B56D6F8-990B-4EB5-94A7-5621F3A8B824")]
[NativeTypeName("struct IWebAccount2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccount2 : IWebAccount2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccount2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccount2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, uint>)(lpVtbl[1]))((IWebAccount2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, uint>)(lpVtbl[2]))((IWebAccount2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccount2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, HSTRING*, int>)(lpVtbl[4]))((IWebAccount2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccount2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccount2.xml' path='doc/member[@name="IWebAccount2.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, HSTRING*, int>)(lpVtbl[6]))((IWebAccount2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAccount2.xml' path='doc/member[@name="IWebAccount2.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t **")] IMapView<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, IMapView<HSTRING, HSTRING>**, int>)(lpVtbl[7]))((IWebAccount2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAccount2.xml' path='doc/member[@name="IWebAccount2.GetPictureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPictureAsync([NativeTypeName("ABI::Windows::Security::Credentials::WebAccountPictureSize")] WebAccountPictureSize desizedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, WebAccountPictureSize, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IWebAccount2*)Unsafe.AsPointer(ref this), desizedSize, asyncInfo);
    }

    /// <include file='IWebAccount2.xml' path='doc/member[@name="IWebAccount2.SignOutAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SignOutAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, IAsyncAction**, int>)(lpVtbl[9]))((IWebAccount2*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IWebAccount2.xml' path='doc/member[@name="IWebAccount2.SignOutWithClientIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SignOutWithClientIdAsync(HSTRING clientId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccount2*, HSTRING, IAsyncAction**, int>)(lpVtbl[10]))((IWebAccount2*)Unsafe.AsPointer(ref this), clientId, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t **")] IMapView<HSTRING, HSTRING>** value);

        [VtblIndex(8)]
        HRESULT GetPictureAsync([NativeTypeName("ABI::Windows::Security::Credentials::WebAccountPictureSize")] WebAccountPictureSize desizedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(9)]
        HRESULT SignOutAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(10)]
        HRESULT SignOutWithClientIdAsync(HSTRING clientId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, HSTRING>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::WebAccountPictureSize, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAccountPictureSize, IAsyncOperation<IntPtr>**, int> GetPictureAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SignOutAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> SignOutWithClientIdAsync;
    }
}
