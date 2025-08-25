// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage"]/*' />
[Guid("6C6D948D-80B5-48F8-B0B1-E04E430F44E5")]
[NativeTypeName("struct IEmailMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMessage : IEmailMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMessage);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, uint>)(lpVtbl[1]))((IEmailMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, uint>)(lpVtbl[2]))((IEmailMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, HSTRING*, int>)(lpVtbl[4]))((IEmailMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.get_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, HSTRING*, int>)(lpVtbl[6]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.put_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Subject(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, HSTRING, int>)(lpVtbl[7]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.get_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, HSTRING*, int>)(lpVtbl[8]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.put_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Body(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, HSTRING, int>)(lpVtbl[9]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.get_To"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_To([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, IVector<Pointer<IEmailRecipient>>**, int>)(lpVtbl[10]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.get_CC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CC([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, IVector<Pointer<IEmailRecipient>>**, int>)(lpVtbl[11]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.get_Bcc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Bcc([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, IVector<Pointer<IEmailRecipient>>**, int>)(lpVtbl[12]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMessage.xml' path='doc/member[@name="IEmailMessage.get_Attachments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Attachments([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailAttachment_t **")] IVector<Pointer<IEmailAttachment>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMessage*, IVector<Pointer<IEmailAttachment>>**, int>)(lpVtbl[13]))((IEmailMessage*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Subject(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Body(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_To([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value);

        [VtblIndex(11)]
        HRESULT get_CC([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value);

        [VtblIndex(12)]
        HRESULT get_Bcc([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **")] IVector<Pointer<IEmailRecipient>>** value);

        [VtblIndex(13)]
        HRESULT get_Attachments([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailAttachment_t **")] IVector<Pointer<IEmailAttachment>>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Subject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Body;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IEmailRecipient>>**, int> get_To;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IEmailRecipient>>**, int> get_CC;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IEmailRecipient>>**, int> get_Bcc;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CEmail__CEmailAttachment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IEmailAttachment>>**, int> get_Attachments;
    }
}
