// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpotLight3.xml' path='doc/member[@name="ISpotLight3"]/*' />
[Guid("E4D03EEA-131F-480E-859E-B82705B74360")]
[NativeTypeName("struct ISpotLight3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpotLight3 : ISpotLight3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpotLight3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, Guid*, void**, int>)(lpVtbl[0]))((ISpotLight3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, uint>)(lpVtbl[1]))((ISpotLight3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, uint>)(lpVtbl[2]))((ISpotLight3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, uint*, Guid**, int>)(lpVtbl[3]))((ISpotLight3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, HSTRING*, int>)(lpVtbl[4]))((ISpotLight3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, TrustLevel*, int>)(lpVtbl[5]))((ISpotLight3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpotLight3.xml' path='doc/member[@name="ISpotLight3.get_MinAttenuationCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinAttenuationCutoff(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, float*, int>)(lpVtbl[6]))((ISpotLight3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpotLight3.xml' path='doc/member[@name="ISpotLight3.put_MinAttenuationCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MinAttenuationCutoff(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, float, int>)(lpVtbl[7]))((ISpotLight3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpotLight3.xml' path='doc/member[@name="ISpotLight3.get_MaxAttenuationCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxAttenuationCutoff(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, float*, int>)(lpVtbl[8]))((ISpotLight3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpotLight3.xml' path='doc/member[@name="ISpotLight3.put_MaxAttenuationCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxAttenuationCutoff(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight3*, float, int>)(lpVtbl[9]))((ISpotLight3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MinAttenuationCutoff(float* value);

        [VtblIndex(7)]
        HRESULT put_MinAttenuationCutoff(float value);

        [VtblIndex(8)]
        HRESULT get_MaxAttenuationCutoff(float* value);

        [VtblIndex(9)]
        HRESULT put_MaxAttenuationCutoff(float value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MinAttenuationCutoff;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_MinAttenuationCutoff;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxAttenuationCutoff;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_MaxAttenuationCutoff;
    }
}
