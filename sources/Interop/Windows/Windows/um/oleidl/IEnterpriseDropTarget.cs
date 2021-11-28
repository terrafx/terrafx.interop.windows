// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("390E3878-FD55-4E18-819D-4682081C0CFD")]
[NativeTypeName("struct IEnterpriseDropTarget : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IEnterpriseDropTarget : IEnterpriseDropTarget.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnterpriseDropTarget*, Guid*, void**, int>)(lpVtbl[0]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnterpriseDropTarget*, uint>)(lpVtbl[1]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnterpriseDropTarget*, uint>)(lpVtbl[2]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDropSourceEnterpriseId([NativeTypeName("LPCWSTR")] ushort* identity)
    {
        return ((delegate* unmanaged<IEnterpriseDropTarget*, ushort*, int>)(lpVtbl[3]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), identity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsEvaluatingEdpPolicy(BOOL* value)
    {
        return ((delegate* unmanaged<IEnterpriseDropTarget*, BOOL*, int>)(lpVtbl[4]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDropSourceEnterpriseId([NativeTypeName("LPCWSTR")] ushort* identity);

        [VtblIndex(4)]
        HRESULT IsEvaluatingEdpPolicy(BOOL* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDropSourceEnterpriseId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsEvaluatingEdpPolicy;
    }
}
