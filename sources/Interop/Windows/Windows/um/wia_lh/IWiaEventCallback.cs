// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaEventCallback.xml' path='doc/member[@name="IWiaEventCallback"]/*' />
[Guid("AE6287B0-0084-11D2-973B-00A0C9068F2E")]
[NativeTypeName("struct IWiaEventCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaEventCallback : IWiaEventCallback.Interface, INativeGuid
{
    /// <include file='IWiaEventCallback.xml' path='doc/member[@name="IWiaEventCallback.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaEventCallback);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaEventCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWiaEventCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaEventCallback*, uint>)(lpVtbl[1]))((IWiaEventCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaEventCallback*, uint>)(lpVtbl[2]))((IWiaEventCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaEventCallback.xml' path='doc/member[@name="IWiaEventCallback.ImageEventCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ImageEventCallback([NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("BSTR")] char* bstrEventDescription, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("BSTR")] char* bstrDeviceDescription, [NativeTypeName("DWORD")] uint dwDeviceType, [NativeTypeName("BSTR")] char* bstrFullItemName, [NativeTypeName("ULONG *")] uint* pulEventType, [NativeTypeName("ULONG")] uint ulReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaEventCallback*, Guid*, char*, char*, char*, uint, char*, uint*, uint, int>)(lpVtbl[3]))((IWiaEventCallback*)Unsafe.AsPointer(ref this), pEventGUID, bstrEventDescription, bstrDeviceID, bstrDeviceDescription, dwDeviceType, bstrFullItemName, pulEventType, ulReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ImageEventCallback([NativeTypeName("const GUID *")] Guid* pEventGUID, [NativeTypeName("BSTR")] char* bstrEventDescription, [NativeTypeName("BSTR")] char* bstrDeviceID, [NativeTypeName("BSTR")] char* bstrDeviceDescription, [NativeTypeName("DWORD")] uint dwDeviceType, [NativeTypeName("BSTR")] char* bstrFullItemName, [NativeTypeName("ULONG *")] uint* pulEventType, [NativeTypeName("ULONG")] uint ulReserved);
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

        [NativeTypeName("HRESULT (const GUID *, BSTR, BSTR, BSTR, DWORD, BSTR, ULONG *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char*, char*, char*, uint, char*, uint*, uint, int> ImageEventCallback;
    }
}
