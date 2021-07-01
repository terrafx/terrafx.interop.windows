// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E1AA6466-9DB4-40BA-BE03-77C38E8E60B2")]
    [NativeTypeName("struct IInternalDocWrap : IUnknown")]
    public unsafe partial struct IInternalDocWrap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternalDocWrap*, Guid*, void**, int>)(lpVtbl[0]))((IInternalDocWrap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternalDocWrap*, uint>)(lpVtbl[1]))((IInternalDocWrap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternalDocWrap*, uint>)(lpVtbl[2]))((IInternalDocWrap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRevoke()
        {
            return ((delegate* unmanaged<IInternalDocWrap*, int>)(lpVtbl[3]))((IInternalDocWrap*)Unsafe.AsPointer(ref this));
        }
    }
}
