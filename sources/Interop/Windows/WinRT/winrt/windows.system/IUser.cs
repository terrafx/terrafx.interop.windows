// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUser.xml' path='doc/member[@name="IUser"]/*' />
[Guid("DF9A26C6-E746-4BCD-B5D4-120103C4209B")]
[NativeTypeName("struct IUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUser : IUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUser);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, Guid*, void**, int>)(lpVtbl[0]))((IUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, uint>)(lpVtbl[1]))((IUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, uint>)(lpVtbl[2]))((IUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, uint*, Guid**, int>)(lpVtbl[3]))((IUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, HSTRING*, int>)(lpVtbl[4]))((IUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, TrustLevel*, int>)(lpVtbl[5]))((IUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUser.xml' path='doc/member[@name="IUser.get_NonRoamableId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NonRoamableId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, HSTRING*, int>)(lpVtbl[6]))((IUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUser.xml' path='doc/member[@name="IUser.get_AuthenticationStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AuthenticationStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, UserAuthenticationStatus*, int>)(lpVtbl[7]))((IUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUser.xml' path='doc/member[@name="IUser.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::System::UserType *")] UserType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, UserType*, int>)(lpVtbl[8]))((IUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUser.xml' path='doc/member[@name="IUser.GetPropertyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyAsync(HSTRING value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")] IAsyncOperation<Pointer<IInspectable>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, HSTRING, IAsyncOperation<Pointer<IInspectable>>**, int>)(lpVtbl[9]))((IUser*)Unsafe.AsPointer(ref this), value, operation);
    }

    /// <include file='IUser.xml' path='doc/member[@name="IUser.GetPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *")] IVectorView<HSTRING>* values, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **")] IAsyncOperation<Pointer<IPropertySet>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, IVectorView<HSTRING>*, IAsyncOperation<Pointer<IPropertySet>>**, int>)(lpVtbl[10]))((IUser*)Unsafe.AsPointer(ref this), values, operation);
    }

    /// <include file='IUser.xml' path='doc/member[@name="IUser.GetPictureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPictureAsync([NativeTypeName("ABI::Windows::System::UserPictureSize")] UserPictureSize desiredSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUser*, UserPictureSize, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[11]))((IUser*)Unsafe.AsPointer(ref this), desiredSize, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NonRoamableId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AuthenticationStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value);

        [VtblIndex(8)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::System::UserType *")] UserType* value);

        [VtblIndex(9)]
        HRESULT GetPropertyAsync(HSTRING value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")] IAsyncOperation<Pointer<IInspectable>>** operation);

        [VtblIndex(10)]
        HRESULT GetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *")] IVectorView<HSTRING>* values, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **")] IAsyncOperation<Pointer<IPropertySet>>** operation);

        [VtblIndex(11)]
        HRESULT GetPictureAsync([NativeTypeName("ABI::Windows::System::UserPictureSize")] UserPictureSize desiredSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NonRoamableId;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserAuthenticationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserAuthenticationStatus*, int> get_AuthenticationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserType*, int> get_Type;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IInspectable>>**, int> GetPropertyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>*, IAsyncOperation<Pointer<IPropertySet>>**, int> GetPropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserPictureSize, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserPictureSize, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int> GetPictureAsync;
    }
}
