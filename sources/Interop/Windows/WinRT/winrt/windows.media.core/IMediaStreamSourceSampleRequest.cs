// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSourceSampleRequest.xml' path='doc/member[@name="IMediaStreamSourceSampleRequest"]/*' />
[Guid("4DB341A9-3501-4D9B-83F9-8F235C822532")]
[NativeTypeName("struct IMediaStreamSourceSampleRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceSampleRequest : IMediaStreamSourceSampleRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaStreamSourceSampleRequest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, uint>)(lpVtbl[1]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, uint>)(lpVtbl[2]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSourceSampleRequest.xml' path='doc/member[@name="IMediaStreamSourceSampleRequest.get_StreamDescriptor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, IMediaStreamDescriptor**, int>)(lpVtbl[6]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSourceSampleRequest.xml' path='doc/member[@name="IMediaStreamSourceSampleRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceSampleRequestDeferral **")] IMediaStreamSourceSampleRequestDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, IMediaStreamSourceSampleRequestDeferral**, int>)(lpVtbl[7]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    /// <include file='IMediaStreamSourceSampleRequest.xml' path='doc/member[@name="IMediaStreamSourceSampleRequest.put_Sample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Sample([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSample *")] IMediaStreamSample* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, IMediaStreamSample*, int>)(lpVtbl[8]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSourceSampleRequest.xml' path='doc/member[@name="IMediaStreamSourceSampleRequest.get_Sample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Sample([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSample **")] IMediaStreamSample** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, IMediaStreamSample**, int>)(lpVtbl[9]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSourceSampleRequest.xml' path='doc/member[@name="IMediaStreamSourceSampleRequest.ReportSampleProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportSampleProgress([NativeTypeName("UINT32")] uint progress)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSampleRequest*, uint, int>)(lpVtbl[10]))((IMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), progress);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** value);

        [VtblIndex(7)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceSampleRequestDeferral **")] IMediaStreamSourceSampleRequestDeferral** deferral);

        [VtblIndex(8)]
        HRESULT put_Sample([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSample *")] IMediaStreamSample* value);

        [VtblIndex(9)]
        HRESULT get_Sample([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSample **")] IMediaStreamSample** value);

        [VtblIndex(10)]
        HRESULT ReportSampleProgress([NativeTypeName("UINT32")] uint progress);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor**, int> get_StreamDescriptor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSourceSampleRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSourceSampleRequestDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSample *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSample*, int> put_Sample;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSample **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSample**, int> get_Sample;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> ReportSampleProgress;
    }
}
