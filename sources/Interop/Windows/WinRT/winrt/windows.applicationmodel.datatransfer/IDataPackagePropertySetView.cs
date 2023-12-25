// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView"]/*' />
[Guid("B94CEC01-0C1A-4C57-BE55-75D01289735D")]
[NativeTypeName("struct IDataPackagePropertySetView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackagePropertySetView : IDataPackagePropertySetView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackagePropertySetView));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, Guid*, void**, int>)(lpVtbl[0]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, uint>)(lpVtbl[1]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, uint>)(lpVtbl[2]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, uint*, Guid**, int>)(lpVtbl[3]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, HSTRING*, int>)(lpVtbl[4]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, TrustLevel*, int>)(lpVtbl[5]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, HSTRING*, int>)(lpVtbl[6]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, HSTRING*, int>)(lpVtbl[7]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, IRandomAccessStreamReference**, int>)(lpVtbl[8]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView.get_FileTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, IVectorView<HSTRING>**, int>)(lpVtbl[9]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView.get_ApplicationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ApplicationName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, HSTRING*, int>)(lpVtbl[10]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackagePropertySetView.xml' path='doc/member[@name="IDataPackagePropertySetView.get_ApplicationListingUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ApplicationListingUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackagePropertySetView*, IUriRuntimeClass**, int>)(lpVtbl[11]))((IDataPackagePropertySetView*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(9)]
        HRESULT get_FileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(10)]
        HRESULT get_ApplicationName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_ApplicationListingUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_FileTypes;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ApplicationName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ApplicationListingUri;
    }
}
