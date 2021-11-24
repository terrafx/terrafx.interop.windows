// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
[NativeTypeName("struct IXAPOParameters : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAPOParameters : IXAPOParameters.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXAPOParameters*, Guid*, void**, int>)(lpVtbl[0]))((IXAPOParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXAPOParameters*, uint>)(lpVtbl[1]))((IXAPOParameters*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXAPOParameters*, uint>)(lpVtbl[2]))((IXAPOParameters*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
    {
        ((delegate* unmanaged<IXAPOParameters*, void*, uint, void>)(lpVtbl[3]))((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetParameters(void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
    {
        ((delegate* unmanaged<IXAPOParameters*, void*, uint, void>)(lpVtbl[4]))((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize);

        [VtblIndex(4)]
        void GetParameters(void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXAPOParameters*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IXAPOParameters*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IXAPOParameters*, uint> Release;

        [NativeTypeName("void (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IXAPOParameters*, void*, uint, void> SetParameters;

        [NativeTypeName("void (void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IXAPOParameters*, void*, uint, void> GetParameters;
    }
}
