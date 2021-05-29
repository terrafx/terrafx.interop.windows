// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3BAB89E4-5FBE-45F4-A5BC-DCA36AD225A8")]
    [NativeTypeName("struct ITfFnBalloon : IUnknown")]
    public unsafe partial struct ITfFnBalloon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnBalloon*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnBalloon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnBalloon*, uint>)(lpVtbl[1]))((ITfFnBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnBalloon*, uint>)(lpVtbl[2]))((ITfFnBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITfFnBalloon*, TfLBBalloonStyle, ushort*, uint, int>)(lpVtbl[3]))((ITfFnBalloon*)Unsafe.AsPointer(ref this), style, pch, cch);
        }
    }
}
