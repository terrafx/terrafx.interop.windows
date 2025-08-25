// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrepareTranscodeResult.xml' path='doc/member[@name="IPrepareTranscodeResult"]/*' />
[Guid("05F25DCE-994F-4A34-9D68-97CCCE1730D6")]
[NativeTypeName("struct IPrepareTranscodeResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrepareTranscodeResult : IPrepareTranscodeResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrepareTranscodeResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, Guid*, void**, int>)(lpVtbl[0]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, uint>)(lpVtbl[1]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, uint>)(lpVtbl[2]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, uint*, Guid**, int>)(lpVtbl[3]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, HSTRING*, int>)(lpVtbl[4]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, TrustLevel*, int>)(lpVtbl[5]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrepareTranscodeResult.xml' path='doc/member[@name="IPrepareTranscodeResult.get_CanTranscode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanTranscode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, byte*, int>)(lpVtbl[6]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrepareTranscodeResult.xml' path='doc/member[@name="IPrepareTranscodeResult.get_FailureReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FailureReason([NativeTypeName("ABI::Windows::Media::Transcoding::TranscodeFailureReason *")] TranscodeFailureReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, TranscodeFailureReason*, int>)(lpVtbl[7]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrepareTranscodeResult.xml' path='doc/member[@name="IPrepareTranscodeResult.TranscodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TranscodeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncActionWithProgress_1_double_t **")] IAsyncActionWithProgress<double>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrepareTranscodeResult*, IAsyncActionWithProgress<double>**, int>)(lpVtbl[8]))((IPrepareTranscodeResult*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanTranscode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_FailureReason([NativeTypeName("ABI::Windows::Media::Transcoding::TranscodeFailureReason *")] TranscodeFailureReason* value);

        [VtblIndex(8)]
        HRESULT TranscodeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncActionWithProgress_1_double_t **")] IAsyncActionWithProgress<double>** operation);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanTranscode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Transcoding::TranscodeFailureReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TranscodeFailureReason*, int> get_FailureReason;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncActionWithProgress_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncActionWithProgress<double>**, int> TranscodeAsync;
    }
}
