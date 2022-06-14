﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Diagnostics;

namespace WorkerHarness.Core
{
    public interface IWorkerProcessBuilder
    {
        Process Build(WorkerDescription workerDescription);
    }
}
