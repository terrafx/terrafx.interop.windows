// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFaceDetectionEffectDefinition.xml' path='doc/member[@name="IFaceDetectionEffectDefinition"]/*' />
[Guid("43DCA081-B848-4F33-B702-1FD2624FB016")]
[NativeTypeName("struct IFaceDetectionEffectDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFaceDetectionEffectDefinition : IFaceDetectionEffectDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFaceDetectionEffectDefinition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, uint>)(lpVtbl[1]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, uint>)(lpVtbl[2]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, uint*, Guid**, int>)(lpVtbl[3]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, HSTRING*, int>)(lpVtbl[4]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, TrustLevel*, int>)(lpVtbl[5]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFaceDetectionEffectDefinition.xml' path='doc/member[@name="IFaceDetectionEffectDefinition.put_DetectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_DetectionMode([NativeTypeName("ABI::Windows::Media::Core::FaceDetectionMode")] FaceDetectionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, FaceDetectionMode, int>)(lpVtbl[6]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFaceDetectionEffectDefinition.xml' path='doc/member[@name="IFaceDetectionEffectDefinition.get_DetectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DetectionMode([NativeTypeName("ABI::Windows::Media::Core::FaceDetectionMode *")] FaceDetectionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, FaceDetectionMode*, int>)(lpVtbl[7]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFaceDetectionEffectDefinition.xml' path='doc/member[@name="IFaceDetectionEffectDefinition.put_SynchronousDetectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SynchronousDetectionEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, byte, int>)(lpVtbl[8]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFaceDetectionEffectDefinition.xml' path='doc/member[@name="IFaceDetectionEffectDefinition.get_SynchronousDetectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SynchronousDetectionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceDetectionEffectDefinition*, byte*, int>)(lpVtbl[9]))((IFaceDetectionEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_DetectionMode([NativeTypeName("ABI::Windows::Media::Core::FaceDetectionMode")] FaceDetectionMode value);

        [VtblIndex(7)]
        HRESULT get_DetectionMode([NativeTypeName("ABI::Windows::Media::Core::FaceDetectionMode *")] FaceDetectionMode* value);

        [VtblIndex(8)]
        HRESULT put_SynchronousDetectionEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_SynchronousDetectionEnabled([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::FaceDetectionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FaceDetectionMode, int> put_DetectionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::FaceDetectionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FaceDetectionMode*, int> get_DetectionMode;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SynchronousDetectionEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SynchronousDetectionEnabled;
    }
}
