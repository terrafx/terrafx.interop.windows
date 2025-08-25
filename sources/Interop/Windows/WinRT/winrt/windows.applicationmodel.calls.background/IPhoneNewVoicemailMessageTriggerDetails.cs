// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneNewVoicemailMessageTriggerDetails.xml' path='doc/member[@name="IPhoneNewVoicemailMessageTriggerDetails"]/*' />
[Guid("13A8C01B-B831-48D3-8BA9-8D22A6580DCF")]
[NativeTypeName("struct IPhoneNewVoicemailMessageTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneNewVoicemailMessageTriggerDetails : IPhoneNewVoicemailMessageTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneNewVoicemailMessageTriggerDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, uint>)(lpVtbl[1]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, uint>)(lpVtbl[2]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneNewVoicemailMessageTriggerDetails.xml' path='doc/member[@name="IPhoneNewVoicemailMessageTriggerDetails.get_LineId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LineId(Guid* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, Guid*, int>)(lpVtbl[6]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneNewVoicemailMessageTriggerDetails.xml' path='doc/member[@name="IPhoneNewVoicemailMessageTriggerDetails.get_VoicemailCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VoicemailCount([NativeTypeName("INT32 *")] int* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, int*, int>)(lpVtbl[7]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneNewVoicemailMessageTriggerDetails.xml' path='doc/member[@name="IPhoneNewVoicemailMessageTriggerDetails.get_OperatorMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OperatorMessage(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneNewVoicemailMessageTriggerDetails*, HSTRING*, int>)(lpVtbl[8]))((IPhoneNewVoicemailMessageTriggerDetails*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LineId(Guid* result);

        [VtblIndex(7)]
        HRESULT get_VoicemailCount([NativeTypeName("INT32 *")] int* result);

        [VtblIndex(8)]
        HRESULT get_OperatorMessage(HSTRING* result);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LineId;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_VoicemailCount;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_OperatorMessage;
    }
}
