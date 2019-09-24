// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct DXGI_INFO_QUEUE_MESSAGE
    {
        [NativeTypeName("DXGI_DEBUG_ID")]
        public Guid Producer;

        public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;

        public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;

        [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")]
        public int ID;

        [NativeTypeName("CHAR")]
        public sbyte* pDescription;

        [NativeTypeName("SIZE_T")]
        public UIntPtr DescriptionByteLength;
    }
}
