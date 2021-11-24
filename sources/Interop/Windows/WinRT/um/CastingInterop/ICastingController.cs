// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("F0A56423-A664-4FBD-8B43-409A45E8D9A1")]
[NativeTypeName("struct ICastingController : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICastingController : ICastingController.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingController*, Guid*, void**, int>)(lpVtbl[0]))((ICastingController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICastingController*, uint>)(lpVtbl[1]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingController*, uint>)(lpVtbl[2]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IUnknown* castingEngine, IUnknown* castingSource)
    {
        return ((delegate* unmanaged<ICastingController*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((ICastingController*)Unsafe.AsPointer(ref this), castingEngine, castingSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Connect()
    {
        return ((delegate* unmanaged<ICastingController*, int>)(lpVtbl[4]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<ICastingController*, int>)(lpVtbl[5]))((ICastingController*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Advise(ICastingEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<ICastingController*, ICastingEventHandler*, uint*, int>)(lpVtbl[6]))((ICastingController*)Unsafe.AsPointer(ref this), eventHandler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnAdvise([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<ICastingController*, uint, int>)(lpVtbl[7]))((ICastingController*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IUnknown* castingEngine, IUnknown* castingSource);

        [VtblIndex(4)]
        HRESULT Connect();

        [VtblIndex(5)]
        HRESULT Disconnect();

        [VtblIndex(6)]
        HRESULT Advise(ICastingEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie);

        [VtblIndex(7)]
        HRESULT UnAdvise([NativeTypeName("DWORD")] uint cookie);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, IUnknown*, IUnknown*, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, int> Connect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, int> Disconnect;

        [NativeTypeName("HRESULT (ICastingEventHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, ICastingEventHandler*, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<ICastingController*, uint, int> UnAdvise;
    }
}
