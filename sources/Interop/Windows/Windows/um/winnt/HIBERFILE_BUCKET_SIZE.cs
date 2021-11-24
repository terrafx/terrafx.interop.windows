// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum HIBERFILE_BUCKET_SIZE
{
    HiberFileBucket1GB = 0,
    HiberFileBucket2GB,
    HiberFileBucket4GB,
    HiberFileBucket8GB,
    HiberFileBucket16GB,
    HiberFileBucket32GB,
    HiberFileBucketUnlimited,
    HiberFileBucketMax,
}
