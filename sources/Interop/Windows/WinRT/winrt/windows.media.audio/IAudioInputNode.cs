// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioInputNode.xml' path='doc/member[@name="IAudioInputNode"]/*' />
[Guid("D148005C-8428-4784-B7FD-A99D468C5D20")]
[NativeTypeName("struct IAudioInputNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioInputNode : IAudioInputNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioInputNode);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, Guid*, void**, int>)(lpVtbl[0]))((IAudioInputNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, uint>)(lpVtbl[1]))((IAudioInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, uint>)(lpVtbl[2]))((IAudioInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioInputNode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, HSTRING*, int>)(lpVtbl[4]))((IAudioInputNode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, TrustLevel*, int>)(lpVtbl[5]))((IAudioInputNode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioInputNode.xml' path='doc/member[@name="IAudioInputNode.get_OutgoingConnections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutgoingConnections([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CAudio__CAudioGraphConnection_t **")] IVectorView<Pointer<IAudioGraphConnection>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, IVectorView<Pointer<IAudioGraphConnection>>**, int>)(lpVtbl[6]))((IAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioInputNode.xml' path='doc/member[@name="IAudioInputNode.AddOutgoingConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddOutgoingConnection([NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode* destination)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, IAudioNode*, int>)(lpVtbl[7]))((IAudioInputNode*)Unsafe.AsPointer(ref this), destination);
    }

    /// <include file='IAudioInputNode.xml' path='doc/member[@name="IAudioInputNode.AddOutgoingConnectionWithGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddOutgoingConnectionWithGain([NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode* destination, double gain)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, IAudioNode*, double, int>)(lpVtbl[8]))((IAudioInputNode*)Unsafe.AsPointer(ref this), destination, gain);
    }

    /// <include file='IAudioInputNode.xml' path='doc/member[@name="IAudioInputNode.RemoveOutgoingConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveOutgoingConnection([NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode* destination)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioInputNode*, IAudioNode*, int>)(lpVtbl[9]))((IAudioInputNode*)Unsafe.AsPointer(ref this), destination);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutgoingConnections([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CAudio__CAudioGraphConnection_t **")] IVectorView<Pointer<IAudioGraphConnection>>** value);

        [VtblIndex(7)]
        HRESULT AddOutgoingConnection([NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode* destination);

        [VtblIndex(8)]
        HRESULT AddOutgoingConnectionWithGain([NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode* destination, double gain);

        [VtblIndex(9)]
        HRESULT RemoveOutgoingConnection([NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode* destination);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CAudio__CAudioGraphConnection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAudioGraphConnection>>**, int> get_OutgoingConnections;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNode*, int> AddOutgoingConnection;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNode *, DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNode*, double, int> AddOutgoingConnectionWithGain;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNode*, int> RemoveOutgoingConnection;
    }
}
