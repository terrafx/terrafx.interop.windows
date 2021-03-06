// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCD285FE-0BE0-43BD-99C9-AAAEC513C555")]
    [NativeTypeName("struct IDocWrap : IUnknown")]
    public unsafe partial struct IDocWrap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDocWrap*, Guid*, void**, int>)(lpVtbl[0]))((IDocWrap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDocWrap*, uint>)(lpVtbl[1]))((IDocWrap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDocWrap*, uint>)(lpVtbl[2]))((IDocWrap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return ((delegate* unmanaged<IDocWrap*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IDocWrap*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWrappedDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IDocWrap*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IDocWrap*)Unsafe.AsPointer(ref this), riid, ppunk);
        }
    }
}
