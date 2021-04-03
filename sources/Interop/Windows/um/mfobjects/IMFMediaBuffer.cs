// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
    [NativeTypeName("struct IMFMediaBuffer : IUnknown")]
    public unsafe partial struct IMFMediaBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint>)(lpVtbl[1]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint>)(lpVtbl[2]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("BYTE **")] byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, byte**, uint*, uint*, int>)(lpVtbl[3]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), ppbBuffer, pcbMaxLength, pcbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock()
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, int>)(lpVtbl[4]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint*, int>)(lpVtbl[5]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), pcbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint, int>)(lpVtbl[6]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), cbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint*, int>)(lpVtbl[7]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }
    }
}
