// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("101D6610-0990-11D3-8DF0-00105A2799B5")]
[NativeTypeName("struct ITfFunctionProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfFunctionProvider : ITfFunctionProvider.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFunctionProvider*, Guid*, void**, int>)(lpVtbl[0]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFunctionProvider*, uint>)(lpVtbl[1]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFunctionProvider*, uint>)(lpVtbl[2]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfFunctionProvider*, Guid*, int>)(lpVtbl[3]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), pguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc)
    {
        return ((delegate* unmanaged<ITfFunctionProvider*, ushort**, int>)(lpVtbl[4]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), pbstrDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFunction([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITfFunctionProvider*, Guid*, Guid*, IUnknown**, int>)(lpVtbl[5]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), rguid, riid, ppunk);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType(Guid* pguid);

        [VtblIndex(4)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc);

        [VtblIndex(5)]
        HRESULT GetFunction([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfFunctionProvider*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfFunctionProvider*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfFunctionProvider*, uint> Release;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public new delegate* unmanaged<ITfFunctionProvider*, Guid*, int> GetType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfFunctionProvider*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfFunctionProvider*, Guid*, Guid*, IUnknown**, int> GetFunction;
    }
}
