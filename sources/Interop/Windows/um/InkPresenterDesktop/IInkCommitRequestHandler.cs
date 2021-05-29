// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FABEA3FC-B108-45B6-A9FC-8D08FA9F85CF")]
    [NativeTypeName("struct IInkCommitRequestHandler : IUnknown")]
    public unsafe partial struct IInkCommitRequestHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkCommitRequestHandler*, Guid*, void**, int>)(lpVtbl[0]))((IInkCommitRequestHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkCommitRequestHandler*, uint>)(lpVtbl[1]))((IInkCommitRequestHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkCommitRequestHandler*, uint>)(lpVtbl[2]))((IInkCommitRequestHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCommitRequested()
        {
            return ((delegate* unmanaged<IInkCommitRequestHandler*, int>)(lpVtbl[3]))((IInkCommitRequestHandler*)Unsafe.AsPointer(ref this));
        }
    }
}
