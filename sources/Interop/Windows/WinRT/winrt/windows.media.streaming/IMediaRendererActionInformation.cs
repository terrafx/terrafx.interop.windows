// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation"]/*' />
[Guid("66FBBFEE-5AB0-4A4F-8D15-E5056B26BEDA")]
[NativeTypeName("struct IMediaRendererActionInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaRendererActionInformation : IMediaRendererActionInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaRendererActionInformation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, Guid*, void**, int>)(lpVtbl[0]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, uint>)(lpVtbl[1]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, uint>)(lpVtbl[2]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, HSTRING*, int>)(lpVtbl[4]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, TrustLevel*, int>)(lpVtbl[5]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsMuteAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsMuteAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[6]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsPauseAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsPauseAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[7]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsPlayAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsPlayAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[8]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsSeekAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsSeekAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[9]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsSetNextSourceAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsSetNextSourceAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[10]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsStopAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsStopAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[11]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_IsVolumeAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsVolumeAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, byte*, int>)(lpVtbl[12]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRendererActionInformation.xml' path='doc/member[@name="IMediaRendererActionInformation.get_PlaySpeeds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PlaySpeeds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CPlaySpeed_t **")] IVector<PlaySpeed>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererActionInformation*, IVector<PlaySpeed>**, int>)(lpVtbl[13]))((IMediaRendererActionInformation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsMuteAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsPauseAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsPlayAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsSeekAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsSetNextSourceAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsStopAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsVolumeAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_PlaySpeeds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CPlaySpeed_t **")] IVector<PlaySpeed>** value);
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

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMuteAvailable;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPauseAvailable;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPlayAvailable;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSeekAvailable;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSetNextSourceAvailable;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsStopAvailable;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVolumeAvailable;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CPlaySpeed_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<PlaySpeed>**, int> get_PlaySpeeds;
    }
}
