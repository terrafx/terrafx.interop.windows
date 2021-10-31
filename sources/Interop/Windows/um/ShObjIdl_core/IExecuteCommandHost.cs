// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B6832A2-5F04-4C9D-B89D-727A15D103E7")]
    [NativeTypeName("struct IExecuteCommandHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExecuteCommandHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExecuteCommandHost*, Guid*, void**, int>)(lpVtbl[0]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExecuteCommandHost*, uint>)(lpVtbl[1]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExecuteCommandHost*, uint>)(lpVtbl[2]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetUIMode(EC_HOST_UI_MODE* pUIMode)
        {
            return ((delegate* unmanaged<IExecuteCommandHost*, EC_HOST_UI_MODE*, int>)(lpVtbl[3]))((IExecuteCommandHost*)Unsafe.AsPointer(ref this), pUIMode);
        }
    }
}
