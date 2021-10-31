// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6E0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLChangePlayback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLChangePlayback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLChangePlayback*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLChangePlayback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLChangePlayback*, uint>)(lpVtbl[1]))((IHTMLChangePlayback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLChangePlayback*, uint>)(lpVtbl[2]))((IHTMLChangePlayback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ExecChange(byte* pbRecord, BOOL fForward)
        {
            return ((delegate* unmanaged<IHTMLChangePlayback*, byte*, BOOL, int>)(lpVtbl[3]))((IHTMLChangePlayback*)Unsafe.AsPointer(ref this), pbRecord, fForward);
        }
    }
}
