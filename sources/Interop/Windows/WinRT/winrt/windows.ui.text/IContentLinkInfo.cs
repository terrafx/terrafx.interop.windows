// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo"]/*' />
[Guid("1ED52525-1C5F-48CB-B335-78B50A2EE642")]
[NativeTypeName("struct IContentLinkInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentLinkInfo : IContentLinkInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentLinkInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, Guid*, void**, int>)(lpVtbl[0]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, uint>)(lpVtbl[1]))((IContentLinkInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, uint>)(lpVtbl[2]))((IContentLinkInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING*, int>)(lpVtbl[4]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, TrustLevel*, int>)(lpVtbl[5]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, uint*, int>)(lpVtbl[6]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, uint, int>)(lpVtbl[7]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.get_DisplayText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING*, int>)(lpVtbl[8]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.put_DisplayText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING, int>)(lpVtbl[9]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.get_SecondaryText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SecondaryText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING*, int>)(lpVtbl[10]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.put_SecondaryText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SecondaryText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING, int>)(lpVtbl[11]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.get_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, IUriRuntimeClass**, int>)(lpVtbl[12]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.put_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, IUriRuntimeClass*, int>)(lpVtbl[13]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.get_LinkContentKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LinkContentKind(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING*, int>)(lpVtbl[14]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContentLinkInfo.xml' path='doc/member[@name="IContentLinkInfo.put_LinkContentKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_LinkContentKind(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentLinkInfo*, HSTRING, int>)(lpVtbl[15]))((IContentLinkInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_Id([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_DisplayText(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayText(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SecondaryText(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_SecondaryText(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(13)]
        HRESULT put_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(14)]
        HRESULT get_LinkContentKind(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_LinkContentKind(HSTRING value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Id;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecondaryText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SecondaryText;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Uri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_Uri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LinkContentKind;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LinkContentKind;
    }
}
