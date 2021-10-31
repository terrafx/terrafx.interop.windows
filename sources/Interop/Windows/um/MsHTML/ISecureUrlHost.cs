// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C81984C4-74C8-11D2-BAA9-00C04FC2040E")]
    [NativeTypeName("struct ISecureUrlHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISecureUrlHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISecureUrlHost*, Guid*, void**, int>)(lpVtbl[0]))((ISecureUrlHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISecureUrlHost*, uint>)(lpVtbl[1]))((ISecureUrlHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISecureUrlHost*, uint>)(lpVtbl[2]))((ISecureUrlHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ValidateSecureUrl(BOOL* pfAllow, [NativeTypeName("OLECHAR *")] ushort* pchUrlInQuestion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ISecureUrlHost*, BOOL*, ushort*, uint, int>)(lpVtbl[3]))((ISecureUrlHost*)Unsafe.AsPointer(ref this), pfAllow, pchUrlInQuestion, dwFlags);
        }
    }
}
