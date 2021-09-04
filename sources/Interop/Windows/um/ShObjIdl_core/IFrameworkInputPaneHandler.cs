// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("226C537B-1E76-4D9E-A760-33DB29922F18")]
    [NativeTypeName("struct IFrameworkInputPaneHandler : IUnknown")]
    public unsafe partial struct IFrameworkInputPaneHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFrameworkInputPaneHandler*, Guid*, void**, int>)(lpVtbl[0]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFrameworkInputPaneHandler*, uint>)(lpVtbl[1]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFrameworkInputPaneHandler*, uint>)(lpVtbl[2]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Showing(RECT* prcInputPaneScreenLocation, [NativeTypeName("BOOL")] int fEnsureFocusedElementInView)
        {
            return ((delegate* unmanaged<IFrameworkInputPaneHandler*, RECT*, int, int>)(lpVtbl[3]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this), prcInputPaneScreenLocation, fEnsureFocusedElementInView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Hiding([NativeTypeName("BOOL")] int fEnsureFocusedElementInView)
        {
            return ((delegate* unmanaged<IFrameworkInputPaneHandler*, int, int>)(lpVtbl[4]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this), fEnsureFocusedElementInView);
        }
    }
}
