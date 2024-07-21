// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass"]/*' />
[Guid("9E365E57-48B2-4160-956F-C7385120BBFC")]
[NativeTypeName("struct IUriRuntimeClass : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUriRuntimeClass : IUriRuntimeClass.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriRuntimeClass));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, Guid*, void**, int>)(lpVtbl[0]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, uint>)(lpVtbl[1]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, uint>)(lpVtbl[2]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, uint*, Guid**, int>)(lpVtbl[3]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[4]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, TrustLevel*, int>)(lpVtbl[5]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_AbsoluteUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AbsoluteUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[6]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_DisplayUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[7]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Domain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Domain(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[8]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Extension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Extension(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[9]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Fragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Fragment(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[10]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Host"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Host(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[11]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Password"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Password(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[12]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Path(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[13]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Query"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Query(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[14]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_QueryParsed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_QueryParsed([NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")] IWwwFormUrlDecoderRuntimeClass** ppWwwFormUrlDecoder)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, IWwwFormUrlDecoderRuntimeClass**, int>)(lpVtbl[15]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), ppWwwFormUrlDecoder);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_RawUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RawUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[16]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_SchemeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SchemeName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[17]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING*, int>)(lpVtbl[18]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Port"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Port([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, int*, int>)(lpVtbl[19]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.get_Suspicious"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Suspicious([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, byte*, int>)(lpVtbl[20]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.Equals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Equals([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* pUri, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, IUriRuntimeClass*, byte*, int>)(lpVtbl[21]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), pUri, value);
    }

    /// <include file='IUriRuntimeClass.xml' path='doc/member[@name="IUriRuntimeClass.CombineUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CombineUri(HSTRING relativeUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** instance)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriRuntimeClass*, HSTRING, IUriRuntimeClass**, int>)(lpVtbl[22]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), relativeUri, instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AbsoluteUri(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayUri(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Domain(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Extension(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Fragment(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Host(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Password(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Path(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Query(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_QueryParsed([NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")] IWwwFormUrlDecoderRuntimeClass** ppWwwFormUrlDecoder);

        [VtblIndex(16)]
        HRESULT get_RawUri(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_SchemeName(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_Port([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT get_Suspicious([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT Equals([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* pUri, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT CombineUri(HSTRING relativeUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** instance);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AbsoluteUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Domain;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Extension;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Fragment;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Host;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Password;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Path;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Query;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWwwFormUrlDecoderRuntimeClass**, int> get_QueryParsed;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RawUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SchemeName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Port;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Suspicious;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, boolean *) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, byte*, int> Equals;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUriRuntimeClass**, int> CombineUri;
    }
}
