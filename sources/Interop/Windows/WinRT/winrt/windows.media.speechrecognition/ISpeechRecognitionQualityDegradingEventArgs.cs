// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognitionQualityDegradingEventArgs.xml' path='doc/member[@name="ISpeechRecognitionQualityDegradingEventArgs"]/*' />
[Guid("4FE24105-8C3A-4C7E-8D0A-5BD4F5B14AD8")]
[NativeTypeName("struct ISpeechRecognitionQualityDegradingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionQualityDegradingEventArgs : ISpeechRecognitionQualityDegradingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognitionQualityDegradingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, uint>)(lpVtbl[1]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, uint>)(lpVtbl[2]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognitionQualityDegradingEventArgs.xml' path='doc/member[@name="ISpeechRecognitionQualityDegradingEventArgs.get_Problem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Problem([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionAudioProblem *")] SpeechRecognitionAudioProblem* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionQualityDegradingEventArgs*, SpeechRecognitionAudioProblem*, int>)(lpVtbl[6]))((ISpeechRecognitionQualityDegradingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Problem([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionAudioProblem *")] SpeechRecognitionAudioProblem* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionAudioProblem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognitionAudioProblem*, int> get_Problem;
    }
}
