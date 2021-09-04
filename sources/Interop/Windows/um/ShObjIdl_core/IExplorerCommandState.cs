// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDDACB60-7657-47AE-8445-D23E1ACF82AE")]
    [NativeTypeName("struct IExplorerCommandState : IUnknown")]
    public unsafe partial struct IExplorerCommandState
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerCommandState*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerCommandState*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerCommandState*, uint>)(lpVtbl[1]))((IExplorerCommandState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerCommandState*, uint>)(lpVtbl[2]))((IExplorerCommandState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState(IShellItemArray* psiItemArray, [NativeTypeName("BOOL")] int fOkToBeSlow, [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState)
        {
            return ((delegate* unmanaged<IExplorerCommandState*, IShellItemArray*, int, uint*, int>)(lpVtbl[3]))((IExplorerCommandState*)Unsafe.AsPointer(ref this), psiItemArray, fOkToBeSlow, pCmdState);
        }
    }
}
