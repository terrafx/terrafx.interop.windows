// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISceneAnalysisEffectFrame.xml' path='doc/member[@name="ISceneAnalysisEffectFrame"]/*' />
[Guid("D8B10E4C-7FD9-42E1-85EB-6572C297C987")]
[NativeTypeName("struct ISceneAnalysisEffectFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISceneAnalysisEffectFrame : ISceneAnalysisEffectFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISceneAnalysisEffectFrame));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, Guid*, void**, int>)(lpVtbl[0]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, uint>)(lpVtbl[1]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, uint>)(lpVtbl[2]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, uint*, Guid**, int>)(lpVtbl[3]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, HSTRING*, int>)(lpVtbl[4]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, TrustLevel*, int>)(lpVtbl[5]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISceneAnalysisEffectFrame.xml' path='doc/member[@name="ISceneAnalysisEffectFrame.get_FrameControlValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FrameControlValues([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrameControlValues **")] ICapturedFrameControlValues** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, ICapturedFrameControlValues**, int>)(lpVtbl[6]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISceneAnalysisEffectFrame.xml' path='doc/member[@name="ISceneAnalysisEffectFrame.get_HighDynamicRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HighDynamicRange([NativeTypeName("ABI::Windows::Media::Core::IHighDynamicRangeOutput **")] IHighDynamicRangeOutput** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneAnalysisEffectFrame*, IHighDynamicRangeOutput**, int>)(lpVtbl[7]))((ISceneAnalysisEffectFrame*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FrameControlValues([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrameControlValues **")] ICapturedFrameControlValues** value);

        [VtblIndex(7)]
        HRESULT get_HighDynamicRange([NativeTypeName("ABI::Windows::Media::Core::IHighDynamicRangeOutput **")] IHighDynamicRangeOutput** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICapturedFrameControlValues **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICapturedFrameControlValues**, int> get_FrameControlValues;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IHighDynamicRangeOutput **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHighDynamicRangeOutput**, int> get_HighDynamicRange;
    }
}
