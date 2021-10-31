// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9F0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolSinkStackable : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetProtocolSinkStackable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetProtocolSinkStackable*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetProtocolSinkStackable*, uint>)(lpVtbl[1]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetProtocolSinkStackable*, uint>)(lpVtbl[2]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SwitchSink(IInternetProtocolSink* pOIProtSink)
        {
            return ((delegate* unmanaged<IInternetProtocolSinkStackable*, IInternetProtocolSink*, int>)(lpVtbl[3]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), pOIProtSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CommitSwitch()
        {
            return ((delegate* unmanaged<IInternetProtocolSinkStackable*, int>)(lpVtbl[4]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RollbackSwitch()
        {
            return ((delegate* unmanaged<IInternetProtocolSinkStackable*, int>)(lpVtbl[5]))((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }
    }
}
