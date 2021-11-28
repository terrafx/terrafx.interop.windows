// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("C71E953F-37B4-4564-8658-D8396866DB0D")]
[NativeTypeName("struct ILearningModelSessionOptionsNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILearningModelSessionOptionsNative : ILearningModelSessionOptionsNative.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative*, Guid*, void**, int>)(lpVtbl[0]))((ILearningModelSessionOptionsNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative*, uint>)(lpVtbl[1]))((ILearningModelSessionOptionsNative*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative*, uint>)(lpVtbl[2]))((ILearningModelSessionOptionsNative*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIntraOpNumThreadsOverride([NativeTypeName("UINT32")] uint intraOpNumThreads)
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative*, uint, int>)(lpVtbl[3]))((ILearningModelSessionOptionsNative*)Unsafe.AsPointer(ref this), intraOpNumThreads);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIntraOpNumThreadsOverride([NativeTypeName("UINT32")] uint intraOpNumThreads);
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

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetIntraOpNumThreadsOverride;
    }
}
