// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppServiceResponse.xml' path='doc/member[@name="IAppServiceResponse"]/*' />
[Guid("8D503CEC-9AA3-4E68-9559-9DE63E372CE4")]
[NativeTypeName("struct IAppServiceResponse : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppServiceResponse : IAppServiceResponse.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppServiceResponse));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceResponse*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, uint>)(lpVtbl[1]))((IAppServiceResponse*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, uint>)(lpVtbl[2]))((IAppServiceResponse*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, uint*, Guid**, int>)(lpVtbl[3]))((IAppServiceResponse*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, HSTRING*, int>)(lpVtbl[4]))((IAppServiceResponse*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, TrustLevel*, int>)(lpVtbl[5]))((IAppServiceResponse*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppServiceResponse.xml' path='doc/member[@name="IAppServiceResponse.get_Message"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Message([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, IPropertySet**, int>)(lpVtbl[6]))((IAppServiceResponse*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceResponse.xml' path='doc/member[@name="IAppServiceResponse.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::AppService::AppServiceResponseStatus *")] AppServiceResponseStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceResponse*, AppServiceResponseStatus*, int>)(lpVtbl[7]))((IAppServiceResponse*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Message([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::AppService::AppServiceResponseStatus *")] AppServiceResponseStatus* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_Message;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::AppService::AppServiceResponseStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppServiceResponseStatus*, int> get_Status;
    }
}
