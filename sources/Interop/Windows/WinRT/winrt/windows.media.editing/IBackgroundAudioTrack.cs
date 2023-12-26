// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack"]/*' />
[Guid("4B91B3BD-9E21-4266-A9C2-67DD011A2357")]
[NativeTypeName("struct IBackgroundAudioTrack : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundAudioTrack : IBackgroundAudioTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundAudioTrack));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, uint>)(lpVtbl[1]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, uint>)(lpVtbl[2]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_TrimTimeFromStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan*, int>)(lpVtbl[6]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.put_TrimTimeFromStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan, int>)(lpVtbl[7]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_TrimTimeFromEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan*, int>)(lpVtbl[8]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.put_TrimTimeFromEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan, int>)(lpVtbl[9]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_OriginalDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OriginalDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan*, int>)(lpVtbl[10]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_TrimmedDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_TrimmedDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan*, int>)(lpVtbl[11]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_UserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UserData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[12]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.put_Delay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan, int>)(lpVtbl[13]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_Delay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, TimeSpan*, int>)(lpVtbl[14]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.put_Volume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Volume(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, double, int>)(lpVtbl[15]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_Volume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Volume(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, double*, int>)(lpVtbl[16]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IBackgroundAudioTrack **")] IBackgroundAudioTrack** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, IBackgroundAudioTrack**, int>)(lpVtbl[17]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.GetAudioEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAudioEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, IAudioEncodingProperties**, int>)(lpVtbl[18]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundAudioTrack.xml' path='doc/member[@name="IBackgroundAudioTrack.get_AudioEffectDefinitions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_AudioEffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrack*, IVector<IntPtr>**, int>)(lpVtbl[19]))((IBackgroundAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT get_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_OriginalDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(11)]
        HRESULT get_TrimmedDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(12)]
        HRESULT get_UserData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);

        [VtblIndex(13)]
        HRESULT put_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(14)]
        HRESULT get_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(15)]
        HRESULT put_Volume(double value);

        [VtblIndex(16)]
        HRESULT get_Volume(double* value);

        [VtblIndex(17)]
        HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IBackgroundAudioTrack **")] IBackgroundAudioTrack** value);

        [VtblIndex(18)]
        HRESULT GetAudioEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(19)]
        HRESULT get_AudioEffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **")] IVector<IntPtr>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimTimeFromStart;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TrimTimeFromStart;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimTimeFromEnd;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TrimTimeFromEnd;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_OriginalDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimmedDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_UserData;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Delay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Delay;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Volume;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Volume;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Editing::IBackgroundAudioTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundAudioTrack**, int> Clone;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties**, int> GetAudioEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_AudioEffectDefinitions;
    }
}
