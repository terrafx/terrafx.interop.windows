// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("52F547EF-5B03-49B5-82D6-565F1EE0DD49")]
    [NativeTypeName("struct ITensorNative : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITensorNative : ITensorNative.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITensorNative*, Guid*, void**, int>)(lpVtbl[0]))((ITensorNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITensorNative*, uint>)(lpVtbl[1]))((ITensorNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITensorNative*, uint>)(lpVtbl[2]))((ITensorNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBuffer(byte** value, [NativeTypeName("UINT32 *")] uint* capacity)
        {
            return ((delegate* unmanaged<ITensorNative*, byte**, uint*, int>)(lpVtbl[3]))((ITensorNative*)Unsafe.AsPointer(ref this), value, capacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetD3D12Resource(ID3D12Resource** result)
        {
            return ((delegate* unmanaged<ITensorNative*, ID3D12Resource**, int>)(lpVtbl[4]))((ITensorNative*)Unsafe.AsPointer(ref this), result);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetBuffer(byte** value, [NativeTypeName("UINT32 *")] uint* capacity);

            [VtblIndex(4)]
            HRESULT GetD3D12Resource(ID3D12Resource** result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITensorNative*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITensorNative*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITensorNative*, uint> Release;

            [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITensorNative*, byte**, uint*, int> GetBuffer;

            [NativeTypeName("HRESULT (ID3D12Resource **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITensorNative*, ID3D12Resource**, int> GetD3D12Resource;
        }
    }
}
