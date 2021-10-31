// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct RM_PROCESS_INFO
    {
        public RM_UNIQUE_PROCESS Process;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort strAppName[256];

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort strServiceShortName[64];

        public RM_APP_TYPE ApplicationType;

        [NativeTypeName("ULONG")]
        public uint AppStatus;

        [NativeTypeName("DWORD")]
        public uint TSSessionId;

        public BOOL bRestartable;
    }
}
