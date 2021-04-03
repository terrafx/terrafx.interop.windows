// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDxDiagProvider : IUnknown")]
    public unsafe partial struct IDxDiagProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxDiagProvider*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxDiagProvider*, uint>)(lpVtbl[1]))((IDxDiagProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxDiagProvider*, uint>)(lpVtbl[2]))((IDxDiagProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(DXDIAG_INIT_PARAMS* pParams)
        {
            return ((delegate* unmanaged<IDxDiagProvider*, DXDIAG_INIT_PARAMS*, int>)(lpVtbl[3]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), pParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRootContainer(IDxDiagContainer** ppInstance)
        {
            return ((delegate* unmanaged<IDxDiagProvider*, IDxDiagContainer**, int>)(lpVtbl[4]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), ppInstance);
        }
    }
}
