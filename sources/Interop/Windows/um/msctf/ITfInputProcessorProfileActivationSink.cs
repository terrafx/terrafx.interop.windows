// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71C6E74E-0F28-11D8-A82A-00065B84435C")]
    [NativeTypeName("struct ITfInputProcessorProfileActivationSink : IUnknown")]
    public unsafe partial struct ITfInputProcessorProfileActivationSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, uint>)(lpVtbl[1]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, uint>)(lpVtbl[2]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnActivated([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* catid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("HKL")] IntPtr hkl, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, uint, ushort, Guid*, Guid*, Guid*, IntPtr, uint, int>)(lpVtbl[3]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, catid, guidProfile, hkl, dwFlags);
        }
    }
}
