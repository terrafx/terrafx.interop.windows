// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode"]/*' />
[Guid("15389D7F-DBD8-4819-BF03-668E9357CD6D")]
[NativeTypeName("struct IAudioNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNode : IAudioNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, uint>)(lpVtbl[1]))((IAudioNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, uint>)(lpVtbl[2]))((IAudioNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, HSTRING*, int>)(lpVtbl[4]))((IAudioNode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.get_EffectDefinitions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IAudioNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.put_OutgoingGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OutgoingGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, double, int>)(lpVtbl[7]))((IAudioNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.get_OutgoingGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutgoingGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, double*, int>)(lpVtbl[8]))((IAudioNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.get_EncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_EncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, IAudioEncodingProperties**, int>)(lpVtbl[9]))((IAudioNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.get_ConsumeInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ConsumeInput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, byte*, int>)(lpVtbl[10]))((IAudioNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.put_ConsumeInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ConsumeInput([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, byte, int>)(lpVtbl[11]))((IAudioNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, int>)(lpVtbl[12]))((IAudioNode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, int>)(lpVtbl[13]))((IAudioNode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, int>)(lpVtbl[14]))((IAudioNode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.DisableEffectsByDefinition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DisableEffectsByDefinition([NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")] IAudioEffectDefinition* definition)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, IAudioEffectDefinition*, int>)(lpVtbl[15]))((IAudioNode*)Unsafe.AsPointer(ref this), definition);
    }

    /// <include file='IAudioNode.xml' path='doc/member[@name="IAudioNode.EnableEffectsByDefinition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnableEffectsByDefinition([NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")] IAudioEffectDefinition* definition)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNode*, IAudioEffectDefinition*, int>)(lpVtbl[16]))((IAudioNode*)Unsafe.AsPointer(ref this), definition);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **")] IVector<IntPtr>** value);

        [VtblIndex(7)]
        HRESULT put_OutgoingGain(double value);

        [VtblIndex(8)]
        HRESULT get_OutgoingGain(double* value);

        [VtblIndex(9)]
        HRESULT get_EncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(10)]
        HRESULT get_ConsumeInput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_ConsumeInput([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT Start();

        [VtblIndex(13)]
        HRESULT Stop();

        [VtblIndex(14)]
        HRESULT Reset();

        [VtblIndex(15)]
        HRESULT DisableEffectsByDefinition([NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")] IAudioEffectDefinition* definition);

        [VtblIndex(16)]
        HRESULT EnableEffectsByDefinition([NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition *")] IAudioEffectDefinition* definition);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_EffectDefinitions;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_OutgoingGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_OutgoingGain;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties**, int> get_EncodingProperties;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ConsumeInput;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ConsumeInput;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::IAudioEffectDefinition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEffectDefinition*, int> DisableEffectsByDefinition;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::IAudioEffectDefinition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEffectDefinition*, int> EnableEffectsByDefinition;
    }
}
