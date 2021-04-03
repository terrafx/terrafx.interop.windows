// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
    [NativeTypeName("struct IXAPOParameters : IUnknown")]
    public unsafe partial struct IXAPOParameters
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXAPOParameters*, Guid*, void**, int>)(lpVtbl[0]))((IXAPOParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXAPOParameters*, uint>)(lpVtbl[1]))((IXAPOParameters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXAPOParameters*, uint>)(lpVtbl[2]))((IXAPOParameters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
        {
            ((delegate* unmanaged<IXAPOParameters*, void*, uint, void>)(lpVtbl[3]))((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetParameters(void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
        {
            ((delegate* unmanaged<IXAPOParameters*, void*, uint, void>)(lpVtbl[4]))((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
        }
    }
}
