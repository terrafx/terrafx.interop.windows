// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSourceStartingRequest.xml' path='doc/member[@name="IMediaStreamSourceStartingRequest"]/*' />
[Guid("2A9093E4-35C4-4B1B-A791-0D99DB56DD1D")]
[NativeTypeName("struct IMediaStreamSourceStartingRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceStartingRequest : IMediaStreamSourceStartingRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaStreamSourceStartingRequest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, uint>)(lpVtbl[1]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, uint>)(lpVtbl[2]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSourceStartingRequest.xml' path='doc/member[@name="IMediaStreamSourceStartingRequest.get_StartPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StartPosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSourceStartingRequest.xml' path='doc/member[@name="IMediaStreamSourceStartingRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceStartingRequestDeferral **")] IMediaStreamSourceStartingRequestDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, IMediaStreamSourceStartingRequestDeferral**, int>)(lpVtbl[7]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    /// <include file='IMediaStreamSourceStartingRequest.xml' path='doc/member[@name="IMediaStreamSourceStartingRequest.SetActualStartPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActualStartPosition([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan position)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceStartingRequest*, TimeSpan, int>)(lpVtbl[8]))((IMediaStreamSourceStartingRequest*)Unsafe.AsPointer(ref this), position);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StartPosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceStartingRequestDeferral **")] IMediaStreamSourceStartingRequestDeferral** deferral);

        [VtblIndex(8)]
        HRESULT SetActualStartPosition([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan position);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_StartPosition;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSourceStartingRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSourceStartingRequestDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> SetActualStartPosition;
    }
}
