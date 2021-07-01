// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("84D2054A-3AA1-4728-A3B0-440A418CF49C")]
    [NativeTypeName("struct IMFPMPHostApp : IUnknown")]
    public unsafe partial struct IMFPMPHostApp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPMPHostApp*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPMPHostApp*, uint>)(lpVtbl[1]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPMPHostApp*, uint>)(lpVtbl[2]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockProcess()
        {
            return ((delegate* unmanaged<IMFPMPHostApp*, int>)(lpVtbl[3]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockProcess()
        {
            return ((delegate* unmanaged<IMFPMPHostApp*, int>)(lpVtbl[4]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateClassById([NativeTypeName("LPCWSTR")] ushort* id, IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMFPMPHostApp*, ushort*, IStream*, Guid*, void**, int>)(lpVtbl[5]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this), id, pStream, riid, ppv);
        }
    }
}
