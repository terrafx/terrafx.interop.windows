// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B8EFEC4-3019-4C27-964E-367202156906")]
    [NativeTypeName("struct IPrintDocumentPackageTarget : IUnknown")]
    public unsafe partial struct IPrintDocumentPackageTarget
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTarget*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTarget*, uint>)(lpVtbl[1]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTarget*, uint>)(lpVtbl[2]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, [NativeTypeName("GUID **")] Guid** targetTypes)
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTarget*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), targetCount, targetTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTarget)
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)(lpVtbl[4]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), guidTargetType, riid, ppvTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTarget*, int>)(lpVtbl[5]))((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }
    }
}
